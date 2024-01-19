namespace tirocinio.Models;

public class Order
{
    public int OrderId { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
    public Customer Customer { get; set; }

}