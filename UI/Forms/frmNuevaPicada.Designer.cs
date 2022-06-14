
namespace UI.Forms
{
    partial class frmNuevaPicada
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductosIngredientes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(32, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 636);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(164, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 20);
            this.label10.TabIndex = 52;
            this.label10.Text = "$";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(192, 560);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 35);
            this.btnCancelar.TabIndex = 51;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(390, 560);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(133, 35);
            this.btnAceptar.TabIndex = 50;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtPrecioFinal
            // 
            this.txtPrecioFinal.Location = new System.Drawing.Point(182, 516);
            this.txtPrecioFinal.Name = "txtPrecioFinal";
            this.txtPrecioFinal.Size = new System.Drawing.Size(201, 26);
            this.txtPrecioFinal.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 522);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 48;
            this.label9.Text = "Precio final";
            // 
            // lblCostoTotalProductos
            // 
            this.lblCostoTotalProductos.AutoSize = true;
            this.lblCostoTotalProductos.Location = new System.Drawing.Point(203, 279);
            this.lblCostoTotalProductos.Name = "lblCostoTotalProductos";
            this.lblCostoTotalProductos.Size = new System.Drawing.Size(14, 20);
            this.lblCostoTotalProductos.TabIndex = 47;
            this.lblCostoTotalProductos.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "Costo total";
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Location = new System.Drawing.Point(178, 483);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(14, 20);
            this.lblPrecioTotal.TabIndex = 45;
            this.lblPrecioTotal.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 483);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Precio total";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(235, 236);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(288, 26);
            this.txtPrecioProducto.TabIndex = 43;
            this.txtPrecioProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPrecioProducto_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "Precio por unidad/KG";
            // 
            // cbUnidad
            // 
            this.cbUnidad.AutoSize = true;
            this.cbUnidad.Location = new System.Drawing.Point(390, 195);
            this.cbUnidad.Name = "cbUnidad";
            this.cbUnidad.Size = new System.Drawing.Size(79, 24);
            this.cbUnidad.TabIndex = 41;
            this.cbUnidad.Text = "Unidad";
            this.cbUnidad.UseVisualStyleBackColor = true;
            this.cbUnidad.Click += new System.EventHandler(this.cbUnidad_Click);
            // 
            // cbPeso
            // 
            this.cbPeso.AutoSize = true;
            this.cbPeso.Checked = true;
            this.cbPeso.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPeso.Location = new System.Drawing.Point(303, 198);
            this.cbPeso.Name = "cbPeso";
            this.cbPeso.Size = new System.Drawing.Size(64, 24);
            this.cbPeso.TabIndex = 40;
            this.cbPeso.Text = "Peso";
            this.cbPeso.UseVisualStyleBackColor = true;
            this.cbPeso.Click += new System.EventHandler(this.cbPeso_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(149, 193);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(126, 26);
            this.txtCantidad.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Cantidad";
            // 
            // grdProductosIngredientes
            // 
            this.grdProductosIngredientes.AllowUserToAddRows = false;
            this.grdProductosIngredientes.AllowUserToDeleteRows = false;
            this.grdProductosIngredientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProductosIngredientes.BackgroundColor = System.Drawing.Color.White;
            this.grdProductosIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductosIngredientes.Location = new System.Drawing.Point(62, 313);
            this.grdProductosIngredientes.Name = "grdProductosIngredientes";
            this.grdProductosIngredientes.ReadOnly = true;
            this.grdProductosIngredientes.Size = new System.Drawing.Size(461, 157);
            this.grdProductosIngredientes.TabIndex = 37;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.Location = new System.Drawing.Point(477, 272);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(46, 35);
            this.btnAgregarProducto.TabIndex = 36;
            this.btnAgregarProducto.Text = "+";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // txtProductoIngrediente
            // 
            this.txtProductoIngrediente.Location = new System.Drawing.Point(221, 154);
            this.txtProductoIngrediente.Name = "txtProductoIngrediente";
            this.txtProductoIngrediente.Size = new System.Drawing.Size(302, 26);
            this.txtProductoIngrediente.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Producto/Ingrediente";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(182, 57);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(341, 90);
            this.txtDescripcion.TabIndex = 33;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(182, 16);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(341, 26);
            this.txtNombre.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nombre";
            // 
            // frmNuevaPicada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(641, 650);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNuevaPicada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNuevaPicada";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductosIngredientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtPrecioFinal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCostoTotalProductos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbUnidad;
        private System.Windows.Forms.CheckBox cbPeso;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grdProductosIngredientes;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.TextBox txtProductoIngrediente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}