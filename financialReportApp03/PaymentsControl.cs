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
    public partial class PaymentsControl : UserControl
    {
        private string connString = @"Server=localhost\SQLEXPRESS;Database=DBFinRep;Trusted_Connection=True;";

        public PaymentsControl()
        {
            InitializeComponent();
            InitializePaymentControl();

            radioReceived.CheckedChanged += new EventHandler(radioReceived_CheckedChanged_1);
            radioPaid.CheckedChanged += new EventHandler(radioPaid_CheckedChanged_1);
            comboReceivedType.SelectedIndexChanged += new EventHandler(comboReceivedType_SelectedIndexChanged_1);
            comboPaidType.SelectedIndexChanged += new EventHandler(comboPaidType_SelectedIndexChanged_1);
        }

        private void InitializePaymentControl()
        {
            // Initially disable combo boxes
            comboReceivedType.Enabled = false;
            comboPaidType.Enabled = false;

            // Initially hide group boxes
            gbDebtors.Visible = false;
            gbLoan.Visible = false;
            gbCreditors.Visible = false;
        }

        private void radioReceived_CheckedChanged_1(object sender, EventArgs e)
        {
            comboReceivedType.Enabled = true;
            comboPaidType.Enabled = false;
            comboPaidType.SelectedIndex = -1;
            gbDebtors.Visible = false;
            gbLoan.Visible = false;
            gbCreditors.Visible = false;
        }

        private void radioPaid_CheckedChanged_1(object sender, EventArgs e)
        {
            comboReceivedType.Enabled = !radioPaid.Checked;
            comboPaidType.Enabled = radioPaid.Checked;
            gbDebtors.Visible = false;
            gbLoan.Visible = false;
            gbCreditors.Visible = false;
        }

        private void comboReceivedType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboReceivedType.SelectedItem?.ToString() == "Debtors")
            {
                gbDebtors.Visible = true;
            }
            else
            {
                gbDebtors.Visible = false;
            }
        }

        private void comboPaidType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboPaidType.SelectedItem?.ToString() == "Loan")
            {
                gbLoan.Visible = true;
                gbCreditors.Visible = false;
            }
            else if (comboPaidType.SelectedItem?.ToString() == "Creditors")
            {
                gbCreditors.Visible = true;
                gbLoan.Visible = false;
            }
            else
            {
                gbLoan.Visible = false;
                gbCreditors.Visible = false;
            }
        }

        private void buttonPayments_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime paymentDate = dtpDate.Value;
                if (!decimal.TryParse(txtAmount.Text, out decimal amount))
                {
                    MessageBox.Show("Invalid amount format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            string query;
                            SqlCommand cmd;

                            if (radioReceived.Checked)
                            {
                                string receivedType = comboReceivedType.SelectedItem?.ToString();

                                if (receivedType == "Debtors")
                                {
                                    string debtorName = txtDebtorName.Text.Trim();

                                    query = "SELECT COUNT(*) FROM Debtors WHERE DebtorName = @name";
                                    cmd = new SqlCommand(query, conn, transaction);
                                    cmd.Parameters.AddWithValue("@name", debtorName);
                                    int debtorCount = (int)cmd.ExecuteScalar();

                                    if (debtorCount > 0)
                                    {
                                        query = "UPDATE Debtors SET Amount = Amount + @amount WHERE DebtorName = @name";
                                        cmd = new SqlCommand(query, conn, transaction);
                                        cmd.Parameters.AddWithValue("@name", debtorName);
                                        cmd.Parameters.AddWithValue("@amount", -amount);
                                        cmd.ExecuteNonQuery();

                                        InsertBalanceSheetEntry("Debtors", amount, true);
                                        InsertBalanceSheetEntry("Cash", amount, false);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Debtor not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        transaction.Rollback();
                                        return;
                                    }
                                }
                                else if (receivedType == "Accrued Income")
                                {
                                    InsertBalanceSheetEntry("AccruedIncome", amount, true);
                                    InsertBalanceSheetEntry("Cash", amount, false);
                                }
                            }
                            else if (radioPaid.Checked)
                            {
                                string paidType = comboPaidType.SelectedItem?.ToString();

                                if (paidType == "Loan")
                                {
                                    string organizationName = txtOrgName.Text.Trim();

                                    query = "SELECT COUNT(*) FROM FinancialActivity WHERE OrganizationName = @name AND Nature = 'Loan'";
                                    cmd = new SqlCommand(query, conn, transaction);
                                    cmd.Parameters.AddWithValue("@name", organizationName);
                                    int loanCount = (int)cmd.ExecuteScalar();

                                    if (loanCount > 0)
                                    {
                                        query = "UPDATE FinancialActivity SET Amount = Amount + @amount WHERE OrganizationName = @name AND Nature = 'Loan'";
                                        cmd = new SqlCommand(query, conn, transaction);
                                        cmd.Parameters.AddWithValue("@name", organizationName);
                                        cmd.Parameters.AddWithValue("@amount", -amount);
                                        cmd.ExecuteNonQuery();

                                        InsertBalanceSheetEntry("Loan", amount, true);
                                        InsertBalanceSheetEntry("Cash", amount, true);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Loan organization not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        transaction.Rollback();
                                        return;
                                    }
                                }
                                else if (paidType == "Other Liabilities")
                                {
                                    InsertBalanceSheetEntry("OtherLiabilities", amount, true);
                                    InsertBalanceSheetEntry("Cash", amount, true);
                                }
                                else if (paidType == "Accrued Expense")
                                {
                                    InsertBalanceSheetEntry("AccruedExpenses", amount, true);
                                    InsertBalanceSheetEntry("Cash", amount, true);
                                }
                                else if (paidType == "Creditors")
                                {
                                    string creditorName = txtCreditorName.Text.Trim();

                                    query = "SELECT COUNT(*) FROM Creditors WHERE CreditorName = @name";
                                    cmd = new SqlCommand(query, conn, transaction);
                                    cmd.Parameters.AddWithValue("@name", creditorName);
                                    int creditorCount = (int)cmd.ExecuteScalar();

                                    if (creditorCount > 0)
                                    {
                                        query = "UPDATE Creditors SET Balance = Balance - @amount WHERE CreditorName = @name";
                                        cmd = new SqlCommand(query, conn, transaction);
                                        cmd.Parameters.AddWithValue("@name", creditorName);
                                        cmd.Parameters.AddWithValue("@amount", -amount);
                                        cmd.ExecuteNonQuery();

                                        InsertBalanceSheetEntry("Creditors", amount, true);
                                        InsertBalanceSheetEntry("Cash", amount, true);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Creditor not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        transaction.Rollback();
                                        return;
                                    }
                                }
                            }

                            // Insert into Transactions table
                            query = "INSERT INTO Transactions (Date, Amount, Nature, TransactionType) VALUES (@date, @amount, @nature, @type)";
                            cmd = new SqlCommand(query, conn, transaction);
                            cmd.Parameters.AddWithValue("@date", paymentDate);
                            cmd.Parameters.AddWithValue("@amount", amount);
                            cmd.Parameters.AddWithValue("@nature", radioReceived.Checked ? "Received" : "Paid");
                            cmd.Parameters.AddWithValue("@type", radioReceived.Checked ? comboReceivedType.SelectedItem.ToString() : comboPaidType.SelectedItem.ToString());
                            cmd.ExecuteNonQuery();

                            transaction.Commit();
                            MessageBox.Show("Transaction recorded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear input fields
                            ClearInputFields();
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
                            MessageBox.Show("Error recording transaction: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (FormatException formatEx)
            {
                MessageBox.Show("Invalid format: " + formatEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertBalanceSheetEntry(string account, decimal amount, bool isSubtraction)
        {
            try
            {
                string query = $"INSERT INTO BalanceSheet (Date, {account}) VALUES (@date, @amount)";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@amount", isSubtraction ? -amount : amount);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating balance sheet: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputFields()
        {
            txtDebtorName.Clear();
            txtOrgName.Clear();
            txtCreditorName.Clear();
            txtAmount.Clear();
            comboReceivedType.SelectedIndex = -1;
            comboPaidType.SelectedIndex = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }
    }
}













