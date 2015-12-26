using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Opdracht2.Models
{
    public class User
    {
        public int ID { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string nummer { get; set; }
        public string email { get; set; }
        public string role { get; set; }
        //public SetPasswordViewModel 
        public virtual List<Competenties> competenties { get; set; }
        public virtual List<Locations> locations { get; set; }
    }
}