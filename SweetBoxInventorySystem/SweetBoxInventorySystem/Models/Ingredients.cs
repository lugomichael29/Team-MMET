using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetBoxInventorySystem.Models
{
    public class Ingredients : Product
    {
        //beans
        public string BeanType { get; set; } // Arabica, Robusta, etc.

        public string Milk { get; set; }
        public string IceCube { get; set; }
        public string ChocolateSauce { get; set; }
        public string WhiteChocolateSauce { get; set; }
        public string SugarPackets { get; set; }
        public string Creamers { get; set; }
        public string CaramelSauce { get; set; } 
        // all Syrup
        public string VanillaSyrup { get; set; } 
        public string CaramelSyrup { get; set; } 
        public string SaltedCaramelSyrup { get; set; } 
        public string CheeseCakeSyrup { get; set; } 
        public string HazelNutSyrup { get; set; } 
        
        //All Powder
        public string VanilaPowder { get; set; }
        public string StrawberryPowder { get; set; }
        public string MatchaPowder { get; set; }
        public string ChocolatePowder { get; set; }
        public string FrappeBasePowder { get; set; }
        public string Fructose { get; set; }





        public Ingredients(
        int productId, string productName, int productQuantity, DateTime expiryDate, string beanType,
        string milk, string iceCube, string chocolateSauce, string whiteChocolateSauce,
        string sugarPackets, string creamers, string caramelSauce,
        string vanillaSyrup, string caramelSyrup, string saltedCaramelSyrup,
        string cheeseCakeSyrup, string hazelNutSyrup,
        string vanilaPowder, string strawberryPowder, string matchaPowder,
        string chocolatePowder, string frappeBasePowder, string fructose
    ) : base(productId, productName, productQuantity, expiryDate)
        {
            BeanType = beanType;
            Milk = milk;
            IceCube = iceCube;
            ChocolateSauce = chocolateSauce;
            WhiteChocolateSauce = whiteChocolateSauce;
            SugarPackets = sugarPackets;
            Creamers = creamers;
            CaramelSauce = caramelSauce;
            VanillaSyrup = vanillaSyrup;
            CaramelSyrup = caramelSyrup;
            SaltedCaramelSyrup = saltedCaramelSyrup;
            CheeseCakeSyrup = cheeseCakeSyrup;
            HazelNutSyrup = hazelNutSyrup;
            VanilaPowder = vanilaPowder;
            StrawberryPowder = strawberryPowder;
            MatchaPowder = matchaPowder;
            ChocolatePowder = chocolatePowder;
            FrappeBasePowder = frappeBasePowder;
            Fructose = fructose;
        }
        public override string GetProductInfo()
        {
            return $"Qty: {ProductQuantity}, Expires: {ExpiryDate.ToShortDateString()}";
        }
    }
}
