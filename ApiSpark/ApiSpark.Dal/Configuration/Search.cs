
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiSpark.Dal.Configuration
{
    public class Search
    {
        [ForeignKey("Configuration")]
        public Guid SearchId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Excerpt { get; set; }

        public virtual Configuration Configuration { get; set; }
    }
}