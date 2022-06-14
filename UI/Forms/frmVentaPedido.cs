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
    public partial class frmVentaPedido : Form
    {

        #region Campos

        BLLVenta oBLLVenta;
        BEVenta oBEVenta;

        BLLProducto oBLLProducto;
        BLLPicada oBLLPicada;
        BLLMetodoPago oBLLMetodoPago;

        BEProducto oBEProducto;
        BEPicada oBEPicada;

        List<BEProducto> lista_productos;
        List<BEPicada> lista_picadas;

        #endregion

        public frmVentaPedido(List<BEProducto> pListaProductos, List<BEPicada> pListaPicadas, string pCliente)
        {
            InitializeComponent();
            lista_productos = new List<BEProducto>();
            lista_picadas = new List<BEPicada>();
            lista_productos = pListaProductos;
            lista_picadas = pListaPicadas;
            lblCliente.Text = pCliente;
        }

        #region Funciones privadas

        private void Cargar_Grilla_Productos_Picadas()
        {
            try
            {
                grdProductos.DataSource = null;
                grdProductos.DataSource = lista_productos;

                if(grdProductos.Rows.Count > 0)
                {
                    grdProductos.Columns["Codigo"].Visible = false;
                    grdProductos.Columns["Bodega"].Visible = false;
                    grdProductos.Columns["Cantidad"].Visible = false;
                }

                grdPicadas.DataSource = null;
                grdPicadas.DataSource = lista_picadas;

                if (grdPicadas.Rows.Count > 0)
                {
                    grdPicadas.Columns["Codigo"].Visible = false;
                    grdPicadas.Columns["Descripcion"].Visible = false;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void Generar_N_Venta()
        {
            try
            {
                oBLLVenta = new BLLVenta();
                lblNumeroVenta.Text = (oBLLVenta.Generar_N_Venta()).ToString();
            }
            catch (Exception ex) { throw ex; }
        }

        private void Cargar_Metodos_Pago()
        {
            try
            {
                oBLLMetodoPago = new BLLMetodoPago();
                cboMetodoPago.DataSource = oBLLMetodoPago.Listar_Metodos_Pago();
                cboMetodoPago.ValueMember = "Codigo";
                cboMetodoPago.DisplayMember = "Metodo_Pago";
                cboMetodoPago.Text = "Seleccionar";
            }
            catch (Exception ex) { throw ex; }
        }

        private void Calcular_Subtotal()
        {
            try
            {
                decimal subtotal = 0;

                if(lista_productos != null)
                {
                    foreach (BEProducto oBEProducto in lista_productos)
                    {
                        subtotal = subtotal + oBEProducto.Precio_Unidad;
                    }
                }

                if(lista_picadas != null)
                {
                    foreach (BEPicada oBEPicada in lista_picadas)
                    {
                        subtotal = subtotal + oBEPicada.Precio;
                    }
                }


                lblSubTotal.Text = subtotal.ToString();
                lblMontoTotal.Text = subtotal.ToString();
            }
            catch (Exception ex) { throw ex; }
        }

        private void Calcular_MontoTotal()
        {
            try
            {

                //Descuento
                if (Convert.ToDecimal(txtDescuentoPesos.Text) > 0)
                {
                    lblMontoTotal.Text = (Convert.ToDecimal(lblSubTotal.Text) - Convert.ToDecimal(txtDescuentoPesos.Text)).ToString();
                }

                //Recargo
                if (Convert.ToDecimal(txtRecargoPesos.Text) > 0)
                {
                    lblMontoTotal.Text = (Convert.ToDecimal(lblSubTotal.Text) + Convert.ToDecimal(txtRecargoPesos.Text)).ToString();
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void Seleccionar_Producto()
        {
            try
            {
                oBLLProducto = new BLLProducto();
                oBEProducto = (BEProducto)grdProductos.CurrentRow.DataBoundItem;

                BEProducto Producto = new BEProducto();
                Producto = oBLLProducto.Seleccionar_Producto(oBEProducto);
                lblPrecioActualProducto.Text = Producto.Precio_Unidad.ToString();
            }
            catch (Exception ex) { throw ex; }
        }

        private void Seleccionar_Picada()
        {
            try
            {
                oBLLPicada = new BLLPicada();
                oBEPicada = (BEPicada)grdPicadas.CurrentRow.DataBoundItem;

                BEPicada Picada = new BEPicada();
                Picada = oBLLPicada.Seleccionar_Picada(oBEPicada);
                lblPrecioActualPicada.Text = Picada.Precio.ToString();
            }
            catch (Exception ex) { throw ex; }
        }

        private void Asignar()
        {
            try
            {
                oBEVenta = new BEVenta(Convert.ToInt32(lblNumeroVenta.Text), lblCliente.Text, DateTime.Now, Convert.ToDecimal(txtDescuentoPesos.Text), Convert.ToDecimal(txtRecargoPesos.Text), Convert.ToDecimal(lblMontoTotal.Text), (BEMetodoPago)cboMetodoPago.SelectedItem, lista_productos, lista_picadas);
            }
            catch (Exception ex) { throw ex; }
        }

        private void Borrar()
        {
            try
            {
                lblNumeroVenta.Text = "";
                lblCliente.Text = "";
                txtDescuentoPesos.Text = "";
                txtRecargoPesos.Text = "";
                lblSubTotal.Text = "0";
                lblMontoTotal.Text = "0";
                grdPicadas.DataSource = null;
                grdProductos.DataSource = null;
                lblPrecioActualPicada.Text = "";
                lblPrecioActualProducto.Text = "";
            }
            catch (Exception ex) { throw ex; }
        }

        #endregion

        private void frmVentaPedido_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Grilla_Productos_Picadas();
                Cargar_Metodos_Pago();
                Generar_N_Venta();
                Calcular_MontoTotal();
                Calcular_Subtotal();
            }
            catch (Exception ex) { throw ex; }
        }

        #region Eventos grilla productos

        private void grdProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Seleccionar_Producto();
            }
            catch (Exception ex) { throw ex; }
        }

        private void grdProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Seleccionar_Producto();
            }
            catch (Exception ex) { throw ex; }
        }

        private void grdProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Seleccionar_Producto();
            }
            catch (Exception ex) { throw ex; }
        }

        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmPedidos.Pedido_Eliminar = false;
            this.Close();
        }

        private void txtDescuentoPesos_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txtDescuentoPesos.Text != "")
                {
                    if (Convert.ToDecimal(txtDescuentoPesos.Text) > 0)
                    {
                        lblMontoTotal.Text = (Convert.ToDecimal(lblSubTotal.Text) - Convert.ToDecimal(txtDescuentoPesos.Text)).ToString();
                    }
                    txtRecargoPesos.Enabled = false;
                }
                else
                {
                    txtDescuentoPesos.Text = "0";
                    lblMontoTotal.Text = lblSubTotal.Text;
                    txtRecargoPesos.Enabled = true;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void txtRecargoPesos_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txtRecargoPesos.Text != "")
                {
                    //Recargo
                    if (Convert.ToDecimal(txtRecargoPesos.Text) > 0)
                    {
                        lblMontoTotal.Text = (Convert.ToDecimal(lblSubTotal.Text) + Convert.ToDecimal(txtRecargoPesos.Text)).ToString();
                    }
                    txtDescuentoPesos.Enabled = false;
                }
                else
                {
                    txtRecargoPesos.Text = "0";
                    lblMontoTotal.Text = lblSubTotal.Text;
                    txtDescuentoPesos.Enabled = true;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void grdPicadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Seleccionar_Picada();
            }
            catch (Exception ex) { throw ex; }
        }

        private void grdPicadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Seleccionar_Picada();
            }
            catch (Exception ex) { throw ex; }
        }

        private void grdPicadas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Seleccionar_Picada();
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnCambiarPrecioProducto_Click(object sender, EventArgs e)
        {
            try
            {
                oBLLProducto = new BLLProducto();
                oBEProducto = (BEProducto)grdProductos.CurrentRow.DataBoundItem;

                BEProducto Producto = new BEProducto();
                Producto = oBLLProducto.Seleccionar_Producto(oBEProducto);

                foreach(BEProducto producto in lista_productos)
                {
                    if(producto.Codigo == Producto.Codigo)
                    {
                        producto.Precio_Unidad = Producto.Precio_Unidad;
                    }
                }

                Cargar_Grilla_Productos_Picadas();
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnCambiarPrecioPicada_Click(object sender, EventArgs e)
        {
            try
            {
                oBLLPicada = new BLLPicada();
                oBEPicada = (BEPicada)grdPicadas.CurrentRow.DataBoundItem;

                BEPicada Picada = new BEPicada();
                Picada = oBLLPicada.Seleccionar_Picada(oBEPicada);

                foreach (BEPicada picada in lista_picadas)
                {
                    if (picada.Codigo == Picada.Codigo)
                    {
                        picada.Precio = Picada.Precio;
                    }
                }

                Cargar_Grilla_Productos_Picadas();
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                oBLLVenta = new BLLVenta();
                Asignar();
                if (oBLLVenta.Verificar_N_Venta(oBEVenta) == false)
                {
                    if (oBLLVenta.Agregar_Venta(oBEVenta) == true)
                    {
                        oBLLVenta.Agregar_Detalle_Venta(oBEVenta);
                        oBLLProducto = new BLLProducto();

                        if(oBEVenta.Retornar_Lista_Productos(oBEVenta) != null)
                        {
                            foreach (BEProducto Producto in oBEVenta.Retornar_Lista_Productos(oBEVenta))
                            {
                                oBLLProducto.Descontar_Producto(Producto);
                            }
                        }

                        MessageBox.Show("Venta cargada exitosamente", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Borrar();
                        frmPedidos.Pedido_Eliminar = true;
                        this.Close();
                    }
                }
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
