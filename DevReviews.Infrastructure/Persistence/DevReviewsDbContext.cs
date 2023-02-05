using DevReviews.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevReviews.Infrastructure.Persistence
{
    public class DevReviewsDbContext : DbContext
    {
        public DevReviewsDbContext(DbContextOptions<DevReviewsDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductReview> ProductReviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Product
            modelBuilder.Entity<Product>(p =>
            {
                p.ToTable("tb_Product");
                p.HasKey(p => p.Id);

                p
                    .HasMany(pp => pp.Reviews)
                    .WithOne()
                    .HasForeignKey(r => r.ProductId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            //ProductReview
            modelBuilder.Entity<ProductReview>(pr =>
            {
                pr.ToTable("tb_ProductReviews");
                pr.HasKey(p => p.Id);

                pr.Property(p => p.Author)
                    .HasMaxLength(50);
            });
                
        }
    }
}
