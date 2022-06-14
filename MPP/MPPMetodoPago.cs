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
    public class MPPMetodoPago
    {
        Acceso oAcceso;

        public List<BEMetodoPago> Listar_Metodos_Pago()
        {
            oAcceso = new Acceso();
            string nombrestored = "Listar_Metodos_Pago";
            DataTable dt = new DataTable();

            dt = oAcceso.Leer(nombrestored, null);
            List<BEMetodoPago> lista_metodo_pago = new List<BEMetodoPago>();

            if(dt.Rows.Count > 0)
            {
                foreach(DataRow r in dt.Rows)
                {
                    BEMetodoPago oBEMetodoPago = new BEMetodoPago();
                    oBEMetodoPago.Codigo = Convert.ToInt32(r[0]);
                    oBEMetodoPago.Metodo_Pago = r[1].ToString();

                    lista_metodo_pago.Add(oBEMetodoPago);
                }
            }
            else { lista_metodo_pago = null; }

            return lista_metodo_pago;
        }
    
        public bool Agregar_Metodo_Pago(BEMetodoPago oBEMetodoPago)
        {
            oAcceso = new Acceso();
            string nombrestored = "Agregar_Metodo_Pago";
            ArrayList parametros = new ArrayList();

            SqlParameter Metodo_Pago = new SqlParameter();
            Metodo_Pago.ParameterName = "@Metodo_Pago";
            Metodo_Pago.Value = oBEMetodoPago.Metodo_Pago;
            Metodo_Pago.SqlDbType = SqlDbType.NVarChar;
            parametros.Add(Metodo_Pago);

            return oAcceso.Escribir(nombrestored, parametros);
        }
    }
}
