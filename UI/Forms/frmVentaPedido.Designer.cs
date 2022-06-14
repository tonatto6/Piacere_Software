
namespace UI.Forms
{
    partial class frmVentaPedido
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRecargoPesos = new System.Windows.Forms.TextBox();
            this.txtDescuentoPesos = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumeroVenta = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboMetodoPago = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblPrecioActualProducto = new System.Windows.Forms.Label();
            this.lblPrecioActualPicada = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCambiarPrecioPicada = new System.Windows.Forms.Button();
            this.btnCambiarPrecioProducto = new System.Windows.Forms.Button();
            this.grdPicadas = new System.Windows.Forms.DataGridView();
            this.grdProductos = new System.Windows.Forms.DataGridView();
            this.btnFinalizarVenta = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPicadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 427);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion pedido";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblMontoTotal);
            this.groupBox5.Controls.Add(this.lblSubTotal);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(282, 212);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(249, 149);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Location = new System.Drawing.Point(142, 90);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(18, 20);
            this.lblMontoTotal.TabIndex = 15;
            this.lblMontoTotal.Text = "0";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(142, 31);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(18, 20);
            this.lblSubTotal.TabIndex = 14;
            this.lblSubTotal.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Subtotal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Monto total";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtRecargoPesos);
            this.groupBox4.Controls.Add(this.txtDescuentoPesos);
            this.groupBox4.Location = new System.Drawing.Point(282, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(249, 148);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Recargo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Descuento";
            // 
            // txtRecargoPesos
            // 
            this.txtRecargoPesos.Location = new System.Drawing.Point(119, 71);
            this.txtRecargoPesos.Name = "txtRecargoPesos";
            this.txtRecargoPesos.Size = new System.Drawing.Size(124, 26);
            this.txtRecargoPesos.TabIndex = 9;
            this.txtRecargoPesos.Text = "0";
            this.txtRecargoPesos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRecargoPesos_KeyUp);
            // 
            // txtDescuentoPesos
            // 
            this.txtDescuentoPesos.Location = new System.Drawing.Point(119, 25);
            this.txtDescuentoPesos.Name = "txtDescuentoPesos";
            this.txtDescuentoPesos.Size = new System.Drawing.Size(124, 26);
            this.txtDescuentoPesos.TabIndex = 3;
            this.txtDescuentoPesos.Text = "0";
            this.txtDescuentoPesos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDescuentoPesos_KeyUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblNumeroVenta);
            this.groupBox2.Controls.Add(this.lblCliente);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 146);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de venta";
            // 
            // lblNumeroVenta
            // 
            this.lblNumeroVenta.AutoSize = true;
            this.lblNumeroVenta.Location = new System.Drawing.Point(156, 22);
            this.lblNumeroVenta.Name = "lblNumeroVenta";
            this.lblNumeroVenta.Size = new System.Drawing.Size(14, 20);
            this.lblNumeroVenta.TabIndex = 2;
            this.lblNumeroVenta.Text = "-";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(6, 94);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(14, 20);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cliente";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboMetodoPago);
            this.groupBox3.Location = new System.Drawing.Point(6, 212);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 149);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Metodo pago";
            // 
            // cboMetodoPago
            // 
            this.cboMetodoPago.FormattingEnabled = true;
            this.cboMetodoPago.Location = new System.Drawing.Point(10, 51);
            this.cboMetodoPago.Name = "cboMetodoPago";
            this.cboMetodoPago.Size = new System.Drawing.Size(214, 28);
            this.cboMetodoPago.TabIndex = 7;
            this.cboMetodoPago.Text = "Seleccionar";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblPrecioActualProducto);
            this.groupBox6.Controls.Add(this.lblPrecioActualPicada);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.btnCambiarPrecioPicada);
            this.groupBox6.Controls.Add(this.btnCambiarPrecioProducto);
            this.groupBox6.Controls.Add(this.grdPicadas);
            this.groupBox6.Controls.Add(this.grdProductos);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox6.Location = new System.Drawing.Point(551, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(501, 550);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Productos";
            // 
            // lblPrecioActualProducto
            // 
            this.lblPrecioActualProducto.AutoSize = true;
            this.lblPrecioActualProducto.Location = new System.Drawing.Point(134, 194);
            this.lblPrecioActualProducto.Name = "lblPrecioActualProducto";
            this.lblPrecioActualProducto.Size = new System.Drawing.Size(14, 20);
            this.lblPrecioActualProducto.TabIndex = 13;
            this.lblPrecioActualProducto.Text = "-";
            // 
            // lblPrecioActualPicada
            // 
            this.lblPrecioActualPicada.AutoSize = true;
            this.lblPrecioActualPicada.Location = new System.Drawing.Point(134, 457);
            this.lblPrecioActualPicada.Name = "lblPrecioActualPicada";
            this.lblPrecioActualPicada.Size = new System.Drawing.Size(14, 20);
            this.lblPrecioActualPicada.TabIndex = 12;
            this.lblPrecioActualPicada.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Precio actual:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Precio actual:";
            // 
            // btnCambiarPrecioPicada
            // 
            this.btnCambiarPrecioPicada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnCambiarPrecioPicada.FlatAppearance.BorderSize = 0;
            this.btnCambiarPrecioPicada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarPrecioPicada.ForeColor = System.Drawing.Color.White;
            this.btnCambiarPrecioPicada.Location = new System.Drawing.Point(231, 498);
            this.btnCambiarPrecioPicada.Name = "btnCambiarPrecioPicada";
            this.btnCambiarPrecioPicada.Size = new System.Drawing.Size(264, 35);
            this.btnCambiarPrecioPicada.TabIndex = 10;
            this.btnCambiarPrecioPicada.Text = "CAMBIAR A PRECIO ACTUAL";
            this.btnCambiarPrecioPicada.UseVisualStyleBackColor = false;
            this.btnCambiarPrecioPicada.Click += new System.EventHandler(this.btnCambiarPrecioPicada_Click);
            // 
            // btnCambiarPrecioProducto
            // 
            this.btnCambiarPrecioProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnCambiarPrecioProducto.FlatAppearance.BorderSize = 0;
            this.btnCambiarPrecioProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarPrecioProducto.ForeColor = System.Drawing.Color.White;
            this.btnCambiarPrecioProducto.Location = new System.Drawing.Point(231, 228);
            this.btnCambiarPrecioProducto.Name = "btnCambiarPrecioProducto";
            this.btnCambiarPrecioProducto.Size = new System.Drawing.Size(264, 35);
            this.btnCambiarPrecioProducto.TabIndex = 9;
            this.btnCambiarPrecioProducto.Text = "CAMBIAR A PRECIO ACTUAL";
            this.btnCambiarPrecioProducto.UseVisualStyleBackColor = false;
            this.btnCambiarPrecioProducto.Click += new System.EventHandler(this.btnCambiarPrecioProducto_Click);
            // 
            // grdPicadas
            // 
            this.grdPicadas.AllowUserToAddRows = false;
            this.grdPicadas.AllowUserToDeleteRows = false;
            this.grdPicadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPicadas.BackgroundColor = System.Drawing.Color.White;
            this.grdPicadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPicadas.Location = new System.Drawing.Point(17, 286);
            this.grdPicadas.Name = "grdPicadas";
            this.grdPicadas.ReadOnly = true;
            this.grdPicadas.Size = new System.Drawing.Size(478, 150);
            this.grdPicadas.TabIndex = 3;
            this.grdPicadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPicadas_CellClick);
            this.grdPicadas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPicadas_CellContentClick);
            this.grdPicadas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPicadas_CellDoubleClick);
            // 
            // grdProductos
            // 
            this.grdProductos.AllowUserToAddRows = false;
            this.grdProductos.AllowUserToDeleteRows = false;
            this.grdProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProductos.BackgroundColor = System.Drawing.Color.White;
            this.grdProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductos.Location = new System.Drawing.Point(17, 25);
            this.grdProductos.Name = "grdProductos";
            this.grdProductos.ReadOnly = true;
            this.grdProductos.Size = new System.Drawing.Size(478, 150);
            this.grdProductos.TabIndex = 2;
            this.grdProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProductos_CellClick);
            this.grdProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProductos_CellContentClick);
            this.grdProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProductos_CellDoubleClick);
            // 
            // btnFinalizarVenta
            // 
            this.btnFinalizarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnFinalizarVenta.FlatAppearance.BorderSize = 0;
            this.btnFinalizarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFinalizarVenta.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarVenta.Location = new System.Drawing.Point(322, 439);
            this.btnFinalizarVenta.Name = "btnFinalizarVenta";
            this.btnFinalizarVenta.Size = new System.Drawing.Size(189, 35);
            this.btnFinalizarVenta.TabIndex = 14;
            this.btnFinalizarVenta.Text = "FINALIZAR VENTA";
            this.btnFinalizarVenta.UseVisualStyleBackColor = false;
            this.btnFinalizarVenta.Click += new System.EventHandler(this.btnFinalizarVenta_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(105, 439);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(189, 35);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmVentaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 574);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFinalizarVenta);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVentaPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta pedido";
            this.Load += new System.EventHandler(this.frmVentaPedido_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPicadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumeroVenta;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboMetodoPago;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRecargoPesos;
        private System.Windows.Forms.TextBox txtDescuentoPesos;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView grdPicadas;
        private System.Windows.Forms.DataGridView grdProductos;
        private System.Windows.Forms.Button btnCambiarPrecioPicada;
        private System.Windows.Forms.Button btnCambiarPrecioProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPrecioActualProducto;
        private System.Windows.Forms.Label lblPrecioActualPicada;
        private System.Windows.Forms.Button btnFinalizarVenta;
        private System.Windows.Forms.Button btnCancelar;
    }
}