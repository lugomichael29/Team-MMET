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
using Dapper;
using System.Data.SQLite;

namespace SweetBoxInventorySystem.UserControl
{
    public partial class ViewItemUC : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly string _connectionString = @"Data Source=.\SweetBoxInventorySystem.db;Version=3;";
        public ViewItemUC()
        {
            InitializeComponent();
        }

        

        private void ViewItemUC_Load(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                var selectFromDB = connection.Query("SELECT * FROM Item").ToList();
                gridControlViewItem.DataSource = selectFromDB;
            }
                
        }

        private void gridControlViewItem_Load(object sender, EventArgs e)
        {
            
        }
    }
}
