namespace financialReportApp03
{
    partial class PurchaseControl
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSales = new System.Windows.Forms.Button();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.dgvPurchaseProducts = new System.Windows.Forms.DataGridView();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxCreditors = new System.Windows.Forms.GroupBox();
            this.lblCreditorName = new System.Windows.Forms.Label();
            this.txtCreditorName = new System.Windows.Forms.TextBox();
            this.txtCreditorAddress = new System.Windows.Forms.TextBox();
            this.lblCreditorAddress = new System.Windows.Forms.Label();
            this.lblCreditorPhone = new System.Windows.Forms.Label();
            this.txtCreditorPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalPurchase = new System.Windows.Forms.TextBox();
            this.rbtnCreditPurchase = new System.Windows.Forms.RadioButton();
            this.rbtnCashPurchase = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SalesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseProducts)).BeginInit();
            this.groupBoxCreditors.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalesGroupBox
            // 
            this.SalesGroupBox.Controls.Add(this.button1);
            this.SalesGroupBox.Controls.Add(this.buttonSales);
            this.SalesGroupBox.Controls.Add(this.dtpPurchaseDate);
            this.SalesGroupBox.Controls.Add(this.dgvPurchaseProducts);
            this.SalesGroupBox.Controls.Add(this.groupBoxCreditors);
            this.SalesGroupBox.Controls.Add(this.label7);
            this.SalesGroupBox.Controls.Add(this.txtTotalPurchase);
            this.SalesGroupBox.Controls.Add(this.rbtnCreditPurchase);
            this.SalesGroupBox.Controls.Add(this.rbtnCashPurchase);
            this.SalesGroupBox.Controls.Add(this.label2);
            this.SalesGroupBox.Controls.Add(this.label1);
            this.SalesGroupBox.Location = new System.Drawing.Point(100, 20);
            this.SalesGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.SalesGroupBox.Name = "SalesGroupBox";
            this.SalesGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.SalesGroupBox.Size = new System.Drawing.Size(842, 478);
            this.SalesGroupBox.TabIndex = 4;
            this.SalesGroupBox.TabStop = false;
            this.SalesGroupBox.Text = "Purchase Details";
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
            this.buttonSales.Click += new System.EventHandler(this.buttonSales_Click);
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.Location = new System.Drawing.Point(38, 37);
            this.dtpPurchaseDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(288, 22);
            this.dtpPurchaseDate.TabIndex = 20;
            // 
            // dgvPurchaseProducts
            // 
            this.dgvPurchaseProducts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPurchaseProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Quantity,
            this.Description,
            this.InventoryId,
            this.CostPrice,
            this.SellingPrice});
            this.dgvPurchaseProducts.Location = new System.Drawing.Point(145, 244);
            this.dgvPurchaseProducts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPurchaseProducts.Name = "dgvPurchaseProducts";
            this.dgvPurchaseProducts.Size = new System.Drawing.Size(545, 116);
            this.dgvPurchaseProducts.TabIndex = 4;
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
            this.InventoryId.HeaderText = "Inventory Id";
            this.InventoryId.Name = "InventoryId";
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
            // groupBoxCreditors
            // 
            this.groupBoxCreditors.Controls.Add(this.lblCreditorName);
            this.groupBoxCreditors.Controls.Add(this.txtCreditorName);
            this.groupBoxCreditors.Controls.Add(this.txtCreditorAddress);
            this.groupBoxCreditors.Controls.Add(this.lblCreditorAddress);
            this.groupBoxCreditors.Controls.Add(this.lblCreditorPhone);
            this.groupBoxCreditors.Controls.Add(this.txtCreditorPhone);
            this.groupBoxCreditors.Location = new System.Drawing.Point(356, 38);
            this.groupBoxCreditors.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCreditors.Name = "groupBoxCreditors";
            this.groupBoxCreditors.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCreditors.Size = new System.Drawing.Size(465, 198);
            this.groupBoxCreditors.TabIndex = 2;
            this.groupBoxCreditors.TabStop = false;
            this.groupBoxCreditors.Text = "Creditors Details";
            // 
            // lblCreditorName
            // 
            this.lblCreditorName.AutoSize = true;
            this.lblCreditorName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditorName.Location = new System.Drawing.Point(27, 28);
            this.lblCreditorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreditorName.Name = "lblCreditorName";
            this.lblCreditorName.Size = new System.Drawing.Size(36, 16);
            this.lblCreditorName.TabIndex = 8;
            this.lblCreditorName.Text = "Name";
            // 
            // txtCreditorName
            // 
            this.txtCreditorName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditorName.Location = new System.Drawing.Point(144, 23);
            this.txtCreditorName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreditorName.Name = "txtCreditorName";
            this.txtCreditorName.Size = new System.Drawing.Size(297, 22);
            this.txtCreditorName.TabIndex = 11;
            // 
            // txtCreditorAddress
            // 
            this.txtCreditorAddress.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditorAddress.Location = new System.Drawing.Point(144, 68);
            this.txtCreditorAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreditorAddress.Multiline = true;
            this.txtCreditorAddress.Name = "txtCreditorAddress";
            this.txtCreditorAddress.Size = new System.Drawing.Size(298, 66);
            this.txtCreditorAddress.TabIndex = 12;
            // 
            // lblCreditorAddress
            // 
            this.lblCreditorAddress.AutoSize = true;
            this.lblCreditorAddress.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditorAddress.Location = new System.Drawing.Point(27, 71);
            this.lblCreditorAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreditorAddress.Name = "lblCreditorAddress";
            this.lblCreditorAddress.Size = new System.Drawing.Size(50, 16);
            this.lblCreditorAddress.TabIndex = 9;
            this.lblCreditorAddress.Text = "Address";
            // 
            // lblCreditorPhone
            // 
            this.lblCreditorPhone.AutoSize = true;
            this.lblCreditorPhone.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditorPhone.Location = new System.Drawing.Point(27, 161);
            this.lblCreditorPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreditorPhone.Name = "lblCreditorPhone";
            this.lblCreditorPhone.Size = new System.Drawing.Size(85, 16);
            this.lblCreditorPhone.TabIndex = 10;
            this.lblCreditorPhone.Text = "Phone Number";
            // 
            // txtCreditorPhone
            // 
            this.txtCreditorPhone.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditorPhone.Location = new System.Drawing.Point(144, 158);
            this.txtCreditorPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreditorPhone.Name = "txtCreditorPhone";
            this.txtCreditorPhone.Size = new System.Drawing.Size(298, 22);
            this.txtCreditorPhone.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 244);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Description";
            // 
            // txtTotalPurchase
            // 
            this.txtTotalPurchase.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPurchase.Location = new System.Drawing.Point(145, 81);
            this.txtTotalPurchase.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalPurchase.Name = "txtTotalPurchase";
            this.txtTotalPurchase.Size = new System.Drawing.Size(181, 22);
            this.txtTotalPurchase.TabIndex = 6;
            // 
            // rbtnCreditPurchase
            // 
            this.rbtnCreditPurchase.AutoSize = true;
            this.rbtnCreditPurchase.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCreditPurchase.Location = new System.Drawing.Point(245, 122);
            this.rbtnCreditPurchase.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnCreditPurchase.Name = "rbtnCreditPurchase";
            this.rbtnCreditPurchase.Size = new System.Drawing.Size(57, 20);
            this.rbtnCreditPurchase.TabIndex = 5;
            this.rbtnCreditPurchase.TabStop = true;
            this.rbtnCreditPurchase.Text = "Credit";
            this.rbtnCreditPurchase.UseVisualStyleBackColor = true;
            this.rbtnCreditPurchase.CheckedChanged += new System.EventHandler(this.rbtnCreditPurchase_CheckedChanged);
            // 
            // rbtnCashPurchase
            // 
            this.rbtnCashPurchase.AutoSize = true;
            this.rbtnCashPurchase.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCashPurchase.Location = new System.Drawing.Point(145, 121);
            this.rbtnCashPurchase.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnCashPurchase.Name = "rbtnCashPurchase";
            this.rbtnCashPurchase.Size = new System.Drawing.Size(52, 20);
            this.rbtnCashPurchase.TabIndex = 4;
            this.rbtnCashPurchase.TabStop = true;
            this.rbtnCashPurchase.Text = "Cash";
            this.rbtnCashPurchase.UseVisualStyleBackColor = true;
            this.rbtnCashPurchase.CheckedChanged += new System.EventHandler(this.rbtnCashPurchase_CheckedChanged);
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
            // PurchaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SalesGroupBox);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PurchaseControl";
            this.Size = new System.Drawing.Size(959, 514);
            this.SalesGroupBox.ResumeLayout(false);
            this.SalesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseProducts)).EndInit();
            this.groupBoxCreditors.ResumeLayout(false);
            this.groupBoxCreditors.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SalesGroupBox;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.DataGridView dgvPurchaseProducts;
        private System.Windows.Forms.GroupBox groupBoxCreditors;
        private System.Windows.Forms.Label lblCreditorName;
        private System.Windows.Forms.TextBox txtCreditorName;
        private System.Windows.Forms.TextBox txtCreditorAddress;
        private System.Windows.Forms.Label lblCreditorAddress;
        private System.Windows.Forms.Label lblCreditorPhone;
        private System.Windows.Forms.TextBox txtCreditorPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalPurchase;
        private System.Windows.Forms.RadioButton rbtnCreditPurchase;
        private System.Windows.Forms.RadioButton rbtnCashPurchase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellingPrice;
    }
}
