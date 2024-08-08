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
    public partial class ExpenseControl : UserControl
    {
        string connString = @"Server=DESKTOP-UFU2OV3\SQLEXPRESS;Initial Catalog=DBFinRep;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public ExpenseControl()
        {
            InitializeComponent();
        }

        private void buttonExpense_Click(object sender, EventArgs e)
        {
            DateTime expenseDate = DateExpense.Value;
            decimal amount = decimal.Parse(txtExpenseAmount.Text);
            bool isCashExpense = rbtnCashExpense.Checked;
            bool isCreditExpense = rbtnCreditExpense.Checked;
            string expenseType = comboExpenseType.SelectedItem.ToString();
            string description = txtDescription.Text.Trim();

            // Validate input fields
            if (amount <= 0)
            {
                MessageBox.Show("Amount must be greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Save expense transaction
                            int expenseId = SaveExpenseTransaction(conn, transaction, expenseDate, amount, isCashExpense, expenseType, description);

                            if (isCreditExpense)
                            {
                                // Update accrued expenses balance in balance sheet
                                UpdateBalanceSheet(conn, transaction, "AccruedExpenses", amount);
                            }
                            else
                            {
                                // Update cash balance in balance sheet
                                UpdateBalanceSheet(conn, transaction, "Cash", -amount);
                            }

                            // Save transaction details
                            SaveTransaction(conn, transaction, expenseId, amount, isCashExpense, description);

                            transaction.Commit();
                            MessageBox.Show("Expense transaction recorded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear input fields
                            ClearInputFields();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Error recording expense transaction: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int SaveExpenseTransaction(SqlConnection conn, SqlTransaction transaction, DateTime expenseDate, decimal amount, bool isCashExpense, string expenseType, string description)
        {
            string query = "INSERT INTO Expenses (Date, Amount, ExpenseType) OUTPUT INSERTED.ExpenseID VALUES (@expenseDate, @amount, @expenseType)";

            using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@expenseDate", expenseDate);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@expenseType", expenseType);

                return (int)cmd.ExecuteScalar();
            }
        }

        private void UpdateBalanceSheet(SqlConnection conn, SqlTransaction transaction, string column, decimal amount)
        {
            string query = $"INSERT INTO BalanceSheet ({column}) VALUES (@amount)";

            using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.ExecuteNonQuery();
            }
        }

        private void SaveTransaction(SqlConnection conn, SqlTransaction transaction, int expenseId, decimal amount, bool isCashExpense, string description)
        {
            string query = "INSERT INTO Transactions (Date, Amount, Nature, TransactionType, Description) VALUES (@date, @amount, @nature, @transactionType, @description)";

            using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@nature", isCashExpense ? "Cash" : "Accrued");
                cmd.Parameters.AddWithValue("@transactionType", "Expense");
                cmd.Parameters.AddWithValue("@description", description);
                cmd.ExecuteNonQuery();
            }
        }

        private void ClearInputFields()
        {
            txtExpenseAmount.Clear();
            comboExpenseType.SelectedIndex = -1;
            txtDescription.Clear();
            rbtnCashExpense.Checked = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }
    }
}
