using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiSpark.Dal.Academies
{
    [Table("Academy")]
    public class Academy
    {
        [Key]
        public Guid AcademyId { get; set; }

        [MaxLength(55), Required]
        public string Name { get; set; }

        [Required]
        public string Avatar { get; set; }

     //   [Required]
        public string Status { get; set; }

    //    [Required]
        public string Mood { get; set; }

        public string Unread { get; set; }
    }


}