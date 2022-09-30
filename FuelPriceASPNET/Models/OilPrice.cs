namespace FuelPriceASPNET.Models;

public class OilPrice
{
    public int OilPriceId { get; set; }
    public string FuelType { get; set; }
    public string City { get; set; }
    public string PostalCode { get; set; }
    public string Address { get; set; }
    public DateTime UpdateTime { get; set; }
    public double Price { get; set; }

}