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
            int ingredientQuantityInteger = int.Parse(ingredientQuantity);

            if (string.IsNullOrEmpty(ingredientName) || string.IsNullOrEmpty(ingredientName) || string.IsNullOrEmpty(ingredientQuantity) || string.IsNullOrEmpty(dateTimeBought) || string.IsNullOrEmpty(dateTimeExpired))
            {
                XtraMessageBox.Show("error");
                return;
            }
            
            switch (ingredientType) {
                case "BeanType":
                   
                    using (var connection = new SQLiteConnection(_connectionString)) {

                        var ingredients = new Ingredients
                        {
                            IngredientType = ingredientType,
                            ProductName = ingredientName,
                            ProductQuantity = ingredientQuantityInteger,
                            BoughtDate = dateTimeBought,
                            ExpiryDate = dateTimeExpired
                        };

                        var insertQuery = @"INSERT INTO Product (ProductId, ProductName, ProductType, Quantity, BoughtDate, ExpiryDate)
                                            VALUES (@ProductId, @ProductName, @Quantity, @BoughtDate, @ExpiryDate)";

                        var parameter = new DynamicParameters();
                        {
                            parameter.Add("ProductId", ingredients.IngredientType);
                            parameter.Add("ProductName", ingredients.ProductName);
                            parameter.Add("ProductType", ingredients.IngredientType);
                            parameter.Add("Quantity", ingredients.ProductQuantity);
                            parameter.Add("BoughtDate", ingredients.BoughtDate);
                            parameter.Add("ExpiryDate", ingredients.ExpiryDate);
                        }

                        connection.Execute(insertQuery, parameter);
                        connection.Close();
                    }

                        break;

                case " Milk":
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

                        var insertQuery = @"INSERT INTO Product (ProductId, ProductName, ProductType, Quantity, BoughtDate, ExpiryDate)
                                            VALUES (@ProductId, @ProductName, @Quantity, @BoughtDate, @ExpiryDate)";

                        var parameter = new DynamicParameters();
                        {
                            parameter.Add("ProductId", ingredients.IngredientType);
                            parameter.Add("ProductName", ingredients.ProductName);
                            parameter.Add("ProductType", ingredients.IngredientType);
                            parameter.Add("Quantity", ingredients.ProductQuantity);
                            parameter.Add("BoughtDate", ingredients.BoughtDate);
                            parameter.Add("ExpiryDate", ingredients.ExpiryDate);
                        }

                        connection.Execute(insertQuery, parameter);
                        connection.Close();
                    }
                    break;

                case "ChocolateSauce":
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

                        var insertQuery = @"INSERT INTO Product (ProductId, ProductName, ProductType, Quantity, BoughtDate, ExpiryDate)
                                            VALUES (@ProductId, @ProductName, @Quantity, @BoughtDate, @ExpiryDate)";

                        var parameter = new DynamicParameters();
                        {
                            parameter.Add("ProductId", ingredients.IngredientType);
                            parameter.Add("ProductName", ingredients.ProductName);
                            parameter.Add("ProductType", ingredients.IngredientType);
                            parameter.Add("Quantity", ingredients.ProductQuantity);
                            parameter.Add("BoughtDate", ingredients.BoughtDate);
                            parameter.Add("ExpiryDate", ingredients.ExpiryDate);
                        }

                        connection.Execute(insertQuery, parameter);
                        connection.Close();
                    }
                    break;

                case "WhiteChocolateSauce":
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

                        var insertQuery = @"INSERT INTO Product (ProductId, ProductName, ProductType, Quantity, BoughtDate, ExpiryDate)
                                            VALUES (@ProductId, @ProductName, @Quantity, @BoughtDate, @ExpiryDate)";

                        var parameter = new DynamicParameters();
                        {
                            parameter.Add("ProductId", ingredients.IngredientType);
                            parameter.Add("ProductName", ingredients.ProductName);
                            parameter.Add("ProductType", ingredients.IngredientType);
                            parameter.Add("Quantity", ingredients.ProductQuantity);
                            parameter.Add("BoughtDate", ingredients.BoughtDate);
                            parameter.Add("ExpiryDate", ingredients.ExpiryDate);
                        }

                        connection.Execute(insertQuery, parameter);
                        connection.Close();
                    }
                    break;

                case "SugarPackets":
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

                        var insertQuery = @"INSERT INTO Product (ProductId, ProductName, ProductType, Quantity, BoughtDate, ExpiryDate)
                                            VALUES (@ProductId, @ProductName, @Quantity, @BoughtDate, @ExpiryDate)";

                        var parameter = new DynamicParameters();
                        {
                            parameter.Add("ProductId", ingredients.IngredientType);
                            parameter.Add("ProductName", ingredients.ProductName);
                            parameter.Add("ProductType", ingredients.IngredientType);
                            parameter.Add("Quantity", ingredients.ProductQuantity);
                            parameter.Add("BoughtDate", ingredients.BoughtDate);
                            parameter.Add("ExpiryDate", ingredients.ExpiryDate);
                        }

                        connection.Execute(insertQuery, parameter);
                        connection.Close();
                    }
                    break;

                case "Creamers":
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

                        var insertQuery = @"INSERT INTO Product (ProductId, ProductName, ProductType, Quantity, BoughtDate, ExpiryDate)
                                            VALUES (@ProductId, @ProductName, @Quantity, @BoughtDate, @ExpiryDate)";

                        var parameter = new DynamicParameters();
                        {
                            parameter.Add("ProductId", ingredients.IngredientType);
                            parameter.Add("ProductName", ingredients.ProductName);
                            parameter.Add("ProductType", ingredients.IngredientType);
                            parameter.Add("Quantity", ingredients.ProductQuantity);
                            parameter.Add("BoughtDate", ingredients.BoughtDate);
                            parameter.Add("ExpiryDate", ingredients.ExpiryDate);
                        }

                        connection.Execute(insertQuery, parameter);
                        connection.Close();
                    }
                    break;

                case "CaramelSauce":
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

                        var insertQuery = @"INSERT INTO Product (ProductId, ProductName, ProductType, Quantity, BoughtDate, ExpiryDate)
                                            VALUES (@ProductId, @ProductName, @Quantity, @BoughtDate, @ExpiryDate)";

                        var parameter = new DynamicParameters();
                        {
                            parameter.Add("ProductId", ingredients.IngredientType);
                            parameter.Add("ProductName", ingredients.ProductName);
                            parameter.Add("ProductType", ingredients.IngredientType);
                            parameter.Add("Quantity", ingredients.ProductQuantity);
                            parameter.Add("BoughtDate", ingredients.BoughtDate);
                            parameter.Add("ExpiryDate", ingredients.ExpiryDate);
                        }

                        connection.Execute(insertQuery, parameter);
                        connection.Close();
                    }
                    break;

                case "VanillaSyrup":
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

                        var insertQuery = @"INSERT INTO Product (ProductId, ProductName, ProductType, Quantity, BoughtDate, ExpiryDate)
                                            VALUES (@ProductId, @ProductName, @Quantity, @BoughtDate, @ExpiryDate)";

                        var parameter = new DynamicParameters();
                        {
                            parameter.Add("ProductId", ingredients.IngredientType);
                            parameter.Add("ProductName", ingredients.ProductName);
                            parameter.Add("ProductType", ingredients.IngredientType);
                            parameter.Add("Quantity", ingredients.ProductQuantity);
                            parameter.Add("BoughtDate", ingredients.BoughtDate);
                            parameter.Add("ExpiryDate", ingredients.ExpiryDate);
                        }

                        connection.Execute(insertQuery, parameter);
                        connection.Close();
                    }
                    break;

                case "CaramelSyrup":
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

                        var insertQuery = @"INSERT INTO Product (ProductId, ProductName, ProductType, Quantity, BoughtDate, ExpiryDate)
                                            VALUES (@ProductId, @ProductName, @Quantity, @BoughtDate, @ExpiryDate)";

                        var parameter = new DynamicParameters();
                        {
                            parameter.Add("ProductId", ingredients.IngredientType);
                            parameter.Add("ProductName", ingredients.ProductName);
                            parameter.Add("ProductType", ingredients.IngredientType);
                            parameter.Add("Quantity", ingredients.ProductQuantity);
                            parameter.Add("BoughtDate", ingredients.BoughtDate);
                            parameter.Add("ExpiryDate", ingredients.ExpiryDate);
                        }

                        connection.Execute(insertQuery, parameter);
                        connection.Close();
                    }
                    break;


                case "SaltedCaramelSyrup":
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

                        var insertQuery = @"INSERT INTO Product (ProductId, ProductName, ProductType, Quantity, BoughtDate, ExpiryDate)
                                            VALUES (@ProductId, @ProductName, @Quantity, @BoughtDate, @ExpiryDate)";

                        var parameter = new DynamicParameters();
                        {
                            parameter.Add("ProductId", ingredients.IngredientType);
                            parameter.Add("ProductName", ingredients.ProductName);
                            parameter.Add("ProductType", ingredients.IngredientType);
                            parameter.Add("Quantity", ingredients.ProductQuantity);
                            parameter.Add("BoughtDate", ingredients.BoughtDate);
                            parameter.Add("ExpiryDate", ingredients.ExpiryDate);
                        }

                        connection.Execute(insertQuery, parameter);
                        connection.Close();
                    }
                    break;

                case "CheeseCakeSyrup":
                    using (var connection = new SQLiteConnection(_connectionString))
                    {

                        var ingredients = new 
                            Ingredients
                        {
                            IngredientType = ingredientType,
                            ProductName = ingredientName,
                            ProductQuantity = ingredientQuantityInteger,
                            BoughtDate = dateTimeBought,
                            ExpiryDate = dateTimeExpired
                        };

                        var insertQuery = @"INSERT INTO Product (ProductId, ProductName, ProductType, Quantity, BoughtDate, ExpiryDate)
                                            VALUES (@ProductId, @ProductName, @Quantity, @BoughtDate, @ExpiryDate)";

                        var parameter = new DynamicParameters();
                        {
                            parameter.Add("ProductId", ingredients.IngredientType);
                            parameter.Add("ProductName", ingredients.ProductName);
                            parameter.Add("ProductType", ingredients.IngredientType);
                            parameter.Add("Quantity", ingredients.ProductQuantity);
                            parameter.Add("BoughtDate", ingredients.BoughtDate);
                            parameter.Add("ExpiryDate", ingredients.ExpiryDate);
                        }

                        connection.Execute(insertQuery, parameter);
                        connection.Close();
                    }
                    break;

                case "HazelNutSyrup":
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

                        var insertQuery = @"INSERT INTO Product (ProductId, ProductName, ProductType, Quantity, BoughtDate, ExpiryDate)
                                            VALUES (@ProductId, @ProductName, @Quantity, @BoughtDate, @ExpiryDate)";

                        var parameter = new DynamicParameters();
                        {
                            parameter.Add("ProductId", ingredients.IngredientType);
                            parameter.Add("ProductName", ingredients.ProductName);
                            parameter.Add("ProductType", ingredients.IngredientType);
                            parameter.Add("Quantity", ingredients.ProductQuantity);
                            parameter.Add("BoughtDate", ingredients.BoughtDate);
                            parameter.Add("ExpiryDate", ingredients.ExpiryDate);
                        }

                        connection.Execute(insertQuery, parameter);
                        connection.Close();
                    }
                    break;

                case "VanilaPowder":
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

                        var insertQuery = @"INSERT INTO Product (ProductId, ProductName, ProductType, Quantity, BoughtDate, ExpiryDate)
                                            VALUES (@ProductId, @ProductName, @Quantity, @BoughtDate, @ExpiryDate)";

                        var parameter = new DynamicParameters();
                        {
                            parameter.Add("ProductId", ingredients.IngredientType);
                            parameter.Add("ProductName", ingredients.ProductName);
                            parameter.Add("ProductType", ingredients.IngredientType);
                            parameter.Add("Quantity", ingredients.ProductQuantity);
                            parameter.Add("BoughtDate", ingredients.BoughtDate);
                            parameter.Add("ExpiryDate", ingredients.ExpiryDate);
                        }

                        connection.Execute(insertQuery, parameter);
                        connection.Close();
                    }
                    break;

                case "StrawberryPowder":
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

                        var insertQuery = @"INSERT INTO Product (ProductId, ProductName, ProductType, Quantity, BoughtDate, ExpiryDate)
                                            VALUES (@ProductId, @ProductName, @Quantity, @BoughtDate, @ExpiryDate)";

                        var parameter = new DynamicParameters();
                        {
                            parameter.Add("ProductId", ingredients.IngredientType);
                            parameter.Add("ProductName", ingredients.ProductName);
                            parameter.Add("ProductType", ingredients.IngredientType);
                            parameter.Add("Quantity", ingredients.ProductQuantity);
                            parameter.Add("BoughtDate", ingredients.BoughtDate);
                            parameter.Add("ExpiryDate", ingredients.ExpiryDate);
                        }

                        connection.Execute(insertQuery, parameter);
                        connection.Close();
                    }
                    break;

                case "MatchaPowder":
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

                        var insertQuery = @"INSERT INTO Product (ProductId, ProductName, ProductType, Quantity, BoughtDate, ExpiryDate)
                                            VALUES (@ProductId, @ProductName, @Quantity, @BoughtDate, @ExpiryDate)";

                        var parameter = new DynamicParameters();
                        {
                            parameter.Add("ProductId", ingredients.IngredientType);
                            parameter.Add("ProductName", ingredients.ProductName);
                            parameter.Add("ProductType", ingredients.IngredientType);
                            parameter.Add("Quantity", ingredients.ProductQuantity);
                            parameter.Add("BoughtDate", ingredients.BoughtDate);
                            parameter.Add("ExpiryDate", ingredients.ExpiryDate);
                        }

                        connection.Execute(insertQuery, parameter);
                        connection.Close();
                    }
                    break;

                case "ChocolatePowder":
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

                        var insertQuery = @"INSERT INTO Product (ProductId, ProductName, ProductType, Quantity, BoughtDate, ExpiryDate)
                                            VALUES (@ProductId, @ProductName, @Quantity, @BoughtDate, @ExpiryDate)";

                        var parameter = new DynamicParameters();
                        {
                            parameter.Add("ProductId", ingredients.IngredientType);
                            parameter.Add("ProductName", ingredients.ProductName);
                            parameter.Add("ProductType", ingredients.IngredientType);
                            parameter.Add("Quantity", ingredients.ProductQuantity);
                            parameter.Add("BoughtDate", ingredients.BoughtDate);
                            parameter.Add("ExpiryDate", ingredients.ExpiryDate);
                        }

                        connection.Execute(insertQuery, parameter);
                        connection.Close();
                    }
                    break;

                case "FrappeBasePowder":
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

                        var insertQuery = @"INSERT INTO Product (ProductId, ProductName, ProductType, Quantity, BoughtDate, ExpiryDate)
                                            VALUES (@ProductId, @ProductName, @Quantity, @BoughtDate, @ExpiryDate)";

                        var parameter = new DynamicParameters();
                        {
                            parameter.Add("ProductId", ingredients.IngredientType);
                            parameter.Add("ProductName", ingredients.ProductName);
                            parameter.Add("ProductType", ingredients.IngredientType);
                            parameter.Add("Quantity", ingredients.ProductQuantity);
                            parameter.Add("BoughtDate", ingredients.BoughtDate);
                            parameter.Add("ExpiryDate", ingredients.ExpiryDate);
                        }

                        connection.Execute(insertQuery, parameter);
                        connection.Close();
                    }
                    break;

                case "Fructose":
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

                        var insertQuery = @"INSERT INTO Product (ProductId, ProductName, ProductType, Quantity, BoughtDate, ExpiryDate)
                                            VALUES (@ProductId, @ProductName, @Quantity, @BoughtDate, @ExpiryDate)";

                        var parameter = new DynamicParameters();
                        {
                            parameter.Add("ProductId", ingredients.IngredientType);
                            parameter.Add("ProductName", ingredients.ProductName);
                            parameter.Add("ProductType", ingredients.IngredientType);
                            parameter.Add("Quantity", ingredients.ProductQuantity);
                            parameter.Add("BoughtDate", ingredients.BoughtDate);
                            parameter.Add("ExpiryDate", ingredients.ExpiryDate);
                        }

                        connection.Execute(insertQuery, parameter);
                        connection.Close();
                    }
                    break;

                  case "CreamerPowder":
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

                        var insertQuery = @"INSERT INTO Product (ProductId, ProductName, ProductType, Quantity, BoughtDate, ExpiryDate)
                                            VALUES (@ProductId, @ProductName, @Quantity, @BoughtDate, @ExpiryDate)";

                        var parameter = new DynamicParameters();
                        {
                            parameter.Add("ProductId", ingredients.IngredientType);
                            parameter.Add("ProductName", ingredients.ProductName);
                            parameter.Add("ProductType", ingredients.IngredientType);
                            parameter.Add("Quantity", ingredients.ProductQuantity);
                            parameter.Add("BoughtDate", ingredients.BoughtDate);
                            parameter.Add("ExpiryDate", ingredients.ExpiryDate);
                        }

                        connection.Execute(insertQuery, parameter);
                        connection.Close();
                    }
                    break;
            }
        }
    }
}