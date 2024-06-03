using Microsoft.EntityFrameworkCore;
using VShop.DiscountApi.Models;

namespace VShop.DiscountApi.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }

    public DbSet<Coupon> Coupons { get; set; }

    protected override void OnModelCreating(ModelBuilder mb)
    {
        base.OnModelCreating(mb);

        mb.Entity<Coupon>().HasData(new Coupon
        {
            CouponId = 1,
            CouponCode = "vshop_10",
            Discount = 10
        });
        mb.Entity<Coupon>().HasData(new Coupon
        {
            CouponId = 2,
            CouponCode = "vshop_20",
            Discount = 20
        });
    }
}
