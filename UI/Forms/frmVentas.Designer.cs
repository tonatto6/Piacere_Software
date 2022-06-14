
namespace UI.Forms
{
    partial class frmVentas
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
            this.groupSeleccionarProductos = new System.Windows.Forms.GroupBox();
            this.btnNuevaPicada = new System.Windows.Forms.Button();
            this.btnVerDetallePicada = new System.Windows.Forms.Button();
            this.txtBuscarPicada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSeleccionarPicada = new System.Windows.Forms.Button();
            this.grdPicadas = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdProductos = new System.Windows.Forms.DataGridView();
            this.groupProductosSeleccionados = new System.Windows.Forms.GroupBox();
            this.grdProductosSeleccionados = new System.Windows.Forms.DataGridView();
            this.btnQuitarPicada = new System.Windows.Forms.Button();
            this.grdPicadaSeleccionada = new System.Windows.Forms.DataGridView();
            this.btnQuitarProducto = new System.Windows.Forms.Button();
            this.groupDetalleVentas = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblNumeroVenta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAgregarMetodoPago = new System.Windows.Forms.Button();
            this.cboMetodoPago = new System.Windows.Forms.ComboBox();
            this.txtOtroMetodoPago = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFinalizarVenta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRecargoPesos = new System.Windows.Forms.TextBox();
            this.txtDescuentoPesos = new System.Windows.Forms.TextBox();
            this.groupSeleccionarProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPicadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).BeginInit();
            this.groupProductosSeleccionados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductosSeleccionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPicadaSeleccionada)).BeginInit();
            this.groupDetalleVentas.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupSeleccionarProductos
            // 
            this.groupSeleccionarProductos.Controls.Add(this.btnNuevaPicada);
            this.groupSeleccionarProductos.Controls.Add(this.btnVerDetallePicada);
            this.groupSeleccionarProductos.Controls.Add(this.txtBuscarPicada);
            this.groupSeleccionarProductos.Controls.Add(this.label5);
            this.groupSeleccionarProductos.Controls.Add(this.btnSeleccionarPicada);
            this.groupSeleccionarProductos.Controls.Add(this.grdPicadas);
            this.groupSeleccionarProductos.Controls.Add(this.btnSeleccionar);
            this.groupSeleccionarProductos.Controls.Add(this.txtBuscarProducto);
            this.groupSeleccionarProductos.Controls.Add(this.label1);
            this.groupSeleccionarProductos.Controls.Add(this.grdProductos);
            this.groupSeleccionarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupSeleccionarProductos.Location = new System.Drawing.Point(11, 12);
            this.groupSeleccionarProductos.Name = "groupSeleccionarProductos";
            this.groupSeleccionarProductos.Size = new System.Drawing.Size(494, 629);
            this.groupSeleccionarProductos.TabIndex = 0;
            this.groupSeleccionarProductos.TabStop = false;
            this.groupSeleccionarProductos.Text = "Seleccionar productos";
            // 
            // btnNuevaPicada
            // 
            this.btnNuevaPicada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnNuevaPicada.FlatAppearance.BorderSize = 0;
            this.btnNuevaPicada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaPicada.ForeColor = System.Drawing.Color.White;
            this.btnNuevaPicada.Location = new System.Drawing.Point(34, 584);
            this.btnNuevaPicada.Name = "btnNuevaPicada";
            this.btnNuevaPicada.Size = new System.Drawing.Size(153, 35);
            this.btnNuevaPicada.TabIndex = 8;
            this.btnNuevaPicada.Text = "NUEVA PICADA";
            this.btnNuevaPicada.UseVisualStyleBackColor = false;
            this.btnNuevaPicada.Click += new System.EventHandler(this.btnNuevaPicada_Click);
            // 
            // btnVerDetallePicada
            // 
            this.btnVerDetallePicada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnVerDetallePicada.FlatAppearance.BorderSize = 0;
            this.btnVerDetallePicada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDetallePicada.ForeColor = System.Drawing.Color.White;
            this.btnVerDetallePicada.Location = new System.Drawing.Point(34, 534);
            this.btnVerDetallePicada.Name = "btnVerDetallePicada";
            this.btnVerDetallePicada.Size = new System.Drawing.Size(210, 35);
            this.btnVerDetallePicada.TabIndex = 7;
            this.btnVerDetallePicada.Text = "VER DETALLE PICADA";
            this.btnVerDetallePicada.UseVisualStyleBackColor = false;
            this.btnVerDetallePicada.Click += new System.EventHandler(this.btnVerDetallePicada_Click);
            // 
            // txtBuscarPicada
            // 
            this.txtBuscarPicada.Location = new System.Drawing.Point(156, 309);
            this.txtBuscarPicada.Name = "txtBuscarPicada";
            this.txtBuscarPicada.Size = new System.Drawing.Size(195, 26);
            this.txtBuscarPicada.TabIndex = 6;
            this.txtBuscarPicada.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarPicada_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Buscar picada";
            // 
            // btnSeleccionarPicada
            // 
            this.btnSeleccionarPicada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnSeleccionarPicada.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarPicada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarPicada.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarPicada.Location = new System.Drawing.Point(347, 534);
            this.btnSeleccionarPicada.Name = "btnSeleccionarPicada";
            this.btnSeleccionarPicada.Size = new System.Drawing.Size(141, 35);
            this.btnSeleccionarPicada.TabIndex = 4;
            this.btnSeleccionarPicada.Text = "SELECCIONAR";
            this.btnSeleccionarPicada.UseVisualStyleBackColor = false;
            this.btnSeleccionarPicada.Click += new System.EventHandler(this.btnSeleccionarPicada_Click);
            // 
            // grdPicadas
            // 
            this.grdPicadas.AllowUserToAddRows = false;
            this.grdPicadas.AllowUserToDeleteRows = false;
            this.grdPicadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPicadas.BackgroundColor = System.Drawing.Color.White;
            this.grdPicadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPicadas.Location = new System.Drawing.Point(34, 338);
            this.grdPicadas.Name = "grdPicadas";
            this.grdPicadas.ReadOnly = true;
            this.grdPicadas.Size = new System.Drawing.Size(454, 190);
            this.grdPicadas.TabIndex = 3;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(34, 249);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(141, 35);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "SELECCIONAR";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(176, 19);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(195, 26);
            this.txtBuscarProducto.TabIndex = 2;
            this.txtBuscarProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarProducto_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar producto";
            // 
            // grdProductos
            // 
            this.grdProductos.AllowUserToAddRows = false;
            this.grdProductos.AllowUserToDeleteRows = false;
            this.grdProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProductos.BackgroundColor = System.Drawing.Color.White;
            this.grdProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductos.Location = new System.Drawing.Point(34, 51);
            this.grdProductos.Name = "grdProductos";
            this.grdProductos.ReadOnly = true;
            this.grdProductos.Size = new System.Drawing.Size(454, 192);
            this.grdProductos.TabIndex = 1;
            // 
            // groupProductosSeleccionados
            // 
            this.groupProductosSeleccionados.Controls.Add(this.grdProductosSeleccionados);
            this.groupProductosSeleccionados.Controls.Add(this.btnQuitarPicada);
            this.groupProductosSeleccionados.Controls.Add(this.grdPicadaSeleccionada);
            this.groupProductosSeleccionados.Controls.Add(this.btnQuitarProducto);
            this.groupProductosSeleccionados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupProductosSeleccionados.Location = new System.Drawing.Point(6, 25);
            this.groupProductosSeleccionados.Name = "groupProductosSeleccionados";
            this.groupProductosSeleccionados.Size = new System.Drawing.Size(523, 237);
            this.groupProductosSeleccionados.TabIndex = 1;
            this.groupProductosSeleccionados.TabStop = false;
            this.groupProductosSeleccionados.Text = "Productos seleccionados";
            // 
            // grdProductosSeleccionados
            // 
            this.grdProductosSeleccionados.AllowUserToAddRows = false;
            this.grdProductosSeleccionados.AllowUserToDeleteRows = false;
            this.grdProductosSeleccionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProductosSeleccionados.BackgroundColor = System.Drawing.Color.White;
            this.grdProductosSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductosSeleccionados.Location = new System.Drawing.Point(6, 39);
            this.grdProductosSeleccionados.Name = "grdProductosSeleccionados";
            this.grdProductosSeleccionados.ReadOnly = true;
            this.grdProductosSeleccionados.Size = new System.Drawing.Size(260, 124);
            this.grdProductosSeleccionados.TabIndex = 5;
            // 
            // btnQuitarPicada
            // 
            this.btnQuitarPicada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnQuitarPicada.FlatAppearance.BorderSize = 0;
            this.btnQuitarPicada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarPicada.ForeColor = System.Drawing.Color.White;
            this.btnQuitarPicada.Location = new System.Drawing.Point(410, 169);
            this.btnQuitarPicada.Name = "btnQuitarPicada";
            this.btnQuitarPicada.Size = new System.Drawing.Size(107, 35);
            this.btnQuitarPicada.TabIndex = 4;
            this.btnQuitarPicada.Text = "QUITAR";
            this.btnQuitarPicada.UseVisualStyleBackColor = false;
            this.btnQuitarPicada.Click += new System.EventHandler(this.btnQuitarPicada_Click);
            // 
            // grdPicadaSeleccionada
            // 
            this.grdPicadaSeleccionada.AllowUserToAddRows = false;
            this.grdPicadaSeleccionada.AllowUserToDeleteRows = false;
            this.grdPicadaSeleccionada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPicadaSeleccionada.BackgroundColor = System.Drawing.Color.White;
            this.grdPicadaSeleccionada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPicadaSeleccionada.Location = new System.Drawing.Point(272, 39);
            this.grdPicadaSeleccionada.Name = "grdPicadaSeleccionada";
            this.grdPicadaSeleccionada.ReadOnly = true;
            this.grdPicadaSeleccionada.Size = new System.Drawing.Size(245, 124);
            this.grdPicadaSeleccionada.TabIndex = 3;
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnQuitarProducto.FlatAppearance.BorderSize = 0;
            this.btnQuitarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarProducto.ForeColor = System.Drawing.Color.White;
            this.btnQuitarProducto.Location = new System.Drawing.Point(159, 169);
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.Size = new System.Drawing.Size(107, 35);
            this.btnQuitarProducto.TabIndex = 3;
            this.btnQuitarProducto.Text = "QUITAR";
            this.btnQuitarProducto.UseVisualStyleBackColor = false;
            this.btnQuitarProducto.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // groupDetalleVentas
            // 
            this.groupDetalleVentas.Controls.Add(this.groupBox2);
            this.groupDetalleVentas.Controls.Add(this.groupBox4);
            this.groupDetalleVentas.Controls.Add(this.groupBox3);
            this.groupDetalleVentas.Controls.Add(this.groupProductosSeleccionados);
            this.groupDetalleVentas.Controls.Add(this.btnCancelar);
            this.groupDetalleVentas.Controls.Add(this.btnFinalizarVenta);
            this.groupDetalleVentas.Controls.Add(this.groupBox1);
            this.groupDetalleVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupDetalleVentas.Location = new System.Drawing.Point(526, 12);
            this.groupDetalleVentas.Name = "groupDetalleVentas";
            this.groupDetalleVentas.Size = new System.Drawing.Size(536, 629);
            this.groupDetalleVentas.TabIndex = 2;
            this.groupDetalleVentas.TabStop = false;
            this.groupDetalleVentas.Text = "Detalle de venta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblNumeroVenta);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtCliente);
            this.groupBox2.Location = new System.Drawing.Point(17, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 130);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Numero venta";
            // 
            // lblNumeroVenta
            // 
            this.lblNumeroVenta.AutoSize = true;
            this.lblNumeroVenta.Location = new System.Drawing.Point(175, 41);
            this.lblNumeroVenta.Name = "lblNumeroVenta";
            this.lblNumeroVenta.Size = new System.Drawing.Size(14, 20);
            this.lblNumeroVenta.TabIndex = 13;
            this.lblNumeroVenta.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(93, 79);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(167, 26);
            this.txtCliente.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblMontoTotal);
            this.groupBox4.Controls.Add(this.lblSubTotal);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(307, 407);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(217, 130);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Total";
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Location = new System.Drawing.Point(155, 77);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(18, 20);
            this.lblMontoTotal.TabIndex = 15;
            this.lblMontoTotal.Text = "0";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(155, 39);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(18, 20);
            this.lblSubTotal.TabIndex = 14;
            this.lblSubTotal.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Subtotal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Monto total";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAgregarMetodoPago);
            this.groupBox3.Controls.Add(this.cboMetodoPago);
            this.groupBox3.Controls.Add(this.txtOtroMetodoPago);
            this.groupBox3.Location = new System.Drawing.Point(17, 407);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 171);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Metodo pago";
            // 
            // btnAgregarMetodoPago
            // 
            this.btnAgregarMetodoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnAgregarMetodoPago.FlatAppearance.BorderSize = 0;
            this.btnAgregarMetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMetodoPago.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMetodoPago.Location = new System.Drawing.Point(179, 121);
            this.btnAgregarMetodoPago.Name = "btnAgregarMetodoPago";
            this.btnAgregarMetodoPago.Size = new System.Drawing.Size(60, 35);
            this.btnAgregarMetodoPago.TabIndex = 6;
            this.btnAgregarMetodoPago.Text = "+";
            this.btnAgregarMetodoPago.UseVisualStyleBackColor = false;
            this.btnAgregarMetodoPago.Click += new System.EventHandler(this.btnAgregarMetodoPago_Click);
            // 
            // cboMetodoPago
            // 
            this.cboMetodoPago.FormattingEnabled = true;
            this.cboMetodoPago.Location = new System.Drawing.Point(25, 38);
            this.cboMetodoPago.Name = "cboMetodoPago";
            this.cboMetodoPago.Size = new System.Drawing.Size(214, 28);
            this.cboMetodoPago.TabIndex = 7;
            this.cboMetodoPago.Text = "Seleccionar";
            // 
            // txtOtroMetodoPago
            // 
            this.txtOtroMetodoPago.Location = new System.Drawing.Point(24, 91);
            this.txtOtroMetodoPago.Name = "txtOtroMetodoPago";
            this.txtOtroMetodoPago.Size = new System.Drawing.Size(214, 26);
            this.txtOtroMetodoPago.TabIndex = 8;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(142, 584);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(141, 35);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFinalizarVenta
            // 
            this.btnFinalizarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnFinalizarVenta.FlatAppearance.BorderSize = 0;
            this.btnFinalizarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarVenta.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarVenta.Location = new System.Drawing.Point(310, 543);
            this.btnFinalizarVenta.Name = "btnFinalizarVenta";
            this.btnFinalizarVenta.Size = new System.Drawing.Size(214, 35);
            this.btnFinalizarVenta.TabIndex = 4;
            this.btnFinalizarVenta.Text = "FINALIZAR VENTA";
            this.btnFinalizarVenta.UseVisualStyleBackColor = false;
            this.btnFinalizarVenta.Click += new System.EventHandler(this.btnFinalizarVenta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtRecargoPesos);
            this.groupBox1.Controls.Add(this.txtDescuentoPesos);
            this.groupBox1.Location = new System.Drawing.Point(307, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 130);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Recargo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Descuento";
            // 
            // txtRecargoPesos
            // 
            this.txtRecargoPesos.Location = new System.Drawing.Point(93, 60);
            this.txtRecargoPesos.Name = "txtRecargoPesos";
            this.txtRecargoPesos.Size = new System.Drawing.Size(99, 26);
            this.txtRecargoPesos.TabIndex = 9;
            this.txtRecargoPesos.Text = "0";
            this.txtRecargoPesos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRecargoPesos_KeyUp);
            // 
            // txtDescuentoPesos
            // 
            this.txtDescuentoPesos.Location = new System.Drawing.Point(93, 16);
            this.txtDescuentoPesos.Name = "txtDescuentoPesos";
            this.txtDescuentoPesos.Size = new System.Drawing.Size(99, 26);
            this.txtDescuentoPesos.TabIndex = 3;
            this.txtDescuentoPesos.Text = "0";
            this.txtDescuentoPesos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDescuentoPesos_KeyUp);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 650);
            this.Controls.Add(this.groupDetalleVentas);
            this.Controls.Add(this.groupSeleccionarProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVentas";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.groupSeleccionarProductos.ResumeLayout(false);
            this.groupSeleccionarProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPicadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).EndInit();
            this.groupProductosSeleccionados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductosSeleccionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPicadaSeleccionada)).EndInit();
            this.groupDetalleVentas.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupSeleccionarProductos;
        private System.Windows.Forms.DataGridView grdProductos;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.GroupBox groupProductosSeleccionados;
        private System.Windows.Forms.Button btnQuitarProducto;
        private System.Windows.Forms.GroupBox groupDetalleVentas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescuentoPesos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRecargoPesos;
        private System.Windows.Forms.ComboBox cboMetodoPago;
        private System.Windows.Forms.TextBox txtOtroMetodoPago;
        private System.Windows.Forms.Button btnFinalizarVenta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNumeroVenta;
        private System.Windows.Forms.Button btnSeleccionarPicada;
        private System.Windows.Forms.DataGridView grdPicadas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscarPicada;
        private System.Windows.Forms.Button btnVerDetallePicada;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdPicadaSeleccionada;
        private System.Windows.Forms.Button btnQuitarPicada;
        private System.Windows.Forms.DataGridView grdProductosSeleccionados;
        private System.Windows.Forms.Button btnNuevaPicada;
        private System.Windows.Forms.Button btnAgregarMetodoPago;
    }
}