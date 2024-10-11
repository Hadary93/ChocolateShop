﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateShopLib
{
    public class Address
    {
        public int PostalCode { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }


        public Address(string street,string city,string country)
        {
            Street = street;

            City = city;

            Country = country;
        }
    }
}
