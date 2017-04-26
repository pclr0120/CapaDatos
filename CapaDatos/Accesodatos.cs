using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
   public  class Accesodatos
    {
        public DataTable GetTabla(string Procedimiento,string[]NombreParametros,params Object[]valparametros)
        {
            /////
            //Solo para consultas
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand();
            Bd con = new Bd();
            cmd.Connection = con.GetConexion();
            cmd.CommandText = Procedimiento;
            cmd.CommandType = CommandType.StoredProcedure;
            if (Procedimiento.Length!=0 && NombreParametros.Length==valparametros.Length)
            {
                int i = 0;
                foreach (string parametro in NombreParametros)
                {
                    cmd.Parameters.AddWithValue(parametro, valparametros[i++]);
                }
                try
                {
                    MySqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    return dt;

                }
                catch (Exception e)
                {
                    throw;
                }
                finally {
                    Bd cone = new Bd();
                    cone.CerrarConexion();

                }
             
            }
            return dt;
        }

        public int ExeProcedimiento(string Procedimiento, string[] NombreParametros, params Object[] valparametros)
        {
            Bd con = new Bd();
           
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con.GetConexion();

            cmd.CommandText = Procedimiento;
            cmd.CommandType = CommandType.StoredProcedure;
            if (Procedimiento.Length != 0 && NombreParametros.Length == valparametros.Length)
            {
                int i = 0;
                foreach (string parametro in NombreParametros)
                    cmd.Parameters.AddWithValue(parametro, valparametros[i++]);

                    try
                    {
                        return cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                    throw;
                    }
                finally
                {
                    Bd cone = new Bd();
                    cone.CerrarConexion();

                }


            }
            return 0;
        }
    }
}
