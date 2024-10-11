using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateShopLib
{
    public class Shop
    {
        public List<Chocolate> Chocolates { get; set; }
        public List<Customer> Customers { get; set; }

        public Shop() { 

            Chocolates = new List<Chocolate>();

            Customers = new List<Customer>();
        }
    }
}
