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
    public partial class OtherPurchaseControl : UserControl
    {
        public OtherPurchaseControl()
        {
            InitializeComponent();
        }

        private void btnOPSubmit_Click(object sender, EventArgs e)
        {
            DateTime date = dtpOPurchaseDate.Value;
            decimal amount;
            if (!decimal.TryParse(txtTotalOPurchase.Text, out amount))
            {
                MessageBox.Show("Please enter a valid amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string nature = radioButtonCash.Checked ? "Cash" : "Credit";
            string type = comboBoxTypeOP.SelectedItem.ToString();

            string connString = @"Server=localhost\SQLEXPRESS;Database=DBFinRep;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            InsertTransaction(conn, transaction, date, amount, nature, type);
                            InsertBalanceSheet(conn, transaction, date, amount, nature, type);

                            transaction.Commit();
                            MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Error saving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    ClearInputFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void InsertTransaction(SqlConnection conn, SqlTransaction transaction, DateTime date, decimal amount, string nature, string type)
        {
            string query = "INSERT INTO Transactions (Date, Amount, Nature, TransactionType, Description) VALUES (@Date, @Amount, @Nature, @TransactionType, @Description)";
            using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@Nature", nature);
                cmd.Parameters.AddWithValue("@TransactionType", type);
                cmd.Parameters.AddWithValue("@Description", type + " Purchase");

                cmd.ExecuteNonQuery();
            }
        }

        private void InsertBalanceSheet(SqlConnection conn, SqlTransaction transaction, DateTime date, decimal amount, string nature, string type)
        {
            string query = "INSERT INTO BalanceSheet (Date, Cash, OtherLiabilities, Land, Furniture, Building) VALUES (@Date, @Cash, @OtherLiabilities, @Land, @Furniture, @Building)";
            using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@Cash", nature == "Cash" ? (object)(-amount) : DBNull.Value);
                cmd.Parameters.AddWithValue("@OtherLiabilities", nature == "Credit" ? (object)amount : DBNull.Value);
                cmd.Parameters.AddWithValue("@Land", type == "Land" ? (object)amount : DBNull.Value);
                cmd.Parameters.AddWithValue("@Furniture", type == "Furniture" ? (object)amount : DBNull.Value);
                cmd.Parameters.AddWithValue("@Building", type == "Building" ? (object)amount : DBNull.Value);

                cmd.ExecuteNonQuery();
            }
        }
        private void ClearInputFields()
        {
            txtTotalOPurchase.Clear();
            
            comboBoxTypeOP.SelectedIndex = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }
    }
}
