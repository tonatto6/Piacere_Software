using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BE;
using DAL;

namespace MPP
{
    public class MPPPedido
    {
        Acceso oAcceso;

        public List<BEPedido> Listar_Pedidos()
        {
            oAcceso = new Acceso();
            string nombrestored = "Listar_Pedidos";

            DataTable dt = new DataTable();
            List<BEPedido> lista_pedidos = new List<BEPedido>();

            dt = oAcceso.Leer(nombrestored, null);

            if(dt.Rows.Count > 0)
            {
                foreach(DataRow r in dt.Rows)
                {
                    BEPedido oBEPedido = new BEPedido();
                    oBEPedido.Codigo = Convert.ToInt32(r[0]);
                    oBEPedido.Cliente = r[1].ToString();
                    oBEPedido.Descripcion = r[2].ToString();
                    oBEPedido.Fecha_Pedido = Convert.ToDateTime(r[3]);
                    oBEPedido.Fecha_Entrega = Convert.ToDateTime(r[4]);
                    oBEPedido.Pagado = Convert.ToBoolean(r[5]);
                    oBEPedido.Costo_Total = Convert.ToDecimal(r[6]);

                    lista_pedidos.Add(oBEPedido);
                }
            }
            else { lista_pedidos = null; }

            return lista_pedidos;
        }

        public List<BEPedido> Listar_Pedidos_Por_Fecha(DateTime fecha_entrega)
        {
            oAcceso = new Acceso();
            string nombrestored = "Listar_Pedidos_Por_Fecha";
            ArrayList parametros = new ArrayList();

            SqlParameter Fecha_Entrega = new SqlParameter();
            Fecha_Entrega.ParameterName = "@Fecha_Entrega";
            Fecha_Entrega.Value = fecha_entrega;
            Fecha_Entrega.SqlDbType = SqlDbType.Date;
            parametros.Add(Fecha_Entrega);

            DataTable dt = new DataTable();
            List<BEPedido> lista_pedidos = new List<BEPedido>();

            dt = oAcceso.Leer(nombrestored, parametros);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    BEPedido oBEPedido = new BEPedido();
                    oBEPedido.Codigo = Convert.ToInt32(r[0]);
                    oBEPedido.Cliente = r[1].ToString();
                    oBEPedido.Descripcion = r[2].ToString();
                    oBEPedido.Fecha_Pedido = Convert.ToDateTime(r[3]);
                    oBEPedido.Fecha_Entrega = Convert.ToDateTime(r[4]);
                    oBEPedido.Pagado = Convert.ToBoolean(r[5]);
                    oBEPedido.Costo_Total = Convert.ToDecimal(r[6]);

                    lista_pedidos.Add(oBEPedido);
                }
            }
            else { lista_pedidos = null; }

