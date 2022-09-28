using Microsoft.EntityFrameworkCore;
using OilPriceAPI.Models;

namespace OilPriceAPI.Data;

public class ApiDatabase : DbContext
{
    public ApiDatabase(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<OilPrice>();
    }
}