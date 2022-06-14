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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        #region Funciones menu

        private void Personalizar_Diseño()
        {
            panelDashboard.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panelDashboard.Visible == true)
            { panelDashboard.Visible = false; }
        }

        private void Mostrar_SubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideSubMenu();
                submenu.Visible = true;
            }
            else { submenu.Visible = false; }
        }

        #endregion

        #region Funciones privadas
        private Form activeForm = null;

        private void AbrirForm(Form frmHijo)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = frmHijo;
            frmHijo.TopLevel = false;
            frmHijo.FormBorderStyle = FormBorderStyle.None;
            frmHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(frmHijo);
            frmHijo.Tag = frmHijo;
            frmHijo.BringToFront();
            frmHijo.Show();
        }

        #endregion

        private void btnVentas_Click_1(object sender, EventArgs e)
        {
            try
            {
                AbrirForm(new frmVentas());
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            try
            {
                Mostrar_SubMenu(panelDashboard);
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnStock_Click_1(object sender, EventArgs e)
        {
            try
            {
                AbrirForm(new frmStock());
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnGastos_Click_1(object sender, EventArgs e)
        {
            try
            {
                AbrirForm(new frmGastos());
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnProductos_Click_1(object sender, EventArgs e)
        {
            try
            {
                AbrirForm(new frmProductos());
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnVentasDashboard_Click(object sender, EventArgs e)
        {
            try
            {
                HideSubMenu();
                AbrirForm(new frmDashboard());
            }
            catch (Exception ex) { throw ex; }

        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            try
            {
                HideSubMenu();
                AbrirForm(new frmInformes());
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnPicadas_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirForm(new frmPicadas());
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnPrecios_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirForm(new frmPrecios());
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirForm(new frmPedidos());
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
