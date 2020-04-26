using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiSpark.Dal.ContenuTextuel
{
    public class Comment
    {
        public User User { get; set; }
        public string Time { get; set; }
        public string Message { get; set; }
    }
}