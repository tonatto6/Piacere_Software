
namespace UI.Forms
{
    partial class frmInformes
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listProductos = new System.Windows.Forms.ListBox();
            this.btnVerDetalles = new System.Windows.Forms.Button();
            this.btnBuscarPorDias = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.grdVentas = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1040, 624);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comparacion ventas y gastos";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(18, 40);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1003, 578);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listProductos);
            this.groupBox2.Controls.Add(this.btnVerDetalles);
            this.groupBox2.Controls.Add(this.btnBuscarPorDias);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpFecha);
            this.groupBox2.Controls.Add(this.grdVentas);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(1099, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 666);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // listProductos
            // 
            this.listProductos.FormattingEnabled = true;
            this.listProductos.ItemHeight = 20;
            this.listProductos.Location = new System.Drawing.Point(29, 400);
            this.listProductos.Name = "listProductos";
            this.listProductos.Size = new System.Drawing.Size(546, 224);
            this.listProductos.TabIndex = 18;
            // 
            // btnVerDetalles
            // 
            this.btnVerDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnVerDetalles.FlatAppearance.BorderSize = 0;
            this.btnVerDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDetalles.ForeColor = System.Drawing.Color.White;
            this.btnVerDetalles.Location = new System.Drawing.Point(395, 319);
            this.btnVerDetalles.Name = "btnVerDetalles";
            this.btnVerDetalles.Size = new System.Drawing.Size(180, 35);
            this.btnVerDetalles.TabIndex = 17;
            this.btnVerDetalles.Text = "VER DETALLES";
            this.btnVerDetalles.UseVisualStyleBackColor = false;
            this.btnVerDetalles.Click += new System.EventHandler(this.btnVerDetalles_Click);
            // 
            // btnBuscarPorDias
            // 
            this.btnBuscarPorDias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarPorDias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(88)))));
            this.btnBuscarPorDias.FlatAppearance.BorderSize = 0;
            this.btnBuscarPorDias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPorDias.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPorDias.Location = new System.Drawing.Point(350, 49);
            this.btnBuscarPorDias.Name = "btnBuscarPorDias";
            this.btnBuscarPorDias.Size = new System.Drawing.Size(100, 35);
            this.btnBuscarPorDias.TabIndex = 16;
            this.btnBuscarPorDias.Text = "BUSCAR";
            this.btnBuscarPorDias.UseVisualStyleBackColor = false;
            this.btnBuscarPorDias.Click += new System.EventHandler(this.btnBuscarPorDias_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccionar fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(29, 58);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(290, 26);
            this.dtpFecha.TabIndex = 2;
            // 
            // grdVentas
            // 
            this.grdVentas.AllowUserToAddRows = false;
            this.grdVentas.AllowUserToDeleteRows = false;
            this.grdVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grdVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdVentas.BackgroundColor = System.Drawing.Color.White;
            this.grdVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVentas.Location = new System.Drawing.Point(29, 101);
            this.grdVentas.Name = "grdVentas";
            this.grdVentas.ReadOnly = true;
            this.grdVentas.Size = new System.Drawing.Size(546, 203);
            this.grdVentas.TabIndex = 2;
            // 
            // frmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 650);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInformes";
            this.Text = "frmInformes";
            this.Load += new System.EventHandler(this.frmInformes_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdVentas;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarPorDias;
        private System.Windows.Forms.Button btnVerDetalles;
        private System.Windows.Forms.ListBox listProductos;
    }
}