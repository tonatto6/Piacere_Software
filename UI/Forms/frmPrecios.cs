using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;

namespace UI.Forms
{
    public partial class frmPrecios : Form
    {

        #region Campos

        BEProducto oBEProducto;
        BLLProducto oBLLProducto;

        List<BEProducto> lista_productos;
        public static decimal Precio_Bulto_Cerrado { get; set; }

        #endregion

        public frmPrecios()
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

                if (grdProductos.Rows.Count > 0)
                {
                    grdProductos.Columns["Codigo"].Visible = false;
                    grdProductos.Columns["Cantidad"].Visible = false;

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
                    grdProductos.Columns["Cantidad"].Visible = false;

                    grdProductos.Columns["Precio_Unidad"].HeaderText = "Unidad";

                    grdProductos.RowsDefaultCellStyle.BackColor = Color.White;
                    grdProductos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void Borrar()
        {
            txtBuscarProducto.Text = "";
            txtPrecioPorUnidad.Text = "";
            lblProducto.Text = "";
            groupBox2.Enabled = false;
            btnSeleccionar.Enabled = true;
            txtRuta.Text = "";
            openFileDialog1.Dispose();

            btnModificarPrecioAutomaticamente.Enabled = false;
            btnSeleccionarArchivo.Enabled = true;
        }

        private string Acortar_Texto(string pCadena)
        {
            try
            {
                pCadena = pCadena.Replace("$", string.Empty);
                if(Detectar_Caracteres(pCadena) == true)
                {
                    //Tiene . y ,
                    pCadena = pCadena.Replace(".", string.Empty);
                    //pCadena = pCadena.Replace(",", ".");
                    pCadena = Math.Ceiling(Convert.ToDecimal(pCadena)).ToString();
                    return pCadena;
                }
                else
                {
                    //Solamente tiene ,
                    pCadena = pCadena.Replace(".", ",");
                    pCadena = Math.Ceiling(Convert.ToDecimal(pCadena)).ToString();
                    return pCadena;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private bool Detectar_Caracteres(string pCadena)
        {
            try
            {
                //resultado 0 o 1 es falso. Si es 2, verdadero, tiene . y , 
                int result = 0;

                foreach(char c in pCadena)
                {
                    if(c == '.')
                    { result++; }
                    else if(c == ','){ result++; }
                }

                if(result == 0 || result == 1)
                { return false; }
                else
                { return true; }
            }
            catch (Exception ex) { throw ex; }
        }

        private string Limpiar_Texto_Producto(string pCadena)
        {
            try
            {
                pCadena = pCadena.Replace("'", string.Empty);
                return pCadena;
            }
            catch (Exception ex) { throw ex; }
        }

        private bool Validar_Campos()
        {
            try
            {
                if(txtPrecioPorUnidad.Text != "")
                {
                    if(Convert.ToDecimal(txtPrecioPorUnidad.Text) > 0)
                    {
                        return true;
                    }
                    else { MessageBox.Show("No se ingresar valores menores o iguales a 0", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
                }
                else { MessageBox.Show("Debe completar los campos", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            }
            catch (Exception ex) { throw ex; }
        }

        private decimal Texto_A_Decimal(string pCadena)
        {
            var clone = (CultureInfo)CultureInfo.InvariantCulture.Clone();
            clone.NumberFormat.NumberDecimalSeparator = ".";
            clone.NumberFormat.NumberGroupSeparator = ",";
            decimal d = decimal.Parse(pCadena, clone);
            return d;
        }

        #endregion

        private void frmPrecios_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Grilla();
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                oBEProducto = (BEProducto)grdProductos.CurrentRow.DataBoundItem;
                lblProducto.Text = oBEProducto.Nombre;
                txtPrecioPorUnidad.Text = oBEProducto.Precio_Unidad.ToString();

                btnSeleccionar.Enabled = false;
                groupBox2.Enabled = true;
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if(Validar_Campos() == true)
                {
                    oBEProducto.Precio_Unidad = Convert.ToDecimal(txtPrecioPorUnidad.Text);

                    oBLLProducto = new BLLProducto();

                    if (oBLLProducto.Operacion_Producto(oBEProducto, 3) == true)
                    {
                        MessageBox.Show("Precios modificados correctamente", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Borrar();
                        Cargar_Grilla();
                    }
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Borrar();
                Cargar_Grilla();
            }
            catch (Exception ex) { throw ex; }
        }

        private void txtBuscarProducto_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if(txtBuscarProducto.Text != "")
                { Buscar_Producto(); }
                else { Cargar_Grilla(); }
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnModificarPrecioAutomaticamente_Click(object sender, EventArgs e)
        {
            try
            {
                lista_productos = new List<BEProducto>();

                StreamReader file = new StreamReader("C://Piacere_Software//precios.txt");
                while(!file.EndOfStream)
                {
                    string[] palabras = file.ReadLine().Split();

                    int i = 0;

                    foreach (string palabra in palabras)
                    {
                        if(palabra == "")
                        {
                            break;
                        }

                        string caracter = palabra.Substring(0, 1);

                        if (caracter == "$")
                        {
                            string nombreproducto = "";

                            for (int j = 1; j < i; j++)
                            {
                                if(j == 1)
                                { nombreproducto = palabras[j]; }
                                else { nombreproducto = nombreproducto + " " + palabras[j]; }
                            }

                            if (palabras.Length > 2)
                            {
                                BEProducto oBEProducto = new BEProducto();
                                oBEProducto.Nombre = Limpiar_Texto_Producto(nombreproducto.ToUpper());
                                oBEProducto.Precio_Unidad = Convert.ToDecimal(Acortar_Texto(palabras[i]));

                                oBLLProducto = new BLLProducto();

                                if (oBLLProducto.Producto_Existe(nombreproducto.ToUpper()) == true)
                                {
                                    lista_productos.Add(oBEProducto);
                                }

                            }
                            break;
                        }

                        i++;
                    }
                }

                oBLLProducto = new BLLProducto();

                foreach(BEProducto Producto in lista_productos)
                {
                    oBLLProducto.Modificar_Precio_Producto(Producto);
                }

                MessageBox.Show("Se modificaron los precios correctamente", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cargar_Grilla();
                Borrar();
                file.Close();
                file.Dispose();
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                //Directorio inicial donde se abrira
                openFileDialog1.InitialDirectory = "C:\\";
                //Filtro de archivos
                //openFileDialog1.Filter = "Archivos PDF (*.pdf)|*.pdf";

                //Codigo para abrir el cuadro de dialogo
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string ruta = openFileDialog1.FileName;
                    txtRuta.Text = ruta;

                    //Luego de seleccionar el arhivo PDF se convierte a TXT para hacer la actualizacion de precios
                    var pdfDocument = new PdfDocument(new PdfReader(ruta));
                    var strategy = new LocationTextExtractionStrategy();
                    string text = String.Empty;
                    StreamWriter file = new StreamWriter("C://Piacere_Software//precios.txt", false);
                    for (int i = 1; i <= pdfDocument.GetNumberOfPages(); i++)
                    {
                        var page = pdfDocument.GetPage(i);
                        text = PdfTextExtractor.GetTextFromPage(page);
                        file.Write(text);
                    }

                    openFileDialog1.Dispose();
                    file.Close();
                    file.Dispose();
                    
                    MessageBox.Show("Todo listo, presione el boton 'Modificar Precio' para continuar", "Piacere software", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnModificarPrecioAutomaticamente.Enabled = true;
                }
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
