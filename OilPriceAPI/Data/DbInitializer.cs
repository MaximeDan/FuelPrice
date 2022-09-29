using OilPriceAPI.Models;

namespace OilPriceAPI.Data;

public class DbInitializer
{
    public static void Initialize(ApiModelContext context)
    {
        context.Database.EnsureCreated();

        // Look for any students.
        if (context.OilPrices.Any())
        {
            return; // DB has been seeded
        }

        var oilPrices = new OilPrice[]
        {
            new() {OilPriceId = 1, Price = 1.598, UpdateTime = DateTime.Parse("2005-09-01")},
            new() {OilPriceId = 2, Price = 1.598, UpdateTime = DateTime.Parse("2005-09-01")},
            new() {OilPriceId = 3, Price = 1.598, UpdateTime = DateTime.Parse("2005-09-01")},
            new() {OilPriceId = 4, Price = 1.598, UpdateTime = DateTime.Parse("2005-09-01")},
            new() {OilPriceId = 5, Price = 1.598, UpdateTime = DateTime.Parse("2005-09-01")},
            new() {OilPriceId = 6, Price = 1.598, UpdateTime = DateTime.Parse("2005-09-01")},
            new() {OilPriceId = 7, Price = 1.598, UpdateTime = DateTime.Parse("2005-09-01")},
            new() {OilPriceId = 8, Price = 1.598, UpdateTime = DateTime.Parse("2005-09-01")},
            new() {OilPriceId = 9, Price = 1.598, UpdateTime = DateTime.Parse("2005-09-01")},
            new() {OilPriceId = 10, Price = 1.598, UpdateTime = DateTime.Parse("2005-09-01")},
        };
        foreach (OilPrice s in oilPrices)
        {
            context.OilPrices.Add(s);
        }

        context.SaveChanges();


    }
}