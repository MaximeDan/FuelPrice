using System.Data.Entity;
using OilPriceAPI.Models;

namespace OilPriceAPI;

public class DataBaseApiContext : DbContext
{
    public DataBaseApiContext(): base()   
    {  
        Database.SetInitializer(new DropCreateDatabaseAlways <DataBaseApiContext> ());
    }  
    
    public DbSet <OilPrice> OilPrices
    {  
        get;  
        set;  
    }  
}