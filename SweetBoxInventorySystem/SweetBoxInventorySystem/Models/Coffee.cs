using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetBoxInventorySystem.Models
{
    public class Coffee : Product
    {
        public string ProductType { get; set; } // E.g., Espresso, Latte, etc.
        public string ProductSize { get; set; } // E.g., Small, Medium, Large

        public Coffee (int productId, string productName, decimal productPrice, int productQuantity, string productType, string productSize) :
            base(productId, productName, productPrice, productQuantity)
        {
            ProductType = productType;
            ProductSize = productSize;

        }
          
        public override string GetProductInfo()
        {
            return $"Type: {ProductType} , Size:  {ProductSize}";
        }
    }
}
