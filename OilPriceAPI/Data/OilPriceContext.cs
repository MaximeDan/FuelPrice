namespace OilPriceAPI.Data;

using Microsoft.EntityFrameworkCore;
using OilPriceAPI.Models;

public class OilPriceContext : DbContext
{
    public OilPriceContext(DbContextOptions<OilPriceContext> options) : base(options)
    {
    }

    public DbSet<OilPrice> OilPrices { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OilPrice>().ToTable("FuelPrice");
        modelBuilder.Entity<OilPrice>().Property(c => c.UpdateTime).HasDefaultValueSql("GETDATE()");
    }
}