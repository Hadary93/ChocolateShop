using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ChocolateShopLib.Components;
using ChocolateShopDataContextLib;

public class ChocolateShopDbContext : DbContext
{
    public DbSet<Shop> Shops { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Chocolate> Chocolates { get; set; }
    public DbSet<Address> Addresses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //configure the Dbcontext to use sql server.
        optionsBuilder.UseSqlServer("Server=NEOVENDI-NB-KEL;Database=ChocolateShopDb;TrustServerCertificate=True;Trusted_Connection=True;", sqlOptions => sqlOptions.EnableRetryOnFailure(
                    maxRetryCount: 5,       // Maximum number of retries
                    maxRetryDelay: TimeSpan.FromSeconds(10),  // Delay between retries
                    errorNumbersToAdd: null  // Specific SQL error numbers to retry (optional)
                ));
    }
}
