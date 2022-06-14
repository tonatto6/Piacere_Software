using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEVenta
    {

        #region Constructores

        public BEVenta()
        { }

        public BEVenta(int n_venta, string cliente, DateTime fecha, decimal descuento, decimal recargo, decimal monto_total, BEMetodoPago metodo_pago, List<BEProducto> lista_producto, List<BEPicada> lista_picada)
        {
            N_Venta = n_venta;
            Cliente = cliente;
            Fecha = fecha;
            Descuento = descuento;
            Recargo = recargo;
            Monto_Total = monto_total;
            Metodo_Pago = metodo_pago;
            lista_productos = lista_producto;
            lista_picadas = lista_picada;
        }

        #endregion

        #region Propiedades

        public int N_Venta { get; set; }

        public string Cliente { get; set; }

        public DateTime Fecha { get; set; }

        public decimal Descuento { get; set; }

        public decimal Recargo { get; set; }

        public decimal Monto_Total { get; set; }

        public BEMetodoPago Metodo_Pago { get; set; }
    
        public List<BEProducto> Lista_Productos { get; set; }

        private List<BEProducto> lista_productos;
        private List<BEPicada> lista_picadas;

        #endregion

        #region Funciones

        public List<BEProducto> Retornar_Lista_Productos(BEVenta oBEVenta)
        { return oBEVenta.lista_productos; }

        public List<BEPicada> Retornar_Lista_Picadas(BEVenta oBEVenta)
        { return oBEVenta.lista_picadas; }

        #endregion

    }
}
