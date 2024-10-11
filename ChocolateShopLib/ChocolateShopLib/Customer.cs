using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ChocolateShopLib
{
    public class Customer
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Address> Address { get; set; }

        public Customer(string firstName, string lastName)
        {
            Id = Guid.NewGuid().ToString();

            FirstName = firstName;

            LastName = lastName;

            Address = new List<Address>();
        }
    }
}
