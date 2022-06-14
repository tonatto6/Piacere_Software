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
    public class MPPPicada
    {
        Acceso oAcceso;

        public List<BEPicada> Listar_Picadas()
        {
            oAcceso = new Acceso();
            DataTable dt = new DataTable();
            string nombrestored = "Listar_Picadas";

            dt = oAcceso.Leer(nombrestored, null);
            List<BEPicada> lista_picadas = new List<BEPicada>();

            if(dt.Rows.Count > 0)
            {
                foreach(DataRow r in dt.Rows)
                {
                    BEPicada oBEPicada = new BEPicada();
                    oBEPicada.Codigo = Convert.ToInt32(r[0]);
                    oBEPicada.Nombre = r[1].ToString();
                    oBEPicada.Descripcion = r[2].ToString();
                    oBEPicada.Precio = Convert.ToDecimal(r[3]);
                    lista_picadas.Add(oBEPicada);
                }
            }
            else { lista_picadas = null; }

            return lista_picadas;
        }

        public List<BEPicada> Buscar_Picadas(string cadena)
        {
            oAcceso = new Acceso();
            DataTable dt = new DataTable();
            string nombrestored = "Buscar_Picada";
            ArrayList parametros = new ArrayList();

            SqlParameter Cadena = new SqlParameter();
            Cadena.ParameterName = "@Cadena";
            Cadena.Value = cadena;
            Cadena.SqlDbType = SqlDbType.NVarChar;
            parametros.Add(Cadena);

            dt = oAcceso.Leer(nombrestored, parametros);
            List<BEPicada> lista_picadas = new List<BEPicada>();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    BEPicada oBEPicada = new BEPicada();
                    oBEPicada.Codigo = Convert.ToInt32(r[0]);
                    oBEPicada.Nombre = r[1].ToString();
                    oBEPicada.Descripcion = r[2].ToString();
                    oBEPicada.Precio = Convert.ToDecimal(r[3]);
                    lista_picadas.Add(oBEPicada);
                }
            }
            else { lista_picadas = null; }

            return lista_picadas;
        }

        public List<BEDetallePicada> Listar_Detalle_Picadas(BEPicada oBEPicada)
        {
            oAcceso = new Acceso();
            string nombrestored = "Listar_Detalle_Picadas";
            ArrayList parametros = new ArrayList();

            SqlParameter Codigo_Picada = new SqlParameter();
            Codigo_Picada.ParameterName = "@Codigo_Picada";
            Codigo_Picada.Value = oBEPicada.Codigo;
            Codigo_Picada.SqlDbType = SqlDbType.Int;
            parametros.Add(Codigo_Picada);

            DataTable dt = new DataTable();
            dt = oAcceso.Leer(nombrestored, parametros);

            List<BEDetallePicada> lista_detalle_picadas = new List<BEDetallePicada>();

            if(dt.Rows.Count > 0)
            {
                foreach(DataRow r in dt.Rows)
                {
                    BEDetallePicada oBEDetallePicada = new BEDetallePicada();
                    oBEDetallePicada.Codigo = Convert.ToInt32(r[0]);
                    oBEDetallePicada.Producto = r[2].ToString();
                    oBEDetallePicada.Cantidad = Convert.ToDecimal(r[3]);
                    oBEDetallePicada.Precio_Unidad = Convert.ToDecimal(r[4]);
                    oBEDetallePicada.Total = Convert.ToDecimal(r[5]);

                    lista_detalle_picadas.Add(oBEDetallePicada);
                }
            }
            else { lista_detalle_picadas = null; }

            return lista_detalle_picadas;
        }

        public BEPicada Seleccionar_Picada(BEPicada oBEPicada)
        {
            oAcceso = new Acceso();
            string nombrestored = "Seleccionar_Picada";
            ArrayList parametros = new ArrayList();

            SqlParameter Codigo_Picada = new SqlParameter();
            Codigo_Picada.ParameterName = "@Codigo_Picada";
            Codigo_Picada.Value = oBEPicada.Codigo;
            Codigo_Picada.SqlDbType = SqlDbType.Int;
            parametros.Add(Codigo_Picada);

            DataTable dt = new DataTable();
            BEPicada Picada = new BEPicada();
            dt = oAcceso.Leer(nombrestored, parametros);

            if(dt.Rows.Count > 0)
            {
                foreach(DataRow r in dt.Rows)
                {
                    Picada.Codigo = Convert.ToInt32(r[0]);
                    Picada.Nombre = r[1].ToString();
                    Picada.Descripcion = r[2].ToString();
                    Picada.Precio = Convert.ToDecimal(r[3]);
                }
            }
            else { Picada = null; }

            return Picada;
        }

        public bool Agregar_Picada(BEPicada oBEPicada)
        {
            oAcceso = new Acceso();
            string nombrestored = "Agregar_Picada";
            ArrayList parametros = new ArrayList();

            SqlParameter Codigo = new SqlParameter();
            Codigo.ParameterName = "@Codigo";
            Codigo.Value = oBEPicada.Codigo;
            Codigo.SqlDbType = SqlDbType.Int;
            parametros.Add(Codigo);

            SqlParameter Nombre = new SqlParameter();
            Nombre.ParameterName = "@Nombre";
            Nombre.Value = oBEPicada.Nombre;
            Nombre.SqlDbType = SqlDbType.NVarChar;
            parametros.Add(Nombre);

            SqlParameter Descripcion = new SqlParameter();
            Descripcion.ParameterName = "@Descripcion";
            Descripcion.Value = oBEPicada.Descripcion;
            Descripcion.SqlDbType = SqlDbType.NVarChar;
            parametros.Add(Descripcion);

            SqlParameter Precio = new SqlParameter();
            Precio.ParameterName = "@Precio";
            Precio.Value = oBEPicada.Precio;
            Precio.SqlDbType = SqlDbType.Decimal;
            parametros.Add(Precio);

            return oAcceso.Escribir(nombrestored, parametros);
        }
    
        public int Crear_Codigo_Nueva_Picada()
        {
            oAcceso = new Acceso();
            string nombrestored = "Crear_Codigo_Nueva_Picada";

            int nuevo_codigo = oAcceso.LeerScalar2(nombrestored, null);

            nuevo_codigo++;

            return nuevo_codigo;
        }
           
        public void Agregar_Detalle_Picada(BEPicada oBEPicada)
        {
            oAcceso = new Acceso();
            string nombrestored = "Agregar_Detalle_Picada";

            ArrayList parametros = new ArrayList();

            foreach(BEDetallePicada Detalle_Picada in oBEPicada.Retornar_Lista_Detalle_Picada(oBEPicada))
            {
                SqlParameter Codigo_Picada = new SqlParameter();
                Codigo_Picada.ParameterName = "@Codigo_Picada";
                Codigo_Picada.Value = oBEPicada.Codigo;
                Codigo_Picada.SqlDbType = SqlDbType.Int;
                parametros.Add(Codigo_Picada);

                SqlParameter Producto = new SqlParameter();
                Producto.ParameterName = "@Producto";
                Producto.Value = Detalle_Picada.Producto;
                Producto.SqlDbType = SqlDbType.NVarChar;
                parametros.Add(Producto);

                SqlParameter Cantidad = new SqlParameter();
                Cantidad.ParameterName = "@Cantidad";
                Cantidad.Value = Detalle_Picada.Cantidad;
                Cantidad.SqlDbType = SqlDbType.Decimal;
                parametros.Add(Cantidad);

                SqlParameter Precio_Unidad = new SqlParameter();
                Precio_Unidad.ParameterName = "@Precio_Unidad";
                Precio_Unidad.Value = Detalle_Picada.Precio_Unidad;
                Precio_Unidad.SqlDbType = SqlDbType.Decimal;
                parametros.Add(Precio_Unidad);

                SqlParameter Total = new SqlParameter();
                Total.ParameterName = "@Total";
                Total.Value = Detalle_Picada.Total;
                Total.SqlDbType = SqlDbType.Decimal;
                parametros.Add(Total);

                oAcceso.Escribir(nombrestored, parametros);

                parametros.Clear();
            }
        }
    
        public bool Validar_Eliminacion_Picada(BEPicada oBEPicada)
        {
            oAcceso = new Acceso();
            string nombrestored = "Validar_Eliminacion_Picada";
            ArrayList parametros = new ArrayList();

            SqlParameter Codigo_Producto = new SqlParameter();
            Codigo_Producto.ParameterName = "@Codigo_Producto";
            Codigo_Producto.Value = oBEPicada.Codigo;
            Codigo_Producto.SqlDbType = SqlDbType.Int;
            parametros.Add(Codigo_Producto);

            return oAcceso.LeerScalar(nombrestored, parametros);
        }

        public bool Validar_Picada_Detalle_Pedido(BEPicada oBEPicada)
        {
            oAcceso = new Acceso();
            string nombrestored = "Validar_Picada_Detalle_Pedido";
            ArrayList parametros = new ArrayList();

            SqlParameter Codigo_Producto = new SqlParameter();
            Codigo_Producto.ParameterName = "@Codigo_Producto";
            Codigo_Producto.Value = oBEPicada.Codigo;
            Codigo_Producto.SqlDbType = SqlDbType.Int;
            parametros.Add(Codigo_Producto);

            return oAcceso.LeerScalar(nombrestored, parametros);
        }

        public bool Eliminar_Picada(BEPicada oBEPicada)
        {
            oAcceso = new Acceso();
            string nombrestored = "Eliminar_Picada";
            ArrayList parametros = new ArrayList();

            SqlParameter Codigo = new SqlParameter();
            Codigo.ParameterName = "@Codigo";
            Codigo.Value = oBEPicada.Codigo;
            Codigo.SqlDbType = SqlDbType.Int;
            parametros.Add(Codigo);

            return oAcceso.Escribir(nombrestored, parametros);
        }
    
        public void Eliminar_Detalle_Picada(BEPicada oBEPicada)
        {
            oAcceso = new Acceso();
            string nombrestored = "Eliminar_Detalle_Picada";
            ArrayList parametros = new ArrayList();

            SqlParameter Codigo = new SqlParameter();
            Codigo.ParameterName = "@Codigo_Picada";
            Codigo.Value = oBEPicada.Codigo;
            Codigo.SqlDbType = SqlDbType.Int;
            parametros.Add(Codigo);

            oAcceso.Escribir(nombrestored, parametros);
        }
    
        public bool Eliminar_Producto_Detalle_Picada(BEDetallePicada oBEDetallePicada)
        {
            oAcceso = new Acceso();
            string nombrestored = "Eliminar_Producto_Detalle_Picada";

            ArrayList parametros = new ArrayList();

            SqlParameter Codigo = new SqlParameter();
            Codigo.ParameterName = "@Codigo";
            Codigo.Value = oBEDetallePicada.Codigo;
            Codigo.SqlDbType = SqlDbType.Int;
            parametros.Add(Codigo);

            return oAcceso.Escribir(nombrestored, parametros);
        }

        public bool Modificar_Precio_Picada(BEPicada oBEPicada)
        {
            oAcceso = new Acceso();
            string nombrestored = "Modificar_Precio_Picada";
            ArrayList parametros = new ArrayList();

            SqlParameter Codigo_Picada = new SqlParameter();
            Codigo_Picada.ParameterName = "@Codigo_Picada";
            Codigo_Picada.Value = oBEPicada.Codigo;
            Codigo_Picada.SqlDbType = SqlDbType.Int;
            parametros.Add(Codigo_Picada);

            SqlParameter Precio = new SqlParameter();
            Precio.ParameterName = "@Precio";
            Precio.Value = oBEPicada.Precio;
            Precio.SqlDbType = SqlDbType.Decimal;
            parametros.Add(Precio);

            return oAcceso.Escribir(nombrestored, parametros);
        }
    
        public bool Modificar_Picada(BEPicada oBEPicada)
        {
            oAcceso = new Acceso();
            string nombrestored = "Modificar_Picada";
            ArrayList parametros = new ArrayList();

            SqlParameter Codigo = new SqlParameter();
            Codigo.ParameterName = "@Codigo";
            Codigo.Value = oBEPicada.Codigo;
            Codigo.SqlDbType = SqlDbType.Int;
            parametros.Add(Codigo);

            SqlParameter Nombre = new SqlParameter();
            Nombre.ParameterName = "@Nombre";
            Nombre.Value = oBEPicada.Nombre;
            Nombre.SqlDbType = SqlDbType.NVarChar;
            parametros.Add(Nombre);

            SqlParameter Descripcion = new SqlParameter();
            Descripcion.ParameterName = "@Descripcion";
            Descripcion.Value = oBEPicada.Descripcion;
            Descripcion.SqlDbType = SqlDbType.NVarChar;
            parametros.Add(Descripcion);

            SqlParameter Precio = new SqlParameter();
            Precio.ParameterName = "@Precio";
            Precio.Value = oBEPicada.Precio;
            Precio.SqlDbType = SqlDbType.Decimal;
            parametros.Add(Precio);

            return oAcceso.Escribir(nombrestored, parametros);
        }
    
        public bool Modificar_Detalle_Picada(BEDetallePicada oBEDetallePicada)
        {
            oAcceso = new Acceso();
            string nombrestored = "Modificar_Detalle_Picada";
            ArrayList parametros = new ArrayList();

            SqlParameter Codigo = new SqlParameter();
            Codigo.ParameterName = "@Codigo";
            Codigo.Value = oBEDetallePicada.Codigo;
            Codigo.SqlDbType = SqlDbType.Int;
            parametros.Add(Codigo);

            SqlParameter Producto = new SqlParameter();
            Producto.ParameterName = "@Producto";
            Producto.Value = oBEDetallePicada.Producto;
            Producto.SqlDbType = SqlDbType.NVarChar;
            parametros.Add(Producto);

            SqlParameter Cantidad = new SqlParameter();
            Cantidad.ParameterName = "@Cantidad";
            Cantidad.Value = oBEDetallePicada.Cantidad;
            Cantidad.SqlDbType = SqlDbType.Decimal;
            parametros.Add(Cantidad);

            SqlParameter Precio_Unidad = new SqlParameter();
            Precio_Unidad.ParameterName = "@Precio_Unidad";
            Precio_Unidad.Value = oBEDetallePicada.Precio_Unidad;
            Precio_Unidad.SqlDbType = SqlDbType.Decimal;
            parametros.Add(Precio_Unidad);

            SqlParameter Total = new SqlParameter();
            Total.ParameterName = "@Total";
            Total.Value = oBEDetallePicada.Total;
            Total.SqlDbType = SqlDbType.Decimal;
            parametros.Add(Total);

            return oAcceso.Escribir(nombrestored, parametros);
        }
    }
}
