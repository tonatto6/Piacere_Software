using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPP;
using BE;

namespace BLL
{
    public class BLLProducto
    {
        MPPProducto oMPPProducto;

        public List<BEProducto> Listar_Productos()
        {
            oMPPProducto = new MPPProducto();
            return oMPPProducto.Listar_Productos();
        }

        public List<BEProducto> Buscar_Producto(string pCadena)
        {
            oMPPProducto = new MPPProducto();
            return oMPPProducto.Buscar_Producto(pCadena);
        }

        public List<BEProducto> Buscar_Producto_Sin_Stock(string pCadena)
        {
            oMPPProducto = new MPPProducto();
            return oMPPProducto.Buscar_Producto_Sin_Stock(pCadena);
        }

        public List<BEProducto> Listar_Productos_Sin_Stock()
        {
            oMPPProducto = new MPPProducto();
            return oMPPProducto.Listar_Productos_Sin_Stock();
        }

        public BEProducto Seleccionar_Producto(BEProducto oBEProducto)
        {
            oMPPProducto = new MPPProducto();
            return oMPPProducto.Seleccionar_Producto(oBEProducto);
        }

        public bool Validar_Producto_Detalle_Venta(BEProducto oBEProducto)
        {
            oMPPProducto = new MPPProducto();
            return oMPPProducto.Validar_Producto_Detalle_Venta(oBEProducto);
        }

        public bool Validar_Producto_Detalle_Pedido(BEProducto oBEProducto)
        {
            oMPPProducto = new MPPProducto();
            return oMPPProducto.Validar_Producto_Detalle_Pedido(oBEProducto);
        }

        public bool Operacion_Producto(BEProducto oBEProducto, int pOperacion)
        {
            oMPPProducto = new MPPProducto();
            return oMPPProducto.Operacion_Producto(oBEProducto, pOperacion);
        }
    
        public void Descontar_Producto(BEProducto oBEProducto)
        {
            oMPPProducto = new MPPProducto();
            oMPPProducto.Descontar_Producto(oBEProducto);
        }
    
        public bool Modificar_Precio(BEProducto oBEProducto)
        {
            oMPPProducto = new MPPProducto();
            return oMPPProducto.Modificar_Precio(oBEProducto);
        }

        public bool Modificar_Stock(BEProducto oBEProducto)
        {
            oMPPProducto = new MPPProducto();
            return oMPPProducto.Modificar_Stock(oBEProducto);
        }

        public bool Producto_Existe(string nombreproducto)
        {
            oMPPProducto = new MPPProducto();
            return oMPPProducto.Producto_Existe(nombreproducto);
        }
    
        public void Modificar_Precio_Producto(BEProducto oBEProducto)
        {
            oMPPProducto = new MPPProducto();
            oMPPProducto.Modificar_Precio_Producto(oBEProducto);
        }
    }
}
