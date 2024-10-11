using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateShopLib.Components
{
    public class Address
    {
        private int PostalCode { get; set; }
        private string Street { get; set; }
        private string City { get; set; }
        private string Country { get; set; }


        public Address(string street, string city, string country, int postalCode)
        {
            Street = street;

            City = city;

            Country = country;

            PostalCode = postalCode;
        }
    }
}
