using System.Collections.Generic;


namespace ApiSpark.Dal.UtilisateurRelation
{
    public class UserGroup
    {
        public string UserGroupId { get; set; }
        public string Name { get; set; }
        public List<User> ContactIds { get; set; }
    }

    public class User
    {
    }
}