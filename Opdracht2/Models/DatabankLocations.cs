using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Opdracht2.Models
{
    public partial class DatabankLocations : DbContext
    {
        public DatabankLocations() : base("name=DatabankEntities")
        {
        }

        public virtual DbSet<Locations> locations { get; set; }
    }
}