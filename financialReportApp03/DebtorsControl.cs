using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace financialReportApp03
{
    public partial class DebtorsControl : UserControl
    {
        public DebtorsControl()
        {
            InitializeComponent();
            LoadDebtorsData();
        }
        private void LoadDebtorsData()
        {
            string connString = @"Server=localhost\SQLEXPRESS;Database=DBFinRep;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT DebtorName, SUM(Amount) as Amount, MAX(Address) as Address, MAX(Phone) as Phone
                        FROM Debtors
                        GROUP BY DebtorName";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewDebtors.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading debtors data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       
    }
}
   
