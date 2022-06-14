using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEPicada
    {

        #region Constructores

        public BEPicada()
        { }

        public BEPicada(int codigo, string nombre, string descripcion, decimal precio, List<BEDetallePicada> lista_detalle_picada)
        {
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            Lista_Detalle_Picada = lista_detalle_picada;
        }

        #endregion

        #region Propiedades

        public int Codigo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public decimal Precio { get; set; }

        private List<BEDetallePicada> Lista_Detalle_Picada;

        #endregion

        #region Funciones

        public List<BEDetallePicada> Retornar_Lista_Detalle_Picada(BEPicada oBEPicada)
        {
            return oBEPicada.Lista_Detalle_Picada;
        }

        #endregion
    }
}
