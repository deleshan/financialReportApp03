namespace financialReportApp03
{
    partial class OtherPurchaseControl
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
            this.SalesGroupBox = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOPSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTypeOP = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSales = new System.Windows.Forms.Button();
            this.dtpOPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.txtTotalOPurchase = new System.Windows.Forms.TextBox();
            this.radioButtonCredit = new System.Windows.Forms.RadioButton();
            this.radioButtonCash = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SalesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalesGroupBox
            // 
            this.SalesGroupBox.Controls.Add(this.btnClear);
            this.SalesGroupBox.Controls.Add(this.btnOPSubmit);
            this.SalesGroupBox.Controls.Add(this.label3);
            this.SalesGroupBox.Controls.Add(this.comboBoxTypeOP);
            this.SalesGroupBox.Controls.Add(this.button1);
            this.SalesGroupBox.Controls.Add(this.buttonSales);
            this.SalesGroupBox.Controls.Add(this.dtpOPurchaseDate);
            this.SalesGroupBox.Controls.Add(this.txtTotalOPurchase);
            this.SalesGroupBox.Controls.Add(this.radioButtonCredit);
            this.SalesGroupBox.Controls.Add(this.radioButtonCash);
            this.SalesGroupBox.Controls.Add(this.label2);
            this.SalesGroupBox.Controls.Add(this.label1);
            this.SalesGroupBox.Location = new System.Drawing.Point(186, 31);
            this.SalesGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.SalesGroupBox.Name = "SalesGroupBox";
            this.SalesGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.SalesGroupBox.Size = new System.Drawing.Size(357, 290);
            this.SalesGroupBox.TabIndex = 5;
            this.SalesGroupBox.TabStop = false;
            this.SalesGroupBox.Text = "Purchase Details";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(40, 227);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 33);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOPSubmit
            // 
            this.btnOPSubmit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnOPSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOPSubmit.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOPSubmit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOPSubmit.Location = new System.Drawing.Point(208, 227);
            this.btnOPSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnOPSubmit.Name = "btnOPSubmit";
            this.btnOPSubmit.Size = new System.Drawing.Size(118, 33);
            this.btnOPSubmit.TabIndex = 26;
            this.btnOPSubmit.Text = "Submit";
            this.btnOPSubmit.UseVisualStyleBackColor = false;
            this.btnOPSubmit.Click += new System.EventHandler(this.btnOPSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Type";
            // 
            // comboBoxTypeOP
            // 
            this.comboBoxTypeOP.FormattingEnabled = true;
            this.comboBoxTypeOP.Items.AddRange(new object[] {
            "Land",
            "Furniture",
            "Building"});
            this.comboBoxTypeOP.Location = new System.Drawing.Point(116, 164);
            this.comboBoxTypeOP.Name = "comboBoxTypeOP";
            this.comboBoxTypeOP.Size = new System.Drawing.Size(210, 21);
            this.comboBoxTypeOP.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(483, 410);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 33);
            this.button1.TabIndex = 23;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonSales
            // 
            this.buttonSales.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSales.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSales.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSales.Location = new System.Drawing.Point(665, 410);
            this.buttonSales.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSales.Name = "buttonSales";
            this.buttonSales.Size = new System.Drawing.Size(156, 33);
            this.buttonSales.TabIndex = 22;
            this.buttonSales.Text = "Submit";
            this.buttonSales.UseVisualStyleBackColor = false;
            // 
            // dtpOPurchaseDate
            // 
            this.dtpOPurchaseDate.Location = new System.Drawing.Point(38, 37);
            this.dtpOPurchaseDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpOPurchaseDate.Name = "dtpOPurchaseDate";
            this.dtpOPurchaseDate.Size = new System.Drawing.Size(288, 20);
            this.dtpOPurchaseDate.TabIndex = 20;
            // 
            // txtTotalOPurchase
            // 
            this.txtTotalOPurchase.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOPurchase.Location = new System.Drawing.Point(116, 81);
            this.txtTotalOPurchase.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalOPurchase.Name = "txtTotalOPurchase";
            this.txtTotalOPurchase.Size = new System.Drawing.Size(210, 22);
            this.txtTotalOPurchase.TabIndex = 6;
            // 
            // radioButtonCredit
            // 
            this.radioButtonCredit.AutoSize = true;
            this.radioButtonCredit.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCredit.Location = new System.Drawing.Point(216, 122);
            this.radioButtonCredit.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonCredit.Name = "radioButtonCredit";
            this.radioButtonCredit.Size = new System.Drawing.Size(57, 20);
            this.radioButtonCredit.TabIndex = 5;
            this.radioButtonCredit.TabStop = true;
            this.radioButtonCredit.Text = "Credit";
            this.radioButtonCredit.UseVisualStyleBackColor = true;
            // 
            // radioButtonCash
            // 
            this.radioButtonCash.AutoSize = true;
            this.radioButtonCash.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCash.Location = new System.Drawing.Point(118, 121);
            this.radioButtonCash.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonCash.Name = "radioButtonCash";
            this.radioButtonCash.Size = new System.Drawing.Size(52, 20);
            this.radioButtonCash.TabIndex = 4;
            this.radioButtonCash.TabStop = true;
            this.radioButtonCash.Text = "Cash";
            this.radioButtonCash.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nature";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // OtherPurchaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SalesGroupBox);
            this.Name = "OtherPurchaseControl";
            this.Size = new System.Drawing.Size(631, 364);
            this.SalesGroupBox.ResumeLayout(false);
            this.SalesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SalesGroupBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSales;
        private System.Windows.Forms.DateTimePicker dtpOPurchaseDate;
        private System.Windows.Forms.TextBox txtTotalOPurchase;
        private System.Windows.Forms.RadioButton radioButtonCredit;
        private System.Windows.Forms.RadioButton radioButtonCash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTypeOP;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOPSubmit;
    }
}
