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
    public partial class OtherIncomeControl : UserControl
    {
        public OtherIncomeControl()
        {
            InitializeComponent();
        }

        private void buttonOtherIncome_Click(object sender, EventArgs e)
        {
            DateTime incomeDate = dtpOtherIncomeDate.Value;
            decimal amount;
            if (!decimal.TryParse(txtTotalOtherIncome.Text, out amount))
            {
                MessageBox.Show("Invalid amount format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isCashIncome = rbtnCashOIncome.Checked;
            string incomeName = textNameIncome.Text.Trim();

            // Validate input fields
            if (amount <= 0)
            {
                MessageBox.Show("Amount must be greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save other income transaction
            int incomeId = SaveOtherIncomeTransaction(incomeDate, amount, isCashIncome, incomeName);

            if (!isCashIncome)
            {
                // Insert accrued income balance into balance sheet
                InsertBalanceSheet(incomeDate, amount, "AccruedIncome");
            }
            else
            {
                // Insert cash balance into balance sheet
                InsertBalanceSheet(incomeDate, amount, "Cash");
            }

            // Save transaction details
            SaveTransaction(incomeId, amount, isCashIncome, incomeDate);

            MessageBox.Show("Other income recorded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear input fields
            ClearInputFields();
        }

        private int SaveOtherIncomeTransaction(DateTime incomeDate, decimal amount, bool isCashIncome, string incomeName)
        {
            string connString = @"Server=DESKTOP-UFU2OV3\SQLEXPRESS;Initial Catalog=DBFinRep;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string query = "INSERT INTO OtherIncome (Date, Amount, Nature, Name) OUTPUT INSERTED.IncomeID VALUES (@incomeDate, @amount, @nature, @incomeName)";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@incomeDate", incomeDate);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@nature", isCashIncome ? "Cash" : "Credit");
                cmd.Parameters.AddWithValue("@incomeName", incomeName);

                return (int)cmd.ExecuteScalar();
            }
        }

        private void InsertBalanceSheet(DateTime date, decimal amount, string column)
        {
            string connString = @"Server=DESKTOP-UFU2OV3\SQLEXPRESS;Initial Catalog=DBFinRep;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string query = $"INSERT INTO BalanceSheet (Date, {column}) VALUES (@date, @amount)";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.ExecuteNonQuery();
            }
        }

        private void SaveTransaction(int incomeId, decimal amount, bool isCashIncome, DateTime date)
        {
            string connString = @"Server=DESKTOP-UFU2OV3\SQLEXPRESS;Initial Catalog=DBFinRep;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string query = "INSERT INTO Transactions (Date, Amount, Nature, TransactionType) VALUES (@date, @amount, @nature, @type)";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@nature", isCashIncome ? "Cash" : "Credit");
                cmd.Parameters.AddWithValue("@type", "Other Income");
                cmd.ExecuteNonQuery();
            }
        }

        private void ClearInputFields()
        {
            txtTotalOtherIncome.Clear();
            textNameIncome.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }
    }
}


