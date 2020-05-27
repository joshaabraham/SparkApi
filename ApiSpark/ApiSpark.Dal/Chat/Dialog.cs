using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApiSpark.Dal.Chat
{
    [Table("Dialog")]
    public class Dialog
    {
        [Key]
        public Guid DialogId { get; set; }
        public string Who { get; set; }
        public string Message { get; set; }
        public DateTime Time { get; set; }


        public ContactStatus status { get; set; }

        public Guid ChatId { get; set; }
        public Chat Chat { get; set; }

    }
}