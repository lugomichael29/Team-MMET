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
       
        public Cake(int productId, string productName, decimal productPrice, int productQuantity,DateTime expiryDate, string productFlavor) :
            base(productId, productName, productPrice, productQuantity, expiryDate)
        {
            ProductFlavor = productFlavor ;
           
        }
        public override string GetProductInfo()
        {
            return $"Flavor: {ProductFlavor}";
        }
    }
}
