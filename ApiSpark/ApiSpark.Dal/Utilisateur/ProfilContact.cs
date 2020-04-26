using System.Collections.Generic;


namespace ApiSpark.Dal.Utilisateur
{

    public class ProfilContact
    {
        public string Address { get; set; }
        public List<string> Tel { get; set; }
        public List<string> Websites { get; set; }
        public List<string> Emails { get; set; }
    }

}