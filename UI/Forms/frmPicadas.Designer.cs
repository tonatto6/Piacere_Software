
namespace UI.Forms
{
    partial class frmPicadas
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grdDetallePicada = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarPicada = new System.Windows.Forms.TextBox();
            this.grdPicadas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuitarProducto = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtPrecioFinal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCostoTotalProductos = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbUnidad = new System.Windows.Forms.CheckBox();
            this.cbPeso = new System.Windows.Forms.CheckBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grdProductosIngredientes = new System.Windows.Forms.DataGridView();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.txtProductoIngrediente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetallePicada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPicadas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductosIngredientes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grdDetallePicada);
            this.groupBox4.Controls.Add(this.btnModificar);
            this.groupBox4.Controls.Add(this.btnEliminar);
            this.groupBox4.Controls.Add(this.btnAgregar);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtBuscarPicada);
            this.groupBox4.Controls.Add(this.grdPicadas);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(580, 613);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lista de picadas";
            // 
            // grdDetallePicada
            // 
            this.grdDetallePicada.AllowUserToAddRows = false;
            this.grdDetallePicada.AllowUserToDeleteRows = false;
            this.grdDetallePicada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDetallePicada.BackgroundColor = System.Drawing.Color.White;
            this.grdDetallePicada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetallePicada.Location = new System.Drawing.Point(26, 401);
            this.grdDetallePicada.Name = "grdDetallePicada";
            this.grdDetallePicada.ReadOnly = true;
            this.grdDetallePicada.Size = new System.Drawing.Size(537, 192);
            this.grdDetallePicada.TabIndex = 14;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(327, 353);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(133, 35);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(177, 353);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(133, 35);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(26, 353);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(133, 35);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar picada";
            // 
            // txtBuscarPicada
            // 
            this.txtBuscarPicada.Location = new System.Drawing.Point(149, 32);
            this.txtBuscarPicada.Name = "txtBuscarPicada";
            this.txtBuscarPicada.Size = new System.Drawing.Size(208, 26);
            this.txtBuscarPicada.TabIndex = 5;
            this.txtBuscarPicada.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarPicada_KeyUp);
            // 
            // grdPicadas
            // 
            this.grdPicadas.AllowUserToAddRows = false;
            this.grdPicadas.AllowUserToDeleteRows = false;
            this.grdPicadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPicadas.BackgroundColor = System.Drawing.Color.White;
            this.grdPicadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPicadas.Location = new System.Drawing.Point(26, 69);
            this.grdPicadas.Name = "grdPicadas";
            this.grdPicadas.ReadOnly = true;
            this.grdPicadas.Size = new System.Drawing.Size(537, 270);
            this.grdPicadas.TabIndex = 5;
            this.grdPicadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPicadas_CellClick);
            this.grdPicadas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPicadas_CellContentClick);
            this.grdPicadas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPicadas_CellContentDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuitarProducto);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.txtPrecioFinal);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblCostoTotalProductos);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblPrecioTotal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtPrecioProducto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbUnidad);
            this.groupBox1.Controls.Add(this.cbPeso);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.grdProductosIngredientes);
            this.groupBox1.Controls.Add(this.btnAgregarProducto);
            this.groupBox1.Controls.Add(this.txtProductoIngrediente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(608, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 613);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos picada";
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnQuitarProducto.FlatAppearance.BorderSize = 0;
            this.btnQuitarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarProducto.ForeColor = System.Drawing.Color.White;
            this.btnQuitarProducto.Location = new System.Drawing.Point(379, 461);
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.Size = new System.Drawing.Size(46, 35);
            this.btnQuitarProducto.TabIndex = 30;
            this.btnQuitarProducto.Text = "-";
            this.btnQuitarProducto.UseVisualStyleBackColor = false;
            this.btnQuitarProducto.Click += new System.EventHandler(this.btnQuitarProducto_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(139, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "$";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(143, 558);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 35);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(292, 558);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(133, 35);
            this.btnAceptar.TabIndex = 27;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtPrecioFinal
            // 
            this.txtPrecioFinal.Location = new System.Drawing.Point(143, 511);
            this.txtPrecioFinal.Name = "txtPrecioFinal";
            this.txtPrecioFinal.Size = new System.Drawing.Size(201, 26);
            this.txtPrecioFinal.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 517);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Precio final";
            // 
            // lblCostoTotalProductos
            // 
            this.lblCostoTotalProductos.AutoSize = true;
            this.lblCostoTotalProductos.Location = new System.Drawing.Point(177, 265);
            this.lblCostoTotalProductos.Name = "lblCostoTotalProductos";
            this.lblCostoTotalProductos.Size = new System.Drawing.Size(14, 20);
            this.lblCostoTotalProductos.TabIndex = 24;
            this.lblCostoTotalProductos.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Costo total";
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Location = new System.Drawing.Point(143, 468);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(14, 20);
            this.lblPrecioTotal.TabIndex = 22;
            this.lblPrecioTotal.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 468);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Precio total";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(210, 222);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(215, 26);
            this.txtPrecioProducto.TabIndex = 20;
            this.txtPrecioProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPrecioProducto_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Precio por unidad/KG";
            // 
            // cbUnidad
            // 
            this.cbUnidad.AutoSize = true;
            this.cbUnidad.Location = new System.Drawing.Point(346, 190);
            this.cbUnidad.Name = "cbUnidad";
            this.cbUnidad.Size = new System.Drawing.Size(79, 24);
            this.cbUnidad.TabIndex = 18;
            this.cbUnidad.Text = "Unidad";
            this.cbUnidad.UseVisualStyleBackColor = true;
            this.cbUnidad.Click += new System.EventHandler(this.cbUnidad_Click);
            // 
            // cbPeso
            // 
            this.cbPeso.AutoSize = true;
            this.cbPeso.Checked = true;
            this.cbPeso.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPeso.Location = new System.Drawing.Point(262, 192);
            this.cbPeso.Name = "cbPeso";
            this.cbPeso.Size = new System.Drawing.Size(64, 24);
            this.cbPeso.TabIndex = 17;
            this.cbPeso.Text = "Peso";
            this.cbPeso.UseVisualStyleBackColor = true;
            this.cbPeso.Click += new System.EventHandler(this.cbPeso_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(121, 188);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(126, 26);
            this.txtCantidad.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cantidad";
            // 
            // grdProductosIngredientes
            // 
            this.grdProductosIngredientes.AllowUserToAddRows = false;
            this.grdProductosIngredientes.AllowUserToDeleteRows = false;
            this.grdProductosIngredientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProductosIngredientes.BackgroundColor = System.Drawing.Color.White;
            this.grdProductosIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductosIngredientes.Location = new System.Drawing.Point(36, 299);
            this.grdProductosIngredientes.Name = "grdProductosIngredientes";
            this.grdProductosIngredientes.ReadOnly = true;
            this.grdProductosIngredientes.Size = new System.Drawing.Size(389, 157);
            this.grdProductosIngredientes.TabIndex = 14;
            this.grdProductosIngredientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProductosIngredientes_CellDoubleClick);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.Location = new System.Drawing.Point(379, 258);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(46, 35);
            this.btnAgregarProducto.TabIndex = 14;
            this.btnAgregarProducto.Text = "+";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // txtProductoIngrediente
            // 
            this.txtProductoIngrediente.Location = new System.Drawing.Point(196, 147);
            this.txtProductoIngrediente.Name = "txtProductoIngrediente";
            this.txtProductoIngrediente.Size = new System.Drawing.Size(229, 26);
            this.txtProductoIngrediente.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Producto/Ingrediente";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(36, 92);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(389, 45);
            this.txtDescripcion.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(121, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(304, 26);
            this.txtNombre.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // frmPicadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 650);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPicadas";
            this.Text = "Picadas";
            this.Load += new System.EventHandler(this.frmPicadas_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetallePicada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPicadas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductosIngredientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView grdPicadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarPicada;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductoIngrediente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.CheckBox cbUnidad;
        private System.Windows.Forms.CheckBox cbPeso;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grdProductosIngredientes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecioFinal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCostoTotalProductos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView grdDetallePicada;
        private System.Windows.Forms.Button btnQuitarProducto;
    }
}