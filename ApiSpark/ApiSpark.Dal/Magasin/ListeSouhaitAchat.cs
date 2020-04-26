using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiSpark.Dal.Magasin
{
    public class ListeSouhaitAchat
    {


        public ICollection<Product> Produits { get; set; }
        public double Total { get; set; }
 
    }
}