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
        // Private fields to encapsulate data
        private int productId;
        private string productName;
        private int productQuantity;
        private string expiryDate = DateTime.Now.Date.ToString("yyyy-MM-dd");

        
        // Public properties with validation
        public int ProductId
        {
            get { return productId; }
            set { productId = value; } // Ensure ProductId cannot be changed after creation
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value ?? throw new ArgumentNullException(nameof(ProductName), "Product name cannot be null."); }
        }

        public int ProductQuantity
        {
            get { return productQuantity; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(ProductQuantity), "Quantity cannot be negative.");
                productQuantity = value;
            }
        }

        public string BoughtDate {
            get;set;
        }

        public string ExpiryDate
        {
            get;set;
        }



        // Abstract method for product details to be implemented by subclasses
        public abstract string GetProductInfo();

        // Override ToString to provide clean product display

    }
}
