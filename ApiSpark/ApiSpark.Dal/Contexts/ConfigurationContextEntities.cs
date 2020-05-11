using ApiSpark.Dal.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSpark.Dal.Contexts
{
    class ConfigurationContextEntities : DbContext
    {

        public ConfigurationContextEntities() : base("name=Configurations")
        {
            Database.SetInitializer<LoginInfoContextEntities>(new CreateDatabaseIfNotExists<LoginInfoContextEntities>());
        }


        public DbSet<Blocage> Blocages { get; set; }
        public DbSet<Connexion> Connexions { get; set; }
        public DbSet<Filter> Filters { get; set; }
        public DbSet<IntegrationProfessionelle> IntegrationProfessionelles { get; set; }
        public DbSet<Langue> Langues { get; set; }
        public DbSet<Localisation> Localisations { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Publication> Publications { get; set; }
        public DbSet<Recommandation> Recommandations { get; set; }
        public DbSet<Search> Searchs { get; set; }
        public DbSet<ViePrivee> ViePrivees { get; set; }

    }
}
