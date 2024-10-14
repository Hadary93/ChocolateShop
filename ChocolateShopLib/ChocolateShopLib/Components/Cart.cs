using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateShopLib.Components
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        private List<Chocolate> Chocolates { get; set; }

        public Cart()
        {
            Chocolates = new List<Chocolate>();
        }
        // Add chocolate to the cart
        public void AddChocolate(Chocolate chocolate)
        {
            if (chocolate == null) throw new ArgumentNullException(nameof(chocolate));
            Chocolates.Add(chocolate);
        }

        // Remove chocolate from the cart
        public bool RemoveChocolate(Chocolate chocolate)
        {
            if (chocolate == null) throw new ArgumentNullException(nameof(chocolate));
            return Chocolates.Remove(chocolate);
        }

        // Get total number of chocolates in the cart
        public int GetTotalCount()
        {
            return Chocolates.Count;
        }

        // Get list of chocolates (read-only)
        public IEnumerable<Chocolate> GetChocolates()
        {
            return Chocolates.AsReadOnly();
        }

        // Clear the cart
        public void Clear()
        {
            Chocolates.Clear();
        }
    }
}
