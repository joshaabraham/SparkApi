using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiSpark.Dal.Magasin
{
    public class Client
    {

        public string Nom { get; set; }
        public string Prenom { get; set; }

        public ICollection<AdresseLivraison> AdressesLivraison { get; set; }
        public ICollection<AdresseFacturation> AdressesFacturation { get; set; }
        public ICollection<Carte> Cartes { get; set; }


    }
}