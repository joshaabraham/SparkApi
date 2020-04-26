using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiSpark.Dal.LigneTemporelle
{
    public class Timeline
    {
        public List<Activity> Activities { get; set; }
        public List<Post> Posts { get; set; }
    }
}