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
    public partial class frmVerDetallePicada : Form
    {
        BLLPicada oBLLPicada;

        public frmVerDetallePicada(BEPicada oBEPicada)
        {
            InitializeComponent();
            lblPicada.Text = "Picada: " + oBEPicada.Nombre;
            lblDescripcion.Text = "Descripcion: " + oBEPicada.Descripcion;
            lblPrecio.Text = "Precio: " + oBEPicada.Precio;

            oBLLPicada = new BLLPicada();
            grdProductosPicadas.DataSource = null;
            grdProductosPicadas.DataSource = oBLLPicada.Listar_Detalle_Picada(oBEPicada);

            if(grdProductosPicadas.Rows.Count > 0)
            {
                grdProductosPicadas.Columns["Codigo"].Visible = false;
                grdProductosPicadas.Columns["Precio_Unidad"].Visible = false;
                grdProductosPicadas.Columns["Total"].Visible = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
