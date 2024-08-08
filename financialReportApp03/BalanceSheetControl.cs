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
    public partial class BalanceSheetControl : UserControl
    {
        string connString = @"Server=DESKTOP-UFU2OV3\SQLEXPRESS;Initial Catalog=DBFinRep;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public BalanceSheetControl()
        {
            InitializeComponent();
        }

        private void btnBalanceSheetGenerate_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dateFromBS.Value.Date;
            DateTime toDate = dateToBS.Value.Date;

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // Calculate Equity (Equity + Retained Earnings until fromDate)
                    decimal equity = CalculateEquity(conn, fromDate);
                    lblEquity.Text = equity.ToString("C");

                    // Calculate Retained Earnings (from profit_loss table)
                    decimal retainedEarnings = CalculateRetainedEarnings(conn, fromDate, toDate);
                    lblRetainedEarnings.Text = retainedEarnings.ToString("C");

                    // Fetch other balance sheet items from database
                    FetchBalanceSheetItems(conn, fromDate, toDate);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching balance sheet data: {ex.Message}");
            }
        }

        private decimal CalculateEquity(SqlConnection conn, DateTime fromDate)
        {
            decimal equity = 0;

            // Calculate Equity: Equity + Retained Earnings until fromDate
            string query = "SELECT SUM(equity) + SUM(retained_earnings) AS total FROM balance_sheet WHERE date <= @fromDate";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@fromDate", fromDate);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    equity = Convert.ToDecimal(result);
                }
            }
            return equity;
        }

        private decimal CalculateRetainedEarnings(SqlConnection conn, DateTime fromDate, DateTime toDate)
        {
            decimal retainedEarnings = 0;

            // Calculate Retained Earnings from profit_loss table for the selected date range
            string query = "SELECT SUM(profit_or_loss) AS total FROM profit_loss WHERE date BETWEEN @fromDate AND @toDate";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@fromDate", fromDate);
                cmd.Parameters.AddWithValue("@toDate", toDate);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    retainedEarnings = Convert.ToDecimal(result);
                }
            }
            return retainedEarnings;
        }

        private void FetchBalanceSheetItems(SqlConnection conn, DateTime fromDate, DateTime toDate)
        {
            // Fetch other balance sheet items from database
            string query = "SELECT loan, other_liabilities, creditors, accrued_expenses, land, furniture, building, investment, cash, debtors, inventory, prepaid_expenses, accrued_income FROM balance_sheet WHERE date BETWEEN @fromDate AND @toDate";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@fromDate", fromDate);
                cmd.Parameters.AddWithValue("@toDate", toDate);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lblLoan.Text = reader["loan"].ToString();
                        lblOtherLiabilities.Text = reader["other_liabilities"].ToString();
                        lblCreditors.Text = reader["creditors"].ToString();
                        lblAccruedExpenses.Text = reader["accrued_expenses"].ToString();
                        lblLand.Text = reader["land"].ToString();
                        lblFurniture.Text = reader["furniture"].ToString();
                        lblBuilding.Text = reader["building"].ToString();
                        lblInvestment.Text = reader["investment"].ToString();
                        lblCash.Text = reader["cash"].ToString();
                        lblDebtors.Text = reader["debtors"].ToString();
                        lblInventory.Text = reader["inventory"].ToString();
                        lblAccruedIncome.Text = reader["accrued_income"].ToString();

                        int equity = int.Parse(lblEquity.Text, System.Globalization.NumberStyles.Currency);
                        int loan = int.Parse(lblLoan.Text);
                        int otherLiabilities = int.Parse(lblOtherLiabilities.Text);
                        int creditors = int.Parse(lblCreditors.Text);
                        int accruedExpenses = int.Parse(lblAccruedExpenses.Text);
                        int land = int.Parse(lblLand.Text);
                        int furniture = int.Parse(lblFurniture.Text);
                        int building = int.Parse(lblBuilding.Text);
                        int investment = int.Parse(lblInvestment.Text);
                        int cash = int.Parse(lblCash.Text);
                        int debtors = int.Parse(lblDebtors.Text);
                        int inventory = int.Parse(lblInventory.Text);
                        int accruedIncome = int.Parse(lblAccruedIncome.Text);

                        int balance1 = equity + loan + otherLiabilities + creditors + accruedExpenses;
                        int balance2 = land + furniture + building + investment + cash + debtors + inventory  + accruedIncome;

                        totalBalance1.Text = balance1.ToString("C");
                        totalBalance2.Text = balance2.ToString("C");
                    }
                }
            }
        }
    }
}