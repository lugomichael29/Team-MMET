using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SweetBoxInventorySystem.Models
{
    public abstract class Product
    {
       
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public DateTime ExpiryDate { get; set; }



        public Product(int productId, string productName, decimal productPrice, int productQuantity, DateTime expiryDate )
        {
            ProductId = productId;
            ProductName = productName;
            ProductPrice = productPrice;
            ProductQuantity = productQuantity;
            ExpiryDate = expiryDate;
        }



        // Abstract method for each product to provide their own details
        public abstract string GetProductInfo();

        // Override ToString to give a clean product display
        public override string ToString()
        {
            return $"{ProductName} - ${ProductPrice} | {GetProductInfo()}";
        }
    }
}
