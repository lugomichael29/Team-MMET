using DevExpress.Data.Utils;
using DevExpress.Skins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetBoxInventorySystem.Models
{
    public class Item : Product
    {
        public string ItemType { get; set; }


        public override string GetProductInfo()
        {
            return $"Item Type: {ItemType}";
        }
    }
}
