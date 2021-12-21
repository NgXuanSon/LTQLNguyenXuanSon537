using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LTQL_1721050537.Models
{
    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext()
            : base("name=LTQLDbContext")
        {
        }
        public virtual DbSet<NhaCungCap537> NhaCungCap537s { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)

        {   
        }
    }
}
