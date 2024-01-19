namespace tirocinio.Models;

using Microsoft.EntityFrameworkCore;

public class Order
{
    public int OrderId { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
    //public Customer customer { get; set; }
}


public class OrderContext : DbContext
{
    public DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { 
        optionsBuilder.UseSqlServer(@"Server=localhost;Database=Test;TrustServerCertificate=True;Integrated Security=SSPI;"); 
    }
}