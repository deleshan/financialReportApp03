using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace financialReportApp03
{
    public partial class LogInForm : Form
    {
        private LogInControl loginUserControl;

        public LogInForm()
        {
            InitializeComponent();
            InitializeLoginUserControl();
            btnMinimize.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinimize.Cursor = Cursors.Hand;
            closePic.SizeMode = PictureBoxSizeMode.StretchImage;
            closePic.Cursor = Cursors.Hand;
        }

        private void InitializeLoginUserControl()
        {
            loginUserControl = new LogInControl();
            loginUserControl.LoginSuccessful += LogInControl_LoginSuccessful;
            this.Controls.Add(loginUserControl);
            loginUserControl.Dock = DockStyle.Fill;
        }

        private void LogInControl_LoginSuccessful(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
            mainForm.FormClosed += (s, args) => this.Close();
        }

        private void closePic_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void LoadUserControl(UserControl userControl)
        {
            contentPanelLoginForm.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            contentPanelLoginForm.Controls.Add(userControl);
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            LoadUserControl(loginUserControl);
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            LoadUserControl(loginUserControl);
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SignUpControl signUp = new SignUpControl();
            LoadUserControl(signUp);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
