
namespace UI.Forms
{
    partial class frmStock
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
            this.btnModificarStockAutomaticamente = new System.Windows.Forms.Button();
            this.btnModificarStock = new System.Windows.Forms.Button();
            this.txtBuscarProductoStock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdStockProductos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnModificarStockProducto = new System.Windows.Forms.Button();
            this.txtBuscarProductoSinStock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grdProductosSinStock = new System.Windows.Forms.DataGridView();
            this.groupModificarStock = new System.Windows.Forms.GroupBox();
            this.txtStockProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStockProductos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductosSinStock)).BeginInit();
            this.groupModificarStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnModificarStockAutomaticamente);
            this.groupBox1.Controls.Add(this.btnModificarStock);
            this.groupBox1.Controls.Add(this.txtBuscarProductoStock);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.grdStockProductos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 605);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock de productos";
            // 
            // btnModificarStockAutomaticamente
            // 
            this.btnModificarStockAutomaticamente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnModificarStockAutomaticamente.FlatAppearance.BorderSize = 0;
            this.btnModificarStockAutomaticamente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarStockAutomaticamente.ForeColor = System.Drawing.Color.White;
            this.btnModificarStockAutomaticamente.Location = new System.Drawing.Point(267, 554);
            this.btnModificarStockAutomaticamente.Name = "btnModificarStockAutomaticamente";
            this.btnModificarStockAutomaticamente.Size = new System.Drawing.Size(358, 35);
            this.btnModificarStockAutomaticamente.TabIndex = 6;
            this.btnModificarStockAutomaticamente.Text = "MODIFICAR STOCK AUTOMATICAMENTE";
            this.btnModificarStockAutomaticamente.UseVisualStyleBackColor = false;
            this.btnModificarStockAutomaticamente.Click += new System.EventHandler(this.btnModificarStockAutomaticamente_Click);
            // 
            // btnModificarStock
            // 
            this.btnModificarStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnModificarStock.FlatAppearance.BorderSize = 0;
            this.btnModificarStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarStock.ForeColor = System.Drawing.Color.White;
            this.btnModificarStock.Location = new System.Drawing.Point(29, 554);
            this.btnModificarStock.Name = "btnModificarStock";
            this.btnModificarStock.Size = new System.Drawing.Size(172, 35);
            this.btnModificarStock.TabIndex = 5;
            this.btnModificarStock.Text = "MODIFICAR STOCK";
            this.btnModificarStock.UseVisualStyleBackColor = false;
            this.btnModificarStock.Click += new System.EventHandler(this.btnModificarStock_Click);
            // 
            // txtBuscarProductoStock
            // 
            this.txtBuscarProductoStock.Location = new System.Drawing.Point(174, 44);
            this.txtBuscarProductoStock.Name = "txtBuscarProductoStock";
            this.txtBuscarProductoStock.Size = new System.Drawing.Size(217, 26);
            this.txtBuscarProductoStock.TabIndex = 2;
            this.txtBuscarProductoStock.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarProductoStock_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar producto";
            // 
            // grdStockProductos
            // 
            this.grdStockProductos.AllowUserToAddRows = false;
            this.grdStockProductos.AllowUserToDeleteRows = false;
            this.grdStockProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdStockProductos.BackgroundColor = System.Drawing.Color.White;
            this.grdStockProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStockProductos.Location = new System.Drawing.Point(29, 90);
            this.grdStockProductos.Name = "grdStockProductos";
            this.grdStockProductos.ReadOnly = true;
            this.grdStockProductos.Size = new System.Drawing.Size(596, 449);
            this.grdStockProductos.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnModificarStockProducto);
            this.groupBox2.Controls.Add(this.txtBuscarProductoSinStock);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.grdProductosSinStock);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(674, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 391);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos sin stock";
            // 
            // btnModificarStockProducto
            // 
            this.btnModificarStockProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnModificarStockProducto.FlatAppearance.BorderSize = 0;
            this.btnModificarStockProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarStockProducto.ForeColor = System.Drawing.Color.White;
            this.btnModificarStockProducto.Location = new System.Drawing.Point(198, 335);
            this.btnModificarStockProducto.Name = "btnModificarStockProducto";
            this.btnModificarStockProducto.Size = new System.Drawing.Size(172, 35);
            this.btnModificarStockProducto.TabIndex = 6;
            this.btnModificarStockProducto.Text = "MODIFICAR STOCK";
            this.btnModificarStockProducto.UseVisualStyleBackColor = false;
            this.btnModificarStockProducto.Click += new System.EventHandler(this.btnModificarStockProducto_Click);
            // 
            // txtBuscarProductoSinStock
            // 
            this.txtBuscarProductoSinStock.Location = new System.Drawing.Point(153, 38);
            this.txtBuscarProductoSinStock.Name = "txtBuscarProductoSinStock";
            this.txtBuscarProductoSinStock.Size = new System.Drawing.Size(217, 26);
            this.txtBuscarProductoSinStock.TabIndex = 4;
            this.txtBuscarProductoSinStock.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarProductoSinStock_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar producto";
            // 
            // grdProductosSinStock
            // 
            this.grdProductosSinStock.AllowUserToAddRows = false;
            this.grdProductosSinStock.AllowUserToDeleteRows = false;
            this.grdProductosSinStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProductosSinStock.BackgroundColor = System.Drawing.Color.White;
            this.grdProductosSinStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductosSinStock.Location = new System.Drawing.Point(25, 90);
            this.grdProductosSinStock.Name = "grdProductosSinStock";
            this.grdProductosSinStock.ReadOnly = true;
            this.grdProductosSinStock.Size = new System.Drawing.Size(345, 239);
            this.grdProductosSinStock.TabIndex = 3;
            // 
            // groupModificarStock
            // 
            this.groupModificarStock.Controls.Add(this.txtStockProducto);
            this.groupModificarStock.Controls.Add(this.label4);
            this.groupModificarStock.Controls.Add(this.lblProducto);
            this.groupModificarStock.Controls.Add(this.label3);
            this.groupModificarStock.Controls.Add(this.btnCancelar);
            this.groupModificarStock.Controls.Add(this.btnAceptar);
            this.groupModificarStock.Enabled = false;
            this.groupModificarStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupModificarStock.Location = new System.Drawing.Point(674, 427);
            this.groupModificarStock.Name = "groupModificarStock";
            this.groupModificarStock.Size = new System.Drawing.Size(378, 190);
            this.groupModificarStock.TabIndex = 2;
            this.groupModificarStock.TabStop = false;
            this.groupModificarStock.Text = "Modificar stock producto";
            // 
            // txtStockProducto
            // 
            this.txtStockProducto.Location = new System.Drawing.Point(137, 98);
            this.txtStockProducto.Name = "txtStockProducto";
            this.txtStockProducto.Size = new System.Drawing.Size(159, 26);
            this.txtStockProducto.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stock";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(21, 62);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(14, 20);
            this.lblProducto.TabIndex = 6;
            this.lblProducto.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Producto:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(25, 149);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(122, 35);
            this.btnCancelar.TabIndex = 5;
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
            this.btnAceptar.Location = new System.Drawing.Point(174, 149);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(122, 35);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 650);
            this.Controls.Add(this.groupModificarStock);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStock";
            this.Text = "frmStock";
            this.Load += new System.EventHandler(this.frmStock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStockProductos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductosSinStock)).EndInit();
            this.groupModificarStock.ResumeLayout(false);
            this.groupModificarStock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdStockProductos;
        private System.Windows.Forms.TextBox txtBuscarProductoStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdProductosSinStock;
        private System.Windows.Forms.TextBox txtBuscarProductoSinStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupModificarStock;
        private System.Windows.Forms.Button btnModificarStock;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStockProducto;
        private System.Windows.Forms.Button btnModificarStockProducto;
        private System.Windows.Forms.Button btnModificarStockAutomaticamente;
    }
}