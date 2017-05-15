using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaLogica
{
    public class Login
    {
        public int Id { get; set; }
        public string Pass { get; set; }

        Accesodatos Acceso = new Accesodatos();
        //pclr
        public int CheckLogin(int Id, string Pass)
        {
            string[] parametros = { "_codigo", "_Pas" };


            if (Acceso.GetTabla("Login", parametros, Id, Pass).Rows.Count>0){
                return 1;
            }
            else{
                return 0;
            }
            
        }

        //MAVO
        public DataTable LoginDatosUsuario(int Id) //Procedimiento para obtener los datos del usuario
        {
            string[] parametros = { "_Id" };
            DataTable Tabla = Acceso.GetTabla("LoginDatosUsuario", parametros, Id);
            return Tabla;
        }
    }

}
