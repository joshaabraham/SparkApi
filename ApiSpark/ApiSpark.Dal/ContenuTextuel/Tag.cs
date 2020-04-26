using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiSpark.Dal.ContenuTextuel
{
    public class Tag
    {
        public long TagId { get; set; }

        public string Handle { get; set; }

        public string Title { get; set; }

        public string Color { get; set; }
    }
}