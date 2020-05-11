using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSpark.Dal.LogInfo
{
    public abstract class User
    {

        public string Avatar { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }


        public virtual Login Login { get; set; }
    }
}
