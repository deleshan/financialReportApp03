namespace financialReportApp03
{
    partial class LogInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closePic = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Button();
            this.logInButton = new System.Windows.Forms.Button();
            this.contentPanelLoginForm = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePic)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.closePic);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 107);
            this.panel1.TabIndex = 18;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = global::financialReportApp03.Properties.Resources.icons8_minimize_48__1_;
            this.btnMinimize.Location = new System.Drawing.Point(796, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(28, 28);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimize.TabIndex = 27;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::financialReportApp03.Properties.Resources.R;
            this.pictureBox1.Location = new System.Drawing.Point(21, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // closePic
            // 
            this.closePic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closePic.Image = ((System.Drawing.Image)(resources.GetObject("closePic.Image")));
            this.closePic.Location = new System.Drawing.Point(823, 3);
            this.closePic.Name = "closePic";
            this.closePic.Size = new System.Drawing.Size(27, 28);
            this.closePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closePic.TabIndex = 20;
            this.closePic.TabStop = false;
            this.closePic.Click += new System.EventHandler(this.closePic_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(114, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(350, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Financial  Report Application";
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.signUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.ForeColor = System.Drawing.Color.White;
            this.signUpButton.Location = new System.Drawing.Point(20, 82);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(95, 33);
            this.signUpButton.TabIndex = 23;
            this.signUpButton.Text = "New User";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // logInButton
            // 
            this.logInButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.logInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.ForeColor = System.Drawing.Color.White;
            this.logInButton.Location = new System.Drawing.Point(20, 24);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(95, 33);
            this.logInButton.TabIndex = 21;
            this.logInButton.Text = "LogIn";
            this.logInButton.UseVisualStyleBackColor = false;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // contentPanelLoginForm
            // 
            this.contentPanelLoginForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentPanelLoginForm.AutoScroll = true;
            this.contentPanelLoginForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.contentPanelLoginForm.Location = new System.Drawing.Point(147, 113);
            this.contentPanelLoginForm.Name = "contentPanelLoginForm";
            this.contentPanelLoginForm.Size = new System.Drawing.Size(692, 470);
            this.contentPanelLoginForm.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.signUpButton);
            this.panel2.Controls.Add(this.logInButton);
            this.panel2.Location = new System.Drawing.Point(0, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 492);
            this.panel2.TabIndex = 24;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(851, 606);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.contentPanelLoginForm);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogInForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Financial Report Application";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox closePic;
        private System.Windows.Forms.Panel contentPanelLoginForm;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnMinimize;
    }
}

