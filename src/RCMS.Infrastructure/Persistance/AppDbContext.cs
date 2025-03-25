using Microsoft.EntityFrameworkCore;
using RCMS.Domain.Entities;

namespace RCMS.Infrastructure.Persistance;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {}
    
    public DbSet<Part> Parts { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Inventory> Inventory { get; set; }
    public DbSet<Category> Category { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Part>()
            .HasOne(p => p.Category)
            .WithMany(c => c.Parts)
            .HasForeignKey(p => p.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<Part>()
            .Property(p => p.Price)
            .HasPrecision(18,2);
        
         modelBuilder.Entity<Part>()
            .HasOne(p => p.Supplier)
            .WithMany(c => c.Parts)
            .HasForeignKey(p => p.SupplierId)
            .OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<Inventory>()
            .HasOne(i => i.Part)
            .WithMany(p => p.Inventory)
            .HasForeignKey(i => i.PartId)
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<Inventory>()
            .HasOne(i => i.User)
            .WithMany(u => u.Inventories)
            .HasForeignKey(i => i.UserId)
            .OnDelete(DeleteBehavior.Cascade);
        
        base.OnModelCreating(modelBuilder);
    }
}