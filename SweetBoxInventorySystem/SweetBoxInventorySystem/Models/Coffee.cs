using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetBoxInventorySystem.Models
{
    public class Coffee : Product
    {
        public string ProductType { get; set; } // example Espresso, Latte, etc.
        public string ProductSize { get; set; } // example Small, Medium, Large
        public int CoffeePrize { get; set; }//

        public Coffee (int productId, string productName, decimal productPrice, int productQuantity, DateTime expiryDate, string productType, string productSize, int coffeePrize) :
            base(productId, productName, productPrice, productQuantity,expiryDate)
        {
            ProductType = productType;
            ProductSize = productSize;
            CoffeePrize = coffeePrize;
        }
          
        public override string GetProductInfo()
        {
            return $"Type: {ProductType} , Size:  {ProductSize}";
        }
    }
}
