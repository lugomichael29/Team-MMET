using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetBoxInventorySystem.Models
{
    public class Cake : Product
    {
        public string ProductFlavor { get; set; } // E.g., Chocolate, Vanilla, etc.
        public string ProductSize { get; set; } // E.g., Small, Medium, Large

        public Cake(int productId, string productName, decimal productPrice, int productQuantity, string productFlavor, string productSize) :
            base(productId, productName, productPrice, productQuantity)
        {
            ProductFlavor = productFlavor ;
            ProductSize = productSize;
        }
        public override string GetProductInfo()
        {
            return $"Flavor: {ProductFlavor}, Size: {ProductSize}";
        }
    }
}
