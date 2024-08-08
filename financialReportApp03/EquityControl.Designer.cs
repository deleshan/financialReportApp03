namespace financialReportApp03
{
    partial class EquityControl
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
            this.EquityGroupBox = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.buttonSales = new System.Windows.Forms.Button();
            this.dateEquity = new System.Windows.Forms.DateTimePicker();
            this.dgvEquity = new System.Windows.Forms.DataGridView();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbEquityType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEquityAmount = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbtnBorrowingEquity = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EquityGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquity)).BeginInit();
            this.SuspendLayout();
            // 
            // EquityGroupBox
            // 
            this.EquityGroupBox.Controls.Add(this.btnClear);
            this.EquityGroupBox.Controls.Add(this.buttonSales);
            this.EquityGroupBox.Controls.Add(this.dateEquity);
            this.EquityGroupBox.Controls.Add(this.dgvEquity);
            this.EquityGroupBox.Controls.Add(this.cmbEquityType);
            this.EquityGroupBox.Controls.Add(this.label3);
            this.EquityGroupBox.Controls.Add(this.label7);
            this.EquityGroupBox.Controls.Add(this.txtEquityAmount);
            this.EquityGroupBox.Controls.Add(this.radioButton2);
            this.EquityGroupBox.Controls.Add(this.rbtnBorrowingEquity);
            this.EquityGroupBox.Controls.Add(this.label2);
            this.EquityGroupBox.Controls.Add(this.label1);
            this.EquityGroupBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquityGroupBox.Location = new System.Drawing.Point(138, 14);
            this.EquityGroupBox.Name = "EquityGroupBox";
            this.EquityGroupBox.Size = new System.Drawing.Size(693, 403);
            this.EquityGroupBox.TabIndex = 7;
            this.EquityGroupBox.TabStop = false;
            this.EquityGroupBox.Text = "Equity Details";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(380, 349);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 27);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // buttonSales
            // 
            this.buttonSales.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSales.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSales.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSales.Location = new System.Drawing.Point(536, 349);
            this.buttonSales.Name = "buttonSales";
            this.buttonSales.Size = new System.Drawing.Size(134, 27);
            this.buttonSales.TabIndex = 24;
            this.buttonSales.Text = "Submit";
            this.buttonSales.UseVisualStyleBackColor = false;
            this.buttonSales.Click += new System.EventHandler(this.buttonSales_Click);
            // 
            // dateEquity
            // 
            this.dateEquity.Location = new System.Drawing.Point(35, 35);
            this.dateEquity.Name = "dateEquity";
            this.dateEquity.Size = new System.Drawing.Size(200, 22);
            this.dateEquity.TabIndex = 23;
            // 
            // dgvEquity
            // 
            this.dgvEquity.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEquity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEquity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Quantity,
            this.Description,
            this.ProductId,
            this.CostPrice,
            this.SellingPrice});
            this.dgvEquity.Location = new System.Drawing.Point(127, 219);
            this.dgvEquity.Name = "dgvEquity";
            this.dgvEquity.Size = new System.Drawing.Size(543, 94);
            this.dgvEquity.TabIndex = 22;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Qty";
            this.Quantity.Name = "Quantity";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Product id";
            this.ProductId.Name = "ProductId";
            // 
            // CostPrice
            // 
            this.CostPrice.HeaderText = "Cost Price ";
            this.CostPrice.Name = "CostPrice";
            // 
            // SellingPrice
            // 
            this.SellingPrice.HeaderText = "Selling Price";
            this.SellingPrice.Name = "SellingPrice";
            // 
            // cmbEquityType
            // 
            this.cmbEquityType.FormattingEnabled = true;
            this.cmbEquityType.Items.AddRange(new object[] {
            "Cash",
            "Building",
            "Land",
            "Inventory",
            "Furniture"});
            this.cmbEquityType.Location = new System.Drawing.Point(128, 149);
            this.cmbEquityType.Name = "cmbEquityType";
            this.cmbEquityType.Size = new System.Drawing.Size(145, 24);
            this.cmbEquityType.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Description";
            // 
            // txtEquityAmount
            // 
            this.txtEquityAmount.Location = new System.Drawing.Point(127, 79);
            this.txtEquityAmount.Name = "txtEquityAmount";
            this.txtEquityAmount.Size = new System.Drawing.Size(144, 22);
            this.txtEquityAmount.TabIndex = 6;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(219, 105);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 20);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Invest";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rbtnBorrowingEquity
            // 
            this.rbtnBorrowingEquity.AutoSize = true;
            this.rbtnBorrowingEquity.Location = new System.Drawing.Point(128, 104);
            this.rbtnBorrowingEquity.Name = "rbtnBorrowingEquity";
            this.rbtnBorrowingEquity.Size = new System.Drawing.Size(63, 20);
            this.rbtnBorrowingEquity.TabIndex = 4;
            this.rbtnBorrowingEquity.TabStop = true;
            this.rbtnBorrowingEquity.Text = "Borrow";
            this.rbtnBorrowingEquity.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nature";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // EquityControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EquityGroupBox);
            this.Name = "EquityControl";
            this.Size = new System.Drawing.Size(912, 429);
            this.EquityGroupBox.ResumeLayout(false);
            this.EquityGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EquityGroupBox;
        private System.Windows.Forms.DateTimePicker dateEquity;
        private System.Windows.Forms.DataGridView dgvEquity;
        private System.Windows.Forms.ComboBox cmbEquityType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEquityAmount;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbtnBorrowingEquity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button buttonSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellingPrice;
    }
}
