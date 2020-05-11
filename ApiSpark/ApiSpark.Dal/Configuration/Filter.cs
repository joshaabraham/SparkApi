

using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiSpark.Dal.Configuration
{
    public class Filter
    {
        [ForeignKey("Configuration")]
        public Guid FilterId { get; set; }
        public string Handle { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }

        public virtual Configuration Configuration { get; set; }
    }
}