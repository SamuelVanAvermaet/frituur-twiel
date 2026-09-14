using System;
using FrituurTWiel.Products.Persistence.DataModel.Entities;
using FrituurTWiel.Products.Persistence.DataModel.Seed;
using Microsoft.EntityFrameworkCore;

namespace FrituurTWiel.Products.Persistence.DataModel;

public class FrituurTWielDbContext : DbContext
{
    public FrituurTWielDbContext(DbContextOptions<FrituurTWielDbContext> options) : base(options)
    {
    }
    public DbSet<ProductEntity> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("dbo");
        modelBuilder.Entity<ProductEntity>().Property(p => p.Category).HasConversion<string>();

        modelBuilder.Entity<ProductEntity>().HasData(ProductSeedData.GetProducts());
    }
}