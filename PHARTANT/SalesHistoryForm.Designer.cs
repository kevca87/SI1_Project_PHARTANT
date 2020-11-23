namespace PHARTANT
{
    partial class SalesHistoryForm
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
            this.dgvSalesHistory = new System.Windows.Forms.DataGridView();
            this.cbxSales = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSalesHistory
            // 
            this.dgvSalesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesHistory.Location = new System.Drawing.Point(40, 87);
            this.dgvSalesHistory.Name = "dgvSalesHistory";
            this.dgvSalesHistory.Size = new System.Drawing.Size(488, 338);
            this.dgvSalesHistory.TabIndex = 0;
            // 
            // cbxSales
            // 
            this.cbxSales.FormattingEnabled = true;
            this.cbxSales.Location = new System.Drawing.Point(89, 31);
            this.cbxSales.Name = "cbxSales";
            this.cbxSales.Size = new System.Drawing.Size(396, 21);
            this.cbxSales.TabIndex = 1;
            // 
            // SalesHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 465);
            this.Controls.Add(this.cbxSales);
            this.Controls.Add(this.dgvSalesHistory);
            this.Name = "SalesHistoryForm";
            this.Text = "Historial de ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSalesHistory;
        private System.Windows.Forms.ComboBox cbxSales;
    }
}