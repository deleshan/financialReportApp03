namespace financialReportApp03
{
    partial class SalesControl
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
            this.debtorGroupBox = new System.Windows.Forms.GroupBox();
            this.lblDebtorName = new System.Windows.Forms.Label();
            this.txtDebtorName = new System.Windows.Forms.TextBox();
            this.txtDebtorAddress = new System.Windows.Forms.TextBox();
            this.lblDebtorAddress = new System.Windows.Forms.Label();
            this.lblDebtorPhone = new System.Windows.Forms.Label();
            this.txtDebtorPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalSale = new System.Windows.Forms.TextBox();
            this.rbtnCreditSale = new System.Windows.Forms.RadioButton();
            this.rbtnCashSale = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpSaleDate = new System.Windows.Forms.DateTimePicker();
            this.buttonSales = new System.Windows.Forms.Button();
            this.dgvSaleProducts = new System.Windows.Forms.DataGridView();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesGroupBox = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.debtorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleProducts)).BeginInit();
            this.SalesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // debtorGroupBox
            // 
            this.debtorGroupBox.Controls.Add(this.lblDebtorName);
            this.debtorGroupBox.Controls.Add(this.txtDebtorName);
            this.debtorGroupBox.Controls.Add(this.txtDebtorAddress);
            this.debtorGroupBox.Controls.Add(this.lblDebtorAddress);
            this.debtorGroupBox.Controls.Add(this.lblDebtorPhone);
            this.debtorGroupBox.Controls.Add(this.txtDebtorPhone);
            this.debtorGroupBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtorGroupBox.Location = new System.Drawing.Point(303, 33);
            this.debtorGroupBox.Name = "debtorGroupBox";
            this.debtorGroupBox.Size = new System.Drawing.Size(399, 161);
            this.debtorGroupBox.TabIndex = 2;
            this.debtorGroupBox.TabStop = false;
            this.debtorGroupBox.Text = "Debtors Details";
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
            // txtDebtorAddress
            // 
            this.txtDebtorAddress.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebtorAddress.Location = new System.Drawing.Point(123, 55);
            this.txtDebtorAddress.Multiline = true;
            this.txtDebtorAddress.Name = "txtDebtorAddress";
            this.txtDebtorAddress.Size = new System.Drawing.Size(256, 54);
            this.txtDebtorAddress.TabIndex = 12;
            // 
            // lblDebtorAddress
            // 
            this.lblDebtorAddress.AutoSize = true;
            this.lblDebtorAddress.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebtorAddress.Location = new System.Drawing.Point(23, 58);
            this.lblDebtorAddress.Name = "lblDebtorAddress";
            this.lblDebtorAddress.Size = new System.Drawing.Size(50, 16);
            this.lblDebtorAddress.TabIndex = 9;
            this.lblDebtorAddress.Text = "Address";
            // 
            // lblDebtorPhone
            // 
            this.lblDebtorPhone.AutoSize = true;
            this.lblDebtorPhone.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebtorPhone.Location = new System.Drawing.Point(23, 131);
            this.lblDebtorPhone.Name = "lblDebtorPhone";
            this.lblDebtorPhone.Size = new System.Drawing.Size(85, 16);
            this.lblDebtorPhone.TabIndex = 10;
            this.lblDebtorPhone.Text = "Phone Number";
            // 
            // txtDebtorPhone
            // 
            this.txtDebtorPhone.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebtorPhone.Location = new System.Drawing.Point(123, 128);
            this.txtDebtorPhone.Name = "txtDebtorPhone";
            this.txtDebtorPhone.Size = new System.Drawing.Size(256, 22);
            this.txtDebtorPhone.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Description";
            // 
            // txtTotalSale
            // 
            this.txtTotalSale.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSale.Location = new System.Drawing.Point(127, 79);
            this.txtTotalSale.Name = "txtTotalSale";
            this.txtTotalSale.Size = new System.Drawing.Size(144, 22);
            this.txtTotalSale.TabIndex = 6;
            // 
            // rbtnCreditSale
            // 
            this.rbtnCreditSale.AutoSize = true;
            this.rbtnCreditSale.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCreditSale.Location = new System.Drawing.Point(219, 115);
            this.rbtnCreditSale.Name = "rbtnCreditSale";
            this.rbtnCreditSale.Size = new System.Drawing.Size(57, 20);
            this.rbtnCreditSale.TabIndex = 5;
            this.rbtnCreditSale.TabStop = true;
            this.rbtnCreditSale.Text = "Credit";
            this.rbtnCreditSale.UseVisualStyleBackColor = true;
            this.rbtnCreditSale.CheckedChanged += new System.EventHandler(this.rbtnCreditSale_CheckedChanged);
            // 
            // rbtnCashSale
            // 
            this.rbtnCashSale.AutoSize = true;
            this.rbtnCashSale.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCashSale.Location = new System.Drawing.Point(127, 115);
            this.rbtnCashSale.Name = "rbtnCashSale";
            this.rbtnCashSale.Size = new System.Drawing.Size(52, 20);
            this.rbtnCashSale.TabIndex = 4;
            this.rbtnCashSale.TabStop = true;
            this.rbtnCashSale.Text = "Cash";
            this.rbtnCashSale.UseVisualStyleBackColor = true;
            this.rbtnCashSale.CheckedChanged += new System.EventHandler(this.rbtnCashSale_CheckedChanged);
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
            // dtpSaleDate
            // 
            this.dtpSaleDate.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSaleDate.Location = new System.Drawing.Point(35, 39);
            this.dtpSaleDate.Name = "dtpSaleDate";
            this.dtpSaleDate.Size = new System.Drawing.Size(236, 22);
            this.dtpSaleDate.TabIndex = 20;
            // 
            // buttonSales
            // 
            this.buttonSales.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSales.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSales.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSales.Location = new System.Drawing.Point(547, 331);
            this.buttonSales.Name = "buttonSales";
            this.buttonSales.Size = new System.Drawing.Size(134, 27);
            this.buttonSales.TabIndex = 19;
            this.buttonSales.Text = "Submit";
            this.buttonSales.UseVisualStyleBackColor = false;
            this.buttonSales.Click += new System.EventHandler(this.buttonSales_Click);
            // 
            // dgvSaleProducts
            // 
            this.dgvSaleProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSaleProducts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSaleProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSaleProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Quantity,
            this.Description,
            this.InventoryId,
            this.costPrice,
            this.SellingPrice});
            this.dgvSaleProducts.Location = new System.Drawing.Point(138, 211);
            this.dgvSaleProducts.Name = "dgvSaleProducts";
            this.dgvSaleProducts.Size = new System.Drawing.Size(543, 94);
            this.dgvSaleProducts.TabIndex = 15;
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
            // InventoryId
            // 
            this.InventoryId.HeaderText = "InventoryId";
            this.InventoryId.Name = "InventoryId";
            // 
            // costPrice
            // 
            this.costPrice.HeaderText = "Cost Price ";
            this.costPrice.Name = "costPrice";
            // 
            // SellingPrice
            // 
            this.SellingPrice.HeaderText = "Selling Price";
            this.SellingPrice.Name = "SellingPrice";
            // 
            // SalesGroupBox
            // 
            this.SalesGroupBox.Controls.Add(this.btnClear);
            this.SalesGroupBox.Controls.Add(this.dtpSaleDate);
            this.SalesGroupBox.Controls.Add(this.buttonSales);
            this.SalesGroupBox.Controls.Add(this.dgvSaleProducts);
            this.SalesGroupBox.Controls.Add(this.debtorGroupBox);
            this.SalesGroupBox.Controls.Add(this.label7);
            this.SalesGroupBox.Controls.Add(this.txtTotalSale);
            this.SalesGroupBox.Controls.Add(this.rbtnCreditSale);
            this.SalesGroupBox.Controls.Add(this.rbtnCashSale);
            this.SalesGroupBox.Controls.Add(this.label2);
            this.SalesGroupBox.Controls.Add(this.label1);
            this.SalesGroupBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesGroupBox.Location = new System.Drawing.Point(146, 12);
            this.SalesGroupBox.Name = "SalesGroupBox";
            this.SalesGroupBox.Size = new System.Drawing.Size(721, 388);
            this.SalesGroupBox.TabIndex = 3;
            this.SalesGroupBox.TabStop = false;
            this.SalesGroupBox.Text = "Sales Details";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(391, 331);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 27);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // SalesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SalesGroupBox);
            this.Name = "SalesControl";
            this.Size = new System.Drawing.Size(870, 422);
            this.debtorGroupBox.ResumeLayout(false);
            this.debtorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleProducts)).EndInit();
            this.SalesGroupBox.ResumeLayout(false);
            this.SalesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox debtorGroupBox;
        private System.Windows.Forms.Label lblDebtorName;
        private System.Windows.Forms.TextBox txtDebtorName;
        private System.Windows.Forms.TextBox txtDebtorAddress;
        private System.Windows.Forms.Label lblDebtorAddress;
        private System.Windows.Forms.Label lblDebtorPhone;
        private System.Windows.Forms.TextBox txtDebtorPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalSale;
        private System.Windows.Forms.RadioButton rbtnCreditSale;
        private System.Windows.Forms.RadioButton rbtnCashSale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpSaleDate;
        private System.Windows.Forms.Button buttonSales;
        private System.Windows.Forms.DataGridView dgvSaleProducts;
        private System.Windows.Forms.GroupBox SalesGroupBox;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellingPrice;
    }
}
