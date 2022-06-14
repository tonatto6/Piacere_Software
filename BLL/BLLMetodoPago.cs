using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPP;
using BE;

namespace BLL
{
    public class BLLMetodoPago
    {
        MPPMetodoPago oMPPMetodoPago;

        public List<BEMetodoPago> Listar_Metodos_Pago()
        {
            oMPPMetodoPago = new MPPMetodoPago();
            return oMPPMetodoPago.Listar_Metodos_Pago();
        }

        public bool Agregar_Metodo_Pago(BEMetodoPago oBEMetodoPago)
        {
            oMPPMetodoPago = new MPPMetodoPago();
            return oMPPMetodoPago.Agregar_Metodo_Pago(oBEMetodoPago);
        }
    }
}
