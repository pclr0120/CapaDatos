using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Data;
using System.Configuration;
//hola soy Michel X2
namespace CapaDatos
{
   public  class Bd
    {
        private MySqlConnection Cone { get; set; }
        private string CadenaConexion()
        {
            return @"Data Source = localhost; user id = root; Password=Pclr0120; database = bdgym";
        }
       // private static string CadenaConexion = ConfigurationSettings.AppSettings["CadenaConexion"];

        public MySqlConnection GetConexion() {
            try
            {
                Cone = new MySqlConnection(CadenaConexion());
                this.Cone.Open();
                return this.Cone;

            }
            catch (Exception)
            {
                return null;
            }
            


        }

        public void CerrarConexion() {
            if (this.Cone!=null)
            {
               this.Cone.Close();
            }

        }
    }
}
