using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEDetallePicada
    {
        public int Codigo { get; set; }

        public string Producto { get; set; }

        public decimal Cantidad { get; set; }

        public decimal Precio_Unidad { get; set; }

        public decimal Total { get; set; }
    }
}
