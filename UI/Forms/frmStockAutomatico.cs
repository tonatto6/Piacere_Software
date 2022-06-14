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
    public partial class frmStockAutomatico : Form
    {
        public frmStockAutomatico()
        {
            InitializeComponent();
        }
        
        #region campos

        List<BEProducto> Lista_Productos;
        BEProducto oBEProducto;
        BLLProducto oBLLProducto;

        public BEProducto Producto { get; set; }

        #endregion

        #region Funciones privadas

        private void Borrar()
        {
            txtStock.Text = "";
            lblProducto.Text = "";
            Producto = null;
        }

        #endregion

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if(Convert.ToInt32(txtStock.Text) > 0 && txtStock.Text != "")
                {
                    Producto.Cantidad = Convert.ToInt32(txtStock.Text);
                    oBLLProducto = new BLLProducto();
                    if(oBLLProducto.Modificar_Stock(Producto) == true)
                    { Borrar(); this.Close(); }
                }
                else { MessageBox.Show("Debe ingresar un valor correcto", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            catch (Exception ex) { throw ex; }
        }

        private void frmStockAutomatico_Load(object sender, EventArgs e)
        {
            try
            {
                lblProducto.Text = "Producto: " + Producto.Nombre;
                txtStock.Text = Producto.Cantidad.ToString();
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
