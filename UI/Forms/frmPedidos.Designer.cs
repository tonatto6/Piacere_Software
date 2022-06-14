
namespace UI.Forms
{
    partial class frmPedidos
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
            this.btnVenderPedido = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBuscarPorDias = new System.Windows.Forms.Button();
            this.txtCantidadDias = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminarPedido = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarPorFecha = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnVerDetallePedido = new System.Windows.Forms.Button();
            this.btnNuevoPedido = new System.Windows.Forms.Button();
            this.grdPedidos = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listProductosPedido = new System.Windows.Forms.ListBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.lblFechaPedido = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPedidos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVenderPedido);
            this.groupBox1.Controls.Add(this.btnRefrescar);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.btnEliminarPedido);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnVerDetallePedido);
            this.groupBox1.Controls.Add(this.btnNuevoPedido);
            this.groupBox1.Controls.Add(this.grdPedidos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 621);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedidos";
            // 
            // btnVenderPedido
            // 
            this.btnVenderPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnVenderPedido.FlatAppearance.BorderSize = 0;
            this.btnVenderPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenderPedido.ForeColor = System.Drawing.Color.White;
            this.btnVenderPedido.Location = new System.Drawing.Point(175, 511);
            this.btnVenderPedido.Name = "btnVenderPedido";
            this.btnVenderPedido.Size = new System.Drawing.Size(191, 35);
            this.btnVenderPedido.TabIndex = 20;
            this.btnVenderPedido.Text = "VENDER PEDIDO";
            this.btnVenderPedido.UseVisualStyleBackColor = false;
            this.btnVenderPedido.Click += new System.EventHandler(this.btnVenderPedido_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnRefrescar.FlatAppearance.BorderSize = 0;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.ForeColor = System.Drawing.Color.White;
            this.btnRefrescar.Location = new System.Drawing.Point(498, 182);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(132, 35);
            this.btnRefrescar.TabIndex = 19;
            this.btnRefrescar.Text = "REFRESCAR";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBuscarPorDias);
            this.groupBox4.Controls.Add(this.txtCantidadDias);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(404, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(226, 145);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fecha de entrega en";
            // 
            // btnBuscarPorDias
            // 
            this.btnBuscarPorDias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarPorDias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnBuscarPorDias.FlatAppearance.BorderSize = 0;
            this.btnBuscarPorDias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPorDias.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPorDias.Location = new System.Drawing.Point(100, 90);
            this.btnBuscarPorDias.Name = "btnBuscarPorDias";
            this.btnBuscarPorDias.Size = new System.Drawing.Size(100, 35);
            this.btnBuscarPorDias.TabIndex = 15;
            this.btnBuscarPorDias.Text = "BUSCAR";
            this.btnBuscarPorDias.UseVisualStyleBackColor = false;
            this.btnBuscarPorDias.Click += new System.EventHandler(this.btnBuscarPorDias_Click);
            // 
            // txtCantidadDias
            // 
            this.txtCantidadDias.Location = new System.Drawing.Point(79, 46);
            this.txtCantidadDias.Name = "txtCantidadDias";
            this.txtCantidadDias.Size = new System.Drawing.Size(121, 26);
            this.txtCantidadDias.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Dias";
            // 
            // btnEliminarPedido
            // 
            this.btnEliminarPedido.BackColor = System.Drawing.Color.DarkRed;
            this.btnEliminarPedido.FlatAppearance.BorderSize = 0;
            this.btnEliminarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPedido.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPedido.Location = new System.Drawing.Point(393, 511);
            this.btnEliminarPedido.Name = "btnEliminarPedido";
            this.btnEliminarPedido.Size = new System.Drawing.Size(237, 35);
            this.btnEliminarPedido.TabIndex = 16;
            this.btnEliminarPedido.Text = "ELIMINAR PEDIDO";
            this.btnEliminarPedido.UseVisualStyleBackColor = false;
            this.btnEliminarPedido.Click += new System.EventHandler(this.btnEliminarPedido_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnBuscarPorFecha);
            this.groupBox2.Controls.Add(this.dtpFecha);
            this.groupBox2.Location = new System.Drawing.Point(6, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 145);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fecha entrega";
            // 
            // btnBuscarPorFecha
            // 
            this.btnBuscarPorFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarPorFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnBuscarPorFecha.FlatAppearance.BorderSize = 0;
            this.btnBuscarPorFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPorFecha.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPorFecha.Location = new System.Drawing.Point(220, 87);
            this.btnBuscarPorFecha.Name = "btnBuscarPorFecha";
            this.btnBuscarPorFecha.Size = new System.Drawing.Size(100, 35);
            this.btnBuscarPorFecha.TabIndex = 14;
            this.btnBuscarPorFecha.Text = "BUSCAR";
            this.btnBuscarPorFecha.UseVisualStyleBackColor = false;
            this.btnBuscarPorFecha.Click += new System.EventHandler(this.btnBuscarPorFecha_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(10, 46);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(310, 26);
            this.dtpFecha.TabIndex = 1;
            // 
            // btnVerDetallePedido
            // 
            this.btnVerDetallePedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnVerDetallePedido.FlatAppearance.BorderSize = 0;
            this.btnVerDetallePedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDetallePedido.ForeColor = System.Drawing.Color.White;
            this.btnVerDetallePedido.Location = new System.Drawing.Point(393, 580);
            this.btnVerDetallePedido.Name = "btnVerDetallePedido";
            this.btnVerDetallePedido.Size = new System.Drawing.Size(237, 35);
            this.btnVerDetallePedido.TabIndex = 12;
            this.btnVerDetallePedido.Text = "VER DETALLE PEDIDO";
            this.btnVerDetallePedido.UseVisualStyleBackColor = false;
            this.btnVerDetallePedido.Click += new System.EventHandler(this.btnVerDetallePedido_Click);
            // 
            // btnNuevoPedido
            // 
            this.btnNuevoPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnNuevoPedido.FlatAppearance.BorderSize = 0;
            this.btnNuevoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPedido.ForeColor = System.Drawing.Color.White;
            this.btnNuevoPedido.Location = new System.Drawing.Point(6, 511);
            this.btnNuevoPedido.Name = "btnNuevoPedido";
            this.btnNuevoPedido.Size = new System.Drawing.Size(147, 35);
            this.btnNuevoPedido.TabIndex = 11;
            this.btnNuevoPedido.Text = "NUEVO PEDIDO";
            this.btnNuevoPedido.UseVisualStyleBackColor = false;
            this.btnNuevoPedido.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grdPedidos
            // 
            this.grdPedidos.AllowUserToAddRows = false;
            this.grdPedidos.AllowUserToDeleteRows = false;
            this.grdPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPedidos.BackgroundColor = System.Drawing.Color.White;
            this.grdPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPedidos.Location = new System.Drawing.Point(6, 223);
            this.grdPedidos.Name = "grdPedidos";
            this.grdPedidos.ReadOnly = true;
            this.grdPedidos.Size = new System.Drawing.Size(624, 282);
            this.grdPedidos.TabIndex = 1;
            this.grdPedidos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grdPedidos_DataBindingComplete);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox3.Location = new System.Drawing.Point(654, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 126);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Referencias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha de entrega hoy o ya pasado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de entrega menor a 5 dias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de entrega mayor a 5 dias";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Location = new System.Drawing.Point(24, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(22, 20);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(24, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(22, 20);
            this.panel3.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Location = new System.Drawing.Point(24, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(22, 20);
            this.panel1.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listProductosPedido);
            this.groupBox5.Controls.Add(this.groupBox8);
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox5.Location = new System.Drawing.Point(654, 144);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(400, 489);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // listProductosPedido
            // 
            this.listProductosPedido.FormattingEnabled = true;
            this.listProductosPedido.ItemHeight = 20;
            this.listProductosPedido.Location = new System.Drawing.Point(9, 323);
            this.listProductosPedido.Name = "listProductosPedido";
            this.listProductosPedido.Size = new System.Drawing.Size(378, 144);
            this.listProductosPedido.TabIndex = 3;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lblEstado);
            this.groupBox8.Controls.Add(this.lblCosto);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Location = new System.Drawing.Point(9, 198);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(274, 102);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(112, 64);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(14, 20);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "-";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(112, 22);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(14, 20);
            this.lblCosto.TabIndex = 13;
            this.lblCosto.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Estado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Costo";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblDescripcion);
            this.groupBox7.Controls.Add(this.lblFechaEntrega);
            this.groupBox7.Controls.Add(this.lblFechaPedido);
            this.groupBox7.Controls.Add(this.lblCliente);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Location = new System.Drawing.Point(9, 14);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(378, 178);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(180, 145);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(14, 20);
            this.lblDescripcion.TabIndex = 10;
            this.lblDescripcion.Text = "-";
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Location = new System.Drawing.Point(180, 104);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(14, 20);
            this.lblFechaEntrega.TabIndex = 9;
            this.lblFechaEntrega.Text = "-";
            // 
            // lblFechaPedido
            // 
            this.lblFechaPedido.AutoSize = true;
            this.lblFechaPedido.Location = new System.Drawing.Point(180, 63);
            this.lblFechaPedido.Name = "lblFechaPedido";
            this.lblFechaPedido.Size = new System.Drawing.Size(14, 20);
            this.lblFechaPedido.TabIndex = 8;
            this.lblFechaPedido.Text = "-";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(180, 22);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(14, 20);
            this.lblCliente.TabIndex = 7;
            this.lblCliente.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Descripcion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Fecha entrega";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Fecha pedido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cliente";
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 650);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPedidos";
            this.Text = "frmPedidos";
            this.Load += new System.EventHandler(this.frmPedidos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPedidos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdPedidos;
        private System.Windows.Forms.Button btnVerDetallePedido;
        private System.Windows.Forms.Button btnNuevoPedido;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarPorFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminarPedido;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBuscarPorDias;
        private System.Windows.Forms.TextBox txtCantidadDias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listProductosPedido;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.Label lblFechaPedido;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnVenderPedido;
    }
}