            return lista_pedidos;
        }

        public List<BEPedido> Listar_Pedidos_Por_Dias(int cantidad_dias)
        {
            oAcceso = new Acceso();
            string nombrestored = "Listar_Pedidos_Dias";
            ArrayList parametros = new ArrayList();

            SqlParameter Cantidad_Dias = new SqlParameter();
            Cantidad_Dias.ParameterName = "@Cantidad_Dias";
            Cantidad_Dias.Value = cantidad_dias;
            Cantidad_Dias.SqlDbType = SqlDbType.Int;
            parametros.Add(Cantidad_Dias);

            DataTable dt = new DataTable();
            List<BEPedido> lista_pedidos = new List<BEPedido>();

            dt = oAcceso.Leer(nombrestored, parametros);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    BEPedido oBEPedido = new BEPedido();
                    oBEPedido.Codigo = Convert.ToInt32(r[0]);
                    oBEPedido.Cliente = r[1].ToString();
                    oBEPedido.Descripcion = r[2].ToString();
                    oBEPedido.Fecha_Pedido = Convert.ToDateTime(r[3]);
                    oBEPedido.Fecha_Entrega = Convert.ToDateTime(r[4]);
                    oBEPedido.Pagado = Convert.ToBoolean(r[5]);
                    oBEPedido.Costo_Total = Convert.ToDecimal(r[6]);

                    lista_pedidos.Add(oBEPedido);
                }
            }
            else { lista_pedidos = null; }

            return lista_pedidos;
        }

        public List<BEProducto> Listar_Productos_Pedidos(BEPedido oBEPedido)
        {
            oAcceso = new Acceso();
            string nombrestored = "Listar_Productos_Pedidos";
            ArrayList parametros = new ArrayList();
            DataTable dt = new DataTable();

            SqlParameter Codigo_Pedido = new SqlParameter();
            Codigo_Pedido.ParameterName = "@Codigo_Pedido";
            Codigo_Pedido.Value = oBEPedido.Codigo;
            Codigo_Pedido.SqlDbType = SqlDbType.Int;
            parametros.Add(Codigo_Pedido);

            dt = oAcceso.Leer(nombrestored, parametros);

            List<BEProducto> lista_productos = new List<BEProducto>();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    BEProducto oBEProducto = new BEProducto();
                    oBEProducto.Codigo = Convert.ToInt32(r[3]);
                    oBEProducto.Nombre = r[4].ToString();
                    oBEProducto.Precio_Unidad = Convert.ToDecimal(r[2]);

                    lista_productos.Add(oBEProducto);
                }
            }
            else { lista_productos = null; }

            return lista_productos;
        }

        public List<BEPicada> Listar_Picadas_Pedido(BEPedido oBEPedido)
        {
            oAcceso = new Acceso();
            string nombrestored = "Listar_Picadas_Pedidos";
            ArrayList parametros = new ArrayList();
            DataTable dt = new DataTable();

            SqlParameter Codigo_Pedido = new SqlParameter();
            Codigo_Pedido.ParameterName = "@Codigo_Pedido";
            Codigo_Pedido.Value = oBEPedido.Codigo;
            Codigo_Pedido.SqlDbType = SqlDbType.Int;
            parametros.Add(Codigo_Pedido);

            dt = oAcceso.Leer(nombrestored, parametros);

            List<BEPicada> lista_picadas = new List<BEPicada>();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    BEPicada oBEPicada = new BEPicada();
                    oBEPicada.Codigo = Convert.ToInt32(r[3]);
                    oBEPicada.Nombre = r[4].ToString();
                    oBEPicada.Precio = Convert.ToDecimal(r[2]);

                    lista_picadas.Add(oBEPicada);
                }
            }
            else { lista_picadas = null; }

            return lista_picadas;
        }

        public bool Agregar_Pedido(BEPedido oBEPedido)
        {
            oAcceso = new Acceso();
            string nombrestored = "Agregar_Pedido";
            ArrayList parametros = new ArrayList();

            SqlParameter Codigo = new SqlParameter();
            Codigo.ParameterName = "@Codigo";
            Codigo.Value = oBEPedido.Codigo;
            Codigo.SqlDbType = SqlDbType.Int;
            parametros.Add(Codigo);

            SqlParameter Cliente = new SqlParameter();
            Cliente.ParameterName = "@Cliente";
            Cliente.Value = oBEPedido.Cliente;
            Cliente.SqlDbType = SqlDbType.NVarChar;
            parametros.Add(Cliente);

            SqlParameter Descripcion = new SqlParameter();
            Descripcion.ParameterName = "@Descripcion";
            Descripcion.Value = oBEPedido.Descripcion;
            Descripcion.SqlDbType = SqlDbType.NVarChar;
            parametros.Add(Descripcion);

            SqlParameter Fecha_Pedido = new SqlParameter();
            Fecha_Pedido.ParameterName = "@Fecha_Pedido";
            Fecha_Pedido.Value = oBEPedido.Fecha_Pedido;
            Fecha_Pedido.SqlDbType = SqlDbType.Date;
            parametros.Add(Fecha_Pedido);

            SqlParameter Fecha_Entrega = new SqlParameter();
            Fecha_Entrega.ParameterName = "@Fecha_Entrega";
            Fecha_Entrega.Value = oBEPedido.Fecha_Entrega;
            Fecha_Entrega.SqlDbType = SqlDbType.Date;
            parametros.Add(Fecha_Entrega);

            SqlParameter Pagado = new SqlParameter();
            Pagado.ParameterName = "@Pagado";
            Pagado.Value = oBEPedido.Pagado;
            Pagado.SqlDbType = SqlDbType.Bit;
            parametros.Add(Pagado);

            SqlParameter Costo = new SqlParameter();
            Costo.ParameterName = "@Costo";
            Costo.Value = oBEPedido.Costo_Total;
            Costo.SqlDbType = SqlDbType.Decimal;
            parametros.Add(Costo);

            return oAcceso.Escribir(nombrestored, parametros);
        }
    
        public void Agregar_Detalle_Pedido(BEPedido oBEPedido)
        {
            string nombrestored = "Agregar_Detalle_Pedido";
            oAcceso = new Acceso();
            ArrayList parametros = new ArrayList();

            if(oBEPedido.Retornar_Lista_Productos(oBEPedido).Count > 0)
            {
                foreach(BEProducto producto in oBEPedido.Retornar_Lista_Productos(oBEPedido))
                {
                    SqlParameter Codigo_Pedido = new SqlParameter();
                    Codigo_Pedido.ParameterName = "@Codigo_Pedido";
                    Codigo_Pedido.Value = oBEPedido.Codigo;
                    Codigo_Pedido.SqlDbType = SqlDbType.Int;
                    parametros.Add(Codigo_Pedido);

                    SqlParameter Codigo_Producto = new SqlParameter();
                    Codigo_Producto.ParameterName = "@Codigo_Producto";
                    Codigo_Producto.Value = producto.Codigo;
                    Codigo_Producto.SqlDbType = SqlDbType.Int;
                    parametros.Add(Codigo_Producto);

                    SqlParameter Tipo_Producto = new SqlParameter();
                    Tipo_Producto.ParameterName = "@Tipo_Producto";
                    Tipo_Producto.Value = "Producto";
                    Tipo_Producto.SqlDbType = SqlDbType.Int;
                    parametros.Add(Tipo_Producto);

                    SqlParameter Precio = new SqlParameter();
                    Precio.ParameterName = "@Precio";
                    Precio.Value = producto.Precio_Unidad;
                    Precio.SqlDbType = SqlDbType.Decimal;
                    parametros.Add(Precio);

                    oAcceso.Escribir(nombrestored, parametros);

                    parametros.Clear();
                }
            }

            if (oBEPedido.Retornar_Lista_Picadas(oBEPedido).Count > 0)
            {
                foreach (BEPicada picada in oBEPedido.Retornar_Lista_Picadas(oBEPedido))
                {
                    SqlParameter Codigo_Pedido = new SqlParameter();
                    Codigo_Pedido.ParameterName = "@Codigo_Pedido";
                    Codigo_Pedido.Value = oBEPedido.Codigo;
                    Codigo_Pedido.SqlDbType = SqlDbType.Int;
                    parametros.Add(Codigo_Pedido);

                    SqlParameter Codigo_Producto = new SqlParameter();
                    Codigo_Producto.ParameterName = "@Codigo_Producto";
                    Codigo_Producto.Value = picada.Codigo;
                    Codigo_Producto.SqlDbType = SqlDbType.Int;
                    parametros.Add(Codigo_Producto);

                    SqlParameter Tipo_Producto = new SqlParameter();
                    Tipo_Producto.ParameterName = "@Tipo_Producto";
                    Tipo_Producto.Value = "Picada";
                    Tipo_Producto.SqlDbType = SqlDbType.Int;
                    parametros.Add(Tipo_Producto);

                    SqlParameter Precio = new SqlParameter();
                    Precio.ParameterName = "@Precio";
                    Precio.Value = picada.Precio;
                    Precio.SqlDbType = SqlDbType.Decimal;
                    parametros.Add(Precio);

                    oAcceso.Escribir(nombrestored, parametros);

                    parametros.Clear();
                }
            }

        }

        public int Crear_Codigo_Pedido()
        {
            string nombrestored = "Crear_Codigo_Pedido";
            oAcceso = new Acceso();

            int nuevocodigo = 0;

            nuevocodigo = oAcceso.LeerScalar2(nombrestored, null);
            nuevocodigo++;

            return nuevocodigo;
        }
    
        public bool Eliminar_Pedido(BEPedido oBEPedido)
        {
            oAcceso = new Acceso();
            string nombrestored = "Eliminar_Pedido";
            ArrayList parametros = new ArrayList();

            SqlParameter Codigo = new SqlParameter();
            Codigo.ParameterName = "@Codigo";
            Codigo.Value = oBEPedido.Codigo;
            Codigo.SqlDbType = SqlDbType.Int;
            parametros.Add(Codigo);

            return oAcceso.Escribir(nombrestored, parametros);
        }
    
        public bool Eliminar_Detalle_Pedido(BEPedido oBEPedido)
        {
            oAcceso = new Acceso();
            string nombrestored = "Eliminar_Detalle_Pedido";
            ArrayList parametros = new ArrayList();

            SqlParameter Codigo = new SqlParameter();
            Codigo.ParameterName = "@Codigo_Pedido";
            Codigo.Value = oBEPedido.Codigo;
            Codigo.SqlDbType = SqlDbType.Int;
            parametros.Add(Codigo);

            return oAcceso.Escribir(nombrestored, parametros);
        }
    }
}
