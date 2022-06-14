using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEProducto
    {
        public int Codigo { get; set; }

        public string Nombre { get; set; }

        public string Bodega { get; set; }

        public decimal Precio_Unidad { get; set; }

        public int Cantidad { get; set; }
    }
}
