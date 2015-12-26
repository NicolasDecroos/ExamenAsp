using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Opdracht2.Models
{
    public class UserComp
    {
        public int UC_ID { get; set; }
        public int FK_U_ID { get; set; }
        public virtual User user { get; set; }
        public int FK_Comp_ID { get; set; }
        public virtual Competenties competenties { get; set; }
    }
}