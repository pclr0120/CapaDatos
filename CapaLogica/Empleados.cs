using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaLogica
{
    public class Empleados
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string App { get; set; }
        public string Apm { get; set; }
        public int IdTipoEmpleado { get; set; }
        public string Escolaridad { get; set; }
        public string Calle { get; set; }
        public string Colonia { get; set; }
        public string Num_ext { get; set; }
        public int IdCiudad { get; set; }
        public int IdMunicipio { get; set; }
        public int IdEntidadF { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Estatus { get; set; }
        Accesodatos Acceso = new Accesodatos();

        public DataTable EmpleadoBuscar()
        {
            string[] parametros = { "_Id" };
            DataTable Tabla = Acceso.GetTabla("EmpleadoBuscar", parametros, IdEmpleado);
            return Tabla;
        }

        public DataTable EmpleadoBuscarEstatus(string Estatus)
        {
            string[] parametros = { "_Estatus" };
            DataTable Tabla = Acceso.GetTabla("EmpleadoBuscarEstatus", parametros, Estatus);
            return Tabla;
        }

        public DataTable EmpleadoBuscarNombre(string Nombre)
        {
            string[] parametros = { "_Nombre" };
            DataTable Tabla = Acceso.GetTabla("EmpleadoBuscarNombre", parametros, Nombre);
            return Tabla;
        }

        public DataTable EmpleadoBuscarPuesto()
        {
            string[] parametros = { "_Nombre" };
            DataTable Tabla = Acceso.GetTabla("EmpleadoBuscarPuesto", parametros, Nombre);
            return Tabla;
        }

        public int EmpleadoBuscarCurp(string Curp)
        {
            string[] parametros = { "_Curp" };
            if(Acceso.GetTabla("EmpleadoBuscarCurp", parametros, Curp).Rows.Count > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public DataTable EmpleadoBuscarDatos(int Id)
        {
            string[] parametros = { "_Id" };
            DataTable Tabla = Acceso.GetTabla("EmpleadoBuscarDatos", parametros, Id);
            return Tabla;
        }

        public DataTable EmpleadoBuscarEntidad()
        {
            string[] parametros = { "_Nombre" };
            DataTable Tabla = Acceso.GetTabla("EmpleadoBuscarEntidad", parametros, Nombre);
            return Tabla;
        }

        public DataTable EmpleadoBuscarMunicipio(string Nombre)
        {
            string[] parametros = { "_NomEnt" };
            DataTable Tabla = Acceso.GetTabla("EmpleadoBuscarMunicipio", parametros, Nombre);
            return Tabla;
        }

        public DataTable EmpleadoBuscarCiudad(string NomEnt, string NomMun)
        {
            string[] parametros = { "_NomEnt" , "_NomMun"};
            DataTable Tabla = Acceso.GetTabla("EmpleadoBuscarCiudad", parametros, NomEnt, NomMun);
            return Tabla;
        }

        public void EmpleadoAlta(int Id)
        {
            string[] parametros = { "_Id" };
            Acceso.ExeProcedimiento("EmpleadoAlta", parametros, Id);
        }

        public DataTable EmpleadoBaja(int Id)
        {
            string[] parametros = { "_Id" };
            DataTable Tabla = Acceso.GetTabla("EmpleadoBaja", parametros, Id);
            return Tabla;
        }

        public void EmpleadoRegistrar(string Curp, string Nombre, string App, string Apm, string IdTipoEmpleado, string Escolaridad, string Calle, string Colonia, string Num_ext, string IdCiudad, string IdMunicipio, string IdEntidadF, string Telefono)
        {
            string[] parametros = { "_Curp", "_Nombre", "_App", "_Apm", "_IdTipoEmpleado", "_Escolaridad", "_Calle", "_Colonia", "_Num_ext", "_IdCiudad", "_IdMunicipio", "_IdEntidadF", "_Telefono" };
            Acceso.ExeProcedimiento("EmpleadoRegistrar", parametros, Curp, Nombre, App, Apm, IdTipoEmpleado, Escolaridad, Calle, Colonia, Num_ext, IdCiudad, IdMunicipio, IdEntidadF, Telefono);
        }

        public void EmpleadoModificar(int Id, string Curp, string Nombre, string App, string Apm, string IdTipoEmpleado, string Escolaridad, string Calle, string Colonia, string Num_ext, string IdCiudad, string IdMunicipio, string IdEntidadF, string Telefono)
        {
            string[] parametros = { "_Id", "_Curp", "_Nombre", "_App", "_Apm", "_IdTipoEmpleado", "_Escolaridad", "_Calle", "_Colonia", "_Num_ext", "_IdCiudad", "_IdMunicipio", "_IdEntidadF", "_Telefono" };
            Acceso.ExeProcedimiento("EmpleadoModificar", parametros, Id, Curp, Nombre, App, Apm, IdTipoEmpleado, Escolaridad, Calle, Colonia, Num_ext, IdCiudad, IdMunicipio, IdEntidadF, Telefono);
        }
    }
}
