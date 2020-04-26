using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiSpark.Dal.ContenuTextuel
{
    public class Article
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Excerpt { get; set; }
        public Media Media { get; set; }
    }
}