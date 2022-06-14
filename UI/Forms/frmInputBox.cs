using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class frmInputBox : Form
    {

        public string Producto { get; set; }

        public frmInputBox()
        {
            InitializeComponent();
        }

        private void frmInputBox_Load(object sender, EventArgs e)
        {
            try
            {
                lblProducto.Text = "Producto: " + Producto;
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtPrecio.Text != "")
                {
                    frmPrecios.Precio_Bulto_Cerrado = Convert.ToDecimal(txtPrecio.Text);
                    MessageBox.Show("Precio establecido exitosamente", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else { MessageBox.Show("Debe completar el campo precio", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
