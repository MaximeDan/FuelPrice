namespace OilPriceAPI.Models;

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

public class ApiModelContext : DbContext
{ 
    public string DbPath { get; }
    
    public ApiModelContext() : base("FuelPrice")
    {
        DbPath = "localhost\\Max";
    }
    
    public DbSet<OilPrice> OilPrices { get; set; }
    protected override void OnModelCreating(DbModelBuilder  modelBuilder)
    {
        modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    }
}