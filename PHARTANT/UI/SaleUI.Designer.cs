namespace PHARTANT.UI
{
    partial class SaleUI
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
            this.dgSale = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgSale)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSale
            // 
            this.dgSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSale.Location = new System.Drawing.Point(60, 40);
            this.dgSale.Name = "dgSale";
            this.dgSale.RowHeadersWidth = 51;
            this.dgSale.RowTemplate.Height = 24;
            this.dgSale.Size = new System.Drawing.Size(680, 370);
            this.dgSale.TabIndex = 1;
            // 
            // SaleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgSale);
            this.Name = "SaleUI";
            this.Text = "SaleUI";
            this.Load += new System.EventHandler(this.SaleUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSale;
    }
}