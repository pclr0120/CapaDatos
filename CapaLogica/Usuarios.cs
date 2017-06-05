using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;


namespace CapaLogica
{
    public class Usuarios
    {

        //public string nombre { get; set; }
        //public string nom { get; set; }
        //public string tel { get; set; }

        //public int beta(Usuarios usuario)
        //{

        //    //Accesodatos Acceder = new Accesodatos();
        //    //string[] parametros = { "@nombre",
        //    //                         "@NombreCom","@telefono" };
        //    //return Acceder.ExeProcedimiento("probando", parametros, usuario.nombre,
        //    //    usuario.nom,
        //    //    usuario.tel);

        //}
        public int IdUsuario { get; set; }
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apm { get; set; }
        public string App { get; set; }
        public string Tel { get; set; }
        public string Pass { get; set; }
        public string Estado { get; set; }
        Accesodatos Acceso = new Accesodatos();

        public DataTable UsuarioBuscar()
        {
            string[] parametros = { "_Id" };
            DataTable Tabla = Acceso.GetTabla("UsuarioBuscar", parametros, IdEmpleado);
            return Tabla;
        }

    }

}
