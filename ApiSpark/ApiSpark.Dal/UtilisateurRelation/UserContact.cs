using System.Collections.Generic;


namespace ApiSpark.Dal.UtilisateurRelation
{

    public class UserContact
    {
        public string UserContactId { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public List<string> Starred { get; set; }
        public List<Contact> FrequentContacts { get; set; }
        public List<UserGroup> Groups { get; set; }
    }
}