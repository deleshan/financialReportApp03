namespace financialReportApp03
{
    partial class ExpenseControl
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
            this.ExpensesGroupBox = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.buttonExpense = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.DateExpense = new System.Windows.Forms.DateTimePicker();
            this.comboExpenseType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtExpenseAmount = new System.Windows.Forms.TextBox();
            this.rbtnCreditExpense = new System.Windows.Forms.RadioButton();
            this.rbtnCashExpense = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ExpensesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExpensesGroupBox
            // 
            this.ExpensesGroupBox.Controls.Add(this.btnClear);
            this.ExpensesGroupBox.Controls.Add(this.buttonExpense);
            this.ExpensesGroupBox.Controls.Add(this.txtDescription);
            this.ExpensesGroupBox.Controls.Add(this.DateExpense);
            this.ExpensesGroupBox.Controls.Add(this.comboExpenseType);
            this.ExpensesGroupBox.Controls.Add(this.label3);
            this.ExpensesGroupBox.Controls.Add(this.label7);
            this.ExpensesGroupBox.Controls.Add(this.txtExpenseAmount);
            this.ExpensesGroupBox.Controls.Add(this.rbtnCreditExpense);
            this.ExpensesGroupBox.Controls.Add(this.rbtnCashExpense);
            this.ExpensesGroupBox.Controls.Add(this.label2);
            this.ExpensesGroupBox.Controls.Add(this.label1);
            this.ExpensesGroupBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpensesGroupBox.Location = new System.Drawing.Point(139, 14);
            this.ExpensesGroupBox.Name = "ExpensesGroupBox";
            this.ExpensesGroupBox.Size = new System.Drawing.Size(545, 355);
            this.ExpensesGroupBox.TabIndex = 5;
            this.ExpensesGroupBox.TabStop = false;
            this.ExpensesGroupBox.Text = "Expenses Details";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(233, 301);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 27);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // buttonExpense
            // 
            this.buttonExpense.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExpense.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExpense.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonExpense.Location = new System.Drawing.Point(390, 301);
            this.buttonExpense.Name = "buttonExpense";
            this.buttonExpense.Size = new System.Drawing.Size(134, 27);
            this.buttonExpense.TabIndex = 22;
            this.buttonExpense.Text = "Submit";
            this.buttonExpense.UseVisualStyleBackColor = false;
            this.buttonExpense.Click += new System.EventHandler(this.buttonExpense_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(125, 208);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(399, 54);
            this.txtDescription.TabIndex = 14;
            // 
            // DateExpense
            // 
            this.DateExpense.Location = new System.Drawing.Point(35, 35);
            this.DateExpense.Name = "DateExpense";
            this.DateExpense.Size = new System.Drawing.Size(236, 22);
            this.DateExpense.TabIndex = 21;
            // 
            // comboExpenseType
            // 
            this.comboExpenseType.FormattingEnabled = true;
            this.comboExpenseType.Items.AddRange(new object[] {
            "Marketing",
            "Salaries/wages",
            "Other tax",
            "Administration M/R",
            "Rent",
            "Utilities",
            "Insurance",
            "Bank fees & interest",
            "Other Expense"});
            this.comboExpenseType.Location = new System.Drawing.Point(125, 141);
            this.comboExpenseType.Name = "comboExpenseType";
            this.comboExpenseType.Size = new System.Drawing.Size(145, 24);
            this.comboExpenseType.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Expense Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Description";
            // 
            // txtExpenseAmount
            // 
            this.txtExpenseAmount.Location = new System.Drawing.Point(127, 72);
            this.txtExpenseAmount.Name = "txtExpenseAmount";
            this.txtExpenseAmount.Size = new System.Drawing.Size(144, 22);
            this.txtExpenseAmount.TabIndex = 6;
            // 
            // rbtnCreditExpense
            // 
            this.rbtnCreditExpense.AutoSize = true;
            this.rbtnCreditExpense.Location = new System.Drawing.Point(219, 98);
            this.rbtnCreditExpense.Name = "rbtnCreditExpense";
            this.rbtnCreditExpense.Size = new System.Drawing.Size(57, 20);
            this.rbtnCreditExpense.TabIndex = 5;
            this.rbtnCreditExpense.TabStop = true;
            this.rbtnCreditExpense.Text = "Credit";
            this.rbtnCreditExpense.UseVisualStyleBackColor = true;
            // 
            // rbtnCashExpense
            // 
            this.rbtnCashExpense.AutoSize = true;
            this.rbtnCashExpense.Location = new System.Drawing.Point(128, 97);
            this.rbtnCashExpense.Name = "rbtnCashExpense";
            this.rbtnCashExpense.Size = new System.Drawing.Size(52, 20);
            this.rbtnCashExpense.TabIndex = 4;
            this.rbtnCashExpense.TabStop = true;
            this.rbtnCashExpense.Text = "Cash";
            this.rbtnCashExpense.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nature";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // ExpenseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ExpensesGroupBox);
            this.Name = "ExpenseControl";
            this.Size = new System.Drawing.Size(774, 387);
            this.ExpensesGroupBox.ResumeLayout(false);
            this.ExpensesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ExpensesGroupBox;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker DateExpense;
        private System.Windows.Forms.ComboBox comboExpenseType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtExpenseAmount;
        private System.Windows.Forms.RadioButton rbtnCreditExpense;
        private System.Windows.Forms.RadioButton rbtnCashExpense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button buttonExpense;
    }
}
