namespace tirocinio;

public class Order
{
    public string name;
    public int quantity;
    public double price;
    public Customer customer;

    public Order(string name, int quantity, double price, Customer customer)
    {
        this.name = name;
        this.quantity = quantity;
        this.price = price;
        this.customer = customer;
    }

    override public string ToString()
    {
        return $"{customer.name}\t|\t{name} qta{quantity} ${price}";
    }
}