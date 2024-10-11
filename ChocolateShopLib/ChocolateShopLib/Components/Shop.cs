using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateShopLib.Components
{
    public class Shop
    {
        private List<Chocolate> Chocolates { get; set; }
        private List<Customer> Customers { get; set; }

        public Shop()
        {

            Chocolates = new List<Chocolate>();

            Customers = new List<Customer>();
        }
        public void AddChocolate(Chocolate chocolate)
        {
            Chocolates.Add(chocolate);
        }
        public void RemoveChocolate(Chocolate chocolate)
        {
            Chocolates.Remove(chocolate);
        }
        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }
        public void RemoveCustomer(Customer customer)
        {
            Customers.Remove(customer);
        }
        public IEnumerable<Order> GetOrders()
        {
            return Customers.SelectMany(c => c.GetOrders());
        }
        public IEnumerable<Customer> GetCustomer()
        {
            return Customers;
        }
    }
}
