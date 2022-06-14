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
    public partial class frmVentas : Form
    {

        #region Campos

        List<BEProducto> lista_productos;
        List<BEPicada> lista_picadas;
        BEProducto oBEProducto;
        BLLProducto oBLLProducto;

        BLLVenta oBLLVenta;
        BEVenta oBEVenta;

        BEPicada oBEPicada;
        BLLPicada oBLLPicada;

        BEMetodoPago oBEMetodoPago;
        BLLMetodoPago oBLLMetodoPago;

        decimal montototal = 0;

        #endregion

        public frmVentas()
        {
            InitializeComponent();
        }

        #region Funciones privadas

        private void Cargar_Grilla_Productos()
        {
            try
            {
                oBLLProducto = new BLLProducto();
                grdProductos.DataSource = null;
                grdProductos.DataSource = oBLLProducto.Listar_Productos();

                if (grdProductos.Rows.Count > 0)
                {
                    grdProductos.Columns["Codigo"].Visible = false;
                    grdProductos.Columns["Bodega"].Visible = false;

                    grdProductos.Columns["Precio_Unidad"].HeaderText = "Precio";

                    grdProductos.RowsDefaultCellStyle.BackColor = Color.White;
                    grdProductos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                }
                else { grdProductos.DataSource = null; }
            }
            catch (Exception ex) { throw ex; }
        }

        private void Cargar_Grilla_Picadas()
        {
            try
            {
                oBLLPicada = new BLLPicada();
                grdPicadas.DataSource = null;
                grdPicadas.DataSource = oBLLPicada.Listar_Picadas();

                if (grdPicadas.Rows.Count > 0)
                {
                    grdPicadas.Columns["Codigo"].Visible = false;

                    grdPicadas.RowsDefaultCellStyle.BackColor = Color.White;
                    grdPicadas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                }
                else { grdPicadas.DataSource = null; }
            }
            catch (Exception ex) { throw ex; }
        }

        private void Buscar_Producto()
        {
            try
            {
                oBLLProducto = new BLLProducto();
                grdProductos.DataSource = null;
                grdProductos.DataSource = oBLLProducto.Buscar_Producto(txtBuscarProducto.Text);

                if (grdProductos.Rows.Count > 0)
                {
                    grdProductos.Columns["Codigo"].Visible = false;

                    grdProductos.Columns["Precio_Unidad"].HeaderText = "Unidad";

                    grdProductos.RowsDefaultCellStyle.BackColor = Color.White;
                    grdProductos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                }
            }
            catch (Exception ex) { throw ex; }

        }
        
        private void Buscar_Picada()
        {
            try
            {
                oBLLPicada = new BLLPicada();
                grdPicadas.DataSource = null;
                grdPicadas.DataSource = oBLLPicada.Buscar_Picadas(txtBuscarPicada.Text);

                if (grdPicadas.Rows.Count > 0)
                {
                    grdPicadas.Columns["Codigo"].Visible = false;
                }
                else { grdPicadas.DataSource = null; }
            }
            catch (Exception ex) { throw ex; }
        }

        private void Calcular_Subtotal()
        {
            try
            {
                decimal subtotal = 0;

                foreach(BEProducto oBEProducto in lista_productos)
                {
                    subtotal = subtotal + oBEProducto.Precio_Unidad;
                }

                foreach(BEPicada oBEPicada in lista_picadas)
                {
                    subtotal = subtotal + oBEPicada.Precio;
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
                if(Convert.ToDecimal(txtDescuentoPesos.Text) > 0)
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

        private void Borrar()
        {
            try
            {
                txtBuscarProducto.Text = "";
                grdProductosSeleccionados.DataSource = null;
                grdPicadaSeleccionada.DataSource = null;
                lista_productos.Clear();
                txtCliente.Text = "";
                txtDescuentoPesos.Text = "0";
                txtRecargoPesos.Text = "0";
                txtOtroMetodoPago.Text = "";
                lblSubTotal.Text = "0";
                lblMontoTotal.Text = "0";
                cboMetodoPago.Text = "Seleccionar";
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

        private void Asignar()
        {
            try
            {
                oBEVenta = new BEVenta(Convert.ToInt32(lblNumeroVenta.Text), txtCliente.Text, DateTime.Now, Convert.ToDecimal(txtDescuentoPesos.Text), Convert.ToDecimal(txtRecargoPesos.Text), Convert.ToDecimal(lblMontoTotal.Text), (BEMetodoPago)cboMetodoPago.SelectedItem, lista_productos, lista_picadas);
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

        private bool Validar_Campos()
        {
            try
            {
                if(cboMetodoPago.Text != "Seleccionar" || txtCliente.Text != "" || lista_productos.Count > 0)
                {
                    return true;
                }
                else { return false; }
            }
            catch (Exception ex) { throw ex; }
 
        }

        private void Estilo_Grilla_Productos()
        {
            try
            {
                if(grdProductosSeleccionados.Rows.Count > 0)
                {
                    grdProductosSeleccionados.Columns["Codigo"].Visible = false;
                    grdProductosSeleccionados.Columns["Bodega"].Visible = false;
                    grdProductosSeleccionados.Columns["Cantidad"].Visible = false;

                    grdProductosSeleccionados.Columns["Precio_Unidad"].HeaderText = "Precio";
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void Estilo_Grilla_Picadas()
        {
            try
            {
                if (grdPicadaSeleccionada.Rows.Count > 0)
                {
                    grdPicadaSeleccionada.Columns["Codigo"].Visible = false;
                    grdPicadaSeleccionada.Columns["Descripcion"].Visible = false;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        #endregion

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                oBEProducto = (BEProducto)grdProductos.CurrentRow.DataBoundItem;
                DialogResult result = MessageBox.Show("¿Desea agregar el producto " + oBEProducto.Nombre + " al carrito?", "Piacere software", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if(result == DialogResult.Yes)
                {
                    //Se debe preguntar la cantidad para saber cuantos productos agregar
                    lista_productos.Add(oBEProducto);

                    int cantProducto = 0;
                    foreach(BEProducto producto in lista_productos)
                    {
                        if(producto == oBEProducto)
                        { cantProducto++; }
                    }

                    if(oBEProducto.Cantidad >= cantProducto)
                    {
                        grdProductosSeleccionados.DataSource = null;
                        grdProductosSeleccionados.DataSource = lista_productos;

                        Estilo_Grilla_Productos();
                        Calcular_Subtotal();
                        Calcular_MontoTotal();
                    }
                    else
                    {
                        MessageBox.Show("La cantidad de productos seleccionados sobrepasa el stock", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        lista_productos.Remove(oBEProducto);
                    }

                }

            }
            catch (Exception ex) { throw ex; }
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Grilla_Productos();
                Cargar_Grilla_Picadas();
                lista_productos = new List<BEProducto>();
                lista_picadas = new List<BEPicada>();
                Generar_N_Venta();
                Cargar_Metodos_Pago();
            }
            catch (Exception ex) { throw ex; }
        }

        private void txtBuscarProducto_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if(txtBuscarProducto.Text == "")
                { Cargar_Grilla_Productos(); }
                else { Buscar_Producto(); }
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                if(grdProductosSeleccionados.Rows.Count >0)
                {
                    oBEProducto = (BEProducto)grdProductosSeleccionados.CurrentRow.DataBoundItem;
                    DialogResult result = MessageBox.Show("¿Desea quitar el producto " + oBEProducto.Nombre + " del carrito?", "Piacere software", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        lista_productos.Remove(oBEProducto);

                        grdProductosSeleccionados.DataSource = null;
                        grdProductosSeleccionados.DataSource = lista_productos;

                        Estilo_Grilla_Productos();
                        Calcular_Subtotal();
                        Calcular_MontoTotal();
                    }
                }
                else { MessageBox.Show("No hay productos en el carrito para quitar", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Borrar();
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

        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                oBLLVenta = new BLLVenta();
                Asignar();
                if(Validar_Campos() == true)
                {
                    if (oBLLVenta.Verificar_N_Venta(oBEVenta) == false)
                    {
                        if (oBLLVenta.Agregar_Venta(oBEVenta) == true)
                        {
                            oBLLVenta.Agregar_Detalle_Venta(oBEVenta);
                            oBLLProducto = new BLLProducto();

                            foreach(BEProducto Producto in oBEVenta.Retornar_Lista_Productos(oBEVenta))
                            {
                                oBLLProducto.Descontar_Producto(Producto);
                            }

                            MessageBox.Show("Venta cargada exitosamente", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Borrar();
                            Generar_N_Venta();
                            Cargar_Grilla_Productos();
                        }
                    }
                }
                else { MessageBox.Show("Debe completar todos los campos", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnSeleccionarPicada_Click(object sender, EventArgs e)
        {
            try
            {
                oBEPicada = (BEPicada)grdPicadas.CurrentRow.DataBoundItem;
                lista_picadas.Add(oBEPicada);

                grdPicadaSeleccionada.DataSource = null;
                grdPicadaSeleccionada.DataSource = lista_picadas;
                Estilo_Grilla_Picadas();

                Calcular_Subtotal();
                Calcular_MontoTotal();
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnVerDetallePicada_Click(object sender, EventArgs e)
        {
            try
            {
                oBEPicada = (BEPicada)grdPicadas.CurrentRow.DataBoundItem;

                frmVerDetallePicada verDetallePicada = new frmVerDetallePicada(oBEPicada);
                verDetallePicada.ShowDialog();
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnQuitarPicada_Click(object sender, EventArgs e)
        {
            try
            {
                if(grdPicadaSeleccionada.Rows.Count > 0)
                {
                    oBEPicada = (BEPicada)grdPicadaSeleccionada.CurrentRow.DataBoundItem;
                    DialogResult result = MessageBox.Show("¿Desea quitar la picada " + oBEPicada.Nombre + " del carrito?", "Piacere software", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        lista_picadas.Remove(oBEPicada);

                        grdPicadaSeleccionada.DataSource = null;
                        grdPicadaSeleccionada.DataSource = lista_picadas;

                        Estilo_Grilla_Picadas();
                        Calcular_Subtotal();
                        Calcular_MontoTotal();
                    }
                }
                else { MessageBox.Show("No hay productos en el carrito para quitar", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnNuevaPicada_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea agregar una nueva picada?", "Piacere software", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(DialogResult.Yes == result)
                {
                    frmNuevaPicada nuevapicada = new frmNuevaPicada();
                    nuevapicada.ShowDialog();

                    Cargar_Grilla_Picadas();
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnAgregarMetodoPago_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtOtroMetodoPago.Text != "")
                {
                    oBEMetodoPago = new BEMetodoPago();
                    oBEMetodoPago.Metodo_Pago = txtOtroMetodoPago.Text;

                    oBLLMetodoPago = new BLLMetodoPago();
                    if(oBLLMetodoPago.Agregar_Metodo_Pago(oBEMetodoPago) == true)
                    {
                        MessageBox.Show("Se agregó correctamente el nuevo metodo de pago", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtOtroMetodoPago.Text = "";
                        Cargar_Metodos_Pago();
                    }
                }
                else { MessageBox.Show("Debe completar el campo requerido para agregar un nuevo metodo de pago", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            catch (Exception ex) { throw ex; }
        }

        private void txtBuscarPicada_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txtBuscarPicada.Text != "")
                { Buscar_Picada(); }
                else { Cargar_Grilla_Picadas(); }
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
