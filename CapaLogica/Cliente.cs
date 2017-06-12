using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;


namespace CapaLogica
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public String Nombre { get; set; }
        public string App { get; set; }
        public string Apm { get; set; }
        public string Foto { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string eMail{ get; set; }
        public string CodigoPersonal{ get; set; }
        public string CodigoInvitacion{ get; set; }
        public string Telefono { get; set; }
        public int IdTipoMembresia { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Estatus { get; set; }
        public string calle { get; set; }
        public string colonia { get; set; }
        public int IdEntidad { get; set; }
        public int IdMunicipio { get; set; }
        public int IdCiudad { get; set; }

        Accesodatos Acceso = new Accesodatos();

        string[] parametros = { "_IdCliente","_Nombre", "_App","_Apm","_Foto", "_FechaNacimiento" };

        public void ClienteRegistrar(string Nombre, string App, string Apm, string Foto, string eMail, string CodigoPersonal, string CodigoInvitacion,string Telefono, int IdTipoMembresia, string IdMunicipio, string IdEntidad, string IdCiudad, string calle,string colonia,string num_ext)
        {
            //DataRow row = ClienteContar().Rows[0];
            //CodigoPersonal = Convert.ToString(Convert.ToInt32(row["count"].ToString()) + 10001);
            string[] parametros = { "_Nombre", "_App", "_Apm", "_Foto", "_Email","_CodigoPersonal","_CodigoInvitacion", "_Telefono","_IdMunicipio","_IdEntidad", "_IdCiudad", "_calle", "_colonia","_num_ext"};
            Acceso.ExeProcedimiento("ClienteRegistrar", parametros, Nombre, App, Apm, Foto, eMail, CodigoPersonal, CodigoInvitacion, Telefono,IdMunicipio,IdEntidad,IdCiudad,calle,colonia,num_ext);
        }

        public void ClienteModificar(int IdCliente, string Nombre, string App, string Apm, string Foto, string eMail, string CodigoPersonal, string CodigoInvitacion, string Telefono, int IdTipoMembresia, string IdMunicipio, string IdEntidad, string IdCiudad, string calle, string colonia, string num_ext)
        {
            string[] parametros = { "_IdCliente", "_Nombre", "_App", "_Apm", "_Foto", "_Email", "_CodigoPersonal", "_CodigoInvitacion", "_Telefono", "_IdMunicipio", "_IdEntidad", "_IdCiudad", "_calle", "_colonia", "_num_ext" };
            Acceso.ExeProcedimiento("ClienteModificar", parametros, Nombre, App, Apm, Foto, eMail, CodigoPersonal, CodigoInvitacion, Telefono, IdMunicipio, IdEntidad, IdCiudad, calle, colonia, num_ext);
        }

        public DataTable ClienteContar()
        {
            string[] parametros = { };
            DataTable Tabla = Acceso.GetTabla("ClienteContar", parametros);
            return Tabla;
        }

        public DataTable ClienteBuscar()
        {
            string[] parametros = { };
            DataTable Tabla = Acceso.GetTabla("ClienteBuscar",parametros);
            return Tabla;
        }

        public DataTable ClienteBuscarNombre(string Nombre)
        {
            string[] parametros = { "_Nombre"};
            DataTable Tabla = Acceso.GetTabla("ClienteBuscarNombre", parametros, Nombre);
            return Tabla;
        }

        public DataTable ClienteBuscarCodigoPersonal()
        {
            string[] parametros = { "_CodigoPersonal"};
            DataTable Tabla = Acceso.GetTabla("ClienteBuscarCodigoPersonal", parametros, CodigoPersonal);
            return Tabla;
        }

        public DataTable ClienteBuscarEntidad()
        {
            string[] parametros = { "_Nombre" };
            DataTable Tabla = Acceso.GetTabla("EmpleadoBuscarEntidad", parametros, Nombre);
            return Tabla;
        }
        public DataTable ClienteBuscarMunicipio(string nombre)
        {
            string[] parametros = { "_NomEnt" };
            DataTable Tabla = Acceso.GetTabla("EmpleadoBuscarMunicipio", parametros, nombre);
            return Tabla;
        }

        public DataTable ClienteBuscarCiudad(string nombre,string Mun)
        {
            string[] parametros = { "_NomEnt","_NomMun" };
            DataTable Tabla = Acceso.GetTabla("EmpleadoBuscarCiudad", parametros, nombre,Mun);
            return Tabla;
        }

        public DataTable ClienteBuscarDatos(int Id)
        {
            string[] parametros = { "_Id" };
            DataTable Tabla = Acceso.GetTabla("ClienteBuscarDatos",parametros,Id);
            return Tabla;
        }

        public DataTable AsistenciasBuscar()
        {
            string[] parametros = { };
            DataTable Tabla = Acceso.GetTabla("AsistenciasBuscar", parametros);
            return Tabla;
        }

        public DataTable AsistenciasBuscarNombre(string Nombre)
        {
            string[] parametros = { "_Nombre" };
            DataTable Tabla = Acceso.GetTabla("AsistenciasBuscarNombre", parametros, Nombre);
            return Tabla;
        }

    }
}
