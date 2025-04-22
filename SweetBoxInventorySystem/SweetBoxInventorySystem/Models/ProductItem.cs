using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetBoxInventorySystem.Models
{
    public class ProductItem : Product
    {
        public DateTime ExpiryDate { get; set; }

        public ProductItem(int productId, string productName, decimal productPrice,) :
           base(productId, productName, productPrice)
        {
            ExpiryDate = DateTime.Now;
           
        }
        public override string GetProductType()
        {
            return $"Expiry: {ExpiryDate} "; 
        }
    }
}
