using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MPP;

namespace BLL
{
    public class BLLPedido
    {
        MPPPedido oMPPPedido;

        public List<BEPedido> Listar_Pedidos()
        {
            oMPPPedido = new MPPPedido();
            return oMPPPedido.Listar_Pedidos();
        }

        public List<BEPedido> Listar_Pedidos_Por_Fecha(DateTime fecha_entrega)
        {
            oMPPPedido = new MPPPedido();
            return oMPPPedido.Listar_Pedidos_Por_Fecha(fecha_entrega);
        }

        public List<BEPedido> Listar_Pedidos_Dias(int cantidad_dias)
        {
            oMPPPedido = new MPPPedido();
            return oMPPPedido.Listar_Pedidos_Por_Dias(cantidad_dias);
        }

        public List<BEProducto> Listar_Productos_Pedido(BEPedido oBEPedido)
        {
            oMPPPedido = new MPPPedido();
            return oMPPPedido.Listar_Productos_Pedidos(oBEPedido);
        }

        public List<BEPicada> Listar_Picadas_Pedido(BEPedido oBEPedido)
        {
            oMPPPedido = new MPPPedido();
            return oMPPPedido.Listar_Picadas_Pedido(oBEPedido);
        }

        public bool Agregar_Pedido(BEPedido oBEPedido)
        {
            oMPPPedido = new MPPPedido();
            return oMPPPedido.Agregar_Pedido(oBEPedido);
        }

        public void Agregar_Detalle_Pedido(BEPedido oBEPedido)
        {
            oMPPPedido = new MPPPedido();
            oMPPPedido.Agregar_Detalle_Pedido(oBEPedido);
        }

        public int Crear_Codigo_Pedido()
        {
            oMPPPedido = new MPPPedido();
            return oMPPPedido.Crear_Codigo_Pedido();
        }

        public bool Eliminar_Pedido(BEPedido oBEPedido)
        {
            oMPPPedido = new MPPPedido();
            return oMPPPedido.Eliminar_Pedido(oBEPedido);
        }

        public bool Eliminar_Detalle_Pedido(BEPedido oBEPedido)
        {
            oMPPPedido = new MPPPedido();
            return oMPPPedido.Eliminar_Detalle_Pedido(oBEPedido);
        }

    }
}
