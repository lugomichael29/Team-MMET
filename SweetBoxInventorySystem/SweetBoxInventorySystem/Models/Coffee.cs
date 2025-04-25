using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetBoxInventorySystem.Models
{
    public class Coffee : Product
    {
        public string BeanType { get; set; } // Arabica, Robusta, etc.

        // Constructor to initialize both inherited and new properties
        public Coffee(int productId, string productName, int productQuantity, DateTime expiryDate,string beanType)
            : base(productId, productName, productQuantity, expiryDate)
        {
            BeanType = beanType;
        }

        // Polymorphism: Override GetProductInfo to return coffee-specific details
        public override string GetProductInfo()
        {
            return $"Type: {BeanType}";
        }
    }
}
