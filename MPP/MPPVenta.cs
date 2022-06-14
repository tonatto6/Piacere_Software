using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using System.Collections;
using System.Data.SqlClient;
using System.Data;

namespace MPP
{
    public class MPPVenta
    {
        Acceso oAcceso;

        public List<BEVenta> Listar_Ventas(int pAño, string pOrdenamiento)
        {
            oAcceso = new Acceso();

            string nombrestored = "";

            if (pOrdenamiento == "Mayor")
            {nombrestored = "Listar_Ventas_DESC";}
            else
            {nombrestored = "Listar_Ventas_ASC";}

            DataTable dt = new DataTable();
            List<BEVenta> listaventas = new List<BEVenta>();

            ArrayList parametros = new ArrayList();
            SqlParameter Año = new SqlParameter();
            Año.ParameterName = "@Año";
            Año.Value = pAño;
            Año.SqlDbType = SqlDbType.Int;
            parametros.Add(Año);

            dt = oAcceso.Leer(nombrestored, parametros);

            if(dt.Rows.Count > 0)
            {
                foreach(DataRow r in dt.Rows)
                {
                    BEVenta oBEVenta = new BEVenta();
                    oBEVenta.N_Venta = Convert.ToInt32(r[0]);
                    oBEVenta.Cliente = r[1].ToString();
                    oBEVenta.Fecha = Convert.ToDateTime(r[2]);
                    oBEVenta.Descuento = Convert.ToDecimal(r[3]);
                    oBEVenta.Recargo = Convert.ToDecimal(r[4]);
                    oBEVenta.Monto_Total = Convert.ToDecimal(r[5]);

                    BEMetodoPago oBEMetodoPago = new BEMetodoPago();
                    oBEMetodoPago.Codigo = Convert.ToInt32(r[7]);
                    oBEMetodoPago.Metodo_Pago = r[8].ToString();

                    oBEVenta.Metodo_Pago = oBEMetodoPago;

                    listaventas.Add(oBEVenta);
                }
            }
            else { listaventas = null; }

            return listaventas;
        }

        public List<BEVenta> Listar_Ventas_Mes(int pMes, int pAño, string pOrdenamiento)
        {
            oAcceso = new Acceso();

            string nombrestored = "";

            if (pOrdenamiento == "Mayor")
            { nombrestored = "Listar_Ventas_Mes_DESC"; }
            else
            { nombrestored = "Listar_Ventas_Mes_ASC"; }

            DataTable dt = new DataTable();
            List<BEVenta> listaventas = new List<BEVenta>();

            ArrayList parametros = new ArrayList();
            
            SqlParameter Mes = new SqlParameter();
            Mes.ParameterName = "@Mes";
            Mes.Value = pMes;
            Mes.SqlDbType = SqlDbType.Int;
            parametros.Add(Mes);

            SqlParameter Año = new SqlParameter();
            Año.ParameterName = "@Año";
            Año.Value = pAño;
            Año.SqlDbType = SqlDbType.Int;
            parametros.Add(Año);

            dt = oAcceso.Leer(nombrestored, parametros);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    BEVenta oBEVenta = new BEVenta();
                    oBEVenta.N_Venta = Convert.ToInt32(r[0]);
                    oBEVenta.Cliente = r[1].ToString();
                    oBEVenta.Fecha = Convert.ToDateTime(r[2]);
                    oBEVenta.Descuento = Convert.ToDecimal(r[3]);
                    oBEVenta.Recargo = Convert.ToDecimal(r[4]);
                    oBEVenta.Monto_Total = Convert.ToDecimal(r[5]);

                    BEMetodoPago oBEMetodoPago = new BEMetodoPago();
                    oBEMetodoPago.Codigo = Convert.ToInt32(r[7]);
                    oBEMetodoPago.Metodo_Pago = r[8].ToString();

                    oBEVenta.Metodo_Pago = oBEMetodoPago;

                    listaventas.Add(oBEVenta);
                }
            }
            else { listaventas = null; }

