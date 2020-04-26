using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiSpark.Dal.LigneTemporelle
{
    public class Activity
    {
        public User User { get; set; }
        public string Message { get; set; }
        public string Time { get; set; }
    }
}