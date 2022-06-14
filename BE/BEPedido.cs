using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEPedido
    {

        #region Constructores

        public BEPedido()
        { }

        public BEPedido(int codigo, string cliente, string descripcion, DateTime fecha_pedido, DateTime fecha_entrega, bool pagado, decimal costo_total, List<BEProducto> listaproductos, List<BEPicada> listapicadas)
        {
            Codigo = codigo;
            Cliente = cliente;
            Descripcion = descripcion;
            Fecha_Pedido = fecha_pedido;
            Fecha_Entrega = fecha_entrega;
            Pagado = pagado;
            Costo_Total = costo_total;
            Lista_Productos = listaproductos;
            Lista_Picadas = listapicadas;
        }

        #endregion

        #region Propiedades

        public int Codigo { get; set; }

        public string Cliente { get; set; }

        public string Descripcion { get; set; }

        public DateTime Fecha_Pedido { get; set; }

        public DateTime Fecha_Entrega { get; set; }

        public bool Pagado { get; set; }

        public decimal Costo_Total { get; set; }

        private List<BEProducto> Lista_Productos;
        private List<BEPicada> Lista_Picadas;

        #endregion

        #region Funciones

        public List<BEProducto> Retornar_Lista_Productos(BEPedido oBEPedido)
        { return oBEPedido.Lista_Productos; }

        public List<BEPicada> Retornar_Lista_Picadas(BEPedido oBEPedido)
        { return oBEPedido.Lista_Picadas; }

        #endregion

    }
}
