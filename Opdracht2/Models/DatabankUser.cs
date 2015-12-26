using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Opdracht2.Models
{
    public partial class DatabankUser : DbContext
    {
        public DatabankUser() : base("name=DatabankEntities")
        {
        }

        public virtual DbSet<User> user { get; set; }
    }
}