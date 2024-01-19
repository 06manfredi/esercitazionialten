namespace tirocinio;

using tirocinio.Data;
using tirocinio.Models;

public class Esercizio1
{
    public static void Run()
    {
        Task.Run(async () =>
        {
            Console.WriteLine("ESERCIZIO 1");
            var ordini = await DataOrder.Get();

            var stampa = string.Join(
                Environment.NewLine,
                ordini
                    .GroupBy(o => o.name)
                    .OrderByDescending(o => o.Sum(x => x.quantity))
                    .Select(g => g.OrderByDescending(o => o.quantity))
                    .Select(g => g.Select(o => o.ToString()))
                    .Select(g => string.Join(Environment.NewLine, g))
            );

            Console.WriteLine(stampa);
        }).Wait();
    }
}