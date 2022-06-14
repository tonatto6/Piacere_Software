using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace MPP
{
    public class MPPProducto
    {
        Acceso oAcceso;
        List<BEProducto> lista_productos;

        public List<BEProducto> Listar_Productos()
        {
            string nombrestored = "Listar_Productos";
            oAcceso = new Acceso();
            DataTable dt = new DataTable();

            dt = oAcceso.Leer(nombrestored, null);

            lista_productos = new List<BEProducto>();    

            if(dt.Rows.Count > 0)
            {
                foreach(DataRow r in dt.Rows)
                {
                    BEProducto oBEProducto = new BEProducto();
                    oBEProducto.Codigo = Convert.ToInt32(r[0]);
                    oBEProducto.Nombre = r[1].ToString();
                    oBEProducto.Bodega = r[2].ToString();
                    oBEProducto.Precio_Unidad = Convert.ToDecimal(r[3]);
                    oBEProducto.Cantidad = Convert.ToInt32(r[4]);

                    lista_productos.Add(oBEProducto);
                }
            }
            else { lista_productos = null; }

            return lista_productos;
        }
        
        public List<BEProducto> Buscar_Producto(string pCadena)
        {
            string nombrestored = "Buscar_Producto";
            oAcceso = new Acceso();
            DataTable dt = new DataTable();
            ArrayList parametros = new ArrayList();

            SqlParameter Cadena = new SqlParameter();
            Cadena.ParameterName = "@Cadena";
            Cadena.Value = pCadena;
            Cadena.SqlDbType = SqlDbType.NVarChar;
            parametros.Add(Cadena);

            dt = oAcceso.Leer(nombrestored, parametros);

            lista_productos = new List<BEProducto>();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    BEProducto oBEProducto = new BEProducto();
                    oBEProducto.Codigo = Convert.ToInt32(r[0]);
                    oBEProducto.Nombre = r[1].ToString();
                    oBEProducto.Bodega = r[2].ToString();
                    oBEProducto.Precio_Unidad = Convert.ToDecimal(r[3]);
                    oBEProducto.Cantidad = Convert.ToInt32(r[4]);

                    lista_productos.Add(oBEProducto);
                }
            }
            else { lista_productos = null; }

            return lista_productos;
        }

        public List<BEProducto> Buscar_Producto_Sin_Stock(string pCadena)
        {
            string nombrestored = "Buscar_Producto_Sin_Stock";
            oAcceso = new Acceso();
            DataTable dt = new DataTable();
            ArrayList parametros = new ArrayList();

            SqlParameter Cadena = new SqlParameter();
            Cadena.ParameterName = "@Cadena";
            Cadena.Value = pCadena;
            Cadena.SqlDbType = SqlDbType.NVarChar;
            parametros.Add(Cadena);

            dt = oAcceso.Leer(nombrestored, parametros);

            lista_productos = new List<BEProducto>();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    BEProducto oBEProducto = new BEProducto();
                    oBEProducto.Codigo = Convert.ToInt32(r[0]);
                    oBEProducto.Nombre = r[1].ToString();
                    oBEProducto.Bodega = r[2].ToString();
                    oBEProducto.Precio_Unidad = Convert.ToDecimal(r[3]);
                    oBEProducto.Cantidad = Convert.ToInt32(r[4]);

                    lista_productos.Add(oBEProducto);
                }
            }
            else { lista_productos = null; }

            return lista_productos;
        }

        public List<BEProducto> Listar_Productos_Sin_Stock()
        {
            string nombrestored = "Listar_Productos_Sin_Stock";
            oAcceso = new Acceso();
            DataTable dt = new DataTable();

            dt = oAcceso.Leer(nombrestored, null);

            lista_productos = new List<BEProducto>();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    BEProducto oBEProducto = new BEProducto();
                    oBEProducto.Codigo = Convert.ToInt32(r[0]);
                    oBEProducto.Nombre = r[1].ToString();
                    oBEProducto.Bodega = r[2].ToString();
                    oBEProducto.Precio_Unidad = Convert.ToDecimal(r[3]);
                    oBEProducto.Cantidad = Convert.ToInt32(r[4]);

                    lista_productos.Add(oBEProducto);
                }
            }
            else { lista_productos = null; }

            return lista_productos;
        }

        public BEProducto Seleccionar_Producto(BEProducto oBEProducto)
        {
            oAcceso = new Acceso();
            string nombrestored = "Seleccionar_Producto";
            ArrayList parametros = new ArrayList();

            SqlParameter Codigo_Producto = new SqlParameter();
            Codigo_Producto.ParameterName = "@Codigo_Producto";
            Codigo_Producto.Value = oBEProducto.Codigo;
            Codigo_Producto.SqlDbType = SqlDbType.Int;
            parametros.Add(Codigo_Producto);

            DataTable dt = new DataTable();
            BEProducto Producto = new BEProducto();
            dt = oAcceso.Leer(nombrestored, parametros);

            if(dt.Rows.Count > 0)
            {
                foreach(DataRow r in dt.Rows)
                {
                    Producto.Codigo = Convert.ToInt32(r[0]);
                    Producto.Nombre = r[1].ToString();
                    Producto.Bodega = r[2].ToString();
                    Producto.Precio_Unidad = Convert.ToDecimal(r[3]);
                }
            }
            else { Producto = null; }

            return Producto;
        }

        public bool Validar_Producto_Detalle_Venta(BEProducto oBEProducto)
        {
            oAcceso = new Acceso();
            string nombrestored = "Validar_Producto_Detalle_Venta";
            ArrayList parametros = new ArrayList();

            SqlParameter Codigo_Producto = new SqlParameter();
            Codigo_Producto.ParameterName = "@Codigo_Producto";
            Codigo_Producto.Value = oBEProducto.Codigo;
            Codigo_Producto.SqlDbType = SqlDbType.Int;
            parametros.Add(Codigo_Producto);

            return oAcceso.LeerScalar(nombrestored, parametros);

        }

        public bool Validar_Producto_Detalle_Pedido(BEProducto oBEProducto)
        {
            oAcceso = new Acceso();
            string nombrestored = "Validar_Producto_Detalle_Pedido";
            ArrayList parametros = new ArrayList();

            SqlParameter Codigo_Producto = new SqlParameter();
            Codigo_Producto.ParameterName = "@Codigo_Producto";
            Codigo_Producto.Value = oBEProducto.Codigo;
            Codigo_Producto.SqlDbType = SqlDbType.Int;
            parametros.Add(Codigo_Producto);

            return oAcceso.LeerScalar(nombrestored, parametros);
        }

        public bool Operacion_Producto(BEProducto oBEProducto, int pOperacion)
        {
            string nombrestored = "";
            ArrayList parametros = new ArrayList();

            switch(pOperacion)
            {
                case 1:
                    nombrestored = "Agregar_Producto";
                    break;
                case 2:
                    nombrestored = "Eliminar_Producto";
                    break;
                case 3:
                    nombrestored = "Modificar_Producto";
                    break;
            }

            if(pOperacion == 2 || pOperacion == 3)
            {
                SqlParameter Codigo = new SqlParameter();
                Codigo.ParameterName = "@Codigo";
                Codigo.Value = oBEProducto.Codigo;
                Codigo.SqlDbType = SqlDbType.Int;
                parametros.Add(Codigo);
            }

            if(pOperacion == 1 || pOperacion == 3)
            {
                SqlParameter Nombre = new SqlParameter();
                Nombre.ParameterName = "@Nombre";
                Nombre.Value = oBEProducto.Nombre;
                Nombre.SqlDbType = SqlDbType.NVarChar;
                parametros.Add(Nombre);

                SqlParameter Bodega = new SqlParameter();
                Bodega.ParameterName = "@Bodega";
                Bodega.Value = oBEProducto.Bodega;
                Bodega.SqlDbType = SqlDbType.NVarChar;
                parametros.Add(Bodega);

                SqlParameter Precio_Unidad = new SqlParameter();
                Precio_Unidad.ParameterName = "@Precio_Unidad";
                Precio_Unidad.Value = oBEProducto.Precio_Unidad;
                Precio_Unidad.SqlDbType = SqlDbType.Decimal;
                parametros.Add(Precio_Unidad);

                SqlParameter Cantidad = new SqlParameter();
                Cantidad.ParameterName = "@Cantidad";
                Cantidad.Value = oBEProducto.Cantidad;
                Cantidad.SqlDbType = SqlDbType.Int;
                parametros.Add(Cantidad);
            }

            oAcceso = new Acceso();

            return oAcceso.Escribir(nombrestored, parametros);
        }

        public void Descontar_Producto(BEProducto oBEProducto)
        {
            oAcceso = new Acceso();
            string nombrestored = "Descontar_Producto";
            ArrayList parametros = new ArrayList();

            SqlParameter Codigo_Producto = new SqlParameter();
            Codigo_Producto.ParameterName = "@Codigo_Producto";
            Codigo_Producto.Value = oBEProducto.Codigo;
            Codigo_Producto.SqlDbType = SqlDbType.Int;
            parametros.Add(Codigo_Producto);

            oAcceso.Escribir(nombrestored, parametros);
        }

        public bool Modificar_Precio(BEProducto oBEProducto)
        {
            oAcceso = new Acceso();
            string nombrestored = "Modificar_Precio_Producto2";
            ArrayList parametros = new ArrayList();

            SqlParameter Producto = new SqlParameter();
            Producto.ParameterName = "@Producto";
            Producto.Value = oBEProducto.Nombre;
            Producto.SqlDbType = SqlDbType.NVarChar;
            parametros.Add(Producto);

            SqlParameter Precio_Unidad = new SqlParameter();
            Precio_Unidad.ParameterName = "@Precio_Unidad";
            Precio_Unidad.Value = oBEProducto.Precio_Unidad;
            Precio_Unidad.SqlDbType = SqlDbType.Decimal;
            parametros.Add(Precio_Unidad);

            return oAcceso.Escribir(nombrestored, parametros);
        }

        public bool Modificar_Stock(BEProducto oBEProducto)
        {
            oAcceso = new Acceso();
            string nombrestored = "Modificar_Stock";
            ArrayList parametros = new ArrayList();

            SqlParameter Codigo = new SqlParameter();
            Codigo.ParameterName = "@Codigo";
            Codigo.Value = oBEProducto.Codigo;
            Codigo.SqlDbType = SqlDbType.Int;
            parametros.Add(Codigo);

            SqlParameter Cantidad = new SqlParameter();
            Cantidad.ParameterName = "@Cantidad";
            Cantidad.Value = oBEProducto.Cantidad;
            Cantidad.SqlDbType = SqlDbType.Int;
            parametros.Add(Cantidad);

            return oAcceso.Escribir(nombrestored, parametros);
        }

        public bool Producto_Existe(string nombreproducto)
        {
            oAcceso = new Acceso();
            string nombrestored = "Producto_Existe";
            ArrayList parametros = new ArrayList();

            SqlParameter Producto = new SqlParameter();
            Producto.ParameterName = "@Producto";
            Producto.Value = nombreproducto;
            Producto.SqlDbType = SqlDbType.NVarChar;
            parametros.Add(Producto);

            return oAcceso.LeerScalar(nombrestored, parametros);
        }

        public void Modificar_Precio_Producto(BEProducto oBEProducto)
        {
            oAcceso = new Acceso();
            oAcceso.Modificar_Precio_Producto(oBEProducto.Nombre, oBEProducto.Precio_Unidad);
        }

    }
}
