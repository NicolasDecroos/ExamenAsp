using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Opdracht2.Models
{
    public partial class DatabankUserComp : DbContext
    {
        public DatabankUserComp() : base("name=DatabankEntities")
        {
        }

        public virtual DbSet<UserComp> UserComps { get; set; }

        public DbSet<User> user { get; set; }
        public DbSet<Competenties> competenties { get; set; }
    }
}