
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiSpark.Dal.Chat
{
    [Table("ContactStatus")]
    public class ContactStatus
    {
        public string ContactStatusId { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string Status { get; set; }
        public string Mood { get; set; }
        public string Unread { get; set; }

        public Dialog dialog { get; set; }
    }
}