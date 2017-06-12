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

        public DataTable Usuario_ObtenerEmpleado()
        {
            string[] parametros = { "_Nombre" };
            DataTable Tabla = Acceso.GetTabla("UsuarioEmpleadobtener", parametros, Nombre);
            return Tabla;
        }

        public int UsuarioNo(int ID)
        {
            string[] parametros = { "_ID" };
            if (Acceso.GetTabla("UsuarioNo", parametros, ID).Rows.Count > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void UsuarioRegistrar(int IdEmpleado, string Nombre, string App, string Apm, string Telefono, string Pass, int Punto_vta, int Inventario, int Clientes, int Equipo, int Empleados, int Config )
        {
            string[] parametros = { "_IdEmpleado", "_Nom", "_App", "_Apm", "_Tel", "_Pass", "_Punto_vta", "_Inventario", "_Clientes", "_Equipo", "_Empleados", "_Config"};
            Acceso.ExeProcedimiento("UsuarioRegistrar", parametros, IdEmpleado, Nombre, App, Apm, Telefono, Pass, Punto_vta, Inventario, Clientes, Equipo, Empleados, Config);
        }

        public void UsuarioModificar(int ID, string Pass, int Punto_vta, int Inventario, int Clientes, int Equipo, int Empleados, int Config)
        {
            string[] parametros = { "_ID", "_Pass", "_Punto_vta", "_Inventario", "_Clientes", "_Equipo", "_Empleados", "_Config" };
            Acceso.ExeProcedimiento("UsuarioModificar", parametros, ID, Pass, Punto_vta, Inventario, Clientes, Equipo, Empleados, Config);
        }

        public DataTable UsuarioBuscarDatos(int _id)
        {
            string[] parametros = { "_Id" };
            DataTable Tabla = Acceso.GetTabla("UsuarioBuscarDatos", parametros, _id);
            return Tabla;
        }

        public void UsuarioAlta(int Id)
        {
            string[] parametros = { "_Id" };
            Acceso.ExeProcedimiento("UsuarioAlta", parametros, Id);
        }

        public DataTable UsuarioBaja(int Id)
        {
            string[] parametros = { "_Id" };
            DataTable Tabla = Acceso.GetTabla("UsuarioBaja", parametros, Id);
            return Tabla;
        }
    }

}
