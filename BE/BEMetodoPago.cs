using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEMetodoPago
    {
        public int Codigo { get; set; }

        public string Metodo_Pago { get; set; }

        public override string ToString()
        {
            return Metodo_Pago;
        }
    }
}
