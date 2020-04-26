
using System.Collections.Generic;

namespace ApiSpark.Dal.Mail
{

    public class Mail
    {
        public string MailMailId { get; set; }
        public MailFrom From { get; set; }
        public List<MailTo> To { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Time { get; set; }
        public bool Read { get; set; }
        public bool Starred { get; set; }
        public bool Important { get; set; }
        public bool HasAttachments { get; set; }
        public List<MailAttachment> Attachments { get; set; }
        public List<int> Labels { get; set; }
        public int Folder { get; set; }
    }
}