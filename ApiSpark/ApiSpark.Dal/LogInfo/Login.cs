using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSpark.Dal.LogInfo
{
    [Table("Login")]
    public class Login
    {
        [Key]
        public Guid LogId { get; set; }


        [MaxLength(75), Required]
        public string Email { get; set; }

        [MaxLength(55), Required]
        public string Password { get; set; }

        public virtual User User { get; set; }


        public string UserRole { get; set; }
    }
}
