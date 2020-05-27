
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiSpark.Dal.Chat
{
    [Table("ContactStatus")]
    public class ContactStatus
    {
        [Key]
        public int ContactStatusId { get; set; }
        public string Name { get; set; }
        public byte[] Avatar { get; set; }
        public string Status { get; set; }
        public string Mood { get; set; }
        public string Unread { get; set; }


        public Guid DialogId { get; set; }
        public Dialog Dialog { get; set; }
    }
}