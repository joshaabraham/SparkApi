using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApiSpark.Dal.Configuration
{
    public class Localisation
    {
        [ForeignKey("Configuration")]
        public Guid LocalisationId { get; set; }

        public virtual Configuration Configuration { get; set; }
    }
}