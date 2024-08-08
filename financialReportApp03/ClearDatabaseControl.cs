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
    public partial class ClearDatabaseControl : UserControl
    {
        public ClearDatabaseControl()
        {
            InitializeComponent();
        }

        private void buttonClearDB_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete all data from all tables?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string connString = @"Server=localhost\SQLEXPRESS;Database=DBFinRep;Trusted_Connection=True;";
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();

                        // Disable foreign key constraints
                        string disableConstraintsQuery = "EXEC sp_msforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL'";
                        using (SqlCommand cmd = new SqlCommand(disableConstraintsQuery, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        // Delete all data from all tables
                        string deleteDataQuery = "EXEC sp_msforeachtable 'DELETE FROM ?'";
                        using (SqlCommand cmd = new SqlCommand(deleteDataQuery, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        // Enable foreign key constraints
                        string enableConstraintsQuery = "EXEC sp_msforeachtable 'ALTER TABLE ? WITH CHECK CHECK CONSTRAINT ALL'";
                        using (SqlCommand cmd = new SqlCommand(enableConstraintsQuery, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("All data cleared successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error clearing data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Data deletion canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
