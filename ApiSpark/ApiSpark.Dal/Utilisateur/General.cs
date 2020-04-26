using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiSpark.Dal.Utilisateur
{
    public class General
    {
        public string Gender { get; set; }
        public string Birthday { get; set; }
        public List<string> Locations { get; set; }
        public string About { get; set; }
    }
}