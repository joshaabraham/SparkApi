using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiSpark.Dal.LigneTemporelle
{
    public class Post
    {
        public string IdPost { get; set; }
        public User User { get; set; }
        public string Message { get; set; }
        public string Time { get; set; }
        public string Type { get; set; }
     
    }
}