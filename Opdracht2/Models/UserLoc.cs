using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Opdracht2.Models
{
    public class UserLoc
    {
        public int ul_ID { get; set; }
        public int fk_loc_id { get; set; }
        public virtual Locations location { get; set; }
        public int fk_u_id { get; set; }
        public virtual User user { get; set; }
    }
}