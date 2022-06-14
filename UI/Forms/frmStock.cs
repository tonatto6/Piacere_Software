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
    public partial class frmStock : Form
    {

        #region Campos

        BEProducto oBEProducto;
        BLLProducto oBLLProducto;

        List<BEProducto> Lista_Productos;

        #endregion

        public frmStock()
        {
            InitializeComponent();
        }

        #region Funciones privadas

        private void Cargar_Grilla()
        {
            try
            {
                oBLLProducto = new BLLProducto();
                grdStockProductos.DataSource = null;
                grdStockProductos.DataSource = oBLLProducto.Listar_Productos();

                if(grdStockProductos.Rows.Count > 0)
                {
                    grdStockProductos.Columns["Codigo"].Visible = false;

                    grdStockProductos.Columns["Precio_Unidad"].HeaderText = "Unidad";

                    grdStockProductos.RowsDefaultCellStyle.BackColor = Color.White;
                    grdStockProductos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void Cargar_Grilla_Sin_Stock()
        {
            try
            {
                oBLLProducto = new BLLProducto();
                grdProductosSinStock.DataSource = null;
                grdProductosSinStock.DataSource = oBLLProducto.Listar_Productos_Sin_Stock();

                if (grdProductosSinStock.Rows.Count > 0)
                {
                    grdProductosSinStock.Columns["Codigo"].Visible = false;
                    grdProductosSinStock.Columns["Bodega"].Visible = false;
                    grdProductosSinStock.Columns["Precio_Unidad"].Visible = false;

                    //grdProductosSinStock.Columns["Precio_Unidad"].HeaderText = "Unidad";

                    grdProductosSinStock.RowsDefaultCellStyle.BackColor = Color.White;
                    grdProductosSinStock.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void Buscar_Producto()
        {
            try
            {
                oBLLProducto = new BLLProducto();
                grdStockProductos.DataSource = null;
                grdStockProductos.DataSource = oBLLProducto.Buscar_Producto(txtBuscarProductoStock.Text);

                if (grdStockProductos.Rows.Count > 0)
                {
                    grdStockProductos.Columns["Codigo"].Visible = false;

                    grdStockProductos.Columns["Precio_Unidad"].HeaderText = "Unidad";

                    grdStockProductos.RowsDefaultCellStyle.BackColor = Color.White;
                    grdStockProductos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                }
            }
            catch (Exception ex) { throw ex; }

        }

        private void Buscar_Producto_Sin_Stock()
        {
            try
            {
                oBLLProducto = new BLLProducto();
                grdProductosSinStock.DataSource = null;
                grdProductosSinStock.DataSource = oBLLProducto.Buscar_Producto_Sin_Stock(txtBuscarProductoSinStock.Text);

                if (grdProductosSinStock.Rows.Count > 0)
                {
                    grdProductosSinStock.Columns["Codigo"].Visible = false;

                    grdProductosSinStock.Columns["Precio_Unidad"].HeaderText = "Unidad";

                    grdProductosSinStock.RowsDefaultCellStyle.BackColor = Color.White;
                    grdProductosSinStock.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void Borrar()
        {
            txtStockProducto.Text = "";
            txtBuscarProductoSinStock.Text = "";
            txtBuscarProductoStock.Text = "";
            lblProducto.Text = "";
            groupModificarStock.Enabled = false;
        }

        #endregion

        private void frmStock_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Grilla();
                Cargar_Grilla_Sin_Stock();
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnModificarStock_Click(object sender, EventArgs e)
        {
            try
            {
                oBEProducto = (BEProducto)grdStockProductos.CurrentRow.DataBoundItem;
                lblProducto.Text = oBEProducto.Nombre;
                txtStockProducto.Text = oBEProducto.Cantidad.ToString();
                groupModificarStock.Enabled = true;
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Borrar();
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtStockProducto.Text != "" && Convert.ToInt32(txtStockProducto.Text) >= 0)
                {
                    oBLLProducto = new BLLProducto();
                    oBEProducto.Cantidad = Convert.ToInt32(txtStockProducto.Text);
                    if (oBLLProducto.Operacion_Producto(oBEProducto, 3) == true)
                    {
                        MessageBox.Show("Stock modificado correctamente", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Borrar();
                        Cargar_Grilla();
                        Cargar_Grilla_Sin_Stock();
                    }
                }
                else { MessageBox.Show("Debe ingresar un valor valido", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnModificarStockProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if(grdProductosSinStock.Rows.Count > 0)
                {
                    oBEProducto = (BEProducto)grdProductosSinStock.CurrentRow.DataBoundItem;
                    lblProducto.Text = oBEProducto.Nombre;
                    txtStockProducto.Text = oBEProducto.Cantidad.ToString();
                    groupModificarStock.Enabled = true;
                }
                else { MessageBox.Show("No hay productos para seleccionar", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            catch (Exception ex) { throw ex; }
        }

        private void txtBuscarProductoStock_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if(txtBuscarProductoStock.Text =="")
                { Cargar_Grilla(); }
                else { Buscar_Producto(); }
            }
            catch (Exception ex) { throw ex; }
        }

        private void txtBuscarProductoSinStock_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txtBuscarProductoSinStock.Text == "")
                { Cargar_Grilla_Sin_Stock(); }
                else { Buscar_Producto_Sin_Stock(); }
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnModificarStockAutomaticamente_Click(object sender, EventArgs e)
        {
            try
            {
                Lista_Productos = new List<BEProducto>();
                oBLLProducto = new BLLProducto();
                Lista_Productos = oBLLProducto.Listar_Productos();

                frmStockAutomatico stockAutomatico;

                foreach(BEProducto oBEProducto in Lista_Productos)
                {
                    stockAutomatico = new frmStockAutomatico();
                    stockAutomatico.Producto = oBEProducto;
                    stockAutomatico.ShowDialog();
                }

                Cargar_Grilla();
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
