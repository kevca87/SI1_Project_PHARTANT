namespace PHARTANT
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnUpdateInventory = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnPendingReservation = new System.Windows.Forms.Button();
            this.btnSalesHistory = new System.Windows.Forms.Button();
            this.btnNewReservatio = new System.Windows.Forms.Button();
            this.btnCheckInventory = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.S = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.NN = new System.Windows.Forms.Button();
            this.btnNewSale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateInventory
            // 
            this.btnUpdateInventory.Location = new System.Drawing.Point(630, 324);
            this.btnUpdateInventory.Name = "btnUpdateInventory";
            this.btnUpdateInventory.Size = new System.Drawing.Size(109, 104);
            this.btnUpdateInventory.TabIndex = 0;
            this.btnUpdateInventory.Text = "ACTUALIZAR INVENTARIO";
            this.btnUpdateInventory.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(326, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 68);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnPendingReservation
            // 
            this.btnPendingReservation.Location = new System.Drawing.Point(462, 324);
            this.btnPendingReservation.Name = "btnPendingReservation";
            this.btnPendingReservation.Size = new System.Drawing.Size(113, 104);
            this.btnPendingReservation.TabIndex = 4;
            this.btnPendingReservation.Text = "RESERVAS PENDIENTES";
            this.btnPendingReservation.UseVisualStyleBackColor = true;
            // 
            // btnSalesHistory
            // 
            this.btnSalesHistory.Location = new System.Drawing.Point(288, 188);
            this.btnSalesHistory.Name = "btnSalesHistory";
            this.btnSalesHistory.Size = new System.Drawing.Size(113, 107);
            this.btnSalesHistory.TabIndex = 5;
            this.btnSalesHistory.Text = "HISTORIAL DE VENTAS";
            this.btnSalesHistory.UseVisualStyleBackColor = true;
            // 
            // btnNewReservatio
            // 
            this.btnNewReservatio.Location = new System.Drawing.Point(462, 187);
            this.btnNewReservatio.Name = "btnNewReservatio";
            this.btnNewReservatio.Size = new System.Drawing.Size(113, 108);
            this.btnNewReservatio.TabIndex = 6;
            this.btnNewReservatio.Text = "NUEVA RESERVA";
            this.btnNewReservatio.UseVisualStyleBackColor = true;
            // 
            // btnCheckInventory
            // 
            this.btnCheckInventory.Location = new System.Drawing.Point(630, 188);
            this.btnCheckInventory.Name = "btnCheckInventory";
            this.btnCheckInventory.Size = new System.Drawing.Size(109, 107);
            this.btnCheckInventory.TabIndex = 7;
            this.btnCheckInventory.Text = "CONSULTAR INVENTARIO";
            this.btnCheckInventory.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(593, 44);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(122, 46);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "FARMA\r\nPLUS+\r\n";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(205, 485);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // S
            // 
            this.S.Location = new System.Drawing.Point(52, 208);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(113, 31);
            this.S.TabIndex = 11;
            this.S.Text = "VENTAS";
            this.S.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(52, 264);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(113, 31);
            this.button9.TabIndex = 12;
            this.button9.Text = "RESERVAS";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(52, 324);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(113, 31);
            this.button10.TabIndex = 13;
            this.button10.Text = "ESTADISTICAS";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // NN
            // 
            this.NN.Location = new System.Drawing.Point(52, 151);
            this.NN.Name = "NN";
            this.NN.Size = new System.Drawing.Size(113, 31);
            this.NN.TabIndex = 14;
            this.NN.Text = "INVENTARIO";
            this.NN.UseVisualStyleBackColor = true;
            // 
            // btnNewSale
            // 
            this.btnNewSale.Location = new System.Drawing.Point(40, 34);
            this.btnNewSale.Name = "btnNewSale";
            this.btnNewSale.Size = new System.Drawing.Size(140, 49);
            this.btnNewSale.TabIndex = 15;
            this.btnNewSale.Text = "NUEVA VENTA";
            this.btnNewSale.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(782, 485);
            this.Controls.Add(this.btnNewSale);
            this.Controls.Add(this.NN);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.S);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCheckInventory);
            this.Controls.Add(this.btnNewReservatio);
            this.Controls.Add(this.btnSalesHistory);
            this.Controls.Add(this.btnPendingReservation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUpdateInventory);
            this.Controls.Add(this.splitter1);
            this.Name = "MainForm";
            this.Text = "Farmaplus";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateInventory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnPendingReservation;
        private System.Windows.Forms.Button btnSalesHistory;
        private System.Windows.Forms.Button btnNewReservatio;
        private System.Windows.Forms.Button btnCheckInventory;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button S;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button NN;
        private System.Windows.Forms.Button btnNewSale;
    }
}

