using System;
using System.Collections.Generic;


namespace ApiSpark.Dal.ScrumBoard
{
    public class Card
    {
        public string CardId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string IdAttachmentCover { get; set; }
        public List<Member> Members { get; set; }
        public List<Label> Labels { get; set; }
        public List<object> Attachments { get; set; }
        public bool Subscribed { get; set; }
        public List<object> Checklists { get; set; }
        public int CheckItems { get; set; }
        public int CheckItemsChecked { get; set; }
        public List<object> Comments { get; set; }
        public List<object> Activities { get; set; }
        public DateTime? Due { get; set; }
    }

}