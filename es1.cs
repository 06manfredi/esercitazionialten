using Microsoft.EntityFrameworkCore.Migrations;

namespace tirocinio;
using tirocinio.Models;

public class Esercizio1
{
    public static void Run()
    {


using var context = new AppDbContext();
var department = new Order() { Name = "Tappi", Quantity = 2, Price = 1.1,  newCustomer() = "" };
context.Orders.Add(department);
context.SaveChanges();
    }
}