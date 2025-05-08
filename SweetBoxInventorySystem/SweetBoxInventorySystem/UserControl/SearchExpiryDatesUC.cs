using Dapper;
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

namespace SweetBoxInventorySystem.UserControl
{
    public partial class SearchExpiryDatesUC : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly string _connectionString = @"Data Source=.\SweetBoxInventorySystem.db;Version=3;";
        public SearchExpiryDatesUC()
        {
            InitializeComponent();
        }

        private void SearchExpiryDatesUC_Load(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                var selectFromDB = connection.Query("SELECT * FROM Product").ToList();
                gcViewIngredientsExpiryDate.DataSource = selectFromDB;
            }
        }
    }
}
