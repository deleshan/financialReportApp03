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
    public partial class FinActControl : UserControl
    {
        public FinActControl()
        {
            InitializeComponent();
            // Attach event handlers for radio buttons
            rbtnInvestmentFA.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            rbtnCreditFA.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCreditFA.Checked)
            {
                cmbTypeFA.Enabled = true;
            }
            else
            {
                cmbTypeFA.Enabled = false;
                cmbTypeFA.SelectedIndex = -1; // Clear the selection
            }
        }

        private void buttonFinAct_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = dateFA.Value;
                if (!decimal.TryParse(txtAmountFA.Text, out decimal amount))
                {
                    MessageBox.Show("Invalid amount format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string nature = rbtnInvestmentFA.Checked ? "Investment" : "Credit/Loan";
                string orgName = txtOrgNameFA.Text;
                string orgAddress = txtOrgAddressFA.Text;
                string orgPhone = txtOrgPhoneFA.Text;
                string type = cmbTypeFA.SelectedItem?.ToString();
                decimal interest = string.IsNullOrEmpty(txtInterestFA.Text) ? 0 : decimal.Parse(txtInterestFA.Text);

                string connString = @"Server=localhost\SQLEXPRESS;Database=DBFinRep;Trusted_Connection=True;";
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Insert into FinancialActivity table
                            string query = "INSERT INTO FinancialActivity (Date, Amount, Nature, Interest, OrganizationName, Address, PhoneNo) " +
                                           "VALUES (@date, @amount, @nature, @interest, @orgName, @orgAddress, @orgPhone)";
                            SqlCommand cmd = new SqlCommand(query, conn, transaction);
                            cmd.Parameters.AddWithValue("@date", date);
                            cmd.Parameters.AddWithValue("@amount", amount);
                            cmd.Parameters.AddWithValue("@nature", nature);
                            cmd.Parameters.AddWithValue("@interest", interest);
                            cmd.Parameters.AddWithValue("@orgName", orgName);
                            cmd.Parameters.AddWithValue("@orgAddress", orgAddress);
                            cmd.Parameters.AddWithValue("@orgPhone", orgPhone);
                            cmd.ExecuteNonQuery();

                            // Insert into BalanceSheet table
                            InsertBalanceSheet(conn, date, amount, nature, type, transaction);

                            // Insert into Transactions table
                            query = "INSERT INTO Transactions (Date, Amount, Nature, TransactionType) VALUES (@date, @amount, @nature, @type)";
                            cmd = new SqlCommand(query, conn, transaction);
                            cmd.Parameters.AddWithValue("@date", date);
                            cmd.Parameters.AddWithValue("@amount", amount);
                            cmd.Parameters.AddWithValue("@nature", nature);
                            cmd.Parameters.AddWithValue("@type", type ?? (object)DBNull.Value);
                            cmd.ExecuteNonQuery();

                            transaction.Commit();
                            MessageBox.Show("Financial activity recorded successfully.");
                        }
                        catch (SqlException sqlEx)
                        {
                            transaction.Rollback();
                            MessageBox.Show("SQL error occurred: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (InvalidOperationException invalidOpEx)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Invalid operation: " + invalidOpEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Error recording financial activity: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (FormatException formatEx)
            {
                MessageBox.Show("Input format error: " + formatEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertBalanceSheet(SqlConnection conn, DateTime date, decimal amount, string nature, string type, SqlTransaction transaction)
        {
            try
            {
                // Create a new record in the BalanceSheet table with the amounts adjusted based on the transaction nature and type
                string query = "INSERT INTO BalanceSheet (Date, Loan, OtherLiabilities, Investment, Cash) " +
                               "VALUES (@date, @loan, @otherLiabilities, @investment, @cash)";
                SqlCommand cmd = new SqlCommand(query, conn, transaction);

                decimal loan = 0, otherLiabilities = 0, investment = 0, cash = 0;

                if (nature == "Credit/Loan")
                {
                    if (type == "Loan")
                    {
                        loan = amount;
                        cash = amount;
                    }
                    else if (type == "Other liabilities")
                    {
                        otherLiabilities = amount;
                        cash = amount;
                    }
                }
                else if (nature == "Investment")
                {
                    investment = amount;
                    cash = -amount;
                }

                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@loan", loan);
                cmd.Parameters.AddWithValue("@otherLiabilities", otherLiabilities);
                cmd.Parameters.AddWithValue("@investment", investment);
                cmd.Parameters.AddWithValue("@cash", cash);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlEx)
            {
                throw new ApplicationException("Error inserting into balance sheet: " + sqlEx.Message);
            }
        }
        private void ClearInputFields()
        {
            txtAmountFA.Clear();
            txtOrgNameFA.Clear();
            txtOrgAddressFA.Clear();
            txtOrgPhoneFA.Clear();
            txtInterestFA.Clear();
            cmbTypeFA.SelectedIndex = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        
    }
}



