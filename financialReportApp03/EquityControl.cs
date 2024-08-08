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
    public partial class EquityControl : UserControl
    {
        string connString = @"Server=DESKTOP-UFU2OV3\SQLEXPRESS;Initial Catalog=DBFinRep;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public EquityControl()
        {
            InitializeComponent();
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            DateTime date = dateEquity.Value;
            decimal amount = decimal.Parse(txtEquityAmount.Text);
            string nature = rbtnBorrowingEquity.Checked ? "Borrowing" : "Invest";
            string type = cmbEquityType.SelectedItem.ToString();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Update balance_sheet table
                        decimal equityChange = nature == "Borrowing" ? -amount : amount;
                        decimal typeChange = equityChange;

                        UpdateBalanceSheet(conn, "Equity", equityChange, transaction);

                        switch (type)
                        {
                            case "Cash":
                                UpdateBalanceSheet(conn, "Cash", typeChange, transaction);
                                break;
                            case "Building":
                                UpdateBalanceSheet(conn, "Building", typeChange, transaction);
                                break;
                            case "Land":
                                UpdateBalanceSheet(conn, "Land", typeChange, transaction);
                                break;
                            case "Inventory":
                                UpdateBalanceSheet(conn, "Inventory", typeChange, transaction);
                                UpdateInventory(conn, typeChange, transaction);
                                break;
                            case "Furniture":
                                UpdateBalanceSheet(conn, "Furniture", typeChange, transaction);
                                break;
                        }

                        // Insert into transactions table
                        string query = "INSERT INTO Transactions (Date, Amount, Nature, TransactionType, Description) VALUES (@date, @amount, @type, @nature, @description)";
                        SqlCommand cmd = new SqlCommand(query, conn, transaction);
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@amount", amount);
                        cmd.Parameters.AddWithValue("@nature", nature);
                        cmd.Parameters.AddWithValue("@type", type);
                        cmd.Parameters.AddWithValue("@description", type);
                        cmd.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Equity transaction recorded successfully.");
                        ClearInputFields();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error recording equity transaction: " + ex.Message);
                    }
                }
            }
        }

        private void UpdateBalanceSheet(SqlConnection conn, string columnName, decimal amount, SqlTransaction transaction)
        {
            string query = $"INSERT INTO BalanceSheet (Date, {columnName}) VALUES (@date, @amount)";
            SqlCommand cmd = new SqlCommand(query, conn, transaction);
            cmd.Parameters.AddWithValue("@date", DateTime.Now);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.ExecuteNonQuery();
        }

        private void UpdateInventory(SqlConnection conn, decimal amount, SqlTransaction transaction)
        {
            foreach (DataGridViewRow row in dgvEquity.Rows)
            {
                if (row.IsNewRow) continue;

                string itemName = row.Cells["Description"].Value.ToString();
                int quantity = int.Parse(row.Cells["Quantity"].Value.ToString());
                decimal costPrice = decimal.Parse(row.Cells["CostPrice"].Value.ToString());
                decimal sellingPrice = decimal.Parse(row.Cells["SellingPrice"].Value.ToString());

                string query = "INSERT INTO Inventory (ItemName, Quantity, CostPrice, SellingPrice) " +
                               "VALUES (@itemName, @quantity, @costPrice, @sellingPrice)";

                SqlCommand cmd = new SqlCommand(query, conn, transaction);
                cmd.Parameters.AddWithValue("@itemName", itemName);
                cmd.Parameters.AddWithValue("@quantity", -quantity);
                cmd.Parameters.AddWithValue("@costPrice", -costPrice);
                cmd.Parameters.AddWithValue("@sellingPrice", -sellingPrice);
                
                cmd.ExecuteNonQuery();
            }
        }
        private void ClearInputFields()
        {
            txtEquityAmount.Clear();
            cmbEquityType.SelectedIndex = -1;
            dgvEquity.Rows.Clear();
        
        
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }
    }
}

