namespace StresTester
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public partial class DaftarUser : DbContext
    {
        public DaftarUser()
            : base("name=DaftarUser")
        {
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
