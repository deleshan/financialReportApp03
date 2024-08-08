namespace financialReportApp03
{
    partial class FinActControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.finActGroupBox = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.buttonFinAct = new System.Windows.Forms.Button();
            this.dateFA = new System.Windows.Forms.DateTimePicker();
            this.txtInterestFA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTypeFA = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrgNameFA = new System.Windows.Forms.TextBox();
            this.txtOrgAddressFA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOrgPhoneFA = new System.Windows.Forms.TextBox();
            this.txtAmountFA = new System.Windows.Forms.TextBox();
            this.rbtnCreditFA = new System.Windows.Forms.RadioButton();
            this.rbtnInvestmentFA = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.finActGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // finActGroupBox
            // 
            this.finActGroupBox.Controls.Add(this.btnClear);
            this.finActGroupBox.Controls.Add(this.buttonFinAct);
            this.finActGroupBox.Controls.Add(this.dateFA);
            this.finActGroupBox.Controls.Add(this.txtInterestFA);
            this.finActGroupBox.Controls.Add(this.label8);
            this.finActGroupBox.Controls.Add(this.cmbTypeFA);
            this.finActGroupBox.Controls.Add(this.label3);
            this.finActGroupBox.Controls.Add(this.groupBox2);
            this.finActGroupBox.Controls.Add(this.txtAmountFA);
            this.finActGroupBox.Controls.Add(this.rbtnCreditFA);
            this.finActGroupBox.Controls.Add(this.rbtnInvestmentFA);
            this.finActGroupBox.Controls.Add(this.label2);
            this.finActGroupBox.Controls.Add(this.label1);
            this.finActGroupBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finActGroupBox.Location = new System.Drawing.Point(134, 13);
            this.finActGroupBox.Name = "finActGroupBox";
            this.finActGroupBox.Size = new System.Drawing.Size(741, 284);
            this.finActGroupBox.TabIndex = 6;
            this.finActGroupBox.TabStop = false;
            this.finActGroupBox.Text = "Financial Activity Details";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(415, 229);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 27);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // buttonFinAct
            // 
            this.buttonFinAct.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonFinAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFinAct.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinAct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonFinAct.Location = new System.Drawing.Point(571, 229);
            this.buttonFinAct.Name = "buttonFinAct";
            this.buttonFinAct.Size = new System.Drawing.Size(134, 27);
            this.buttonFinAct.TabIndex = 24;
            this.buttonFinAct.Text = "Submit";
            this.buttonFinAct.UseVisualStyleBackColor = false;
            this.buttonFinAct.Click += new System.EventHandler(this.buttonFinAct_Click);
            // 
            // dateFA
            // 
            this.dateFA.Location = new System.Drawing.Point(37, 28);
            this.dateFA.Name = "dateFA";
            this.dateFA.Size = new System.Drawing.Size(233, 22);
            this.dateFA.TabIndex = 21;
            // 
            // txtInterestFA
            // 
            this.txtInterestFA.Location = new System.Drawing.Point(125, 158);
            this.txtInterestFA.Name = "txtInterestFA";
            this.txtInterestFA.Size = new System.Drawing.Size(146, 22);
            this.txtInterestFA.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "interest";
            // 
            // cmbTypeFA
            // 
            this.cmbTypeFA.FormattingEnabled = true;
            this.cmbTypeFA.Items.AddRange(new object[] {
            "Loan",
            "other liabilities"});
            this.cmbTypeFA.Location = new System.Drawing.Point(125, 128);
            this.cmbTypeFA.Name = "cmbTypeFA";
            this.cmbTypeFA.Size = new System.Drawing.Size(145, 24);
            this.cmbTypeFA.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtOrgNameFA);
            this.groupBox2.Controls.Add(this.txtOrgAddressFA);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtOrgPhoneFA);
            this.groupBox2.Location = new System.Drawing.Point(326, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 161);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Organization Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name";
            // 
            // txtOrgNameFA
            // 
            this.txtOrgNameFA.Location = new System.Drawing.Point(123, 19);
            this.txtOrgNameFA.Name = "txtOrgNameFA";
            this.txtOrgNameFA.Size = new System.Drawing.Size(255, 22);
            this.txtOrgNameFA.TabIndex = 11;
            // 
            // txtOrgAddressFA
            // 
            this.txtOrgAddressFA.Location = new System.Drawing.Point(123, 55);
            this.txtOrgAddressFA.Multiline = true;
            this.txtOrgAddressFA.Name = "txtOrgAddressFA";
            this.txtOrgAddressFA.Size = new System.Drawing.Size(256, 54);
            this.txtOrgAddressFA.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phone Number";
            // 
            // txtOrgPhoneFA
            // 
            this.txtOrgPhoneFA.Location = new System.Drawing.Point(123, 128);
            this.txtOrgPhoneFA.Name = "txtOrgPhoneFA";
            this.txtOrgPhoneFA.Size = new System.Drawing.Size(256, 22);
            this.txtOrgPhoneFA.TabIndex = 13;
            // 
            // txtAmountFA
            // 
            this.txtAmountFA.Location = new System.Drawing.Point(127, 64);
            this.txtAmountFA.Name = "txtAmountFA";
            this.txtAmountFA.Size = new System.Drawing.Size(144, 22);
            this.txtAmountFA.TabIndex = 6;
            // 
            // rbtnCreditFA
            // 
            this.rbtnCreditFA.AutoSize = true;
            this.rbtnCreditFA.Location = new System.Drawing.Point(219, 90);
            this.rbtnCreditFA.Name = "rbtnCreditFA";
            this.rbtnCreditFA.Size = new System.Drawing.Size(57, 20);
            this.rbtnCreditFA.TabIndex = 5;
            this.rbtnCreditFA.TabStop = true;
            this.rbtnCreditFA.Text = "Credit";
            this.rbtnCreditFA.UseVisualStyleBackColor = true;
            // 
            // rbtnInvestmentFA
            // 
            this.rbtnInvestmentFA.AutoSize = true;
            this.rbtnInvestmentFA.Location = new System.Drawing.Point(128, 89);
            this.rbtnInvestmentFA.Name = "rbtnInvestmentFA";
            this.rbtnInvestmentFA.Size = new System.Drawing.Size(84, 20);
            this.rbtnInvestmentFA.TabIndex = 4;
            this.rbtnInvestmentFA.TabStop = true;
            this.rbtnInvestmentFA.Text = "Investment";
            this.rbtnInvestmentFA.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nature";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // FinActControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.finActGroupBox);
            this.Name = "FinActControl";
            this.Size = new System.Drawing.Size(894, 310);
            this.finActGroupBox.ResumeLayout(false);
            this.finActGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox finActGroupBox;
        private System.Windows.Forms.DateTimePicker dateFA;
        private System.Windows.Forms.TextBox txtInterestFA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbTypeFA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrgNameFA;
        private System.Windows.Forms.TextBox txtOrgAddressFA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOrgPhoneFA;
        private System.Windows.Forms.TextBox txtAmountFA;
        private System.Windows.Forms.RadioButton rbtnCreditFA;
        private System.Windows.Forms.RadioButton rbtnInvestmentFA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button buttonFinAct;
    }
}
