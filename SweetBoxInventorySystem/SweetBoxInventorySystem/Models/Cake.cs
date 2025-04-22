using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetBoxInventorySystem.Models
{
    public class Cake : Product
    {
        public string ProductFlavor { get; set; } // Example Chocolate, Vanilla, etc.
        public int CakePrize { get; set; } // Example Small, Medium, Large

        public Cake(int productId, string productName, decimal productPrice, int productQuantity,DateTime expiryDate, string productFlavor, int cakePrize) :
            base(productId, productName, productPrice, productQuantity, expiryDate)
        {
            ProductFlavor = productFlavor ;
            CakePrize = cakePrize;
        }
        public override string GetProductInfo()
        {
            return $"Flavor: {ProductFlavor}, Size: {CakePrize}";
        }
    }
}
