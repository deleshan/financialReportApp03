using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace financialReportApp03
{
    public partial class SignUpControl : UserControl
    {
        public SignUpControl()
        {
            InitializeComponent();
        }

        private void btnSubmitSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                string adminName = txtAdminName.Text;
                string orgName = txtOrgName.Text;
                string password = txtPassword.Text;
                string confirmPassword = txtConfirmPassword.Text;

                // Validate input fields
                if (string.IsNullOrEmpty(adminName) || string.IsNullOrEmpty(orgName) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
                {
                    MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate and parse balance sheet amounts
                decimal equity = ParseDecimal(txtEquity.Text);
                decimal loan = ParseDecimal(txtLoan.Text);
                decimal otherLiabilities = ParseDecimal(txtOtherLiabilities.Text);
                decimal creditors = ParseDecimal(txtCreditors.Text);
                decimal accruedExpenses = ParseDecimal(txtAccruedExpenses.Text);
                decimal land = ParseDecimal(txtLand.Text);
                decimal furniture = ParseDecimal(txtFurniture.Text);
                decimal building = ParseDecimal(txtBuilding.Text);
                decimal investment = ParseDecimal(txtInvestment.Text);
                decimal cash = ParseDecimal(txtCash.Text);
                decimal debtors = ParseDecimal(txtDebtors.Text);
                decimal inventory = ParseDecimal(txtInventory.Text);
                decimal prepaidExpenses = ParseDecimal(txtPrepaidExpenses.Text);
                decimal accruedIncome = ParseDecimal(txtAccruedIncome.Text);

                // Calculate total assets and liabilities
                decimal totalAssets = land + furniture + building + investment + cash + debtors + inventory + prepaidExpenses + accruedIncome;
                decimal totalLiabilities = equity + loan + otherLiabilities + creditors + accruedExpenses;

                // Check balance sheet equality
                if (totalAssets != totalLiabilities)
                {
                    MessageBox.Show("Balance sheet totals do not match. Adjusting Equity to balance.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // Adjust equity to balance the balance sheet
                    equity += (totalLiabilities - totalAssets);
                }

                // Save user and balance sheet details to database
                SaveUserDetails(adminName, orgName, password);
                SaveBalanceSheetDetails(equity, loan, otherLiabilities, creditors, accruedExpenses, land, furniture, building, investment, cash, debtors, inventory, prepaidExpenses, accruedIncome);
                SaveInventoryDetails(inventory);
                SaveCreditorDetails(creditors);
                SaveDebtorDetails(debtors);

                MessageBox.Show("User registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear input fields after successful registration
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearInputFields()
        {
            txtAdminName.Clear();
            txtOrgName.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtEquity.Clear();
            txtLoan.Clear();
            txtOtherLiabilities.Clear();
            txtCreditors.Clear();
            txtAccruedExpenses.Clear();
            txtLand.Clear();
            txtFurniture.Clear();
            txtBuilding.Clear();
            txtInvestment.Clear();
            txtCash.Clear();
            txtDebtors.Clear();
            txtInventory.Clear();
            txtPrepaidExpenses.Clear();
            txtAccruedIncome.Clear();
        }

        private decimal ParseDecimal(string value)
        {
            if (decimal.TryParse(value, out decimal result))
                return result;
            return 0;
        }

        private void SaveUserDetails(string adminName, string orgName, string password)
        {
            string connString = @"Server=DESKTOP-UFU2OV3\SQLEXPRESS;Initial Catalog=DBFinRep;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string deleteQuery = "DELETE FROM Users";
            string insertQuery = "INSERT INTO Users (admin_name, Organization_name, Password) VALUES (@adminName, @orgName, @password)";
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // Delete existing user data
                    SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
                    deleteCmd.ExecuteNonQuery();

                    // Insert new user data
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@adminName", adminName);
                    insertCmd.Parameters.AddWithValue("@orgName", orgName);
                    insertCmd.Parameters.AddWithValue("@password", password);
                    insertCmd.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlEx)
            {
                // Handle SQL exceptions
                MessageBox.Show($"SQL Error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException invOpEx)
            {
                // Handle invalid operation exceptions
                MessageBox.Show($"Invalid Operation: {invOpEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveBalanceSheetDetails(decimal equity, decimal loan, decimal otherLiabilities, decimal creditors, decimal accruedExpenses,
            decimal land, decimal furniture, decimal building, decimal investment, decimal cash, decimal debtors, decimal inventory,
            decimal prepaidExpenses, decimal accruedIncome)
        {
            string connString = @"Server=DESKTOP-UFU2OV3\SQLEXPRESS;Initial Catalog=DBFinRep;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string deleteQuery = "DELETE FROM BalanceSheet";
            string insertQuery = "INSERT INTO BalanceSheet (Equity, Loan, OtherLiabilities, Creditors, AccruedExpenses, Land, Furniture, Building, " +
                "Investment, Cash, Debtors, Inventory, PrepaidExpenses, AccruedIncome) " +
                "VALUES (@equity, @loan, @otherLiabilities, @creditors, @accruedExpenses, @land, @furniture, @building, @investment, " +
                "@cash, @debtors, @inventory, @prepaidExpenses, @accruedIncome)";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                // Delete existing balance sheet data
                SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
                deleteCmd.ExecuteNonQuery();

                // Insert new balance sheet data
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@equity", equity);
                insertCmd.Parameters.AddWithValue("@loan", loan);
                insertCmd.Parameters.AddWithValue("@otherLiabilities", otherLiabilities);
                insertCmd.Parameters.AddWithValue("@creditors", creditors);
                insertCmd.Parameters.AddWithValue("@accruedExpenses", accruedExpenses);
                insertCmd.Parameters.AddWithValue("@land", land);
                insertCmd.Parameters.AddWithValue("@furniture", furniture);
                insertCmd.Parameters.AddWithValue("@building", building);
                insertCmd.Parameters.AddWithValue("@investment", investment);
                insertCmd.Parameters.AddWithValue("@cash", cash);
                insertCmd.Parameters.AddWithValue("@debtors", debtors);
                insertCmd.Parameters.AddWithValue("@inventory", inventory);
                insertCmd.Parameters.AddWithValue("@prepaidExpenses", prepaidExpenses);
                insertCmd.Parameters.AddWithValue("@accruedIncome", accruedIncome);
                insertCmd.ExecuteNonQuery();
            }
        }

        private void SaveInventoryDetails(decimal inventory)
        {
            string connString = @"Server=DESKTOP-UFU2OV3\SQLEXPRESS;Initial Catalog=DBFinRep;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string deleteQuery = "DELETE FROM Inventory";
            string insertQuery = "INSERT INTO Inventory (CostPrice) VALUES (@amount)";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                // Delete existing inventory data
                SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
                deleteCmd.ExecuteNonQuery();

                // Insert new inventory data
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@amount", inventory);
                insertCmd.ExecuteNonQuery();
            }
        }

        private void SaveCreditorDetails(decimal creditors)
        {
            string connString = @"Server=DESKTOP-UFU2OV3\SQLEXPRESS;Initial Catalog=DBFinRep;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string deleteQuery = "DELETE FROM Creditors";
            string insertQuery = "INSERT INTO Creditors (Balance) VALUES (@amount)";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                // Delete existing creditors data
                SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
                deleteCmd.ExecuteNonQuery();

                // Insert new creditors data
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@amount", creditors);
                insertCmd.ExecuteNonQuery();
            }
        }

        private void SaveDebtorDetails(decimal debtors)
        {
            string connString = @"Server=DESKTOP-UFU2OV3\SQLEXPRESS;Initial Catalog=DBFinRep;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string deleteQuery = "DELETE FROM Debtors";
            string insertQuery = "INSERT INTO Debtors (Amount) VALUES (@amount)";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                // Delete existing debtors data
                SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
                deleteCmd.ExecuteNonQuery();

                // Insert new debtors data
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@amount", debtors);
                insertCmd.ExecuteNonQuery();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !checkBox1.Checked;
            txtConfirmPassword.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}