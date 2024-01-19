namespace tirocinio.Data;

using tirocinio.Models;

public static class DataCustomer
{
    public static List<Customer> Get()
    {
        var mario = new Customer("Mario");
        var luigi = new Customer("Luigi");

        return [mario, luigi];
    }
}