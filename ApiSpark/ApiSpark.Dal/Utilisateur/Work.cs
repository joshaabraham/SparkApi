using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiSpark.Dal.Utilisateur
{
    public class Work
    {
        public string Occupation { get; set; }
        public string Skills { get; set; }
        public List<Job> Jobs { get; set; }
    }
}