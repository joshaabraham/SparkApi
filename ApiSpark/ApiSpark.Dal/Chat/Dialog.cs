using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiSpark.Dal.Chat
{
    public class Dialog
    {
        public string Who { get; set; }
        public string Message { get; set; }
        public DateTime Time { get; set; }
    }
}