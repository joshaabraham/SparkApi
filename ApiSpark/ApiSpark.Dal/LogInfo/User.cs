using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSpark.Dal.LogInfo
{
    [Table("User")]
    public class User
    {
        [Key]
        public Guid userID { get; set; }
        public string Avatar { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

  
        public virtual Login Login { get; set; }
    }
}
