using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SweetBoxInventorySystem.Models;
using System.Data.SQLite;
using Dapper;
using SweetBoxInventorySystem.UserControl;

namespace SweetBoxInventorySystem.WinForms
{
    public partial class AddIngredientsType : DevExpress.XtraEditors.XtraForm
    {
        
        public AddIngredientsType()
        {
            InitializeComponent();
        }


        private readonly string _connectionString = @"Data Source=.\SweetBoxInventorySystem.db;Version=3;";

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            string ingredientType = cbIngredientsType.SelectedItem.ToString();
            string ingredientName = teSupplyName.Text;
            string ingredientQuantity = teQuantity.Text;
            string dateTimeBought = dateAddDateIngredients.Text;
            string dateTimeExpired = dateEditExpirationdate.Text;
            int ingredientQuantityInteger = Convert.ToInt32(ingredientQuantity);

            if (string.IsNullOrEmpty(ingredientName) || string.IsNullOrEmpty(ingredientName) || string.IsNullOrEmpty(ingredientQuantity) || string.IsNullOrEmpty(dateTimeBought) || string.IsNullOrEmpty(dateTimeExpired)) {
                XtraMessageBox.Show("error");
                return;
            }

            using (var connection = new SQLiteConnection(_connectionString))
            {

                var ingredients = new Ingredients
                {
                    IngredientType = ingredientType,
                    ProductName = ingredientName,
                    ProductQuantity = ingredientQuantityInteger,
                    BoughtDate = dateTimeBought,
                    ExpiryDate = dateTimeExpired
                };

                var insertQuery = @"INSERT INTO Product (ProductName, ProductQuantity, ProductType, BoughtDate, ExpiryDate)
                                    VALUES (@ProductName,@ProductQuantity, @ProductType, @BoughtDate, @ExpiryDate)";

                var parameter = new DynamicParameters();
                {
                    parameter.Add("ProductName", ingredients.ProductName);
                    parameter.Add("ProductQuantity", ingredients.ProductQuantity);
                    parameter.Add("ProductType", ingredients.IngredientType);
                    parameter.Add("BoughtDate", ingredients.BoughtDate);
                    parameter.Add("ExpiryDate", ingredients.ExpiryDate);
                }
                XtraMessageBox.Show("Ingredient details successfully added");
               

                connection.Execute(insertQuery, parameter);
                connection.Close();
                this.Close();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }

        }
    }
}