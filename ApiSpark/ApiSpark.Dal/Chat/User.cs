using ApiSpark.Dal.Chat;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiSpark.Dal.Chat
{
    [Table("User")]
    public class User
    {
        [Key]
        public Guid UserId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Avatar { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string Mood { get; set; }
        public List<ChatList> ChatList { get; set; }
    }

}