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
    public partial class frmPicadas : Form
    {

        #region Campos

        BLLPicada oBLLPicada;
        BEPicada oBEPicada;

        List<BEDetallePicada> lista_detalle_picada;

        BEDetallePicada DetallePicada;

        public int Operacion { get; set; }

        #endregion

        public frmPicadas()
        {
            InitializeComponent();
        }

        #region Funciones privadas

        private void Cargar_Grilla()
        {
            try
            {
                oBLLPicada = new BLLPicada();
                grdPicadas.DataSource = null;
                grdPicadas.DataSource = oBLLPicada.Listar_Picadas();

                if(grdPicadas.Rows.Count > 0)
                {
                    grdPicadas.Columns["Codigo"].Visible = false;

                    grdPicadas.RowsDefaultCellStyle.BackColor = Color.White;
                    grdPicadas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                }
                else { grdPicadas.DataSource = null; }
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

                    grdPicadas.RowsDefaultCellStyle.BackColor = Color.White;
                    grdPicadas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                }
                else { grdPicadas.DataSource = null; }
            }
            catch (Exception ex) { throw ex; }
        }

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
            grdDetallePicada.DataSource = null;
            txtBuscarPicada.Text = "";

            btnAgregar.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
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

        private void Asignar2()
        {
            oBEPicada.Nombre = txtNombre.Text;
            oBEPicada.Descripcion = txtDescripcion.Text;
            oBEPicada.Precio = Convert.ToDecimal(txtPrecioFinal.Text);
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
            if(txtNombre.Text != "" && txtDescripcion.Text != "" && txtPrecioFinal.Text != "")
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

                foreach(BEDetallePicada detalle_picada in lista_detalle_picada)
                {
                    total = total + detalle_picada.Total; 
                }

                lblPrecioTotal.Text = total.ToString();
            }
            catch (Exception ex) { throw ex; }
        }

        private void Mostrar_Detalle_Picada()
        {
            try
            {
                oBEPicada = (BEPicada)grdPicadas.CurrentRow.DataBoundItem;

                oBLLPicada = new BLLPicada();

                grdDetallePicada.DataSource = null;
                grdDetallePicada.DataSource = oBLLPicada.Listar_Detalle_Picada(oBEPicada);

                if(grdDetallePicada.Rows.Count > 0)
                {
                    grdDetallePicada.Columns["Codigo"].Visible = false;

                    grdDetallePicada.Columns["Precio_Unidad"].HeaderText = "Precio unidad";
                }
                else { grdDetallePicada.DataSource = null; }
            }
            catch (Exception ex) { throw ex; }
        }

        #endregion

        private void frmPicadas_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Grilla();
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Operacion = 1;
                groupBox1.Enabled = true;

                btnAgregar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;

                lista_detalle_picada = new List<BEDetallePicada>();
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar la picada seleccionada?", "Piacere software", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
                if(result == DialogResult.Yes)
                {
                    oBEPicada = (BEPicada)grdPicadas.CurrentRow.DataBoundItem;
                    oBLLPicada = new BLLPicada();
                    
                    if(oBLLPicada.Validar_Eliminacion_Picada(oBEPicada) == false)
                    {
                        if(oBLLPicada.Validar_Picada_Detalle_Pedido(oBEPicada) == false)
                        {
                            oBLLPicada.Eliminar_Detalle_Picada(oBEPicada);
                            oBLLPicada.Eliminar_Picada(oBEPicada);
                            MessageBox.Show("La picada se eliminó con exito", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Cargar_Grilla();
                        }
                        else { MessageBox.Show("La picada seleccionada no se puede eliminar porque forma parte de uno o más pedidos", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    }
                    else { MessageBox.Show("La picada seleccionada no se puede eliminar porque forma parte de uno o más datos de ventas", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Operacion = 3;
                oBLLPicada = new BLLPicada();

                btnAgregar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                groupBox1.Enabled = true;

                oBEPicada = (BEPicada)grdPicadas.CurrentRow.DataBoundItem;
                txtNombre.Text = oBEPicada.Nombre;
                txtDescripcion.Text = oBEPicada.Descripcion;
                txtPrecioFinal.Text = oBEPicada.Precio.ToString();

                lista_detalle_picada = new List<BEDetallePicada>();

                lista_detalle_picada = oBLLPicada.Listar_Detalle_Picada(oBEPicada);
                grdProductosIngredientes.DataSource = null;
                grdProductosIngredientes.DataSource = lista_detalle_picada;

                if (grdProductosIngredientes.Rows.Count > 0)
                {
                    grdProductosIngredientes.Columns["Codigo"].Visible = false;

                    grdProductosIngredientes.Columns["Precio_Unidad"].HeaderText = "Precio unidad";
                }
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
                if(Validar_Campos_Picada_Completos() == true)
                {
                    oBLLPicada = new BLLPicada();

                    if (Operacion != 3)
                    {
                        Asignar();
                        if (oBLLPicada.Agregar_Picada(oBEPicada) == true)
                        {
                            oBLLPicada.Agregar_Detalle_Picada(oBEPicada);

                            Borrar();
                            Cargar_Grilla();
                        }
                    }
                    else
                    {
                        Asignar2();

                        if(oBLLPicada.Modificar_Picada(oBEPicada) == true)
                        {
                            foreach(BEDetallePicada DetallePicada in lista_detalle_picada)
                            {
                                oBLLPicada.Modificar_Detalle_Picada(DetallePicada);
                            }

                            Borrar();
                            Cargar_Grilla();
                        }
                    }
                }
                else{ MessageBox.Show("Debe completar todos los campos", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
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
                if(Operacion != 3)
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
                }
                else
                {
                    foreach(BEDetallePicada detallepicada in lista_detalle_picada)
                    {
                        if(detallepicada.Codigo == DetallePicada.Codigo)
                        {
                            detallepicada.Producto = txtProductoIngrediente.Text;
                            detallepicada.Cantidad = Convert.ToDecimal(txtCantidad.Text);
                            detallepicada.Precio_Unidad = Convert.ToDecimal(txtPrecioProducto.Text);
                            detallepicada.Total = Convert.ToDecimal(lblCostoTotalProductos.Text);
                        }
                    }

                    grdProductosIngredientes.DataSource = null;
                    grdProductosIngredientes.DataSource = lista_detalle_picada;

                    if (grdProductosIngredientes.Rows.Count > 0)
                    {
                        grdProductosIngredientes.Columns["Codigo"].Visible = false;

                        grdProductosIngredientes.Columns["Precio_Unidad"].HeaderText = "Precio unidad";
                    }
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
                if(txtCantidad.Text != "" && Convert.ToDecimal(txtCantidad.Text) > 0)
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
                else { MessageBox.Show("Primero debe ingresar una cantidad", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            catch (Exception ex) { throw ex; }
        }

        private void grdPicadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Mostrar_Detalle_Picada();
        }

        private void grdPicadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Mostrar_Detalle_Picada();
        }

        private void grdPicadas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Mostrar_Detalle_Picada();
        }

        private void txtBuscarPicada_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if(txtBuscarPicada.Text != "")
                { Buscar_Picada(); }
                else { Cargar_Grilla(); }
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnQuitarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea quitar el producto/ingrediente de la picada?", "Piacere software", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(result == DialogResult.Yes)
                {
                    oBLLPicada = new BLLPicada();
                    BEDetallePicada oBEDetallePicada = new BEDetallePicada();
                    oBEDetallePicada = (BEDetallePicada)grdProductosIngredientes.CurrentRow.DataBoundItem;

                    if(Operacion != 3)
                    {

                        lista_detalle_picada.Remove(oBEDetallePicada);
                        grdProductosIngredientes.DataSource = null;
                        grdProductosIngredientes.DataSource = lista_detalle_picada;

                        if (grdProductosIngredientes.Rows.Count > 0)
                        {
                            grdProductosIngredientes.Columns["Codigo"].Visible = false;

                            grdProductosIngredientes.Columns["Precio_Unidad"].HeaderText = "Precio unidad";
                        }
                        else { grdProductosIngredientes.DataSource = null; }
                    }
                    else
                    {
                        if (oBLLPicada.Eliminar_Producto_Detalle_Picada(oBEDetallePicada) == true)
                        {
                            MessageBox.Show("El producto/ingrediente se eliminó correctamente", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            lista_detalle_picada = oBLLPicada.Listar_Detalle_Picada(oBEPicada);
                            grdProductosIngredientes.DataSource = null;
                            grdProductosIngredientes.DataSource = lista_detalle_picada;

                            if (grdProductosIngredientes.Rows.Count > 0)
                            {
                                grdProductosIngredientes.Columns["Codigo"].Visible = false;

                                grdProductosIngredientes.Columns["Precio_Unidad"].HeaderText = "Precio unidad";
                            }
                        }
                    }

                    Calcular_Total_Productos();
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void grdProductosIngredientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DetallePicada = new BEDetallePicada();
                DetallePicada = (BEDetallePicada)grdProductosIngredientes.CurrentRow.DataBoundItem;

                txtProductoIngrediente.Text = DetallePicada.Producto;
                txtCantidad.Text = DetallePicada.Cantidad.ToString();
                txtPrecioProducto.Text = DetallePicada.Precio_Unidad.ToString();
                lblCostoTotalProductos.Text = DetallePicada.Total.ToString();
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
