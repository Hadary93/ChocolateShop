using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateShopLib.Components
{
    public class Cart
    {
        private List<Chocolate> Chocolates { get; set; }

        public Cart()
        {
            Chocolates = new List<Chocolate>();
        }
    }
}
