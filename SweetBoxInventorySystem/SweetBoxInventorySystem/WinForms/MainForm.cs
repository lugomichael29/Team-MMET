using DevExpress.XtraEditors;
using SweetBoxInventorySystem.UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SweetBoxInventorySystem.WinForms
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AcViewItem_Click(object sender, EventArgs e)
        {
            ViewItemUC viewItem = new ViewItemUC();
            viewItem.Dock = DockStyle.Fill;
            panelControlmainForm.Controls.Clear();
            panelControlmainForm.Controls.Add(viewItem);
        }

        private void AcAddItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddItemForm AcAddItem = new AddItemForm();
            AcAddItem.Show();
        
        }

        private void AcUpdateItem_Click(object sender, EventArgs e)
        {
            UpdateItemUC updateItem = new UpdateItemUC();
            updateItem.Dock = DockStyle.Fill;
            panelControlmainForm.Controls.Clear();
            panelControlmainForm.Controls.Add(updateItem);
        }

        private void AcSearchExpiryDates_Click(object sender, EventArgs e)
        {
            SearchExpiryDatesUC searchExpiryDates = new SearchExpiryDatesUC();
            searchExpiryDates.Dock = DockStyle.Fill;
            panelControlmainForm.Controls.Clear();
            panelControlmainForm.Controls.Add(searchExpiryDates);
        }

        private void AcViewPastOrders_Click(object sender, EventArgs e)
        {
            ViewPastOrderUC viewPastOrders = new ViewPastOrderUC();
            viewPastOrders.Dock = DockStyle.Fill;
            panelControlmainForm.Controls.Clear();
            panelControlmainForm.Controls.Add(viewPastOrders);
        }

        private void AcViewSupply_Click(object sender, EventArgs e)
        {
            //ViewSupplyUC viewSupply = new ViewSupplyUC();
            //viewSupply.Dock = DockStyle.Fill;
            panelControlmainForm.Controls.Clear();
            //panelControlmainForm.Controls.Add(viewSupply);
        }

        private void AcFullInventoryOverview_Click(object sender, EventArgs e)
        {
            FullInventoryOverviewUC fullInventoryOverview = new FullInventoryOverviewUC();
            fullInventoryOverview.Dock = DockStyle.Fill;
            panelControlmainForm.Controls.Clear();
            panelControlmainForm.Controls.Add(fullInventoryOverview);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

      

        private void aCAddIngredients_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AddIngredientsType ingredientsTypeForm = new AddIngredientsType();
            ingredientsTypeForm.Show();
        }

        private void acLogOut_Click(object sender, EventArgs e)
        {
                // Step 1: Confirm logout with user
                DialogResult result = XtraMessageBox.Show(
                    "Are you sure you want to log out?",
                    "Confirm Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result != DialogResult.Yes)
                    return;

                try
                {
                  

                    // Step 3: Notify user of successful logout
                    XtraMessageBox.Show(
                        "Logout successful. Returning to login screen.",
                        "Logout",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    // Step 4: Close current form and show login form
                    this.Hide();
                    var loginForm = new LogInForm();
                    loginForm.Show();
                }
                catch (Exception ex)
                {
                    // Step 5: Handle any errors
                    XtraMessageBox.Show(
                        $"Logout failed: {ex.Message}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }

                //Application.Exit();
            }
    }
}