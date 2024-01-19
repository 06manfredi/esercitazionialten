namespace tirocinio.Models;

using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    private static readonly string connectionString = @"Server=localhost\SQLEXPRESS;Database=Test;TrustServerCertificate=True;Integrated Security=SSPI;";

    public DbSet<Order> Orders { get; set; }
    public DbSet<Customer> Customers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString);
    }
}