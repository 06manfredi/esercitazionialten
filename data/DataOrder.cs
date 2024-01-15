namespace tirocinio.Data;

using tirocinio.Models;

public static class DataOrder
{
    public static List<Order> Get()
    {
        var mario = new Customer("Mario");
        var luigi = new Customer("Luigi");

        var ordini = new List<Order>
        {
            new("Penne", 2, 1.5, mario),
            new("Cartucce", 4, 0.5, luigi),
            new("Tappi", 5, 1, mario)
        };

        return ordini;
    }
}