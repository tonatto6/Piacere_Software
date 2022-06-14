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
    public partial class frmNuevoPedido : Form
    {

        #region Campos

        BEPicada oBEPicada;
        BEProducto oBEProducto;
        BEPedido oBEPedido;

        BLLPicada oBLLPicada;
        BLLProducto oBLLProducto;
        BLLPedido oBLLPedido;

        List<BEPicada> lista_picadas;
        List<BEProducto> lista_productos;

        #endregion

        public frmNuevoPedido()
        {
            InitializeComponent();
            lista_picadas = new List<BEPicada>();
            lista_productos = new List<BEProducto>();
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

                    grdProductos.Columns["Precio_Unidad"].HeaderText = "Unidad";

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
                }
                else { grdPicadas.DataSource = null; }
            }
            catch (Exception ex) { throw ex; }
        }

        private void Mostrar_Carrito()
        {
            try
            {
                //listaProductosSeleccionados.DataSource = null;
                listaProductosSeleccionados.Items.Clear();

                if (lista_productos.Count > 0)
                {
                    foreach (BEProducto producto in lista_productos)
                    {
                        listaProductosSeleccionados.Items.Add(producto.Nombre + " - $" + producto.Precio_Unidad);
                    }
                }

                if (lista_picadas.Count > 0)
                {
                    foreach (BEPicada picada in lista_picadas)
                    {
                        listaProductosSeleccionados.Items.Add(picada.Nombre + " - $" + picada.Precio);
                    }
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void Calcular_Costo_Total()
        {
            try
            {
                decimal costo_total = 0;

                if (lista_productos.Count > 0)
                {
                    foreach (BEProducto producto in lista_productos)
                    {
                        costo_total = costo_total + producto.Precio_Unidad;
                    }
                }

                if (lista_picadas.Count > 0)
                {
                    foreach (BEPicada picada in lista_picadas)
                    {
                        costo_total = costo_total + picada.Precio;
                    }
                }

                txtCostoTotal.Text = costo_total.ToString();
            }
            catch (Exception ex) { throw ex; }
        }

        private void Asignar()
        {
            try
            {
                oBLLPedido = new BLLPedido();

                bool pagado;
                if(cbPagado.Checked == true)
                { pagado = true; }
                else { pagado = false; }

                oBEPedido = new BEPedido(oBLLPedido.Crear_Codigo_Pedido(), txtCliente.Text, txtDescripcion.Text, DateTime.Now, dtpFechaEntrega.Value, pagado, Convert.ToDecimal(txtCostoTotal.Text), lista_productos, lista_picadas);
            }
            catch (Exception ex) { throw ex; }
        }

        private void Borrar()
        {
            txtCliente.Text = "";
            txtDescripcion.Text = "";
            txtCostoTotal.Text = "";
            cbPagado.Checked = true;
            cbNoPagado.Checked = false;
            listaProductosSeleccionados.Items.Clear();
            dtpFechaEntrega.Value = DateTime.Now;
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
                    grdProductos.Columns["Bodega"].Visible = false;

                    grdProductos.Columns["Precio_Unidad"].HeaderText = "Unidad";

                    grdProductos.RowsDefaultCellStyle.BackColor = Color.White;
                    grdProductos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                }
                else { grdProductos.DataSource = null; }
            }
            catch (Exception ex) { throw ex; }
        }

        #endregion

        private void btnSeleccionarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea agregar el producto seleccionado al carrito?", "Piacere software", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (DialogResult.Yes == result)
                {
                    oBEProducto = (BEProducto)grdProductos.CurrentRow.DataBoundItem;
                    lista_productos.Add(oBEProducto);

                    Mostrar_Carrito();
                    Calcular_Costo_Total();
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void frmNuevoPedido_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Grilla_Picadas();
                Cargar_Grilla_Productos();
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnSeleccionarPicada_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea agregar la picada seleccionado al carrito?", "Piacere software", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (DialogResult.Yes == result)
                {
                    oBEPicada = (BEPicada)grdPicadas.CurrentRow.DataBoundItem;
                    lista_picadas.Add(oBEPicada);

                    Mostrar_Carrito();
                    Calcular_Costo_Total();
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnNuevaPicada_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea agregar una nueva picada?", "Piacere software", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult.Yes == result)
                {
                    frmNuevaPicada nuevapicada = new frmNuevaPicada();
                    nuevapicada.ShowDialog();

                    Cargar_Grilla_Picadas();
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void cbPagado_Click(object sender, EventArgs e)
        {
            try
            {
                cbPagado.Checked = true;
                cbNoPagado.Checked = false;
            }
            catch (Exception ex) { throw ex; }
        }

        private void cbNoPagado_Click(object sender, EventArgs e)
        {
            try
            {
                cbPagado.Checked = false;
                cbNoPagado.Checked = true;
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea cancelar la carga de un nuevo pedido?", "Piacere software", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if(result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea cargar el pedido?", "Piacere software", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
                if(result == DialogResult.Yes)
                {
                    Asignar();
                    oBLLPedido = new BLLPedido();

                    if(oBLLPedido.Agregar_Pedido(oBEPedido) == true)
                    {
                        oBLLPedido.Agregar_Detalle_Pedido(oBEPedido);

                        MessageBox.Show("Pedido creado con exito", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Borrar();
                        this.Close();
                    }

                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void txtBuscarPicada_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if(txtBuscarPicada.Text != "")
                { Buscar_Picada(); }
                else { Cargar_Grilla_Picadas(); }
            }
            catch (Exception ex) { throw ex; }
        }

        private void txtBuscarProducto_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if(txtBuscarProducto.Text != "")
                { Buscar_Producto(); }
                else { Cargar_Grilla_Productos(); }
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
