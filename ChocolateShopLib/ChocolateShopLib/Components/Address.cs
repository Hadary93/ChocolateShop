using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateShopLib.Components
{
    public class Address
    {
        public int Id {  get; set; }    
        public int PostalCode { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }

        //public Address()
        //{
                
        //}
        //public Address(string street, string city, string country, int postalCode, string description)
        //{
        //    Street = street;

        //    City = city;

        //    Country = country;

        //    PostalCode = postalCode;

        //    Description = string.Empty;
        //}
    }
}
