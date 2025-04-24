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
        private DateTime expiryDate;

        // Public properties with validation
        public int ProductId
        {
            get { return productId; }
            private set { productId = value; } // Ensure ProductId cannot be changed after creation
        }

        public string ProductName
        {
            get { return productName; }
            private set { productName = value ?? throw new ArgumentNullException(nameof(ProductName), "Product name cannot be null."); }
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

        public DateTime ExpiryDate
        {
            get { return expiryDate; }
            set
            {
                if (value < DateTime.Now) throw new ArgumentException("Expiry date cannot be in the past.", nameof(ExpiryDate));
                expiryDate = value;
            }
        }

        // Constructor to initialize the properties
        public Product(int productId, string productName, int productQuantity, DateTime expiryDate)
        {
            ProductId = productId;
            ProductName = productName;
            ProductQuantity = productQuantity;
            ExpiryDate = expiryDate;
        }

        // Abstract method for product details to be implemented by subclasses
        public abstract string GetProductInfo();

        // Override ToString to provide clean product display
        public override string ToString()
        {
            return $"{ProductName} - {GetProductInfo()}";
        }
    }
}
