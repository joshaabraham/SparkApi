using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiSpark.Dal.Magasin
{
    public class InvoiceService
    {
        public string Title { get; set; }
        public string Detail { get; set; }
        public string Unit { get; set; }
        public string UnitPrice { get; set; }
        public string Quantity { get; set; }
        public string Total { get; set; }
    }
}