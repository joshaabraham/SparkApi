using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiSpark.Dal.Media
{
    public class PhotosVideo
    {
        public string Name { get; set; }
        public string Info { get; set; }
        public List<Medium> Media { get; set; }
    }
}