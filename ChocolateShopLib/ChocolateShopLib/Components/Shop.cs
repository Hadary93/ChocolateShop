using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateShopLib.Components
{
    public class Shop
    {
        public int Id { get; set; }
        private ICollection<Chocolate> Chocolates { get; set; }
        private ICollection<Customer> Customers { get; set; }

        //public Shop()
        //{

        //    Chocolates = new List<Chocolate>();

        //    Customers = new List<Customer>();
        //}
        //public void AddChocolate(Chocolate chocolate)
        //{
        //    if (chocolate == null) throw new ArgumentNullException(nameof(chocolate));

        //    Chocolates.Add(chocolate);
        //}
        //public bool RemoveChocolate(Chocolate chocolate)
        //{
        //    if (Chocolates.Contains(chocolate)) {

        //        Chocolates.Remove(chocolate);
        //        return true;
        //    }
        //    return false;
        //}
        //public void AddCustomer(Customer customer)
        //{
        //    if (customer == null) throw new ArgumentNullException(nameof(customer));

        //    Customers.Add(customer);
        //}
        //public bool RemoveCustomer(Customer customer)
        //{
        //    if (Customers.Contains(customer)) {

        //        Customers.Remove(customer);
        //        return true;
        //    }
        //    return false;
        //}
        //public IEnumerable<Order> GetOrders()
        //{
        //    return Customers.SelectMany(c => c.GetOrders());
        //}
        //public IEnumerable<Customer> GetCustomers()
        //{
        //    return Customers.AsReadOnly();
        //}
    }
}
