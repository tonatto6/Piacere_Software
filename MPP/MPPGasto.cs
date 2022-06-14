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
    public class MPPGasto
    {
        Acceso oAcceso;
        List<BEGasto> lista_Gastos;

        public List<BEGasto> Listar_Gastos(int pAño)
        {
            string nombrestored = "Listar_Gastos";
            DataTable dt = new DataTable();
            oAcceso = new Acceso();
            ArrayList parametros = new ArrayList();

            SqlParameter Año = new SqlParameter();
            Año.ParameterName = "@Año";
            Año.Value = pAño;
            Año.SqlDbType = SqlDbType.Int;
            parametros.Add(Año);

            dt = oAcceso.Leer(nombrestored, parametros);

            lista_Gastos = new List<BEGasto>();

            if(dt.Rows.Count > 0)
            {
                foreach(DataRow r in dt.Rows)
                {
                    BEGasto oBEGasto = new BEGasto();
                    oBEGasto.Codigo = Convert.ToInt32(r[0]);
                    oBEGasto.Gasto = r[1].ToString();
                    oBEGasto.Fecha = Convert.ToDateTime(r[2]);
                    oBEGasto.Monto = Convert.ToDecimal(r[3]);

                    lista_Gastos.Add(oBEGasto);
                }
            }
            else { lista_Gastos = null; }

            return lista_Gastos;
        }

        public List<BEGasto> Filtrar_Gastos_Por_Mes(int pMes, int pAño)
        {
            string nombrestored = "Filtrar_Gastos_Por_Mes";
            DataTable dt = new DataTable();
            ArrayList parametros = new ArrayList();
            oAcceso = new Acceso();

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

            lista_Gastos = new List<BEGasto>();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    BEGasto oBEGasto = new BEGasto();
                    oBEGasto.Codigo = Convert.ToInt32(r[0]);
                    oBEGasto.Gasto = r[1].ToString();
                    oBEGasto.Fecha = Convert.ToDateTime(r[2]);
                    oBEGasto.Monto = Convert.ToDecimal(r[3]);

                    lista_Gastos.Add(oBEGasto);
                }
            }
            else { lista_Gastos = null; }

            return lista_Gastos;
        }

        public bool Operacion_Gasto(BEGasto oBEGasto, int pOperacion)
        {
            string nombrestored = "";
            ArrayList parametros = new ArrayList();

            switch(pOperacion)
            {
                case 1:
                    nombrestored = "Agregar_Gasto";
                    break;
                case 2:
                    nombrestored = "Eliminar_Gasto";
                    break;
                case 3:
                    nombrestored = "Modificar_Gasto";
                    break;
            }

            if(pOperacion == 2 || pOperacion == 3)
            {
                SqlParameter Codigo = new SqlParameter();
                Codigo.ParameterName = "@Codigo";
                Codigo.Value = oBEGasto.Codigo;
                Codigo.SqlDbType = SqlDbType.Int;
                parametros.Add(Codigo);
            }

            if(pOperacion == 1 || pOperacion == 3)
            {
                SqlParameter Gasto = new SqlParameter();
                Gasto.ParameterName = "@Gasto";
                Gasto.Value = oBEGasto.Gasto;
                Gasto.SqlDbType = SqlDbType.NVarChar;
                parametros.Add(Gasto);

                SqlParameter Fecha = new SqlParameter();
                Fecha.ParameterName = "@Fecha";
                Fecha.Value = oBEGasto.Fecha;
                Fecha.SqlDbType = SqlDbType.Date;
                parametros.Add(Fecha);

                SqlParameter Monto = new SqlParameter();
                Monto.ParameterName = "@Monto";
                Monto.Value = oBEGasto.Monto;
                Monto.SqlDbType = SqlDbType.Decimal;
                parametros.Add(Monto);
            }

            oAcceso = new Acceso();
            return oAcceso.Escribir(nombrestored, parametros);
        }

        public decimal Total_Gastos(int pAño)
        {
            oAcceso = new Acceso();
            ArrayList parametros = new ArrayList();
            SqlParameter Año = new SqlParameter();
            Año.ParameterName = "@Año";
            Año.Value = pAño;
            Año.SqlDbType = SqlDbType.Int;
            parametros.Add(Año);

            string nombrestored = "Total_Gastos";
            return oAcceso.LeerScalar3(nombrestored, parametros); 
        }

        public decimal Total_Gastos_Mes(int pMes, int pAño)
        {
            oAcceso = new Acceso();
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

            string nombrestored = "Gasto_Total_Mes";
            return oAcceso.LeerScalar3(nombrestored, parametros);
        }

        public Dictionary<string, decimal> Grafico_Gastos(int pAño)
        {
            DataTable dt = new DataTable();
            ArrayList parametros = new ArrayList();
            Acceso oAcceso = new Acceso();
            string nombreStored = "Grafico_Gastos";

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
