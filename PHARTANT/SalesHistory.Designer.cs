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
            this.tbxSalesHistory = new System.Windows.Forms.TextBox();
            this.btnSaleDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSalesHistory
            // 
            this.dgvSalesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesHistory.Location = new System.Drawing.Point(47, 77);
            this.dgvSalesHistory.Name = "dgvSalesHistory";
            this.dgvSalesHistory.Size = new System.Drawing.Size(526, 364);
            this.dgvSalesHistory.TabIndex = 0;
            // 
            // tbxSalesHistory
            // 
            this.tbxSalesHistory.Location = new System.Drawing.Point(29, 23);
            this.tbxSalesHistory.Multiline = true;
            this.tbxSalesHistory.Name = "tbxSalesHistory";
            this.tbxSalesHistory.Size = new System.Drawing.Size(544, 30);
            this.tbxSalesHistory.TabIndex = 1;
            // 
            // btnSaleDetail
            // 
            this.btnSaleDetail.Location = new System.Drawing.Point(601, 118);
            this.btnSaleDetail.Name = "btnSaleDetail";
            this.btnSaleDetail.Size = new System.Drawing.Size(96, 80);
            this.btnSaleDetail.TabIndex = 2;
            this.btnSaleDetail.Text = "VER DETALLE \r\nDE LA VENTA";
            this.btnSaleDetail.UseVisualStyleBackColor = true;
            // 
            // SalesHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(741, 490);
            this.Controls.Add(this.btnSaleDetail);
            this.Controls.Add(this.tbxSalesHistory);
            this.Controls.Add(this.dgvSalesHistory);
            this.Name = "SalesHistoryForm";
            this.Text = "Historial de ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSalesHistory;
        private System.Windows.Forms.TextBox tbxSalesHistory;
        private System.Windows.Forms.Button btnSaleDetail;
    }
}