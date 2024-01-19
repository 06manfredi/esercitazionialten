namespace tirocinio.Data;

using tirocinio.Models;

public static class DataOrder
{
    public async static Task<List<Order>> Get()
    {
        // Aspetta 1 secondo per simulare il caricamento dei dati
        await Task.Delay(1000);

        var mario = new Customer("Mario");
        var luigi = new Customer("Luigi");
        
        return new List<Order>();

/*         var ordini = new List<Order>
        {
            new("Penne", 2, 1.5, mario),
            new("Cartucce", 4, 0.5, luigi),
            new("Tappi", 5, 1, mario)
        };

        return ordini; */
    }
}