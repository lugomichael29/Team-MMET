using DevExpress.Sparkline.Core;
using DevExpress.XtraEditors;
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
            string supplyName = texSupplyName.Text;
            string quantity =  texQuantity.Text;
            string itemDate = dateAddDateItem.Text;

            if (string.IsNullOrEmpty(supplyName) || string.IsNullOrEmpty(quantity) || string.IsNullOrEmpty(itemDate)) { 
                XtraMessageBox.Show("Please fill up all the fields!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
        }

        private void cbChooseProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {

        }
    }
}