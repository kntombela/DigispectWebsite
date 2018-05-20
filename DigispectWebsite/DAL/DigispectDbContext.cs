namespace DigispectWebsite.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using DigispectWebsite.Models;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public partial class DigispectDbContext : DbContext
    {
        public DigispectDbContext()
            : base("name=DigispectDbContext")
        {
        }

        public virtual DbSet<Lead> Leads { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
