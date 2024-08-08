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
    public partial class CreditorsControl : UserControl
    {
        public CreditorsControl()
        {
            InitializeComponent();
            LoadCreditorsData();
        }

        private void LoadCreditorsData()
        {
            string connString = @"Server=localhost\SQLEXPRESS;Database=DBFinRep;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            CreditorName AS Name, 
                            SUM(Balance) AS Amount, 
                            MAX(Address) AS Address, 
                            MAX(Phone) AS Phone
                        FROM Creditors
                        GROUP BY CreditorName";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewCreditors.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading creditors data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
