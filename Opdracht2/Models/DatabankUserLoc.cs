using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace Opdracht2.Models
{
    public partial class DatabankUserLoc : DbContext
    {
        public DatabankUserLoc() : base("name=DatabankEntities")
        {
        }

        public virtual DbSet<UserLoc> UsersLocs { get; set; }

        public DbSet<User> user { get; set; }
        public DbSet<Competenties> competenties { get; set; }
    }
}