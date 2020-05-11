using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSpark.Dal.Configuration
{
    [Table("Configuration")]
    public class Configuration
    {
        [Key]
        public Guid ConfigurationId { get; set; }

        public virtual  Blocage Blocage { get; set; }


        public virtual  Connexion Connexion { get; set; }


        public virtual  Filter Filter { get; set; }


        public virtual IntegrationProfessionelle IntegrationProfessionelle { get; set; }

        public virtual Langue Langue { get; set; }

        public virtual Localisation Localisation { get; set; }

        public virtual Notification Notification { get; set; }

        public virtual Publication Publication { get; set; }

        public virtual Recommandation Recommandation { get; set; }

        public virtual Search Search { get; set; }

        public virtual ViePrivee ViePrivee { get; set; }


    }
}
