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

namespace SweetBoxInventorySystem.WinForms
{
    public partial class LogInForm : DevExpress.XtraEditors.XtraForm
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(texUserName.Text) || string.IsNullOrWhiteSpace(texPassword.Text))
            {
                XtraMessageBox.Show("Please enter fields.","Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string correctUsername = "Admin";
            string correctPassword = "123";
            if(texUserName.Text == correctUsername &&  texPassword.Text == correctPassword)
            {
                this.Hide();
                MainForm form = new MainForm();
                form.Show();

            }
            else
            {
                XtraMessageBox.Show("Invalid Username or Password.", "Login Fieled", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}