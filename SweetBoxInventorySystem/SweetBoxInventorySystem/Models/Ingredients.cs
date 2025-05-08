using DevExpress.Skins;
using DevExpress.Utils.About;
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
        

        public string IngredientType { get; set; }

        

        public override string GetProductInfo()
        {
            return $"Ingredient Types: {IngredientType}";
        }
    }
}
