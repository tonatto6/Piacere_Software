using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BE;
using BLL;

namespace UI.Forms
{
    public partial class frmGastos : Form
    {

        #region Campos

        public int Operacion { get; set; }
        public int Codigo { get; set; }
        public int Mes { get; set; }


        BEGasto oBEGasto;
        BLLGasto oBLLGasto;

        #endregion

        public frmGastos()
        {
            InitializeComponent();
        }

        #region Funciones privadas

        private void Cargar_Grilla()
        {
            try
            {
                oBLLGasto = new BLLGasto();
                grdGastos.DataSource = null;
                grdGastos.DataSource = oBLLGasto.Listar_Gastos(Convert.ToInt32(txtAño.Text));

                if(grdGastos.Rows.Count > 0)
                {
                    grdGastos.Columns["Codigo"].Visible = false;

                    grdGastos.RowsDefaultCellStyle.BackColor = Color.White;
                    grdGastos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                }
                else
                {
                    MessageBox.Show("No se encontraron gastos para el mes seleccionado", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void Cargar_Grilla_Por_Mes(int pMes)
        {
            try
            {
                oBLLGasto = new BLLGasto();
                grdGastos.DataSource = null;
                grdGastos.DataSource = oBLLGasto.Filtrar_Gastos_Por_Mes(pMes, Convert.ToInt32(txtAño.Text));

                if (grdGastos.Rows.Count > 0)
                {
                    grdGastos.Columns["Codigo"].Visible = false;

                    grdGastos.RowsDefaultCellStyle.BackColor = Color.White;
                    grdGastos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                }
                else
                {
                    MessageBox.Show("No se encontraron gastos para el mes seleccionado", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void Asignar()
        {
            try
            {
                oBEGasto = new BEGasto();
                oBEGasto.Codigo = Codigo;
                oBEGasto.Gasto = txtGasto.Text;
                oBEGasto.Fecha = Convert.ToDateTime(dtpFechaGasto.Text);
                oBEGasto.Monto = Convert.ToDecimal(txtMontoTotal.Text);
            }
            catch (Exception ex) { throw ex; }
        }

        private void Borrar()
        {
            try
            {
                cboMes.Text = "Todos";
                txtAño.Text = DateTime.Now.Year.ToString();
                groupOperacionGastos.Enabled = false;
                btnNuevo.Enabled = true;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
                txtGasto.Text = "";
                dtpFechaGasto.Text = DateTime.Now.ToString();
                txtMontoTotal.Text = "0";
                txtAñoGrafico.Text = DateTime.Now.Year.ToString();
            }
            catch (Exception ex) { throw ex; }
        }

        private void Total_Gastos()
        {
            try
            {
                oBLLGasto = new BLLGasto();
                lblTotalGastos.Text = oBLLGasto.Total_Gastos(Convert.ToInt32(txtAño.Text)).ToString();
            }
            catch (Exception ex) { throw ex; }
        }

        private void Total_Gastos_Mes()
        {
            try
            {
                oBLLGasto = new BLLGasto();
                //lblTotalGastosMes.Text = oBLLGasto.Gasto_Total_Mes(Convert.ToInt32(txtAño.Text), Mes).ToString();
            }
            catch (Exception ex) { throw ex; }
        }

        private void Cargar_Grafico_Gastos()
        {
            try
            {
                oBLLGasto = new BLLGasto();

                Dictionary<string, decimal> lDatos = new Dictionary<string, decimal>();
                lDatos = oBLLGasto.Grafico_Gastos(Convert.ToInt32(txtAñoGrafico.Text));

                chartGastos.Titles.Clear();
                chartGastos.ChartAreas.Clear();
                chartGastos.Series.Clear();

                Title Titulo = new Title("Gastos por mes");
                Titulo.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
                chartGastos.Titles.Add(Titulo);

                ChartArea Area = new ChartArea();
                //Area.Area3DStyle.Enable3D = true;
                chartGastos.ChartAreas.Add(Area);


                Series serie = new Series("Mes");

                serie.ChartType = SeriesChartType.Column;
                serie.Points.DataBindXY(lDatos.Keys, lDatos.Values);

                chartGastos.Series.Add(serie);
            }
            catch (Exception ex) { throw ex; }
        }

        private void Actualizar_Datos()
        {
            try
            {
                Cargar_Grilla();
                Total_Gastos();
                Cargar_Grafico_Gastos();
            }
            catch (Exception ex) { throw ex; }
        }

        private void Obtener_Mes()
        {
            try
            {
                switch (cboMes.Text)
                {
                    case "Enero":
                        Mes = 1;
                        break;
                    case "Febrero":
                        Mes = 2;
                        break;
                    case "Marzo":
                        Mes = 3;
                        break;
                    case "Abril":
                        Mes = 4;
                        break;
                    case "Mayo":
                        Mes = 5;
                        break;
                    case "Junio":
                        Mes = 6;
                        break;
                    case "Julio":
                        Mes = 7;
                        break;
                    case "Agosto":
                        Mes = 8;
                        break;
                    case "Septiembre":
                        Mes = 9;
                        break;
                    case "Octubre":
                        Mes = 10;
                        break;
                    case "Noviembre":
                        Mes = 11;
                        break;
                    case "Diciembre":
                        Mes = 12;
                        break;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        #endregion

        private void frmStock_Load(object sender, EventArgs e)
        {
            try
            {
                txtAño.Text = DateTime.Now.Year.ToString();
                txtAñoGrafico.Text = DateTime.Now.Year.ToString();
                Cargar_Grilla();
                Total_Gastos();
                Cargar_Grafico_Gastos();
            }
            catch (Exception ex) { throw ex; }
        }

        private void cboMes_TextChanged(object sender, EventArgs e)
        {
            try
            {
                switch(cboMes.Text)
                {
                    case "Todos":
                        Cargar_Grilla();
                        break;
                    case "Enero":
                        Cargar_Grilla_Por_Mes(1);
                        break;
                    case "Febrero":
                        Cargar_Grilla_Por_Mes(2);
                        break;
                    case "Marzo":
                        Cargar_Grilla_Por_Mes(3);
                        break;
                    case "Abril":
                        Cargar_Grilla_Por_Mes(4);
                        break;
                    case "Mayo":
                        Cargar_Grilla_Por_Mes(5);
                        break;
                    case "Junio":
                        Cargar_Grilla_Por_Mes(6);
                        break;
                    case "Julio":
                        Cargar_Grilla_Por_Mes(7);
                        break;
                    case "Agosto":
                        Cargar_Grilla_Por_Mes(8);
                        break;
                    case "Septiembre":
                        Cargar_Grilla_Por_Mes(9);
                        break;
                    case "Octubre":
                        Cargar_Grilla_Por_Mes(10);
                        break;
                    case "Noviembre":
                        Cargar_Grilla_Por_Mes(11);
                        break;
                    case "Diciembre":
                        Cargar_Grilla_Por_Mes(12);
                        break;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                btnNuevo.Enabled = false;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                groupOperacionGastos.Enabled = true;
                Operacion = 1;
                Codigo = 0;
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar el gasto seleccionado?", "Piacere software", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(result == DialogResult.Yes)
                {
                    Operacion = 2;
                    oBLLGasto = new BLLGasto();
                    oBEGasto = (BEGasto)grdGastos.CurrentRow.DataBoundItem;

                    if(oBLLGasto.Operacion_Gasto(oBEGasto, Operacion) == true)
                    {
                        MessageBox.Show("Gasto eliminado exitosamente", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cboMes.Text = "Todos";
                        Actualizar_Datos();
                    }
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                btnNuevo.Enabled = false;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                Operacion = 3;
                oBEGasto = (BEGasto)grdGastos.CurrentRow.DataBoundItem;
                Codigo = oBEGasto.Codigo;
                txtGasto.Text = oBEGasto.Gasto;
                dtpFechaGasto.Text = oBEGasto.Fecha.ToString();
                txtMontoTotal.Text = oBEGasto.Monto.ToString();
                groupOperacionGastos.Enabled = true;
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Asignar();
                oBLLGasto = new BLLGasto();

                if(oBLLGasto.Operacion_Gasto(oBEGasto, Operacion) == true)
                {
                    MessageBox.Show("Operacion realizada correctamente", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Borrar();
                    Actualizar_Datos();
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Borrar();
                Actualizar_Datos();
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                Cargar_Grafico_Gastos();
            }
            catch (Exception ex) { throw ex; }
        }

        private void cboMesGastos_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Obtener_Mes();
                Total_Gastos_Mes();
            }
            catch (Exception ex) { throw ex; }
        }

        private void txtAño_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if(txtAño.TextLength == 4)
                {
                    if(cboMes.Text == "Todos")
                    { Cargar_Grilla(); }
                    else
                    {
                        Obtener_Mes();
                        Cargar_Grilla_Por_Mes(Mes);
                    }

                    Total_Gastos();
                }
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
