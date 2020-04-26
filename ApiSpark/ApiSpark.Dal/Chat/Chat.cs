using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiSpark.Dal.Chat
{
    public class Chat
    {
        public string ChatId { get; set; }
        public List<Dialog> Dialog { get; set; }
    }
}