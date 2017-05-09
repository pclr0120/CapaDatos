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

        public void EmpleadoAlta(int Id)
        {
            string[] parametros = { "_Id" };
            Acceso.ExeProcedimiento("EmpleadoAlta", parametros, Id);
        }

        public void EmpleadoBaja(int Id)
        {
            string[] parametros = { "_Id" };
            Acceso.ExeProcedimiento("EmpleadoBaja", parametros, Id);
        }
    }
}
