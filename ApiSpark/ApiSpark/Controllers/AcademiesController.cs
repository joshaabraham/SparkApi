using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ApiSpark.Dal;
using ApiSpark.Dal.Academies;
using ApiSpark.Dal.Contexts;

namespace ApiSpark.Controllers
{
    public class AcademiesController : ApiController
    {
        private AcademyContextEntities db = new AcademyContextEntities();

        // GET: api/Academies
        public IQueryable<Academy> GetAcademies()
        {
            return db.Academies;
        }

        // GET: api/Academies/5
        [ResponseType(typeof(Academy))]
        public async Task<IHttpActionResult> GetAcademy(Guid id)
        {
            Academy academy = await db.Academies.FindAsync(id);
            if (academy == null)
            {
                return NotFound();
            }

            return Ok(academy);
        }

        // PUT: api/Academies/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAcademy(Guid id, Academy academy)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != academy.AcademyId)
            {
                return BadRequest();
            }

            db.Entry(academy).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AcademyExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Academies
        [ResponseType(typeof(Academy))]
        public async Task<IHttpActionResult> PostAcademy(Academy academy)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Academies.Add(academy);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AcademyExists(academy.AcademyId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = academy.AcademyId }, academy);
        }

        // DELETE: api/Academies/5
        [ResponseType(typeof(Academy))]
        public async Task<IHttpActionResult> DeleteAcademy(Guid id)
        {
            Academy academy = await db.Academies.FindAsync(id);
            if (academy == null)
            {
                return NotFound();
            }

            db.Academies.Remove(academy);
            await db.SaveChangesAsync();

            return Ok(academy);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AcademyExists(Guid id)
        {
            return db.Academies.Count(e => e.AcademyId == id) > 0;
        }
    }
}