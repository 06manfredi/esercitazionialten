namespace tirocinio;

public class Esercizio1
{
    public static void Run()
    {
        var ordini = DataOrder.Get();

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