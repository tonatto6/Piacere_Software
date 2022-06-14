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
    public partial class frmPedidos : Form
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

        public static bool Pedido_Eliminar { get; set; }

        #endregion

        public frmPedidos()
        {
            InitializeComponent();
        }

        #region Funciones privadas

        private void Cargar_Grilla()
        {
            try
            {
                oBLLPedido = new BLLPedido();
                grdPedidos.DataSource = null;
                grdPedidos.DataSource = oBLLPedido.Listar_Pedidos();

                if(grdPedidos.Rows.Count > 0)
                {
                    grdPedidos.Columns["Codigo"].Visible = false;
                    grdPedidos.Columns["Descripcion"].Visible = false;

                    grdPedidos.Columns["Fecha_Pedido"].HeaderText = "Fecha pedido";
                    grdPedidos.Columns["Fecha_Entrega"].HeaderText = "Fecha entrega";
                    grdPedidos.Columns["Costo_Total"].HeaderText = "Monto";
                }
            }
            catch (Exception ex) { throw ex; }
        }

        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea agregar un nuevo pedido?", "Piacere software", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(DialogResult.Yes == result)
                {
                    frmNuevoPedido nuevopedido = new frmNuevoPedido();
                    nuevopedido.ShowDialog();

                    Cargar_Grilla();
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void frmPedidos_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Grilla();
            }
            catch (Exception ex) { throw ex; }
        }

        private void grdPedidos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {

                if (grdPedidos.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in grdPedidos.Rows)
                    {
                        TimeSpan diferencia = Convert.ToDateTime(row.Cells["Fecha_Entrega"].Value) - DateTime.Now;
                        int dias = diferencia.Days;

                        if (dias == 0 || dias < 0)
                        {
                            row.DefaultCellStyle.BackColor = Color.Red;
                        }
                        else if(dias > 0 && dias < 5) 
                        { row.DefaultCellStyle.BackColor = Color.Yellow; }
                        else if(dias > 5)
                        { row.DefaultCellStyle.BackColor = Color.Green; }
                    }
                }
            }
            catch (Exception ex) { throw ex; }

        }

        private void btnEliminarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar el pedido seleccionado?", "Piacere software", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(DialogResult.Yes == result)
                {
                    oBLLPedido = new BLLPedido();
                    oBEPedido = (BEPedido)grdPedidos.CurrentRow.DataBoundItem;

                    oBLLPedido.Eliminar_Detalle_Pedido(oBEPedido);
                    oBLLPedido.Eliminar_Pedido(oBEPedido);

                    MessageBox.Show("Pedido eliminado correctamente", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Cargar_Grilla();
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnBuscarPorFecha_Click(object sender, EventArgs e)
        {
            try
            {
                oBLLPedido = new BLLPedido();
                grdPedidos.DataSource = null;
                grdPedidos.DataSource = oBLLPedido.Listar_Pedidos_Por_Fecha(dtpFecha.Value);

                if (grdPedidos.Rows.Count > 0)
                {
                    grdPedidos.Columns["Codigo"].Visible = false;
                    grdPedidos.Columns["Descripcion"].Visible = false;

                    grdPedidos.Columns["Fecha_Pedido"].HeaderText = "Fecha pedido";
                    grdPedidos.Columns["Fecha_Entrega"].HeaderText = "Fecha entrega";
                    grdPedidos.Columns["Costo_Total"].HeaderText = "Monto";
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnBuscarPorDias_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtCantidadDias.Text != "" && Convert.ToInt32(txtCantidadDias.Text) > 0)
                {
                    oBLLPedido = new BLLPedido();
                    grdPedidos.DataSource = null;
                    grdPedidos.DataSource = oBLLPedido.Listar_Pedidos_Dias(Convert.ToInt32(txtCantidadDias.Text));

                    if (grdPedidos.Rows.Count > 0)
                    {
                        grdPedidos.Columns["Codigo"].Visible = false;
                        grdPedidos.Columns["Descripcion"].Visible = false;

                        grdPedidos.Columns["Fecha_Pedido"].HeaderText = "Fecha pedido";
                        grdPedidos.Columns["Fecha_Entrega"].HeaderText = "Fecha entrega";
                        grdPedidos.Columns["Costo_Total"].HeaderText = "Monto";
                    }
                }
                else { MessageBox.Show("Debe ingresar un valor valido", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            try
            {
                Cargar_Grilla();
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnVerDetallePedido_Click(object sender, EventArgs e)
        {
            try
            {
                listProductosPedido.Items.Clear();

                oBEPedido = (BEPedido)grdPedidos.CurrentRow.DataBoundItem;

                lblCliente.Text = oBEPedido.Cliente;
                lblFechaEntrega.Text = oBEPedido.Fecha_Entrega.ToString();
                lblFechaPedido.Text = oBEPedido.Fecha_Pedido.ToString();
                lblDescripcion.Text = oBEPedido.Descripcion;
                lblCosto.Text = oBEPedido.Costo_Total.ToString();
                
                if(oBEPedido.Pagado == true)
                { lblEstado.Text = "Pagado"; }
                else { lblEstado.Text = "No pagado"; }

                oBLLPedido = new BLLPedido();
                List<BEProducto> lista_productos = new List<BEProducto>();
                List<BEPicada> lista_picadas = new List<BEPicada>();
                lista_productos = oBLLPedido.Listar_Productos_Pedido(oBEPedido);
                lista_picadas = oBLLPedido.Listar_Picadas_Pedido(oBEPedido);

                if(lista_productos != null)
                {
                    foreach(BEProducto producto in lista_productos)
                    {
                        listProductosPedido.Items.Add(producto.Nombre + " - $" + producto.Precio_Unidad);
                    }
                }

                if(lista_picadas != null)
                {
                    foreach(BEPicada picada in lista_picadas)
                    {
                        listProductosPedido.Items.Add(picada.Nombre + " - $" + picada.Precio);
                    }
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnVenderPedido_Click(object sender, EventArgs e)
        {
            try
            {
                oBLLPedido = new BLLPedido();
                oBEPedido = (BEPedido)grdPedidos.CurrentRow.DataBoundItem;

                List<BEProducto> lista_productos = new List<BEProducto>();
                List<BEPicada> lista_picadas = new List<BEPicada>();
                
                lista_productos = oBLLPedido.Listar_Productos_Pedido(oBEPedido);
                lista_picadas = oBLLPedido.Listar_Picadas_Pedido(oBEPedido);
                
                frmVentaPedido ventapedido = new frmVentaPedido(lista_productos, lista_picadas, oBEPedido.Cliente);
                ventapedido.ShowDialog();

                if(Pedido_Eliminar == true)
                {
                    oBLLPedido.Eliminar_Detalle_Pedido(oBEPedido);
                    oBLLPedido.Eliminar_Pedido(oBEPedido);
                    Cargar_Grilla();
                }
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
