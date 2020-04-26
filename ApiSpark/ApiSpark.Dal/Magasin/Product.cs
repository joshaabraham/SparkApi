using System.Collections.Generic;

namespace ApiSpark.Dal.Magasin
{
    public class Product
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        public string Handle { get; set; }
        public string Description { get; set; }
        public List<string> Categories { get; set; }
        public List<string> Tags { get; set; }
        public int FeaturedImageId { get; set; }
        public List<Image> Images { get; set; }
        public double PriceTaxExcl { get; set; }
        public double PriceTaxIncl { get; set; }
        public int TaxRate { get; set; }
        public double ComparedPrice { get; set; }
        public int Quantity { get; set; }
        public string Sku { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string Depth { get; set; }
        public string Weight { get; set; }
        public double ExtraShippingFee { get; set; }
        public bool Active { get; set; }
    }
}