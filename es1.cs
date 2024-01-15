namespace tirocinio;

public class Customer
{
    public string name;

    public Customer(string name)
    {
        this.name = name;
    }
}

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

public class Esercizio1
{
    public static void Run()
    {
        var mario = new Customer("Mario");
        var luigi = new Customer("Luigi");

        var ordini = new List<Order>();

        ordini.Add(new Order("Penne", 2, 1.5, mario));
        ordini.Add(new Order("Cartucce", 4, 0.5, luigi));
        ordini.Add(new Order("Tappi", 5, 1, mario));

        Console.WriteLine("Ordini:");

        // Non ho voglia di scrivere un foreach
        //ordini.ForEach(o => Console.WriteLine(o.ToString()));

        /*
        Lista di partenza:

            Ordine1
                Mario
            Ordine2
                Mario
            Ordine3
                Luigi

        */

        // operazioni:
        // (OrderByDescending) n
        // (ThenByDescending) n
        // (Select) n
        // (ToList) n

        // operazioni:
        // (OrderByDescending con un Where all'interno) n * n
        // (ThenByDescending) n
        // (Select) n
        // (ToList) n

        var stampa = string.Join(
            Environment.NewLine,
            /*
            GroupBy:

                Group1
                    [Mario, Ordine1]
                        Mario
                    [Mario, Ordine2]
                        Mario
                Group2
                    [Luigi, Ordine3]
                        Luigi

            */
            ordini
                .GroupBy(o => o.customer.name)
                .OrderByDescending(o => o.Sum(x => x.quantity))
                .Select(g => g.OrderByDescending(o => o.quantity))
                // complicato
                //.Select(g =>
                //    string.Join(Environment.NewLine, g.Select(o => o.ToString()))
                //)
                // meno complicato
                .Select(g => g.Select(o => o.ToString()))
                .Select(g => string.Join(Environment.NewLine, g))
        );

        Console.WriteLine(stampa);
    }
}