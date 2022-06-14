
namespace UI.Forms
{
    partial class frmDashboard
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbMenor = new System.Windows.Forms.CheckBox();
            this.cbMayor = new System.Windows.Forms.CheckBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.cboMes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerDetalleVenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grdVentas = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grdPicadas = new System.Windows.Forms.DataGridView();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grdProductos = new System.Windows.Forms.DataGridView();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.lblRecargo = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVentas)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPicadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtAño);
            this.groupBox1.Controls.Add(this.cboMes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnVerDetalleVenta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.grdVentas);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 618);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ventas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbMenor);
            this.groupBox2.Controls.Add(this.cbMayor);
            this.groupBox2.Location = new System.Drawing.Point(404, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 110);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordenar por";
            // 
            // cbMenor
            // 
            this.cbMenor.AutoSize = true;
            this.cbMenor.Location = new System.Drawing.Point(38, 69);
            this.cbMenor.Name = "cbMenor";
            this.cbMenor.Size = new System.Drawing.Size(130, 24);
            this.cbMenor.TabIndex = 5;
            this.cbMenor.Text = "Menor primero";
            this.cbMenor.UseVisualStyleBackColor = true;
            this.cbMenor.Click += new System.EventHandler(this.cbMenor_Click);
            // 
            // cbMayor
            // 
            this.cbMayor.AutoSize = true;
            this.cbMayor.Checked = true;
            this.cbMayor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMayor.Location = new System.Drawing.Point(38, 37);
            this.cbMayor.Name = "cbMayor";
            this.cbMayor.Size = new System.Drawing.Size(128, 24);
            this.cbMayor.TabIndex = 4;
            this.cbMayor.Text = "Mayor primero";
            this.cbMayor.UseVisualStyleBackColor = true;
            this.cbMayor.Click += new System.EventHandler(this.cbMayor_Click);
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(124, 71);
            this.txtAño.MaxLength = 4;
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(214, 26);
            this.txtAño.TabIndex = 3;
            this.txtAño.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAño_KeyUp);
            // 
            // cboMes
            // 
            this.cboMes.FormattingEnabled = true;
            this.cboMes.Items.AddRange(new object[] {
            "Todos",
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cboMes.Location = new System.Drawing.Point(124, 31);
            this.cboMes.Name = "cboMes";
            this.cboMes.Size = new System.Drawing.Size(214, 28);
            this.cboMes.TabIndex = 12;
            this.cboMes.Text = "Todos";
            this.cboMes.TextChanged += new System.EventHandler(this.cboMes_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Año";
            // 
            // btnVerDetalleVenta
            // 
            this.btnVerDetalleVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnVerDetalleVenta.FlatAppearance.BorderSize = 0;
            this.btnVerDetalleVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDetalleVenta.ForeColor = System.Drawing.Color.White;
            this.btnVerDetalleVenta.Location = new System.Drawing.Point(390, 504);
            this.btnVerDetalleVenta.Name = "btnVerDetalleVenta";
            this.btnVerDetalleVenta.Size = new System.Drawing.Size(218, 35);
            this.btnVerDetalleVenta.TabIndex = 10;
            this.btnVerDetalleVenta.Text = "VER DETALLE VENTA";
            this.btnVerDetalleVenta.UseVisualStyleBackColor = false;
            this.btnVerDetalleVenta.Click += new System.EventHandler(this.btnVerDetalleVenta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtrar mes";
            // 
            // grdVentas
            // 
            this.grdVentas.AllowUserToAddRows = false;
            this.grdVentas.AllowUserToDeleteRows = false;
            this.grdVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdVentas.BackgroundColor = System.Drawing.Color.White;
            this.grdVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVentas.Location = new System.Drawing.Point(12, 124);
            this.grdVentas.Name = "grdVentas";
            this.grdVentas.ReadOnly = true;
            this.grdVentas.Size = new System.Drawing.Size(596, 374);
            this.grdVentas.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grdPicadas);
            this.groupBox4.Controls.Add(this.lblMetodoPago);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.grdProductos);
            this.groupBox4.Controls.Add(this.lblMontoTotal);
            this.groupBox4.Controls.Add(this.lblRecargo);
            this.groupBox4.Controls.Add(this.lblDescuento);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.lblCliente);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox4.Location = new System.Drawing.Point(670, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(382, 618);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detalle venta";
            // 
            // grdPicadas
            // 
            this.grdPicadas.AllowUserToAddRows = false;
            this.grdPicadas.AllowUserToDeleteRows = false;
            this.grdPicadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPicadas.BackgroundColor = System.Drawing.Color.White;
            this.grdPicadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPicadas.Location = new System.Drawing.Point(23, 389);
            this.grdPicadas.Name = "grdPicadas";
            this.grdPicadas.ReadOnly = true;
            this.grdPicadas.Size = new System.Drawing.Size(347, 150);
            this.grdPicadas.TabIndex = 24;
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Location = new System.Drawing.Point(138, 73);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(14, 20);
            this.lblMetodoPago.TabIndex = 23;
            this.lblMetodoPago.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Metodo pago";
            // 
            // grdProductos
            // 
            this.grdProductos.AllowUserToAddRows = false;
            this.grdProductos.AllowUserToDeleteRows = false;
            this.grdProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProductos.BackgroundColor = System.Drawing.Color.White;
            this.grdProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductos.Location = new System.Drawing.Point(23, 219);
            this.grdProductos.Name = "grdProductos";
            this.grdProductos.ReadOnly = true;
            this.grdProductos.Size = new System.Drawing.Size(347, 150);
            this.grdProductos.TabIndex = 4;
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Location = new System.Drawing.Point(124, 566);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(14, 20);
            this.lblMontoTotal.TabIndex = 21;
            this.lblMontoTotal.Text = "-";
            // 
            // lblRecargo
            // 
            this.lblRecargo.AutoSize = true;
            this.lblRecargo.Location = new System.Drawing.Point(138, 151);
            this.lblRecargo.Name = "lblRecargo";
            this.lblRecargo.Size = new System.Drawing.Size(14, 20);
            this.lblRecargo.TabIndex = 20;
            this.lblRecargo.Text = "-";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(138, 112);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(14, 20);
            this.lblDescuento.TabIndex = 19;
            this.lblDescuento.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 566);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Monto total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Lista de productos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Recargo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Descuento";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(138, 34);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(14, 20);
            this.lblCliente.TabIndex = 14;
            this.lblCliente.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cliente";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 650);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVentas)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPicadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerDetalleVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMes;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.Label lblRecargo;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.DataGridView grdProductos;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbMenor;
        private System.Windows.Forms.CheckBox cbMayor;
        private System.Windows.Forms.DataGridView grdPicadas;
    }
}