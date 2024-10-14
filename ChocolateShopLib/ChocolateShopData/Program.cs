using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateShopData
{
    public class Program
    {
        public static void Main(string[] args) { 
        
            ChocolateShopContext DBcontext = new ChocolateShopContext();

            DBcontext.Shops.Add(new ChocolateShopLib.Components.Shop());

            DBcontext.SaveChanges();    
        }
    }
}
