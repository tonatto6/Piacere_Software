
namespace UI.Forms
{
    partial class frmNuevoPedido
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtCostoTotal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbNoPagado = new System.Windows.Forms.CheckBox();
            this.cbPagado = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listaProductosSeleccionados = new System.Windows.Forms.ListBox();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnNuevaPicada = new System.Windows.Forms.Button();
            this.btnSeleccionarPicada = new System.Windows.Forms.Button();
            this.btnSeleccionarProducto = new System.Windows.Forms.Button();
            this.txtBuscarPicada = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grdPicadas = new System.Windows.Forms.DataGridView();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grdProductos = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPicadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(-2, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1054, 832);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(788, 587);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 35);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(931, 587);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(106, 35);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.listaProductosSeleccionados);
            this.groupBox4.Controls.Add(this.dtpFechaEntrega);
            this.groupBox4.Controls.Add(this.txtDescripcion);
            this.groupBox4.Controls.Add(this.txtCliente);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(6, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(888, 308);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtCostoTotal);
            this.groupBox5.Location = new System.Drawing.Point(205, 135);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 134);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Costo total";
            // 
            // txtCostoTotal
            // 
            this.txtCostoTotal.Location = new System.Drawing.Point(21, 60);
            this.txtCostoTotal.Name = "txtCostoTotal";
            this.txtCostoTotal.Size = new System.Drawing.Size(161, 26);
            this.txtCostoTotal.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNoPagado);
            this.groupBox1.Controls.Add(this.cbPagado);
            this.groupBox1.Location = new System.Drawing.Point(20, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 134);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // cbNoPagado
            // 
            this.cbNoPagado.AutoSize = true;
            this.cbNoPagado.Location = new System.Drawing.Point(27, 84);
            this.cbNoPagado.Name = "cbNoPagado";
            this.cbNoPagado.Size = new System.Drawing.Size(106, 24);
            this.cbNoPagado.TabIndex = 1;
            this.cbNoPagado.Text = "No pagado";
            this.cbNoPagado.UseVisualStyleBackColor = true;
            this.cbNoPagado.Click += new System.EventHandler(this.cbNoPagado_Click);
            // 
            // cbPagado
            // 
            this.cbPagado.AutoSize = true;
            this.cbPagado.Checked = true;
            this.cbPagado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPagado.Location = new System.Drawing.Point(27, 34);
            this.cbPagado.Name = "cbPagado";
            this.cbPagado.Size = new System.Drawing.Size(83, 24);
            this.cbPagado.TabIndex = 0;
            this.cbPagado.Text = "Pagado";
            this.cbPagado.UseVisualStyleBackColor = true;
            this.cbPagado.Click += new System.EventHandler(this.cbPagado_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Lista de productos";
            // 
            // listaProductosSeleccionados
            // 
            this.listaProductosSeleccionados.FormattingEnabled = true;
            this.listaProductosSeleccionados.ItemHeight = 20;
            this.listaProductosSeleccionados.Location = new System.Drawing.Point(431, 45);
            this.listaProductosSeleccionados.Name = "listaProductosSeleccionados";
            this.listaProductosSeleccionados.Size = new System.Drawing.Size(432, 204);
            this.listaProductosSeleccionados.TabIndex = 3;
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Location = new System.Drawing.Point(558, 268);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(270, 26);
            this.dtpFechaEntrega.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(20, 79);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(385, 50);
            this.txtDescripcion.TabIndex = 13;
            this.txtDescripcion.Text = "-";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(80, 16);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(306, 26);
            this.txtCliente.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fecha entrega";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cliente";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnNuevaPicada);
            this.groupBox3.Controls.Add(this.btnSeleccionarPicada);
            this.groupBox3.Controls.Add(this.btnSeleccionarProducto);
            this.groupBox3.Controls.Add(this.txtBuscarPicada);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.grdPicadas);
            this.groupBox3.Controls.Add(this.txtBuscarProducto);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.grdProductos);
            this.groupBox3.Location = new System.Drawing.Point(6, 339);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1031, 242);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seleccionar productos";
            // 
            // btnNuevaPicada
            // 
            this.btnNuevaPicada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevaPicada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnNuevaPicada.FlatAppearance.BorderSize = 0;
            this.btnNuevaPicada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaPicada.ForeColor = System.Drawing.Color.White;
            this.btnNuevaPicada.Location = new System.Drawing.Point(579, 197);
            this.btnNuevaPicada.Name = "btnNuevaPicada";
            this.btnNuevaPicada.Size = new System.Drawing.Size(158, 35);
            this.btnNuevaPicada.TabIndex = 20;
            this.btnNuevaPicada.Text = "NUEVA PICADA";
            this.btnNuevaPicada.UseVisualStyleBackColor = false;
            this.btnNuevaPicada.Click += new System.EventHandler(this.btnNuevaPicada_Click);
            // 
            // btnSeleccionarPicada
            // 
            this.btnSeleccionarPicada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionarPicada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnSeleccionarPicada.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarPicada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarPicada.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarPicada.Location = new System.Drawing.Point(853, 197);
            this.btnSeleccionarPicada.Name = "btnSeleccionarPicada";
            this.btnSeleccionarPicada.Size = new System.Drawing.Size(158, 35);
            this.btnSeleccionarPicada.TabIndex = 19;
            this.btnSeleccionarPicada.Text = "SELECCIONAR";
            this.btnSeleccionarPicada.UseVisualStyleBackColor = false;
            this.btnSeleccionarPicada.Click += new System.EventHandler(this.btnSeleccionarPicada_Click);
            // 
            // btnSeleccionarProducto
            // 
            this.btnSeleccionarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnSeleccionarProducto.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarProducto.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarProducto.Location = new System.Drawing.Point(387, 197);
            this.btnSeleccionarProducto.Name = "btnSeleccionarProducto";
            this.btnSeleccionarProducto.Size = new System.Drawing.Size(158, 35);
            this.btnSeleccionarProducto.TabIndex = 13;
            this.btnSeleccionarProducto.Text = "SELECCIONAR";
            this.btnSeleccionarProducto.UseVisualStyleBackColor = false;
            this.btnSeleccionarProducto.Click += new System.EventHandler(this.btnSeleccionarProducto_Click);
            // 
            // txtBuscarPicada
            // 
            this.txtBuscarPicada.Location = new System.Drawing.Point(691, 30);
            this.txtBuscarPicada.Name = "txtBuscarPicada";
            this.txtBuscarPicada.Size = new System.Drawing.Size(318, 26);
            this.txtBuscarPicada.TabIndex = 18;
            this.txtBuscarPicada.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarPicada_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(575, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Buscar picada";
            // 
            // grdPicadas
            // 
            this.grdPicadas.AllowUserToAddRows = false;
            this.grdPicadas.AllowUserToDeleteRows = false;
            this.grdPicadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPicadas.BackgroundColor = System.Drawing.Color.White;
            this.grdPicadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPicadas.Location = new System.Drawing.Point(579, 62);
            this.grdPicadas.Name = "grdPicadas";
            this.grdPicadas.ReadOnly = true;
            this.grdPicadas.Size = new System.Drawing.Size(432, 129);
            this.grdPicadas.TabIndex = 16;
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(148, 30);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(397, 26);
            this.txtBuscarProducto.TabIndex = 15;
            this.txtBuscarProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarProducto_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Buscar producto";
            // 
            // grdProductos
            // 
            this.grdProductos.AllowUserToAddRows = false;
            this.grdProductos.AllowUserToDeleteRows = false;
            this.grdProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProductos.BackgroundColor = System.Drawing.Color.White;
            this.grdProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductos.Location = new System.Drawing.Point(20, 59);
            this.grdProductos.Name = "grdProductos";
            this.grdProductos.ReadOnly = true;
            this.grdProductos.Size = new System.Drawing.Size(525, 132);
            this.grdProductos.TabIndex = 13;
            // 
            // frmNuevoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 650);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNuevoPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNuevoPedido";
            this.Load += new System.EventHandler(this.frmNuevoPedido_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPicadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listaProductosSeleccionados;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSeleccionarPicada;
        private System.Windows.Forms.Button btnSeleccionarProducto;
        private System.Windows.Forms.TextBox txtBuscarPicada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grdPicadas;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grdProductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbNoPagado;
        private System.Windows.Forms.CheckBox cbPagado;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnNuevaPicada;
        private System.Windows.Forms.TextBox txtCostoTotal;
    }
}