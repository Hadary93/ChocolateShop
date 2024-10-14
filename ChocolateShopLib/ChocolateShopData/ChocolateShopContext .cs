using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ChocolateShopLib.Components;

public class ChocolateShopContext : DbContext
{
    public DbSet<Shop> Shops { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Chocolate> Chocolates { get; set; }
    public DbSet<Address> Addresses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=NEOVENDI-NB-KEL;Database=ChocolateShopDb;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}
