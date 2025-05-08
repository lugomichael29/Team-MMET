using Dapper;
using DevExpress.Sparkline.Core;
using DevExpress.XtraEditors;
using SweetBoxInventorySystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SweetBoxInventorySystem.WinForms
{
    public partial class AddItemForm : DevExpress.XtraEditors.XtraForm
    {
        public AddItemForm()
        {
            InitializeComponent();
        }

        private readonly string _connectionString = @"Data Source=.\SweetBoxInventorySystem.db;Version=3;";

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //string userChoice = cbChooseProduct.SelectedItem.ToString();
            string itemType = cbItemType.SelectedItem.ToString();
            string itemQuantity = texQuantity.Text;
            string dateTimeBought = dateAddDateItem.Text;
            int itemQuantityInteger = Convert.ToInt32(itemQuantity);



            if (string.IsNullOrEmpty(itemType) || string.IsNullOrEmpty(itemQuantity) || string.IsNullOrEmpty(dateTimeBought))
            {
                XtraMessageBox.Show("Please fill up all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var connection = new SQLiteConnection(_connectionString))
            {

                var item = new Item
                {
                    ItemType = itemType,
                    ProductQuantity = itemQuantityInteger,
                    BoughtDate = dateTimeBought
                };

                var insertQuery = @"INSERT INTO Item (ProductName, ProductQuantity, BoughtDate )
                                            VALUES (@ProductName, @ProductQuantity, @BoughtDate )";

                var parameter = new DynamicParameters();
                {
                    parameter.Add("ProductName", item.ItemType);
                    parameter.Add("ProductQuantity", item.ProductQuantity);
                    parameter.Add("BoughtDate", item.BoughtDate);

                }

                connection.Execute(insertQuery, parameter);
                XtraMessageBox.Show("Item successsfully added to the database");
                connection.Close();
                MainForm form = new MainForm();
                form.Show();
            }
        }
    } 
}