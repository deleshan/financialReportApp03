namespace financialReportApp03
{
    partial class PaymentsControl
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
            this.PaymentGroupBox = new System.Windows.Forms.GroupBox();
            this.gbCreditors = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCreditorName = new System.Windows.Forms.TextBox();
            this.gbLoan = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOrgName = new System.Windows.Forms.TextBox();
            this.gbDebtors = new System.Windows.Forms.GroupBox();
            this.lblDebtorName = new System.Windows.Forms.Label();
            this.txtDebtorName = new System.Windows.Forms.TextBox();
            this.comboPaidType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboReceivedType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.buttonPayments = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.radioPaid = new System.Windows.Forms.RadioButton();
            this.radioReceived = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PaymentGroupBox.SuspendLayout();
            this.gbCreditors.SuspendLayout();
            this.gbLoan.SuspendLayout();
            this.gbDebtors.SuspendLayout();
            this.SuspendLayout();
            // 
            // PaymentGroupBox
            // 
            this.PaymentGroupBox.Controls.Add(this.gbCreditors);
            this.PaymentGroupBox.Controls.Add(this.gbLoan);
            this.PaymentGroupBox.Controls.Add(this.gbDebtors);
            this.PaymentGroupBox.Controls.Add(this.comboPaidType);
            this.PaymentGroupBox.Controls.Add(this.label4);
            this.PaymentGroupBox.Controls.Add(this.comboReceivedType);
            this.PaymentGroupBox.Controls.Add(this.label3);
            this.PaymentGroupBox.Controls.Add(this.btnClear);
            this.PaymentGroupBox.Controls.Add(this.dtpDate);
            this.PaymentGroupBox.Controls.Add(this.buttonPayments);
            this.PaymentGroupBox.Controls.Add(this.txtAmount);
            this.PaymentGroupBox.Controls.Add(this.radioPaid);
            this.PaymentGroupBox.Controls.Add(this.radioReceived);
            this.PaymentGroupBox.Controls.Add(this.label2);
            this.PaymentGroupBox.Controls.Add(this.label1);
            this.PaymentGroupBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentGroupBox.Location = new System.Drawing.Point(136, 14);
            this.PaymentGroupBox.Name = "PaymentGroupBox";
            this.PaymentGroupBox.Size = new System.Drawing.Size(721, 303);
            this.PaymentGroupBox.TabIndex = 4;
            this.PaymentGroupBox.TabStop = false;
            this.PaymentGroupBox.Text = "Payments Details";
            // 
            // gbCreditors
            // 
            this.gbCreditors.Controls.Add(this.label6);
            this.gbCreditors.Controls.Add(this.txtCreditorName);
            this.gbCreditors.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCreditors.Location = new System.Drawing.Point(302, 39);
            this.gbCreditors.Name = "gbCreditors";
            this.gbCreditors.Size = new System.Drawing.Size(399, 55);
            this.gbCreditors.TabIndex = 14;
            this.gbCreditors.TabStop = false;
            this.gbCreditors.Text = "Creditor\'s details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Name";
            // 
            // txtCreditorName
            // 
            this.txtCreditorName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditorName.Location = new System.Drawing.Point(123, 19);
            this.txtCreditorName.Name = "txtCreditorName";
            this.txtCreditorName.Size = new System.Drawing.Size(255, 22);
            this.txtCreditorName.TabIndex = 11;
            // 
            // gbLoan
            // 
            this.gbLoan.Controls.Add(this.label9);
            this.gbLoan.Controls.Add(this.txtOrgName);
            this.gbLoan.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLoan.Location = new System.Drawing.Point(296, 41);
            this.gbLoan.Name = "gbLoan";
            this.gbLoan.Size = new System.Drawing.Size(399, 55);
            this.gbLoan.TabIndex = 15;
            this.gbLoan.TabStop = false;
            this.gbLoan.Text = "Organization Details";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Name";
            // 
            // txtOrgName
            // 
            this.txtOrgName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrgName.Location = new System.Drawing.Point(123, 19);
            this.txtOrgName.Name = "txtOrgName";
            this.txtOrgName.Size = new System.Drawing.Size(255, 22);
            this.txtOrgName.TabIndex = 11;
            // 
            // gbDebtors
            // 
            this.gbDebtors.Controls.Add(this.lblDebtorName);
            this.gbDebtors.Controls.Add(this.txtDebtorName);
            this.gbDebtors.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDebtors.Location = new System.Drawing.Point(302, 39);
            this.gbDebtors.Name = "gbDebtors";
            this.gbDebtors.Size = new System.Drawing.Size(399, 55);
            this.gbDebtors.TabIndex = 2;
            this.gbDebtors.TabStop = false;
            this.gbDebtors.Text = "Debtors Details";
            // 
            // lblDebtorName
            // 
            this.lblDebtorName.AutoSize = true;
            this.lblDebtorName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebtorName.Location = new System.Drawing.Point(23, 23);
            this.lblDebtorName.Name = "lblDebtorName";
            this.lblDebtorName.Size = new System.Drawing.Size(36, 16);
            this.lblDebtorName.TabIndex = 8;
            this.lblDebtorName.Text = "Name";
            // 
            // txtDebtorName
            // 
            this.txtDebtorName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebtorName.Location = new System.Drawing.Point(123, 19);
            this.txtDebtorName.Name = "txtDebtorName";
            this.txtDebtorName.Size = new System.Drawing.Size(255, 22);
            this.txtDebtorName.TabIndex = 11;
            // 
            // comboPaidType
            // 
            this.comboPaidType.FormattingEnabled = true;
            this.comboPaidType.Items.AddRange(new object[] {
            "Loan",
            "Creditors",
            "Other Credits",
            "Accrued Expense"});
            this.comboPaidType.Location = new System.Drawing.Point(127, 202);
            this.comboPaidType.Name = "comboPaidType";
            this.comboPaidType.Size = new System.Drawing.Size(145, 24);
            this.comboPaidType.TabIndex = 25;
            this.comboPaidType.SelectedIndexChanged += new System.EventHandler(this.comboPaidType_SelectedIndexChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Paid Type";
            // 
            // comboReceivedType
            // 
            this.comboReceivedType.FormattingEnabled = true;
            this.comboReceivedType.Items.AddRange(new object[] {
            "Debtors",
            "Accrued Income"});
            this.comboReceivedType.Location = new System.Drawing.Point(127, 156);
            this.comboReceivedType.Name = "comboReceivedType";
            this.comboReceivedType.Size = new System.Drawing.Size(145, 24);
            this.comboReceivedType.TabIndex = 23;
            this.comboReceivedType.SelectedIndexChanged += new System.EventHandler(this.comboReceivedType_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Received Type";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(399, 202);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 27);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(35, 39);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(236, 22);
            this.dtpDate.TabIndex = 20;
            // 
            // buttonPayments
            // 
            this.buttonPayments.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPayments.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPayments.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPayments.Location = new System.Drawing.Point(555, 202);
            this.buttonPayments.Name = "buttonPayments";
            this.buttonPayments.Size = new System.Drawing.Size(134, 27);
            this.buttonPayments.TabIndex = 19;
            this.buttonPayments.Text = "Submit";
            this.buttonPayments.UseVisualStyleBackColor = false;
            this.buttonPayments.Click += new System.EventHandler(this.buttonPayments_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(127, 79);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(144, 22);
            this.txtAmount.TabIndex = 6;
            // 
            // radioPaid
            // 
            this.radioPaid.AutoSize = true;
            this.radioPaid.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPaid.Location = new System.Drawing.Point(219, 115);
            this.radioPaid.Name = "radioPaid";
            this.radioPaid.Size = new System.Drawing.Size(48, 20);
            this.radioPaid.TabIndex = 5;
            this.radioPaid.TabStop = true;
            this.radioPaid.Text = "Paid";
            this.radioPaid.UseVisualStyleBackColor = true;
            this.radioPaid.CheckedChanged += new System.EventHandler(this.radioPaid_CheckedChanged_1);
            // 
            // radioReceived
            // 
            this.radioReceived.AutoSize = true;
            this.radioReceived.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioReceived.Location = new System.Drawing.Point(127, 115);
            this.radioReceived.Name = "radioReceived";
            this.radioReceived.Size = new System.Drawing.Size(73, 20);
            this.radioReceived.TabIndex = 4;
            this.radioReceived.TabStop = true;
            this.radioReceived.Text = "Received";
            this.radioReceived.UseVisualStyleBackColor = true;
            this.radioReceived.CheckedChanged += new System.EventHandler(this.radioReceived_CheckedChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nature";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // PaymentsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PaymentGroupBox);
            this.Name = "PaymentsControl";
            this.Size = new System.Drawing.Size(890, 333);
            this.PaymentGroupBox.ResumeLayout(false);
            this.PaymentGroupBox.PerformLayout();
            this.gbCreditors.ResumeLayout(false);
            this.gbCreditors.PerformLayout();
            this.gbLoan.ResumeLayout(false);
            this.gbLoan.PerformLayout();
            this.gbDebtors.ResumeLayout(false);
            this.gbDebtors.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PaymentGroupBox;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button buttonPayments;
        private System.Windows.Forms.GroupBox gbDebtors;
        private System.Windows.Forms.Label lblDebtorName;
        private System.Windows.Forms.TextBox txtDebtorName;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.RadioButton radioPaid;
        private System.Windows.Forms.RadioButton radioReceived;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboPaidType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboReceivedType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbCreditors;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCreditorName;
        private System.Windows.Forms.GroupBox gbLoan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOrgName;
    }
}
