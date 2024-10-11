using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ChocolateShopLib.Components
{
    public class Customer
    {
        private string Id { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private List<Address> Address { get; set; }
        private List<Order> orders { get; set; }
        private Cart Cart { get; set; }

        public Customer(string firstName, string lastName)
        {
            Id = Guid.NewGuid().ToString();

            FirstName = firstName;

            LastName = lastName;

            Address = new List<Address>();

            orders = new List<Order>();

            Cart = new Cart();
        }

        public IEnumerable<Order> GetOrders()
        {
            return orders;
        }
    }
}
