using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateShopLib.Components
{
    public class Order
    {
        private string Id { get; set; }
        private List<Chocolate> Chocolates { get; set; }
        private Customer Customer { get; set; }
        private DateTime OrderTime { get; set; }

        public Order(Customer customer)
        {
            Id = Guid.NewGuid().ToString();

            OrderTime = DateTime.Now;

            Customer = customer;

            Chocolates = new List<Chocolate>();
        }
    }
}
