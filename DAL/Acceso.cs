using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Acceso
    {
        private SqlConnection cnn = new SqlConnection(@"Data Source=(localdb)\.;Initial Catalog=PiacereSoftware;Integrated Security=True");
        SqlTransaction Tranx;
        SqlCommand cmd;

        public bool Escribir(string nombreStored, ArrayList parametros)
        {
            SqlDataAdapter da = new SqlDataAdapter(nombreStored, cnn);

            try
            {
                cnn.Open();

                Tranx = cnn.BeginTransaction();

                cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = nombreStored;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = Tranx;

                if (parametros != null)
                {
                    foreach (SqlParameter dato in parametros)
                    {
                        cmd.Parameters.AddWithValue(dato.ParameterName, dato.Value);
                    }
                }

                int respuesta = cmd.ExecuteNonQuery();
                if (respuesta > 0)
                {
                    Tranx.Commit();
                    return true;
                }
                else { Tranx.Rollback(); return false; }
            }
            catch (SqlException ex) { throw ex; }

            catch (Exception ex) { throw ex; }

            finally
            { cnn.Close(); }
        }

        public DataTable Leer(string nombreStored, ArrayList Parametros)
        {

            DataTable Dt = new DataTable();
            cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreStored;
            cmd.Parameters.Clear();

            try
            {
                if ((Parametros != null))
                {
                    //si la el arraylist esta vacia
                    foreach (SqlParameter dato in Parametros)
                    {
                        //cargo los parametros que le estoy pasando con la Hash
                        cmd.Parameters.AddWithValue(dato.ParameterName, dato.Value);
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(Dt);
            }

            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
            return Dt;
        }

        public bool LeerScalar(string nombreStored, ArrayList parametros)
        {
            cnn.Open();

            SqlDataAdapter da = new SqlDataAdapter();
            cmd = new SqlCommand(nombreStored, cnn);

            cmd.CommandType = CommandType.StoredProcedure;

            if (parametros != null)
            {
                foreach (SqlParameter dato in parametros)
                {
                    cmd.Parameters.AddWithValue(dato.ParameterName, dato.Value);
                }
            }

            int respuesta = Convert.ToInt32(cmd.ExecuteScalar());
            cnn.Close();
            if (respuesta > 0) { return true; }
            else { return false; }
        }

        public int LeerScalar2(string nombreStored, ArrayList parametros)
        {
            cnn.Open();

            SqlDataAdapter da = new SqlDataAdapter();
            cmd = new SqlCommand(nombreStored, cnn);

            cmd.CommandType = CommandType.StoredProcedure;

            if (parametros != null)
            {
                foreach (SqlParameter dato in parametros)
                {
                    cmd.Parameters.AddWithValue(dato.ParameterName, dato.Value);
                }
            }

            int respuesta = Convert.ToInt32(cmd.ExecuteScalar());
            cnn.Close();
            return respuesta;
        }

        public decimal LeerScalar3(string nombreStored, ArrayList parametros)
        {
            cnn.Open();

            SqlDataAdapter da = new SqlDataAdapter();
            cmd = new SqlCommand(nombreStored, cnn);

            cmd.CommandType = CommandType.StoredProcedure;

            if (parametros != null)
            {
                foreach (SqlParameter dato in parametros)
                {
                    cmd.Parameters.AddWithValue(dato.ParameterName, dato.Value);
                }
            }

            decimal respuesta = Convert.ToDecimal(cmd.ExecuteScalar());
            cnn.Close();
            return respuesta;
        }
    
        public void Modificar_Precio_Producto(string nombreproducto, decimal precio)
        {
            string query = "UPDATE Productos SET Precio_Unidad = @Precio WHERE Nombre = @Nombre";
            cnn.Open();

            SqlCommand command = new SqlCommand(query, cnn);
            command.Parameters.AddWithValue("@Precio", precio);
            command.Parameters.AddWithValue("@Nombre", nombreproducto);

            command.ExecuteNonQuery();

            cnn.Close();
        }
    }
}
