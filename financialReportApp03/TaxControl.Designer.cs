namespace financialReportApp03
{
    partial class TaxControl
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
            this.TexGroupBox = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.buttonSales = new System.Windows.Forms.Button();
            this.dateTax = new System.Windows.Forms.DateTimePicker();
            this.comboTypeTax = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaxAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TexGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TexGroupBox
            // 
            this.TexGroupBox.Controls.Add(this.btnClear);
            this.TexGroupBox.Controls.Add(this.buttonSales);
            this.TexGroupBox.Controls.Add(this.dateTax);
            this.TexGroupBox.Controls.Add(this.comboTypeTax);
            this.TexGroupBox.Controls.Add(this.label3);
            this.TexGroupBox.Controls.Add(this.txtTaxAmount);
            this.TexGroupBox.Controls.Add(this.label1);
            this.TexGroupBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexGroupBox.Location = new System.Drawing.Point(181, 13);
            this.TexGroupBox.Name = "TexGroupBox";
            this.TexGroupBox.Size = new System.Drawing.Size(300, 247);
            this.TexGroupBox.TabIndex = 6;
            this.TexGroupBox.TabStop = false;
            this.TexGroupBox.Text = "Tax Details";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(36, 193);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 27);
            this.btnClear.TabIndex = 24;
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
            this.buttonSales.Location = new System.Drawing.Point(161, 193);
            this.buttonSales.Name = "buttonSales";
            this.buttonSales.Size = new System.Drawing.Size(111, 27);
            this.buttonSales.TabIndex = 23;
            this.buttonSales.Text = "Submit";
            this.buttonSales.UseVisualStyleBackColor = false;
            this.buttonSales.Click += new System.EventHandler(this.buttonSales_Click);
            // 
            // dateTax
            // 
            this.dateTax.Location = new System.Drawing.Point(36, 37);
            this.dateTax.Name = "dateTax";
            this.dateTax.Size = new System.Drawing.Size(235, 22);
            this.dateTax.TabIndex = 22;
            // 
            // comboTypeTax
            // 
            this.comboTypeTax.FormattingEnabled = true;
            this.comboTypeTax.Location = new System.Drawing.Point(127, 123);
            this.comboTypeTax.Name = "comboTypeTax";
            this.comboTypeTax.Size = new System.Drawing.Size(145, 24);
            this.comboTypeTax.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Type";
            // 
            // txtTaxAmount
            // 
            this.txtTaxAmount.Location = new System.Drawing.Point(127, 76);
            this.txtTaxAmount.Name = "txtTaxAmount";
            this.txtTaxAmount.Size = new System.Drawing.Size(144, 22);
            this.txtTaxAmount.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // TaxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TexGroupBox);
            this.Name = "TaxControl";
            this.Size = new System.Drawing.Size(638, 280);
            this.TexGroupBox.ResumeLayout(false);
            this.TexGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TexGroupBox;
        private System.Windows.Forms.DateTimePicker dateTax;
        private System.Windows.Forms.ComboBox comboTypeTax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTaxAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button buttonSales;
    }
}
