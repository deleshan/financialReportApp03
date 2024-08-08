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
    public partial class ProfitOrLossControl : UserControl
    {
        private decimal netIncomeAfterTax; // Class-level variable to store net income after tax

        public ProfitOrLossControl()
        {
            InitializeComponent();
        }

        private void buttonGenaratePOL_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateFromPOL.Value;
            DateTime endDate = dateToPOL.Value;

            string connString = @"Server=localhost\SQLEXPRESS;Database=DBFinRep;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    // Generate Profit or Loss Report
                    GenerateProfitOrLossReport(conn, startDate, endDate);

                    // Generate Balance Sheet
                    GenerateBalanceSheet(conn, endDate);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating reports: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GenerateProfitOrLossReport(SqlConnection conn, DateTime startDate, DateTime endDate)
        {
            // Sales
            lblSales.Text = GetTotalAmount(conn, "Sales", "Amount", startDate, endDate).ToString("N");

            // Gross Profit
            decimal grossProfit = GetTotalAmount(conn, "Sales", "TotalProfit", startDate, endDate);
            lblTotalProfitOfSales.Text = grossProfit.ToString("N");

            // Cost of Sales
            decimal salesAmount = GetTotalAmount(conn, "Sales", "Amount", startDate, endDate);
            decimal costOfSales = salesAmount - grossProfit;
            lblCostOfSales.Text = costOfSales.ToString("N");

            // Expenses
            lblMarketing.Text = GetExpenseTotal(conn, "Marketing", startDate, endDate).ToString("N");
            lblSalary.Text = GetExpenseTotal(conn, "Salaries/wages", startDate, endDate).ToString("N");
            lblOtherTax.Text = GetExpenseTotal(conn, "Other Tax", startDate, endDate).ToString("N");
            lblAdministration.Text = GetExpenseTotal(conn, "Administration M/R", startDate, endDate).ToString("N");
            lblRent.Text = GetExpenseTotal(conn, "Rent", startDate, endDate).ToString("N");
            lblUtilities.Text = GetExpenseTotal(conn, "Utilities", startDate, endDate).ToString("N");
            lblInsurance.Text = GetExpenseTotal(conn, "Insurance", startDate, endDate).ToString("N");
            lblBankFees.Text = GetExpenseTotal(conn, "Bank fees and Interst", startDate, endDate).ToString("N");
            lblOtherExpense.Text = GetExpenseTotal(conn, "Other Expense", startDate, endDate).ToString("N");

            // Total Expense
            decimal totalExpense = GetTotalExpenses(conn, startDate, endDate);
            lblTotalExpense.Text = totalExpense.ToString("N");

            // Operating Income
            decimal operatingIncome = grossProfit - totalExpense;
            lblTotalIncome.Text = operatingIncome.ToString("N");

            // Non-operating Income
            decimal nonOperatingIncome = GetTotalAmount(conn, "OtherIncome", "Amount", startDate, endDate);
            lblNonOperatingIncome.Text = nonOperatingIncome.ToString("N");

            // Total Income before Tax
            decimal totalIncomeBeforeTax = operatingIncome + nonOperatingIncome;
            lblNetIncomeBeforeTax.Text = totalIncomeBeforeTax.ToString("N");

            // Tax
            decimal tax = 0;
            if(totalIncomeBeforeTax >= 500000)
            {
                 tax = (totalIncomeBeforeTax / 100) * 6;
                 lblTax.Text = tax.ToString("N");
            }
            else {
                lblTax.Text = tax.ToString("N");
            }
            // Net Income after Tax
            netIncomeAfterTax = totalIncomeBeforeTax - tax;
            lblNetIncome.Text = netIncomeAfterTax.ToString("N");

            // Retained Earnings
            lblRetainedEarnings.Text = netIncomeAfterTax.ToString("N");
        }

        private void GenerateBalanceSheet(SqlConnection conn, DateTime endDate)
        {
            lblEquity.Text = GetTotalAmountUntilDate(conn, "BalanceSheet", "Equity", endDate).ToString("N");
            lblRetainedEarningsBS.Text = netIncomeAfterTax.ToString("N");
            lblLoan.Text = GetTotalAmountUntilDate(conn, "BalanceSheet", "Loan", endDate).ToString("N");
            lblOtherLiabilities.Text = GetTotalAmountUntilDate(conn, "BalanceSheet", "OtherLiabilities", endDate).ToString("N");
            lblCreditors.Text = GetTotalAmountUntilDate(conn, "BalanceSheet", "Creditors", endDate).ToString("N");
            lblAccruedExpenses.Text = GetTotalAmountUntilDate(conn, "BalanceSheet", "AccruedExpenses", endDate).ToString("N");
            lblLand.Text = GetTotalAmountUntilDate(conn, "BalanceSheet", "Land", endDate).ToString("N");
            lblFurniture.Text = GetTotalAmountUntilDate(conn, "BalanceSheet", "Furniture", endDate).ToString("N");
            lblBuilding.Text = GetTotalAmountUntilDate(conn, "BalanceSheet", "Building", endDate).ToString("N");
            lblInvestment.Text = GetTotalAmountUntilDate(conn, "BalanceSheet", "Investment", endDate).ToString("N");
            lblCash.Text = GetTotalAmountUntilDate(conn, "BalanceSheet", "Cash", endDate).ToString("N");
            lblDebtors.Text = GetTotalAmountUntilDate(conn, "BalanceSheet", "Debtors", endDate).ToString("N");
            lblInventory.Text = GetTotalAmountUntilDate(conn, "BalanceSheet", "Inventory", endDate).ToString("N");
            lblAccruedIncome.Text = GetTotalAmountUntilDate(conn, "BalanceSheet", "AccruedIncome", endDate).ToString("N");

            // Total Balances
            decimal totalBalance1 = GetTotalAmountUntilDate(conn, "BalanceSheet", "Equity", endDate) +
                                    netIncomeAfterTax + // Retained earnings from profit or loss
                                    GetTotalAmountUntilDate(conn, "BalanceSheet", "Loan", endDate) +
                                    GetTotalAmountUntilDate(conn, "BalanceSheet", "OtherLiabilities", endDate) +
                                    GetTotalAmountUntilDate(conn, "BalanceSheet", "Creditors", endDate) +
                                    GetTotalAmountUntilDate(conn, "BalanceSheet", "AccruedExpenses", endDate);

            decimal totalBalance2 = GetTotalAmountUntilDate(conn, "BalanceSheet", "Land", endDate) +
                                    GetTotalAmountUntilDate(conn, "BalanceSheet", "Furniture", endDate) +
                                    GetTotalAmountUntilDate(conn, "BalanceSheet", "Building", endDate) +
                                    GetTotalAmountUntilDate(conn, "BalanceSheet", "Investment", endDate) +
                                    GetTotalAmountUntilDate(conn, "BalanceSheet", "Cash", endDate) +
                                    GetTotalAmountUntilDate(conn, "BalanceSheet", "Debtors", endDate) +
                                    GetTotalAmountUntilDate(conn, "BalanceSheet", "Inventory", endDate) +
                                    GetTotalAmountUntilDate(conn, "BalanceSheet", "AccruedIncome", endDate);

            lblTotalBalance1.Text = totalBalance1.ToString("N");
            lblTotalBalance2.Text = totalBalance2.ToString("N");
        }

        private decimal GetTotalAmount(SqlConnection conn, string tableName, string columnName, DateTime startDate, DateTime endDate)
        {
            string query = $"SELECT SUM({columnName}) FROM {tableName} WHERE Date BETWEEN @startDate AND @endDate";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);
                object result = cmd.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
            }
        }

        private decimal GetTotalAmountUntilDate(SqlConnection conn, string tableName, string columnName, DateTime endDate)
        {
            string query = $"SELECT SUM({columnName}) FROM {tableName} WHERE Date <= @endDate";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@endDate", endDate);
                object result = cmd.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
            }
        }

        private decimal GetExpenseTotal(SqlConnection conn, string expenseType, DateTime startDate, DateTime endDate)
        {
            string query = "SELECT SUM(Amount) FROM Expenses WHERE ExpenseType = @expenseType AND Date BETWEEN @startDate AND @endDate";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@expenseType", expenseType);
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);
                object result = cmd.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
            }
        }

        private decimal GetTotalExpenses(SqlConnection conn, DateTime startDate, DateTime endDate)
        {
            string[] expenseTypes = {
                "Marketing", "Salaries/wages", "Other Tax", "Administration M/R",
                "Rent", "Utilities", "Insurance", "Bank fees and Interst", "Other Expense"
            };
            decimal totalExpense = 0;
            foreach (string expenseType in expenseTypes)
            {
                totalExpense += GetExpenseTotal(conn, expenseType, startDate, endDate);
            }
            return totalExpense;
        }

        private void profitOrLossButton_Click(object sender, EventArgs e)
        {
            profitOrLossPanel.Visible = true;
            balanceSheetgb.Visible = false;
        }

        private void balanceSheetButton_Click(object sender, EventArgs e)
        {
            profitOrLossPanel.Visible = false;
            balanceSheetgb.Visible = true;
        }

        private void ProfitOrLossControl_Load(object sender, EventArgs e)
        {
            profitOrLossPanel.Visible = true;
            balanceSheetgb.Visible = false;
        }
    }
}


