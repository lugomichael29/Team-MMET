using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetBoxInventorySystem.Models
{
    public class Cake : Product
    {
        public string ProductFlavor { get; set; } // e.g., Chocolate, Vanilla, etc.

        // Constructor to initialize both inherited and new properties
        public Cake(int productId, string productName, int productQuantity, DateTime expiryDate, string productFlavor)
            : base(productId, productName, productQuantity, expiryDate)
        {
            ProductFlavor = productFlavor;
        }

        // Polymorphism: Override GetProductInfo to return cake-specific details
        public override string GetProductInfo()
        {
            return $"Flavor: {ProductFlavor}";
        }
    }
}
