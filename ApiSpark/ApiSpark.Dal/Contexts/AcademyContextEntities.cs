using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiSpark.Dal.Academies;
    
namespace ApiSpark.Dal.Contexts
{
    public class AcademyContextEntities : DbContext
    {

        public AcademyContextEntities() : base("Academy")
        {

        }
        public DbSet<Academy> Academies { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
