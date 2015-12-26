using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Opdracht2.Models
{
    public class Locations
    {
        public int loc_ID { get; set; }
        public int loc_name { get; set; }
        public virtual User user { get; set; }
    }
}