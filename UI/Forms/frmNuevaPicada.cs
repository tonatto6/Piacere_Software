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
    public partial class frmNuevaPicada : Form
    {

        #region Campos

        BLLPicada oBLLPicada;
        BEPicada oBEPicada;

        List<BEDetallePicada> lista_detalle_picada;

        public int Operacion { get; set; }

        #endregion

        public frmNuevaPicada()
        {
            InitializeComponent();
            lista_detalle_picada = new List<BEDetallePicada>();
        }

        #region Funciones privadas

        private void Borrar()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtProductoIngrediente.Text = "";
            txtCantidad.Text = "";
            cbPeso.Checked = true;
            cbUnidad.Checked = false;
            txtPrecioProducto.Text = "";
            txtPrecioFinal.Text = "";
            lblCostoTotalProductos.Text = "";
            grdProductosIngredientes.DataSource = null;
            groupBox1.Enabled = false;
        }

        private void Asignar()
        {
            try
            {
                oBLLPicada = new BLLPicada();

                oBEPicada = new BEPicada(oBLLPicada.Crear_Codigo_Nueva_Picada(), txtNombre.Text, txtDescripcion.Text, Convert.ToDecimal(txtPrecioFinal.Text), lista_detalle_picada);
            }
            catch (Exception ex) { throw ex; }
        }

        private void Asignar_Detalle_Picada()
        {
            try
            {
                BEDetallePicada detalle_picada = new BEDetallePicada();
                detalle_picada.Producto = txtProductoIngrediente.Text;
                detalle_picada.Cantidad = Convert.ToDecimal(txtCantidad.Text);
                detalle_picada.Precio_Unidad = Convert.ToDecimal(txtPrecioProducto.Text);
                detalle_picada.Total = Convert.ToDecimal(lblCostoTotalProductos.Text);
                lista_detalle_picada.Add(detalle_picada);
            }
            catch (Exception ex) { throw ex; }
        }

        private bool Validar_Campos_Picada_Completos()
        {
            if (txtNombre.Text != "" && txtDescripcion.Text != "" && txtPrecioFinal.Text != "")
            { return true; }
            else { return false; }
        }

        private void Borrar_Campos_Productos()
        {
            txtProductoIngrediente.Text = "";
            txtCantidad.Text = "";
            txtPrecioProducto.Text = "";
            lblCostoTotalProductos.Text = "";
        }

        private void Calcular_Total_Productos()
        {
            try
            {
                decimal total = 0;

                foreach (BEDetallePicada detalle_picada in lista_detalle_picada)
                {
                    total = total + detalle_picada.Total;
                }

                lblPrecioTotal.Text = total.ToString();
            }
            catch (Exception ex) { throw ex; }
        }

        #endregion

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar_Campos_Picada_Completos() == true)
                {
                    Asignar();
                    oBLLPicada = new BLLPicada();
                    if (oBLLPicada.Agregar_Picada(oBEPicada) == true)
                    {
                        oBLLPicada.Agregar_Detalle_Picada(oBEPicada);

                        MessageBox.Show("Picada agregada con exito", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Borrar();
                        this.Close();
                    }
                }
                else { MessageBox.Show("Debe completar todos los campos", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            catch (Exception ex) { throw ex; }
        }

        private void cbPeso_Click(object sender, EventArgs e)
        {
            try
            {
                cbPeso.Checked = true;
                cbUnidad.Checked = false;
            }
            catch (Exception ex) { throw ex; }
        }

        private void cbUnidad_Click(object sender, EventArgs e)
        {
            try
            {
                cbPeso.Checked = false;
                cbUnidad.Checked = true;
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                //Falta validar los que campos esten completos
                Asignar_Detalle_Picada();
                grdProductosIngredientes.DataSource = null;
                grdProductosIngredientes.DataSource = lista_detalle_picada;

                if (grdProductosIngredientes.Rows.Count > 0)
                {
                    grdProductosIngredientes.Columns["Codigo"].Visible = false;

                    grdProductosIngredientes.Columns["Precio_Unidad"].HeaderText = "Precio unidad";
                }

                Calcular_Total_Productos();
                Borrar_Campos_Productos();
            }
            catch (Exception ex) { throw ex; }
        }

        private void txtPrecioProducto_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txtPrecioProducto.TextLength > 0)
                {
                    if (cbUnidad.Checked == true)
                    {
                        lblCostoTotalProductos.Text = (Convert.ToDecimal(txtCantidad.Text) * Convert.ToDecimal(txtPrecioProducto.Text)).ToString();
                    }
                    else { lblCostoTotalProductos.Text = (Convert.ToDecimal(txtCantidad.Text) * Convert.ToDecimal(txtPrecioProducto.Text) / 1000).ToString(); }
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea cancelar la carga de una nueva picada?", "Piacere software", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if(DialogResult.Yes == result)
                {
                    Borrar();
                    this.Close();
                }
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
