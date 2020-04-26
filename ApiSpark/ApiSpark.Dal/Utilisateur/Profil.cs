using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiSpark.Dal.Utilisateur
{
    public class Profil
    {
        public General General { get; set; }
        public Work Work { get; set; }
        public ProfilContact Contact { get; set; }
        public List<Group> Groups { get; set; }
        public List<Friend> Friends { get; set; }
    }
}