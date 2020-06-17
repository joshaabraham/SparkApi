using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiSpark.Dal.LogInfo;

namespace ApiSpark.Dal.Contexts
{
    public class LoginInfoContextEntities : DbContext
    {

        public LoginInfoContextEntities() : base("name=Login")
        {
         
            Database.SetInitializer<LoginInfoContextEntities>(new CreateDatabaseIfNotExists<LoginInfoContextEntities>());
        }
        public DbSet<Login> Logins { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Login>()
                .HasRequired(s => s.User);
                
        }
    }
}
