namespace Telecom.ModelEF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Subscriptions> Subscriptions { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tariffs> Tariffs { get; set; }
        public virtual DbSet<Tickets> Tickets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clients>()
                .Property(e => e.Balance)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Clients>()
                .HasMany(e => e.Tickets)
                .WithRequired(e => e.Clients)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tariffs>()
                .Property(e => e.MonthlyFee)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Tariffs>()
                .HasMany(e => e.Subscriptions)
                .WithRequired(e => e.Tariffs)
                .WillCascadeOnDelete(false);
        }
    }
}
