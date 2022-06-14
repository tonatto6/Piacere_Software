
namespace UI.Forms
{
    partial class frmGastos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGastos));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupListaGastos = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdGastos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotalGastos = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAñoGrafico = new System.Windows.Forms.TextBox();
            this.chartGastos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupOperacionGastos = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dtpFechaGasto = new System.Windows.Forms.DateTimePicker();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.txtGasto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupListaGastos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGastos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGastos)).BeginInit();
            this.groupOperacionGastos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupListaGastos
            // 
            this.groupListaGastos.Controls.Add(this.btnModificar);
            this.groupListaGastos.Controls.Add(this.btnEliminar);
            this.groupListaGastos.Controls.Add(this.btnNuevo);
            this.groupListaGastos.Controls.Add(this.txtAño);
            this.groupListaGastos.Controls.Add(this.label2);
            this.groupListaGastos.Controls.Add(this.cboMes);
            this.groupListaGastos.Controls.Add(this.label1);
            this.groupListaGastos.Controls.Add(this.grdGastos);
            this.groupListaGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupListaGastos.Location = new System.Drawing.Point(12, 6);
            this.groupListaGastos.Name = "groupListaGastos";
            this.groupListaGastos.Size = new System.Drawing.Size(462, 424);
            this.groupListaGastos.TabIndex = 0;
            this.groupListaGastos.TabStop = false;
            this.groupListaGastos.Text = "Lista de gastos";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(287, 338);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(122, 35);
            this.btnModificar.TabIndex = 11;
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
            this.btnEliminar.Location = new System.Drawing.Point(146, 338);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 35);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(6, 338);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(122, 35);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(354, 44);
            this.txtAño.MaxLength = 4;
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(82, 26);
            this.txtAño.TabIndex = 3;
            this.txtAño.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAño_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Año";
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
            this.cboMes.Location = new System.Drawing.Point(122, 39);
            this.cboMes.Name = "cboMes";
            this.cboMes.Size = new System.Drawing.Size(175, 28);
            this.cboMes.TabIndex = 1;
            this.cboMes.Text = "Todos";
            this.cboMes.TextChanged += new System.EventHandler(this.cboMes_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtrar por mes";
            // 
            // grdGastos
            // 
            this.grdGastos.AllowUserToAddRows = false;
            this.grdGastos.AllowUserToDeleteRows = false;
            this.grdGastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdGastos.BackgroundColor = System.Drawing.Color.White;
            this.grdGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGastos.Location = new System.Drawing.Point(6, 87);
            this.grdGastos.Name = "grdGastos";
            this.grdGastos.ReadOnly = true;
            this.grdGastos.Size = new System.Drawing.Size(430, 245);
            this.grdGastos.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotalGastos);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(581, 442);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 136);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total gastos";
            // 
            // lblTotalGastos
            // 
            this.lblTotalGastos.AutoSize = true;
            this.lblTotalGastos.Location = new System.Drawing.Point(139, 58);
            this.lblTotalGastos.Name = "lblTotalGastos";
            this.lblTotalGastos.Size = new System.Drawing.Size(14, 20);
            this.lblTotalGastos.TabIndex = 14;
            this.lblTotalGastos.Text = "-";
            this.lblTotalGastos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAñoGrafico);
            this.groupBox1.Controls.Add(this.chartGastos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(480, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 424);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graficos sobre gastos";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(329, 27);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(122, 35);
            this.btnFiltrar.TabIndex = 12;
            this.btnFiltrar.Text = "FILTRAR";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Seleccionar año";
            // 
            // txtAñoGrafico
            // 
            this.txtAñoGrafico.Location = new System.Drawing.Point(171, 36);
            this.txtAñoGrafico.Name = "txtAñoGrafico";
            this.txtAñoGrafico.Size = new System.Drawing.Size(118, 26);
            this.txtAñoGrafico.TabIndex = 3;
            // 
            // chartGastos
            // 
            this.chartGastos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartGastos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGastos.Legends.Add(legend1);
            this.chartGastos.Location = new System.Drawing.Point(34, 79);
            this.chartGastos.Name = "chartGastos";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGastos.Series.Add(series1);
            this.chartGastos.Size = new System.Drawing.Size(511, 339);
            this.chartGastos.TabIndex = 3;
            this.chartGastos.Text = "chart1";
            // 
            // groupOperacionGastos
            // 
            this.groupOperacionGastos.Controls.Add(this.btnCancelar);
            this.groupOperacionGastos.Controls.Add(this.btnAceptar);
            this.groupOperacionGastos.Controls.Add(this.dtpFechaGasto);
            this.groupOperacionGastos.Controls.Add(this.txtMontoTotal);
            this.groupOperacionGastos.Controls.Add(this.txtGasto);
            this.groupOperacionGastos.Controls.Add(this.label5);
            this.groupOperacionGastos.Controls.Add(this.label4);
            this.groupOperacionGastos.Controls.Add(this.label3);
            this.groupOperacionGastos.Enabled = false;
            this.groupOperacionGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupOperacionGastos.Location = new System.Drawing.Point(12, 436);
            this.groupOperacionGastos.Name = "groupOperacionGastos";
            this.groupOperacionGastos.Size = new System.Drawing.Size(549, 202);
            this.groupOperacionGastos.TabIndex = 2;
            this.groupOperacionGastos.TabStop = false;
            this.groupOperacionGastos.Text = "Gastos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(173, 152);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(122, 35);
            this.btnCancelar.TabIndex = 8;
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
            this.btnAceptar.Location = new System.Drawing.Point(314, 152);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(122, 35);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dtpFechaGasto
            // 
            this.dtpFechaGasto.Location = new System.Drawing.Point(146, 73);
            this.dtpFechaGasto.Name = "dtpFechaGasto";
            this.dtpFechaGasto.Size = new System.Drawing.Size(290, 26);
            this.dtpFechaGasto.TabIndex = 7;
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(146, 111);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(290, 26);
            this.txtMontoTotal.TabIndex = 6;
            this.txtMontoTotal.Text = "0";
            // 
            // txtGasto
            // 
            this.txtGasto.Location = new System.Drawing.Point(146, 35);
            this.txtGasto.Name = "txtGasto";
            this.txtGasto.Size = new System.Drawing.Size(290, 26);
            this.txtGasto.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Monto total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gasto";
            // 
            // frmGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 650);
            this.Controls.Add(this.groupOperacionGastos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupListaGastos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGastos";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.frmStock_Load);
            this.groupListaGastos.ResumeLayout(false);
            this.groupListaGastos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGastos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGastos)).EndInit();
            this.groupOperacionGastos.ResumeLayout(false);
            this.groupOperacionGastos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupListaGastos;
        private System.Windows.Forms.DataGridView grdGastos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.GroupBox groupOperacionGastos;
        private System.Windows.Forms.DateTimePicker dtpFechaGasto;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.TextBox txtGasto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTotalGastos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGastos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAñoGrafico;
        private System.Windows.Forms.Button btnFiltrar;
    }
}