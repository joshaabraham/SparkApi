using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiSpark.Dal.ContenuTextuel
{
    public class Post
    {
        public string IdPost { get; set; }
        public User User { get; set; }
        public string Message { get; set; }
        public string Time { get; set; }
        public string Type { get; set; }
        public int Like { get; set; }
        public int Share { get; set; }
        public List<Media> Media { get; set; }
        public List<Comment> Comments { get; set; }
        public Article Article { get; set; }
    }
}