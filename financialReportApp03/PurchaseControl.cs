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
    public partial class PurchaseControl : UserControl
    {
        private string connString = @"Server=DESKTOP-UFU2OV3\SQLEXPRESS;Initial Catalog=DBFinRep;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public PurchaseControl()
        {
            InitializeComponent();
            groupBoxCreditors.Visible = false;
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            DateTime purchaseDate = dtpPurchaseDate.Value;
            decimal totalAmount = decimal.Parse(txtTotalPurchase.Text);
            bool isCashPurchase = rbtnCashPurchase.Checked;
            string creditorName = txtCreditorName.Text.Trim();
            string creditorAddress = txtCreditorAddress.Text.Trim();
            string creditorPhone = txtCreditorPhone.Text.Trim();

            // Validate input fields
            if (totalAmount <= 0)
            {
                MessageBox.Show("Total amount must be greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!isCashPurchase && (string.IsNullOrEmpty(creditorName) || string.IsNullOrEmpty(creditorAddress) || string.IsNullOrEmpty(creditorPhone)))
            {
                MessageBox.Show("Creditor details are required for credit purchases.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save purchase transaction
            int purchaseId = SavePurchaseTransaction(purchaseDate, totalAmount, isCashPurchase);

            if (!isCashPurchase)
            {
                // Save creditor details
                SaveCreditorDetails(creditorName, creditorAddress, creditorPhone, totalAmount);

                // Update creditors balance in balance sheet
                UpdateBalanceSheet("Creditors", totalAmount, false);
                UpdateBalanceSheet("Inventory", totalAmount, false);
            }
            else
            {
                // Update cash balance in balance sheet
                UpdateBalanceSheet("Cash", totalAmount, true);
                UpdateBalanceSheet("Inventory", totalAmount, false);
            }

            // Save transaction details
            SaveTransaction(purchaseDate, purchaseId, totalAmount, isCashPurchase);

            // Update inventory quantities
            UpdateInventory();

            MessageBox.Show("Purchase transaction recorded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear input fields
            ClearInputFields();
        }

        private int SavePurchaseTransaction(DateTime purchaseDate, decimal totalAmount, bool isCashPurchase)
        {
            try
            {
                string query = "INSERT INTO Purchases (Date, Amount, Nature) VALUES (@purchaseDate, @totalAmount, @nature); SELECT SCOPE_IDENTITY();";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@purchaseDate", purchaseDate);
                    cmd.Parameters.AddWithValue("@totalAmount", totalAmount);
                    cmd.Parameters.AddWithValue("@nature", isCashPurchase ? "cash" : "credit");
                    int purchaseId = Convert.ToInt32(cmd.ExecuteScalar());
                    return purchaseId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving purchase transaction: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Return a failure indicator
            }
        }

        private void SaveCreditorDetails(string creditorName, string creditorAddress, string creditorPhone, decimal totalAmount)
        {
            try
            {
                string query = "INSERT INTO Creditors (CreditorName, Address, Phone, Balance) VALUES (@creditorName, @creditorAddress, @creditorPhone, @amountDue)";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@creditorName", creditorName);
                    cmd.Parameters.AddWithValue("@creditorAddress", creditorAddress);
                    cmd.Parameters.AddWithValue("@creditorPhone", creditorPhone);
                    cmd.Parameters.AddWithValue("@amountDue", totalAmount);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving creditor details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateBalanceSheet(string account, decimal amount, bool isSubtraction)
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

        private void SaveTransaction(DateTime purchaseDate, int purchaseId, decimal totalAmount, bool isCashPurchase)
        {
            try
            {
                string query = "INSERT INTO Transactions (Date, Amount, Nature, TransactionType, Description) VALUES (@purchaseDate, @amount, @nature, @transactionType, @description)";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@purchaseDate", purchaseDate);
                    cmd.Parameters.AddWithValue("@amount", totalAmount);
                    cmd.Parameters.AddWithValue("@nature", isCashPurchase ? "cash" : "credit");
                    cmd.Parameters.AddWithValue("@transactionType", "Purchase");
                    cmd.Parameters.AddWithValue("@description", isCashPurchase ? "Cash purchase" : "Credit purchase");
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving transaction: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateInventory()
        {
            try
            {
                string insertQuery = "INSERT INTO Inventory (ItemName, Quantity, CostPrice, SellingPrice) VALUES (@itemName, @quantity, @costPrice, @sellingPrice)";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    foreach (DataGridViewRow row in dgvPurchaseProducts.Rows)
                    {
                        if (row.Cells["Description"].Value != null)
                        {
                            string itemName = row.Cells["Description"].Value.ToString();
                            int quantity = int.Parse(row.Cells["Quantity"].Value.ToString());
                            decimal costPrice = decimal.Parse(row.Cells["CostPrice"].Value.ToString());
                            decimal sellingPrice = decimal.Parse(row.Cells["SellingPrice"].Value.ToString());

                            SqlCommand cmd = new SqlCommand(insertQuery, conn);
                            cmd.Parameters.AddWithValue("@itemName", itemName);
                            cmd.Parameters.AddWithValue("@quantity", quantity);
                            cmd.Parameters.AddWithValue("@costPrice", costPrice);
                            cmd.Parameters.AddWithValue("@sellingPrice", sellingPrice);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating inventory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputFields()
        {
            txtTotalPurchase.Clear();
            txtCreditorName.Clear();
            txtCreditorAddress.Clear();
            txtCreditorPhone.Clear();
            dgvPurchaseProducts.Rows.Clear();
        }

        private void rbtnCashPurchase_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxCreditors.Visible = !rbtnCashPurchase.Checked;
        }

        private void rbtnCreditPurchase_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxCreditors.Visible = rbtnCreditPurchase.Checked;
        }
    }
}