            return listaventas;
        }

        public List<BEVenta> Listar_Ventas_Fecha(DateTime fecha)
        {
            oAcceso = new Acceso();
            string nombrestored = "Listar_Ventas_Fecha";
            ArrayList parametros = new ArrayList();

            SqlParameter Fecha = new SqlParameter();
            Fecha.ParameterName = "@Fecha";
            Fecha.Value = fecha;
            Fecha.SqlDbType = SqlDbType.Date;
            parametros.Add(Fecha);

            DataTable dt = new DataTable();
            List<BEVenta> Lista_Ventas = new List<BEVenta>();
            dt = oAcceso.Leer(nombrestored, parametros);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    BEVenta oBEVenta = new BEVenta();
                    oBEVenta.N_Venta = Convert.ToInt32(r[0]);
                    oBEVenta.Cliente = r[1].ToString();
                    oBEVenta.Fecha = Convert.ToDateTime(r[2]);
                    oBEVenta.Descuento = Convert.ToDecimal(r[3]);
                    oBEVenta.Recargo = Convert.ToDecimal(r[4]);
                    oBEVenta.Monto_Total = Convert.ToDecimal(r[5]);

                    Lista_Ventas.Add(oBEVenta);
                }
            }
            else { Lista_Ventas = null; }

            return Lista_Ventas;
        }

        public List<BEProducto> Listar_Productos_Venta(BEVenta oBEVenta)
        {
            oAcceso = new Acceso();
            string nombrestored = "Listar_Productos_Venta";
            ArrayList parametros = new ArrayList();
            DataTable dt = new DataTable();

            SqlParameter N_Venta = new SqlParameter();
            N_Venta.ParameterName = "@N_Venta";
            N_Venta.Value = oBEVenta.N_Venta;
            N_Venta.SqlDbType = SqlDbType.Int;
            parametros.Add(N_Venta);

            dt = oAcceso.Leer(nombrestored, parametros);

            List<BEProducto> lista_productos = new List<BEProducto>();

            if(dt.Rows.Count > 0)
            {
                foreach(DataRow r in dt.Rows)
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

        public List<BEPicada> Listar_Picadas_Venta(BEVenta oBEVenta)
        {
            oAcceso = new Acceso();
            string nombrestored = "Listar_Picadas_Venta";
            ArrayList parametros = new ArrayList();
            DataTable dt = new DataTable();

            SqlParameter N_Venta = new SqlParameter();
            N_Venta.ParameterName = "@N_Venta";
            N_Venta.Value = oBEVenta.N_Venta;
            N_Venta.SqlDbType = SqlDbType.Int;
            parametros.Add(N_Venta);

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

        public bool Agregar_Venta(BEVenta oBEVenta)
        {
            oAcceso = new Acceso();
            string nombrestored = "Agregar_Venta";
            ArrayList parametros = new ArrayList();

            SqlParameter N_Venta = new SqlParameter();
            N_Venta.ParameterName = "@N_Venta";
            N_Venta.Value = oBEVenta.N_Venta;
            N_Venta.SqlDbType = SqlDbType.Int;
            parametros.Add(N_Venta);

            SqlParameter Cliente = new SqlParameter();
            Cliente.ParameterName = "@Cliente";
            Cliente.Value = oBEVenta.Cliente;
            Cliente.SqlDbType = SqlDbType.NVarChar;
            parametros.Add(Cliente);

            SqlParameter Fecha = new SqlParameter();
            Fecha.ParameterName = "@Fecha";
            Fecha.Value = oBEVenta.Fecha;
            Fecha.SqlDbType = SqlDbType.Date;
            parametros.Add(Fecha);

            SqlParameter Descuento = new SqlParameter();
            Descuento.ParameterName = "@Descuento";
            Descuento.Value = oBEVenta.Descuento;
            Descuento.SqlDbType = SqlDbType.Decimal;
            parametros.Add(Descuento);

            SqlParameter Recargo = new SqlParameter();
            Recargo.ParameterName = "@Recargo";
            Recargo.Value = oBEVenta.Recargo;
            Recargo.SqlDbType = SqlDbType.Decimal;
            parametros.Add(Recargo);

            SqlParameter Monto_Total = new SqlParameter();
            Monto_Total.ParameterName = "@Monto_Total";
            Monto_Total.Value = oBEVenta.Monto_Total;
            Monto_Total.SqlDbType = SqlDbType.Decimal;
            parametros.Add(Monto_Total);

            SqlParameter Codigo_Metodo_Pago = new SqlParameter();
            Codigo_Metodo_Pago.ParameterName = "@Codigo_Metodo_Pago";
            Codigo_Metodo_Pago.Value = oBEVenta.Metodo_Pago.Codigo;
            Codigo_Metodo_Pago.SqlDbType = SqlDbType.Int;
            parametros.Add(Codigo_Metodo_Pago);

            return oAcceso.Escribir(nombrestored, parametros);
        }   
    
        public int Generar_N_Venta()
        {
            oAcceso = new Acceso();
            string nombrestored = "Generar_N_Venta";

            int numeroventa = 0;
            numeroventa = oAcceso.LeerScalar2(nombrestored, null);
            numeroventa++;
            return numeroventa;
        }
    
        public bool Verificar_N_Venta(BEVenta oBEVenta)
        {
            oAcceso = new Acceso();
            string nombrestored = "Verificiar_N_Venta";
            ArrayList parametros = new ArrayList();

            SqlParameter N_Venta = new SqlParameter();
            N_Venta.ParameterName = "@N_Venta";
            N_Venta.Value = oBEVenta.N_Venta;
            N_Venta.SqlDbType = SqlDbType.Int;
            parametros.Add(N_Venta);

            return oAcceso.LeerScalar(nombrestored, parametros);
        }

        public void Agregar_Detalle_Venta(BEVenta oBEVenta)
        {
            oAcceso = new Acceso();
            string nombrestored = "Agregar_Detalle_Venta";
            ArrayList parametros = new ArrayList();

            if (oBEVenta.Retornar_Lista_Productos(oBEVenta) != null)
            {
                foreach (BEProducto producto in oBEVenta.Retornar_Lista_Productos(oBEVenta))
                {
                    SqlParameter N_Venta = new SqlParameter();
                    N_Venta.ParameterName = "@N_Venta";
                    N_Venta.Value = oBEVenta.N_Venta;
                    N_Venta.SqlDbType = SqlDbType.Int;
                    parametros.Add(N_Venta);

                    SqlParameter Codigo_Producto = new SqlParameter();
                    Codigo_Producto.ParameterName = "@Codigo_Producto";
                    Codigo_Producto.Value = producto.Codigo;
                    Codigo_Producto.SqlDbType = SqlDbType.Int;
                    parametros.Add(Codigo_Producto);

                    SqlParameter Tipo_Producto = new SqlParameter();
                    Tipo_Producto.ParameterName = "@Tipo_Producto";
                    Tipo_Producto.Value = "Producto";
                    Tipo_Producto.SqlDbType = SqlDbType.NVarChar;
                    parametros.Add(Tipo_Producto);

                    SqlParameter Precio_Unitario = new SqlParameter();
                    Precio_Unitario.ParameterName = "@Precio_Unitario";
                    Precio_Unitario.Value = producto.Precio_Unidad;
                    Precio_Unitario.SqlDbType = SqlDbType.Decimal;
                    parametros.Add(Precio_Unitario);

                    oAcceso.Escribir(nombrestored, parametros);
                    parametros.Clear();
                }
            }

            if(oBEVenta.Retornar_Lista_Picadas(oBEVenta) != null)
            {
                foreach (BEPicada picada in oBEVenta.Retornar_Lista_Picadas(oBEVenta))
                {
                    SqlParameter N_Venta = new SqlParameter();
                    N_Venta.ParameterName = "@N_Venta";
                    N_Venta.Value = oBEVenta.N_Venta;
                    N_Venta.SqlDbType = SqlDbType.Int;
                    parametros.Add(N_Venta);

                    SqlParameter Codigo_Producto = new SqlParameter();
                    Codigo_Producto.ParameterName = "@Codigo_Producto";
                    Codigo_Producto.Value = picada.Codigo;
                    Codigo_Producto.SqlDbType = SqlDbType.Int;
                    parametros.Add(Codigo_Producto);

                    SqlParameter Tipo_Producto = new SqlParameter();
                    Tipo_Producto.ParameterName = "@Tipo_Producto";
                    Tipo_Producto.Value = "Picada";
                    Tipo_Producto.SqlDbType = SqlDbType.NVarChar;
                    parametros.Add(Tipo_Producto);

                    SqlParameter Precio_Unitario = new SqlParameter();
                    Precio_Unitario.ParameterName = "@Precio_Unitario";
                    Precio_Unitario.Value = picada.Precio;
                    Precio_Unitario.SqlDbType = SqlDbType.Decimal;
                    parametros.Add(Precio_Unitario);

                    oAcceso.Escribir(nombrestored, parametros);
                    parametros.Clear();
                }
            } 
        }

        public Dictionary<string, decimal> Grafico_Ventas(int pAño)
        {
            DataTable dt = new DataTable();
            ArrayList parametros = new ArrayList();
            Acceso oAcceso = new Acceso();
            string nombreStored = "Grafico_Ventas";

            SqlParameter paramAño = new SqlParameter();
            paramAño.ParameterName = "@Año";
            paramAño.Value = pAño;
            paramAño.SqlDbType = SqlDbType.Int;
            parametros.Add(paramAño);

            dt = oAcceso.Leer(nombreStored, parametros);

            Dictionary<string, decimal> lDatos = new Dictionary<string, decimal>();

            foreach (DataRow r in dt.Rows)
            {
                switch (Convert.ToInt32(r[1]))
                {
                    case 1:
                        lDatos.Add("Enero", Convert.ToInt32(r[0]));
                        break;

                    case 2:
                        lDatos.Add("Febrero", Convert.ToInt32(r[0]));
                        break;

                    case 3:
                        lDatos.Add("Marzo", Convert.ToInt32(r[0]));
                        break;

                    case 4:
                        lDatos.Add("Abril", Convert.ToInt32(r[0]));
                        break;

                    case 5:
                        lDatos.Add("Mayo", Convert.ToInt32(r[0]));
                        break;

                    case 6:
                        lDatos.Add("Junio", Convert.ToInt32(r[0]));
                        break;

                    case 7:
                        lDatos.Add("Julio", Convert.ToInt32(r[0]));
                        break;

                    case 8:
                        lDatos.Add("Agosto", Convert.ToInt32(r[0]));
                        break;

                    case 9:
                        lDatos.Add("Septiembre", Convert.ToInt32(r[0]));
                        break;

                    case 10:
                        lDatos.Add("Octubre", Convert.ToInt32(r[0]));
                        break;

                    case 11:
                        lDatos.Add("Noviembre", Convert.ToInt32(r[0]));
                        break;

                    case 12:
                        lDatos.Add("Diciembre", Convert.ToInt32(r[0]));
                        break;
                }
            }

            return lDatos;
        }
    }
}
