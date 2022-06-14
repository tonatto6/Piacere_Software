using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MPP;

namespace BLL
{
    public class BLLVenta
    {
        MPPVenta oMPPVenta;
        
        public List<BEVenta> Listar_Ventas(int pAño, string pOrdenamiento)
        {
            oMPPVenta = new MPPVenta();
            return oMPPVenta.Listar_Ventas(pAño, pOrdenamiento);
        }

        public List<BEVenta> Listar_Ventas_Mes(int pMes, int pAño, string pOrdenamiento)
        {
            oMPPVenta = new MPPVenta();
            return oMPPVenta.Listar_Ventas_Mes(pMes, pAño, pOrdenamiento);
        }

        public List<BEVenta> Listar_Ventas_Fecha(DateTime fecha)
        {
            oMPPVenta = new MPPVenta();
            return oMPPVenta.Listar_Ventas_Fecha(fecha);
        }

        public List<BEProducto> Listar_Productos_Venta(BEVenta oBEVenta)
        {
            oMPPVenta = new MPPVenta();
            return oMPPVenta.Listar_Productos_Venta(oBEVenta);
        }

        public List<BEPicada> Listar_Picadas_Venta(BEVenta oBEVenta)
        {
            oMPPVenta = new MPPVenta();
            return oMPPVenta.Listar_Picadas_Venta(oBEVenta);
        }

        public Dictionary<string, decimal> Grafico_Ventas(int pAño)
        {
            oMPPVenta = new MPPVenta();
            return oMPPVenta.Grafico_Ventas(pAño);
        }

        public bool Agregar_Venta(BEVenta oBEVenta)
        {
            oMPPVenta = new MPPVenta();
            return oMPPVenta.Agregar_Venta(oBEVenta);
        }

        public void Agregar_Detalle_Venta(BEVenta oBEVenta)
        {
            oMPPVenta = new MPPVenta();
            oMPPVenta.Agregar_Detalle_Venta(oBEVenta);
        }

        public int Generar_N_Venta()
        {
            oMPPVenta = new MPPVenta();
            return oMPPVenta.Generar_N_Venta();
        }

        public bool Verificar_N_Venta(BEVenta oBEVenta)
        {
            oMPPVenta = new MPPVenta();
            return oMPPVenta.Verificar_N_Venta(oBEVenta);
        }
    }
}
