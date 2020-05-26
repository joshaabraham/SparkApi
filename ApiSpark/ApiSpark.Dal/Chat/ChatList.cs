using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApiSpark.Dal.Chat
{
    [Table("ChatList")]
    public class ChatList
    {
        [Key]
        public string ChatListId { get; set; }
        [Required]
        public string ContactId { get; set; }
        [Required]
        public DateTime LastMessageTime { get; set; }
    }
}