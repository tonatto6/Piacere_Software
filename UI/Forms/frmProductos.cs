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
    public partial class frmProductos : Form
    {

        #region Campos

        public int Operacion { get; set; }
        public int Codigo { get; set; }


        BEProducto oBEProducto;
        BLLProducto oBLLProducto;

        #endregion

        public frmProductos()
        {
            InitializeComponent();
        }

        #region Funciones privadas
        
        private void Cargar_Grilla()
        {
            try
            {
                oBLLProducto = new BLLProducto();
                grdProductos.DataSource = null;
                grdProductos.DataSource = oBLLProducto.Listar_Productos();

                if(grdProductos.Rows.Count > 0)
                {
                    grdProductos.Columns["Codigo"].Visible = false;

                    grdProductos.Columns["Precio_Unidad"].HeaderText = "Unidad";

                    grdProductos.RowsDefaultCellStyle.BackColor = Color.White;
                    grdProductos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                }
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

        private void Asignar()
        {
            try
            {
                oBEProducto = new BEProducto();
                oBEProducto.Codigo = Codigo;
                oBEProducto.Nombre = txtProducto.Text.ToUpper();
                oBEProducto.Bodega = txtBodega.Text;
                oBEProducto.Precio_Unidad = Convert.ToDecimal(txtPrecioPorUnidad.Text);
                oBEProducto.Cantidad = Convert.ToInt32(txtStock.Text);
            }
            catch (Exception ex) { throw ex; }
        }

        private void Borrar()
        {
            txtProducto.Text = "";
            txtBodega.Text = "";
            txtPrecioPorUnidad.Text = "0";
            txtStock.Text = "1";
            txtBuscarProducto.Text = "";

            groupBox2.Enabled = false;

            btnNuevo.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
        }

        private bool Validar_Campos()
        {
            try
            {
                if(txtProducto.Text == "" || txtBodega.Text == "" || txtPrecioPorUnidad.Text == "" || txtStock.Text == "")
                {
                    return false;
                }
                else { return true; }
            }
            catch (Exception ex) { throw ex; }
        }

        #endregion

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox2.Enabled = true;
                btnNuevo.Enabled = false;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                Operacion = 1;
                Codigo = 0;
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar el producto seleccionado?", "Piacere software", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if(result == DialogResult.Yes)
                {
                    oBEProducto = (BEProducto)grdProductos.CurrentRow.DataBoundItem;
                    oBLLProducto = new BLLProducto();
                    
                    if(oBLLProducto.Validar_Producto_Detalle_Venta(oBEProducto) != true )
                    {
                        if(oBLLProducto.Validar_Producto_Detalle_Pedido(oBEProducto) != true)
                        {
                            Operacion = 2;

                            if (oBLLProducto.Operacion_Producto(oBEProducto, Operacion) == true)
                            {
                                MessageBox.Show("Producto eliminado correctamente", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Borrar();
                                Cargar_Grilla();
                            }
                        }
                        else { MessageBox.Show("No se puede eliminar el producto porque forma parte de uno o más pedidos", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    }
                    else { MessageBox.Show("No se puede eliminar el producto porque forma parte de una o más ventas", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox2.Enabled = true;
                btnNuevo.Enabled = false;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                Operacion = 3;
                
                oBEProducto = (BEProducto)grdProductos.CurrentRow.DataBoundItem;
                Codigo = oBEProducto.Codigo;
                txtProducto.Text = oBEProducto.Nombre;
                txtBodega.Text = oBEProducto.Bodega;
                txtPrecioPorUnidad.Text = oBEProducto.Precio_Unidad.ToString();
                txtStock.Text = oBEProducto.Cantidad.ToString();
            }
            catch (Exception ex) { throw ex; }
        }

        #region keypress textbox

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)(Keys.Enter))
                {
                    txtBodega.Focus();
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void txtBodega_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)(Keys.Enter))
                {
                    txtPrecioPorUnidad.Focus();
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void txtPrecioPorUnidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)(Keys.Enter))
                {
                    txtStock.Focus();
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)(Keys.Enter))
                {
                    btnAceptar.Focus();
                }
            }
            catch (Exception ex) { throw ex; }
        }

        #endregion

        private void frmProductos_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Grilla();
            }
            catch (Exception ex) { throw ex; }
        }

        private void txtBuscarProducto_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if(txtBuscarProducto.Text == "")
                { Cargar_Grilla(); }
                else { Buscar_Producto(); }
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if(Validar_Campos() == true)
                {
                    oBLLProducto = new BLLProducto();
                    Asignar();

                    if(Operacion == 1 && oBLLProducto.Producto_Existe(oBEProducto.Nombre) == true)
                    {
                        MessageBox.Show("Ya existe un producto con el nombre ingresado", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {

                        if (oBLLProducto.Operacion_Producto(oBEProducto, Operacion) == true)
                        {
                            MessageBox.Show("Operacion realizada correctamente", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Borrar();
                            Cargar_Grilla();
                        }
                    }

                }
                else { MessageBox.Show("Debe completar todos los campos", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
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
    }
}
