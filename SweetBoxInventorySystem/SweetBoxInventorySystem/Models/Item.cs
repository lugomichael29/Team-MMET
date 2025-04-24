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
        public string SyrupPumps { get; set; }

        public string Cups { get; set; }

        public string LidsAndSleeves { get; set; }

        public string Stirrers { get; set; }

        public string Straws { get; set; }

        public string Napkins { get; set; }

        public string SugarPackets { get; set; }

        public string Creamers { get; set; }

        public string TogoBags { get; set; }

        public Item(int productId, string productName, decimal productPrice, int productQuantity, 
            DateTime expiryDate, string syrupPumps , string cups, string lidsAndSleeves,
            string stirrers, string straws, string napkins, string sugarPackets, string creamers, string togoBags) :
           base(productId, productName, productPrice, productQuantity, expiryDate)
        {
            SyrupPumps = syrupPumps;
            Cups = cups;
            LidsAndSleeves = lidsAndSleeves;
            Stirrers = stirrers;
            Straws = straws;
            Napkins = napkins;
            SugarPackets = sugarPackets;
            Creamers = creamers;
            TogoBags = togoBags;
            
        }
        public override string GetProductInfo()
        {
            return $"Item: {SyrupPumps}, {Cups} ,{LidsAndSleeves}, {Stirrers} ,{Straws}, {Napkins} ,{SugarPackets}, {Creamers} ,{TogoBags}";
        }

    }
}
