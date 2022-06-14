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
    public partial class frmInformes : Form
    {

        #region Campos

        BEGasto oBEGasto;
        BLLGasto oBLLGasto;

        BEVenta oBEVenta;
        BLLVenta oBLLVenta;

        List<BEProducto> listaproductos;
        List<BEPicada> listapicadas;

        #endregion

        public frmInformes()
        {
            InitializeComponent();
        }

        #region Funciones privadas

        private void Cargar_Grafico_Gastos()
        {
            try
            {
                oBLLGasto = new BLLGasto();
                oBLLVenta = new BLLVenta();

                Dictionary<string, decimal> lDatosGastos = new Dictionary<string, decimal>();
                Dictionary<string, decimal> lDatosVentas = new Dictionary<string, decimal>();
                lDatosGastos = oBLLGasto.Grafico_Gastos(2022);
                lDatosVentas = oBLLVenta.Grafico_Ventas(2022);

                chart1.Titles.Clear();
                chart1.ChartAreas.Clear();
                chart1.Series.Clear();

                Title Titulo = new Title("Ventas y gastos por mes");
                Titulo.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
                chart1.Titles.Add(Titulo);

                ChartArea Area = new ChartArea();
                //Area.Area3DStyle.Enable3D = true;
                chart1.ChartAreas.Add(Area);


                Series serieGastos = new Series("Gastos");
                Series serieVentas = new Series("Ventas");

                serieGastos.ChartType = SeriesChartType.Column;
                serieGastos.Points.DataBindXY(lDatosGastos.Keys, lDatosGastos.Values);

                serieVentas.ChartType = SeriesChartType.Column;
                serieVentas.Points.DataBindXY(lDatosVentas.Keys, lDatosVentas.Values);

                chart1.Series.Add(serieGastos);
                chart1.Series.Add(serieVentas);
            }
            catch (Exception ex) { throw ex; }
        }

        private void Cargar_Grilla_Ventas()
        {
            try
            {
                oBLLVenta = new BLLVenta();
                grdVentas.DataSource = null;
                grdVentas.DataSource = oBLLVenta.Listar_Ventas_Fecha(dtpFecha.Value);

                if(grdVentas.Rows.Count > 0)
                {
                    grdVentas.Columns["N_Venta"].Visible = false;
                    grdVentas.Columns["Descuento"].Visible = false;
                    grdVentas.Columns["Recargo"].Visible = false;
                    grdVentas.Columns["Metodo_Pago"].Visible = false;

                    grdVentas.RowsDefaultCellStyle.BackColor = Color.White;
                    grdVentas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                }

            }
            catch (Exception ex) { throw ex; }
        }

        #endregion

        private void frmInformes_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Grafico_Gastos();
                Cargar_Grilla_Ventas();
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnBuscarPorDias_Click(object sender, EventArgs e)
        {
            try
            {
                Cargar_Grilla_Ventas();
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            try
            {
                oBEVenta = (BEVenta)grdVentas.CurrentRow.DataBoundItem;

                oBLLVenta = new BLLVenta();
                listaproductos = new List<BEProducto>();
                listapicadas = new List<BEPicada>();

                listaproductos = oBLLVenta.Listar_Productos_Venta(oBEVenta);
                listapicadas = oBLLVenta.Listar_Picadas_Venta(oBEVenta);

                listProductos.Items.Clear();

                if(listaproductos != null)
                {
                    foreach (BEProducto producto in listaproductos)
                    {
                        listProductos.Items.Add(producto.Nombre + " - $" + producto.Precio_Unidad);
                    }
                }

                if(listapicadas != null)
                {
                    foreach (BEPicada picada in listapicadas)
                    {
                        listProductos.Items.Add(picada.Nombre + " - $" + picada.Precio);
                    }
                }

            }
            catch (Exception ex) { throw ex; }
        }
    }
}
