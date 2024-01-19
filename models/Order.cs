namespace tirocinio.Models;

using Microsoft.EntityFrameworkCore;
using System;

public class Order
{
    public int OrderId { get; set; }
    public string name { get; set; }
    public int quantity { get; set; }
    public double price { get; set; }
    //public Customer customer { get; set; }




    override public string ToString()
    {
        return $"\t|\t{name} qta{quantity} ${price}";
    }
}


public class OrderContext : DbContext
{
    public DbSet<Order> Orders { get; set; }


    public string DbPath { get; }


    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { 
        optionsBuilder.UseSqlServer(@"Server=1C84KS3-A081\SQLEXPRESS\mssqllocaldb;Database=Test"); 
    }
}