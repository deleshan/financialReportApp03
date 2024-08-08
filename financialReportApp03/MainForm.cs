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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            logInToolStripMenuItem.MouseLeave += logInToolStripMenuItem_MouseLeave;
            logInToolStripMenuItem.MouseEnter += logInToolStripMenuItem_MouseEnter;
            btnMinimize.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinimize.Cursor = Cursors.Hand;
            btnClosePic.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClosePic.Cursor = Cursors.Hand;
            LoadUserData();
        }

        private void closePic_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void LoadUserControl(UserControl userControl)
        {
            contentPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(userControl);
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesControl salesTransection = new SalesControl();
            LoadUserControl(salesTransection);
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseControl purchase = new PurchaseControl();
            LoadUserControl(purchase);
        }

        private void expenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpenseControl expenses = new ExpenseControl();
            LoadUserControl(expenses);
        }

        private void financialActivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinActControl finAct = new FinActControl();
            LoadUserControl(finAct);
        }

        private void equityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EquityControl equity = new EquityControl();
            LoadUserControl(equity);
        }

        private void otherIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtherIncomeControl otherIncome = new OtherIncomeControl();
            LoadUserControl(otherIncome);
        }

        private void taxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaxControl taxAct = new TaxControl();
            LoadUserControl(taxAct);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void profitOrLossAcountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfitOrLossControl proOrLoss = new ProfitOrLossControl();
            LoadUserControl(proOrLoss);
        }

        private void balanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BalanceSheetControl balSheet = new BalanceSheetControl();
            LoadUserControl(balSheet);
        }

        private void craditorsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreditorsControl creditorsCont = new CreditorsControl();
            LoadUserControl(creditorsCont);
        }

        private void debtorsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DebtorsControl debCont = new DebtorsControl();
            LoadUserControl(debCont);
        }

        private void inventoryDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryControl inventCont = new InventoryControl();
            LoadUserControl(inventCont);
        }

        private void transectionsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TransactionsControl transections = new TransactionsControl();
            LoadUserControl(transections);
        }

        private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentsControl payments = new PaymentsControl();
            LoadUserControl(payments);
        }

        private void logInToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            logInToolStripMenuItem.ForeColor = Color.Black;
        }

        private void logInToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            logInToolStripMenuItem.ForeColor = Color.White;
        }

        private void transectionsToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            transectionsToolStripMenuItem.ForeColor = Color.Black;
        }

        private void transectionsToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            transectionsToolStripMenuItem.ForeColor = Color.White;
        }

        private void reportsToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            reportsToolStripMenuItem.ForeColor = Color.Black;
        }

        private void reportsToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            reportsToolStripMenuItem.ForeColor = Color.White;
        }

        private void clearDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearDatabaseControl clearDB = new ClearDatabaseControl();
            LoadUserControl(clearDB);
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                
                UserSession.Clear();


                this.Hide();

                LogInForm loginForm = new LogInForm();
                loginForm.FormClosed += (s, args) => this.Close(); // Ensure the main form closes when login form is closed
                loginForm.Show();
            }
        }

        private void otherPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtherPurchaseControl oPurchase = new OtherPurchaseControl();
            LoadUserControl(oPurchase);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void LoadUserData()
        {
            string connString = @"Server=localhost\SQLEXPRESS;Database=DBFinRep;Trusted_Connection=True;";
            string query = "SELECT Organization_name, admin_name FROM Users WHERE UserID = @UserID";

            
            int userId = 1008;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblOrgName.Text = reader["Organization_name"].ToString();
                                lblAdminName.Text = reader["admin_name"].ToString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading user data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }

}


public static class UserSession
    {
        public static int UserID { get; set; }

        public static void Clear()
        {
            UserID = 0;
            
        }
    }


   
