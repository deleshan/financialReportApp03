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
    public partial class TaxControl : UserControl
    {
        string connString = @"Server=DESKTOP-UFU2OV3\SQLEXPRESS;Initial Catalog=DBFinRep;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public TaxControl()
        {
            InitializeComponent();
            LoadTaxTypes();
        }

        private void LoadTaxTypes()
        {
            comboTypeTax.Items.Add("Sales Tax");
            comboTypeTax.Items.Add("Property Tax");
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            DateTime date = dateTax.Value.Date;
            decimal amount = decimal.Parse(txtTaxAmount.Text);
            string type = comboTypeTax.SelectedItem.ToString();

            if (amount <= 0)
            {
                MessageBox.Show("Amount must be greater than zero.");
                return;
            }

            // Save tax transaction to database
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // Insert into OtherTax table
                    string insertQuery = "INSERT INTO OtherTax (Date, Amount, TaxType) VALUES (@date, @amount, @type)";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.ExecuteNonQuery();

                    // Update balanceSheet table (reduce cash balance)
                    UpdateBalanceSheet("Cash", -amount);

                    // Insert into Transaction table
                    string insertTransactionQuery = "INSERT INTO Transactions (Date, TransactionType, Amount, Description) VALUES (@date, 'Tax', @amount, @type)";
                    SqlCommand transactionCmd = new SqlCommand(insertTransactionQuery, conn);
                    transactionCmd.Parameters.AddWithValue("@date", date);
                    transactionCmd.Parameters.AddWithValue("@amount", amount);
                    transactionCmd.Parameters.AddWithValue("@type", type);
                    transactionCmd.ExecuteNonQuery();

                    MessageBox.Show("Tax record saved successfully.");
                    ClearInputFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving tax record: {ex.Message}");
            }
        }

        private void UpdateBalanceSheet(string column, decimal amount)
        {
            try
            {
                string query = "INSERT INTO BalanceSheet (Date, " + column + ") VALUES (@date, @amount)";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating balance sheet: {ex.Message}");
            }
        }

        private void ClearInputFields()
        {
            txtTaxAmount.Clear();
            comboTypeTax.SelectedIndex = -1;
            
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }
    }
}
