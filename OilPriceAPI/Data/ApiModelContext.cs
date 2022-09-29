namespace OilPriceAPI.Data;

using Microsoft.EntityFrameworkCore;
using OilPriceAPI.Models;

public class ApiModelContext : DbContext
{
    public ApiModelContext(DbContextOptions<ApiModelContext> options) : base(options)
    {
    }

    public DbSet<OilPrice> OilPrices { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OilPrice>().ToTable("Course");
        modelBuilder.Entity<OilPrice>().Property(c => c.UpdateTime).HasDefaultValueSql("GETDATE()");

    }
}