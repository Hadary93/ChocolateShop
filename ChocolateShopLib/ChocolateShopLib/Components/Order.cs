using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateShopLib.Components
{
    public class Order
    {
        [Key]
        public string Id { get; set; }
        public List<Chocolate> Chocolates { get; set; }
        public Customer Customer { get; set; }
        public DateTime OrderTime { get; set; }

        public Order() { 
        
        }

        public Order(Customer customer)
        {
            Id = Guid.NewGuid().ToString();

            OrderTime = DateTime.Now;

            Customer = customer;

            Chocolates = new List<Chocolate>();
        }
    }
}
