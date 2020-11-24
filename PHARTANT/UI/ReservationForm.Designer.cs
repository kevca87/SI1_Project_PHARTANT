namespace PHARTANT
{
    partial class ReservationForm
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
            this.dgvPendingReservation = new System.Windows.Forms.DataGridView();
            this.dgvReservationHistory = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingReservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPendingReservation
            // 
            this.dgvPendingReservation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvPendingReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendingReservation.Location = new System.Drawing.Point(16, 132);
            this.dgvPendingReservation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPendingReservation.Name = "dgvPendingReservation";
            this.dgvPendingReservation.RowHeadersWidth = 51;
            this.dgvPendingReservation.Size = new System.Drawing.Size(436, 325);
            this.dgvPendingReservation.TabIndex = 0;
            // 
            // dgvReservationHistory
            // 
            this.dgvReservationHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvReservationHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservationHistory.Location = new System.Drawing.Point(505, 132);
            this.dgvReservationHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvReservationHistory.Name = "dgvReservationHistory";
            this.dgvReservationHistory.RowHeadersWidth = 51;
            this.dgvReservationHistory.Size = new System.Drawing.Size(445, 325);
            this.dgvReservationHistory.TabIndex = 1;
            this.dgvReservationHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservationHistory_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reservas pendientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(573, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Historial de reservas\r\n";
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(967, 506);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReservationHistory);
            this.Controls.Add(this.dgvPendingReservation);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReservationForm";
            this.Text = "Reservas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingReservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPendingReservation;
        private System.Windows.Forms.DataGridView dgvReservationHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}