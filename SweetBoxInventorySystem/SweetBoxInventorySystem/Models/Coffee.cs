using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetBoxInventorySystem.Models
{
    public class Coffee : Product
    {
        public string ProductType { get; set; } // e.g., Espresso, Latte, etc.
        public string ProductSize { get; set; } // e.g., Small, Medium, Large

        // Constructor to initialize both inherited and new properties
        public Coffee(int productId, string productName, int productQuantity, DateTime expiryDate,
                      string productType, string productSize)
            : base(productId, productName, productQuantity, expiryDate)
        {
            ProductType = productType;
            ProductSize = productSize;
        }

        // Polymorphism: Override GetProductInfo to return coffee-specific details
        public override string GetProductInfo()
        {
            return $"Type: {ProductType}, Size: {ProductSize}";
        }
    }
}
