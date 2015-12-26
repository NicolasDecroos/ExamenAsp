using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Opdracht2.Models
{
    public partial class DatabankCompetenties : DbContext
    {
        public DatabankCompetenties() : base("name=DatabankEntities")
        {
        }

        public virtual DbSet<Competenties> competenties { get; set; }
    }
}