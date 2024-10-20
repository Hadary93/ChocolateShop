using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ChocolateShopLib.Components;
using ChocolateShopDataContextLib;

public class ChocolateShopDbContext : DbContext
{
    public ChocolateShopDbContext(DbContextOptions<ChocolateShopDbContext> options)
           : base(options)
    {
    }

    public DbSet<Shop> Shops { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Chocolate> Chocolates { get; set; }
    public DbSet<Address> Addresses { get; set; }



}
