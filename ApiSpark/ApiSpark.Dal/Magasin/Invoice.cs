
using System.Collections.Generic;

namespace ApiSpark.Dal.Magasin
{

    public class Invoice
    {
        public InvoiceFrom From { get; set; }
        public InvoiceClient Client { get; set; }
        public string Number { get; set; }
        public string Date { get; set; }
        public string DueDate { get; set; }
        public List<InvoiceService> Services { get; set; }
        public string Subtotal { get; set; }
        public string Tax { get; set; }
        public string Discount { get; set; }
        public string Total { get; set; }
    }
}