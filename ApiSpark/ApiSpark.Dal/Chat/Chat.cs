using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApiSpark.Dal.Chat
{
    [Table("Chat")]
    public class Chat
    {
        [Key]
        public string ChatId { get; set; }

        public List<Dialog> Dialog { get; set; }
    }
}