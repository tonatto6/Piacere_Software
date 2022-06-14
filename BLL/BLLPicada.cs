using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPP;
using BE;
namespace BLL
{
    public class BLLPicada
    {
        MPPPicada oMPPPicada;

        public List<BEPicada> Listar_Picadas()
        {
            oMPPPicada = new MPPPicada();
            return oMPPPicada.Listar_Picadas();
        }

        public List<BEDetallePicada> Listar_Detalle_Picada(BEPicada oBEPicada)
        {
            oMPPPicada = new MPPPicada();
            return oMPPPicada.Listar_Detalle_Picadas(oBEPicada);
        }

        public List<BEPicada> Buscar_Picadas(string cadena)
        {
            oMPPPicada = new MPPPicada();
            return oMPPPicada.Buscar_Picadas(cadena);
        }

        public BEPicada Seleccionar_Picada(BEPicada oBEPicada)
        {
            oMPPPicada = new MPPPicada();
            return oMPPPicada.Seleccionar_Picada(oBEPicada);
        }

        public bool Modificar_Precio_Picada(BEPicada oBEPicada)
        {
            oMPPPicada = new MPPPicada();
            return oMPPPicada.Modificar_Precio_Picada(oBEPicada);
        }

        public bool Agregar_Picada(BEPicada oBEPicada)
        {
            oMPPPicada = new MPPPicada();
            return oMPPPicada.Agregar_Picada(oBEPicada);
        }

        public int Crear_Codigo_Nueva_Picada()
        {
            oMPPPicada = new MPPPicada();
            return oMPPPicada.Crear_Codigo_Nueva_Picada();
        }

        public void Agregar_Detalle_Picada(BEPicada oBEPicada)
        {
            oMPPPicada = new MPPPicada();
            oMPPPicada.Agregar_Detalle_Picada(oBEPicada);
        }
    
        public bool Validar_Eliminacion_Picada(BEPicada oBEPicada)
        {
            oMPPPicada = new MPPPicada();
            return oMPPPicada.Validar_Eliminacion_Picada(oBEPicada);
        }

        public bool Validar_Picada_Detalle_Pedido(BEPicada oBEPicada)
        {
            oMPPPicada = new MPPPicada();
            return oMPPPicada.Validar_Picada_Detalle_Pedido(oBEPicada);
        }

        public bool Eliminar_Picada(BEPicada oBEPicada)
        {
            oMPPPicada = new MPPPicada();
            return oMPPPicada.Eliminar_Picada(oBEPicada);
        }

        public void Eliminar_Detalle_Picada(BEPicada oBEPicada)
        {
            oMPPPicada = new MPPPicada();
            oMPPPicada.Eliminar_Detalle_Picada(oBEPicada);
        }
    
        public bool Eliminar_Producto_Detalle_Picada(BEDetallePicada oBEDetallePicada)
        {
            oMPPPicada = new MPPPicada();
            return oMPPPicada.Eliminar_Producto_Detalle_Picada(oBEDetallePicada);
        }
    
        public bool Modificar_Picada(BEPicada oBEPicada)
        {
            oMPPPicada = new MPPPicada();
            return oMPPPicada.Modificar_Picada(oBEPicada);
        }
    
        public bool Modificar_Detalle_Picada(BEDetallePicada oBEDetallePicada)
        {
            oMPPPicada = new MPPPicada();
            return oMPPPicada.Modificar_Detalle_Picada(oBEDetallePicada);
        }
    }
}
