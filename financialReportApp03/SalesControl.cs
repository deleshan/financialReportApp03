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
    public partial class SalesControl : UserControl
    {
        private string connString = @"Server=DESKTOP-UFU2OV3\SQLEXPRESS;Initial Catalog=DBFinRep;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public SalesControl()
        {
            InitializeComponent();
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime saleDate = dtpSaleDate.Value;
                decimal amount = decimal.Parse(txtTotalSale.Text);
                bool cashSale = rbtnCashSale.Checked;
                string debtorName = txtDebtorName.Text;
                string debtorAddress = txtDebtorAddress.Text;
                string debtorPhone = txtDebtorPhone.Text;

                if (amount <= 0)
                {
                    MessageBox.Show("Total amount must be greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!cashSale && (string.IsNullOrEmpty(debtorName) || string.IsNullOrEmpty(debtorAddress) || string.IsNullOrEmpty(debtorPhone)))
                {
                    MessageBox.Show("Debtor details are required for credit sales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Calculate total profit and cost of sales
                decimal totalProfit = CalculateTotalProfit();
                decimal costOfSales = CalculateCostOfSales();

                int saleId = SaveSalesTransaction(saleDate, amount, cashSale, totalProfit);

                if (!cashSale)
                {
                    SaveDebtorDetails(debtorName, debtorAddress, debtorPhone, amount);
                    UpdateBalanceSheet("Debtors", amount, false);
                    UpdateBalanceSheet("Inventory", costOfSales, true);
                }
                else
                {
                    UpdateBalanceSheet("Cash", amount, false);
                    UpdateBalanceSheet("Inventory", costOfSales, true);
                }

                SaveTransaction(saleDate, saleId, amount, cashSale ? "cash" : "credit");
                UpdateInventory(saleDate);

                MessageBox.Show("Sales transaction recorded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal CalculateTotalProfit()
        {
            decimal totalProfit = 0;

            foreach (DataGridViewRow row in dgvSaleProducts.Rows)
            {
                if (row.Cells["Description"].Value != null)
                {
                    int quantity = int.Parse(row.Cells["Quantity"].Value.ToString());
                    decimal costPrice = decimal.Parse(row.Cells["CostPrice"].Value.ToString());
                    decimal sellingPrice = decimal.Parse(row.Cells["SellingPrice"].Value.ToString());
                    decimal profitPer = sellingPrice - costPrice;
                    totalProfit += quantity * profitPer;
                }
            }

            return totalProfit;
        }

        private decimal CalculateCostOfSales()
        {
            decimal costOfSales = 0;

            foreach (DataGridViewRow row in dgvSaleProducts.Rows)
            {
                if (row.Cells["Description"].Value != null)
                {
                    int quantity = int.Parse(row.Cells["Quantity"].Value.ToString());
                    decimal costPrice = decimal.Parse(row.Cells["CostPrice"].Value.ToString());
                    costOfSales += quantity * costPrice;
                }
            }

            return costOfSales;
        }

        private int SaveSalesTransaction(DateTime saleDate, decimal totalAmount, bool isCashSale, decimal totalProfit)
        {
            try
            {
                string nature = isCashSale ? "cash" : "credit";
                string query = "INSERT INTO Sales (Date, Amount, Nature, TotalProfit) VALUES (@Date, @totalAmount, @nature, @totalProfit); SELECT SCOPE_IDENTITY();";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Date", saleDate);
                    cmd.Parameters.AddWithValue("@totalAmount", totalAmount);
                    cmd.Parameters.AddWithValue("@nature", nature);
                    cmd.Parameters.AddWithValue("@totalProfit", totalProfit);
                    int saleId = Convert.ToInt32(cmd.ExecuteScalar());
                    return saleId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving sales transaction: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Return a failure indicator
            }
        }

        private void SaveDebtorDetails(string debtorName, string debtorAddress, string debtorPhone, decimal totalAmount)
        {
            try
            {
                string query = "INSERT INTO Debtors (DebtorName, Address, Phone, Amount) VALUES (@debtorName, @debtorAddress, @debtorPhone, @amountDue)";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@debtorName", debtorName);
                    cmd.Parameters.AddWithValue("@debtorAddress", debtorAddress);
                    cmd.Parameters.AddWithValue("@debtorPhone", debtorPhone);
                    cmd.Parameters.AddWithValue("@amountDue", totalAmount);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving debtor details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void SaveTransaction(DateTime saleDate, int saleId, decimal totalAmount, string nature)
        {
            try
            {
                string query = "INSERT INTO Transactions (Date, Amount, Nature, TransactionType) VALUES (@Date, @amount, @nature, @transactionType)";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Date", saleDate);
                    cmd.Parameters.AddWithValue("@amount", totalAmount);
                    cmd.Parameters.AddWithValue("@nature", nature);
                    cmd.Parameters.AddWithValue("@transactionType", "sale");
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving transaction: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateInventory(DateTime saleDate)
        {
            try
            {
                string insertQuery = "INSERT INTO Inventory ( Date, ItemName, Quantity, CostPrice, SellingPrice, ProfitPer, TotalProfit) VALUES (@date, @itemName, @quantity, @costPrice, @sellingPrice, @profitPer, @totalProfit)";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    foreach (DataGridViewRow row in dgvSaleProducts.Rows)
                    {
                        if (row.Cells["Description"].Value != null)
                        {
                            string itemName = row.Cells["Description"].Value.ToString();
                            int quantity = int.Parse(row.Cells["Quantity"].Value.ToString());
                            decimal costPrice = decimal.Parse(row.Cells["CostPrice"].Value.ToString());
                            decimal sellingPrice = decimal.Parse(row.Cells["SellingPrice"].Value.ToString());
                            decimal profitPer = sellingPrice - costPrice;
                            decimal totalProfit = quantity * profitPer;

                            SqlCommand cmd = new SqlCommand(insertQuery, conn);
                            cmd.Parameters.AddWithValue("@date", saleDate);
                            cmd.Parameters.AddWithValue("@itemName", itemName);
                            cmd.Parameters.AddWithValue("@quantity", -quantity); // Decrease inventory quantity
                            cmd.Parameters.AddWithValue("@costPrice", -costPrice); // Negative cost for sale
                            cmd.Parameters.AddWithValue("@sellingPrice", sellingPrice);
                            cmd.Parameters.AddWithValue("@profitPer", profitPer);
                            cmd.Parameters.AddWithValue("@totalProfit", totalProfit);
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
            txtTotalSale.Clear();
            txtDebtorName.Clear();
            txtDebtorAddress.Clear();
            txtDebtorPhone.Clear();
            dgvSaleProducts.Rows.Clear();
        }

        private void rbtnCashSale_CheckedChanged(object sender, EventArgs e)
        {
            debtorGroupBox.Visible = !rbtnCashSale.Checked;
        }

        private void rbtnCreditSale_CheckedChanged(object sender, EventArgs e)
        {
            debtorGroupBox.Visible = rbtnCreditSale.Checked;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }
    }
}


