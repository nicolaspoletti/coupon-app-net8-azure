using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CouponAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CouponAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Coupon> Coupons { get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Coupon>().HasData(new Coupon {
                Id = 1,
                CouponCode="000A",
                DiscountAmount=10,
                MinAmount = 20
            });

            builder.Entity<Coupon>().HasData(new Coupon {
                Id = 2,
                CouponCode="001A",
                DiscountAmount=10,
                MinAmount = 40
            });
        }
    }
}