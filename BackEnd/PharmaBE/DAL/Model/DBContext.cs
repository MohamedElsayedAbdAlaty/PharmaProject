namespace DAL.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using DbContext = Microsoft.EntityFrameworkCore.DbContext;

    public partial class DatabaseContext : DbContext
    {
        //public DatabaseContext()
        //    : base("name=DatabaseContext")
        //{
        //}
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public virtual Microsoft.EntityFrameworkCore.DbSet<product_> products_ { get; set; }
        public virtual Microsoft.EntityFrameworkCore.DbSet<seller_products_> seller_products_ { get; set; }
        public virtual Microsoft.EntityFrameworkCore.DbSet<seller_> sellers_ { get; set; }
        public virtual Microsoft.EntityFrameworkCore.DbSet<sysdiagram> sysdiagrams { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<products_>()
        //        .Property(e => e.price)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<products_>()
        //        .HasMany(e => e.seller_products_)
        //        .WithOptional(e => e.products_)
        //        .HasForeignKey(e => e.product_id);

        //    modelBuilder.Entity<seller_products_>()
        //        .Property(e => e.price)
        //        .HasPrecision(18, 0);
            
        //    modelBuilder.Entity<seller_products_>()
        //        .Property(e => e.discount)
        //        .HasPrecision(18, 0);

        //    modelBuilder.Entity<sellers_>()
        //        .HasMany(e => e.seller_products_)
        //        .WithOptional(e => e.sellers_)
        //        .HasForeignKey(e => e.seller_id);
        //}
    }
}
