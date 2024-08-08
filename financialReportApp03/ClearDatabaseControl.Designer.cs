namespace financialReportApp03
{
    partial class ClearDatabaseControl
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
            this.buttonClearDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClearDB
            // 
            this.buttonClearDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonClearDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonClearDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearDB.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearDB.Location = new System.Drawing.Point(59, 37);
            this.buttonClearDB.Name = "buttonClearDB";
            this.buttonClearDB.Size = new System.Drawing.Size(313, 43);
            this.buttonClearDB.TabIndex = 0;
            this.buttonClearDB.Text = "Clear All Data from Database";
            this.buttonClearDB.UseVisualStyleBackColor = false;
            this.buttonClearDB.Click += new System.EventHandler(this.buttonClearDB_Click);
            // 
            // ClearDatabaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.buttonClearDB);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "ClearDatabaseControl";
            this.Size = new System.Drawing.Size(563, 177);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClearDB;
    }
}
