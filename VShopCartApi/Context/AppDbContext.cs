using Microsoft.EntityFrameworkCore;
using VShopCartApi.Models;

namespace VShop.CartApi.Context;

public class AppDbContext : DbContext 
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Product>? Products { get; set; }
    public DbSet<CartItem> CartItems { get; set; }
    public DbSet<CartHeader> CartHeaders { get; set; }

    protected override void OnModelCreating(ModelBuilder mb)
    {
        //product
        mb.Entity<Product>()
            .HasKey(p => p.Id);
        mb.Entity<Product>()
            .Property(p => p.Id)
            .ValueGeneratedNever();
        mb.Entity<Product>()
            .Property(p => p.Name)
            .HasMaxLength(100)
            .IsRequired();
        mb.Entity<Product>()
            .Property(p => p.Description)
            .HasMaxLength(200)
            .IsRequired();
        mb.Entity<Product>()
            .Property(p => p.ImageURL)
            .HasMaxLength(200)
            .IsRequired();
        mb.Entity<Product>()
            .Property(p => p.CategoryName)
            .HasMaxLength(100)
            .IsRequired();
        mb.Entity<Product>()
            .Property(p => p.Price)
            .HasPrecision(12, 2);
            


        base.OnModelCreating(mb);
    }
}
