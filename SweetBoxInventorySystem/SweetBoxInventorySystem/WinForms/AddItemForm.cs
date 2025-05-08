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
            int itemQuantityInteger = int.Parse(itemQuantity);



            if (string.IsNullOrEmpty(itemType) || string.IsNullOrEmpty(itemQuantity) || string.IsNullOrEmpty(dateTimeBought))
            {
                XtraMessageBox.Show("Please fill up all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           

            switch (itemType)
            {
                case "SyrupPumps":

                    using (var connection = new SQLiteConnection(_connectionString))
                    {

                        var item = new Item
                        {
                            ItemType = itemType,
                            ProductQuantity = itemQuantityInteger,
                            BoughtDate = dateTimeBought,



                        };

                        var insertQuery = @"INSERT INTO Product (ProductId, ProductName, ProductQuantity, BoughtDate )
                                            VALUES (@ProductId, @ProductName, @Quantity, @BoughtDate )";

                        var parameter = new DynamicParameters();
                        {
                            parameter.Add("ProductId", item.ItemType);
                            parameter.Add("ProductName", item.ProductName);
                            parameter.Add("Quantity", item.ProductQuantity);
                            parameter.Add("BoughtDate", item.BoughtDate);

                        }

                        connection.Execute(insertQuery, parameter);
                        connection.Close();
                    }

                    break;

                    case "Cups":

                    using (var connection = new SQLiteConnection(_connectionString))
                    {

                        var item = new Item
                        {
                            ItemType = itemType,
                            ProductQuantity = itemQuantityInteger,
                            BoughtDate = dateTimeBought,



                        };

                        var insertQuery = @"INSERT INTO Product (ProductId, ProductName, ProductQuantity, BoughtDate )
                                            VALUES (@ProductId, @ProductName, @Quantity, @BoughtDate )";

                        var parameter = new DynamicParameters();
                        {
                            parameter.Add("ProductId", item.ItemType);
                            parameter.Add("ProductName", item.ProductName);
                            parameter.Add("Quantity", item.ProductQuantity);
                            parameter.Add("BoughtDate", item.BoughtDate);

                        }

                        connection.Execute(insertQuery, parameter);
                        connection.Close();
                    }

                    break;

                case "LidsAndSleeves":

                    using (var connection = new SQLiteConnection(_connectionString))
                    {

                        var item = new Item
                        {
                            ItemType = itemType,
                            ProductQuantity = itemQuantityInteger,
                            BoughtDate = dateTimeBought,



                        };

                        var insertQuery = @"INSERT INTO Product (ProductId, ProductName, ProductQuantity, BoughtDate )
                                            VALUES (@ProductId, @ProductName, @Quantity, @BoughtDate )";

                        var parameter = new DynamicParameters();
                        {
                            parameter.Add("ProductId", item.ItemType);
                            parameter.Add("ProductName", item.ProductName);
                            parameter.Add("Quantity", item.ProductQuantity);
                            parameter.Add("BoughtDate", item.BoughtDate);

                        }

                        connection.Execute(insertQuery, parameter);
                        connection.Close();
                    }

                    break;


                case "Stirrers":

                    using (var connection = new SQLiteConnection(_connectionString))
                    {

                        var item = new Item
                        {
                            ItemType = itemType,
                            ProductQuantity = itemQuantityInteger,
                            BoughtDate = dateTimeBought,



                        };

                        var insertQuery = @"INSERT INTO Product (ProductId, ProductName, ProductQuantity, BoughtDate )
                                            VALUES (@ProductId, @ProductName, @Quantity, @BoughtDate )";

                        var parameter = new DynamicParameters();
                        {
                            parameter.Add("ProductId", item.ItemType);
                            parameter.Add("ProductName", item.ProductName);
                            parameter.Add("Quantity", item.ProductQuantity);
                            parameter.Add("BoughtDate", item.BoughtDate);

                        }

                        connection.Execute(insertQuery, parameter);
                        connection.Close();
                    }

                    break;

                    case "Straws":

                    using (var connection = new SQLiteConnection(_connectionString))
                    {

                        var item = new Item
                        {
                            ItemType = itemType,
                            ProductQuantity = itemQuantityInteger,
                            BoughtDate = dateTimeBought,



                        };

                        var insertQuery = @"INSERT INTO Product (ProductId, ProductName, ProductQuantity, BoughtDate )
                                            VALUES (@ProductId, @ProductName, @Quantity, @BoughtDate )";

                        var parameter = new DynamicParameters();
                        {
                            parameter.Add("ProductId", item.ItemType);
                            parameter.Add("ProductName", item.ProductName);
                            parameter.Add("Quantity", item.ProductQuantity);
                            parameter.Add("BoughtDate", item.BoughtDate);

                        }

                        connection.Execute(insertQuery, parameter);
                        connection.Close();
                    }

                    break;

                case "Napkins":

                    using (var connection = new SQLiteConnection(_connectionString))
                    {

                        var item = new Item
                        {
                            ItemType = itemType,
                            ProductQuantity = itemQuantityInteger,
                            BoughtDate = dateTimeBought,



                        };

                        var insertQuery = @"INSERT INTO Product (ProductId, ProductName, ProductQuantity, BoughtDate )
                                            VALUES (@ProductId, @ProductName, @Quantity, @BoughtDate )";

                        var parameter = new DynamicParameters();
                        {
                            parameter.Add("ProductId", item.ItemType);
                            parameter.Add("ProductName", item.ProductName);
                            parameter.Add("Quantity", item.ProductQuantity);
                            parameter.Add("BoughtDate", item.BoughtDate);

                        }

                        connection.Execute(insertQuery, parameter);
                        connection.Close();
                    }

                    break;

                case "TogoBags":

                    using (var connection = new SQLiteConnection(_connectionString))
                    {

                        var item = new Item
                        {
                            ItemType = itemType,
                            ProductQuantity = itemQuantityInteger,
                            BoughtDate = dateTimeBought,



                        };

                        var insertQuery = @"INSERT INTO Product (ProductId, ProductName, ProductQuantity, BoughtDate )
                                            VALUES (@ProductId, @ProductName, @Quantity, @BoughtDate )";

                        var parameter = new DynamicParameters();
                        {
                            parameter.Add("ProductId", item.ItemType);
                            parameter.Add("ProductName", item.ProductName);
                            parameter.Add("Quantity", item.ProductQuantity);
                            parameter.Add("BoughtDate", item.BoughtDate);

                        }

                        connection.Execute(insertQuery, parameter);
                        connection.Close();
                    }

                    break;


            }

            //private void cbChooseProduct_SelectedIndexChanged(object sender, EventArgs e)
            //{

            //}

            //private void AddItemForm_Load(object sender, EventArgs e)
            //{

            //}
        }
    } 
}