using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace UI.Forms
{
    public partial class frmDashboard : Form
    {

        #region Campos

        BEVenta oBEVenta;
        BLLVenta oBLLVenta;

        public string Ordenamiento { get; set; }
        public int Mes { get; set; }

        #endregion

        public frmDashboard()
        {
            InitializeComponent();
            Ordenamiento = "Mayor";
        }

        #region Funciones privadas

        private void Cargar_Grilla_Ventas()
        {
            try
            {
                oBLLVenta = new BLLVenta();
                grdVentas.DataSource = null;
                grdVentas.DataSource = oBLLVenta.Listar_Ventas(Convert.ToInt32(txtAño.Text), Ordenamiento);

                if(grdVentas.Rows.Count > 0)
                {
                    grdVentas.Columns["Descuento"].Visible = false;
                    grdVentas.Columns["Recargo"].Visible = false;
                    grdVentas.Columns["Metodo_Pago"].Visible = false;
                    grdVentas.Columns["N_Venta"].Visible = false;

                    //grdVentas.Columns["N_Venta"].HeaderText = "Numero venta";
                    grdVentas.Columns["Monto_Total"].HeaderText = "Monto";
                    //grdVentas.Columns["Metodo_Pago"].HeaderText = "Metodo pago";

                    grdVentas.RowsDefaultCellStyle.BackColor = Color.White;
                    grdVentas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void Cargar_Grilla_Ventas_Mes()
        {
            try
            {
                oBLLVenta = new BLLVenta();
                grdVentas.DataSource = null;
                grdVentas.DataSource = oBLLVenta.Listar_Ventas_Mes(Mes, Convert.ToInt32(txtAño.Text), Ordenamiento);

                if (grdVentas.Rows.Count > 0)
                {
                    grdVentas.Columns["Descuento"].Visible = false;
                    grdVentas.Columns["Recargo"].Visible = false;

                    grdVentas.Columns["N_Venta"].HeaderText = "Numero venta";
                    grdVentas.Columns["Monto_Total"].HeaderText = "Monto";
                    grdVentas.Columns["Metodo_Pago"].HeaderText = "Metodo pago";

                    grdVentas.RowsDefaultCellStyle.BackColor = Color.White;
                    grdVentas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                }
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

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                txtAño.Text = DateTime.Now.Year.ToString();
                Cargar_Grilla_Ventas();
            }
            catch (Exception ex) { throw ex; }
        }

        private void cbMayor_Click(object sender, EventArgs e)
        {
            try
            {
                cbMayor.Checked = true;
                cbMenor.Checked = false;
                Ordenamiento = "Mayor";
                if(cboMes.Text == "Todos")
                { Cargar_Grilla_Ventas(); }
                else { Obtener_Mes(); Cargar_Grilla_Ventas_Mes(); }
            }
            catch (Exception ex) { throw ex; }
        }

        private void cbMenor_Click(object sender, EventArgs e)
        {
            try
            {
                cbMayor.Checked = false;
                cbMenor.Checked = true;
                Ordenamiento = "Menor";
                if (cboMes.Text == "Todos")
                { Cargar_Grilla_Ventas(); }
                else { Obtener_Mes(); Cargar_Grilla_Ventas_Mes(); }
            }
            catch (Exception ex) { throw ex; }
        }

        private void cboMes_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbMayor.Checked == true)
                {
                    Ordenamiento = "Mayor";
                }
                else
                {
                    Ordenamiento = "Menor";
                }

                if (cboMes.Text == "Todos")
                {
                    Cargar_Grilla_Ventas();
                }
                else
                {
                    Obtener_Mes();
                    Cargar_Grilla_Ventas_Mes();
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void txtAño_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if(txtAño.TextLength == 4)
                {
                    //Establece ordenamiento
                    if (cbMayor.Checked == true){Ordenamiento = "Mayor";}
                    else{Ordenamiento = "Menor";}
                    
                    //Definir mes
                    if(cboMes.Text == "Todos") { Cargar_Grilla_Ventas(); }
                    else { Obtener_Mes(); Cargar_Grilla_Ventas_Mes(); }
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnVerDetalleVenta_Click(object sender, EventArgs e)
        {
            try
            {
                oBEVenta = (BEVenta)grdVentas.CurrentRow.DataBoundItem;

                lblCliente.Text = oBEVenta.Cliente;
                lblMetodoPago.Text = oBEVenta.Metodo_Pago.Metodo_Pago;
                lblDescuento.Text = oBEVenta.Descuento.ToString();
                lblRecargo.Text = oBEVenta.Recargo.ToString();
                lblMontoTotal.Text = oBEVenta.Monto_Total.ToString();

                oBLLVenta = new BLLVenta();
                grdProductos.DataSource = null;
                grdProductos.DataSource = oBLLVenta.Listar_Productos_Venta(oBEVenta);

                if(grdProductos.Rows.Count > 0)
                {
                    grdProductos.Columns["Codigo"].Visible = false;
                    grdProductos.Columns["Precio_Unidad"].HeaderText = "Precio";
                    grdProductos.Columns["Bodega"].Visible = false;
                    grdProductos.Columns["Cantidad"].Visible = false;

                    grdProductos.RowsDefaultCellStyle.BackColor = Color.White;
                    grdProductos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                }

                grdPicadas.DataSource = null;
                grdPicadas.DataSource = oBLLVenta.Listar_Picadas_Venta(oBEVenta);

                if (grdPicadas.Rows.Count > 0)
                {
                    grdPicadas.Columns["Codigo"].Visible = false;
                    grdPicadas.Columns["Descripcion"].Visible = false;

                    grdPicadas.RowsDefaultCellStyle.BackColor = Color.White;
                    grdPicadas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                }
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
