using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;


namespace CapaLogica
{
    public class Puesto
    {
        public int IdTipoEmpleado { get; set; }
        public string Tipo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Estatus { get; set; }
        public int NumVacantes { get; set; }
        public float Sueldo { get; set; }
        public string Descripcion { get; set; }
        Accesodatos Acceso = new Accesodatos();

        public DataTable PuestoBuscar() {
            string[] parametros = { "_Id"};
            DataTable Tabla = Acceso.GetTabla("PuestoBuscar", parametros, IdTipoEmpleado);
            return Tabla;
        }

        public DataTable PuestoBuscarEstatus(string Estatus)
        {
            string[] parametros = { "_Estatus" };
            DataTable Tabla = Acceso.GetTabla("PuestoBuscarEstatus", parametros, Estatus);
            return Tabla;
        }

        public DataTable PuestoBuscarNombre(string Nombre)
        {
            string[] parametros = { "_Nombre" };
            DataTable Tabla = Acceso.GetTabla("PuestoBuscarNombre", parametros, Nombre);
            return Tabla;
        }

        public DataTable PuestoBuscarId(int Id)
        {
            string[] parametros = { "_Id" };
            DataTable Tabla = Acceso.GetTabla("PuestoBuscarId", parametros, Id);
            return Tabla;
        }

        public int PuestoBuscarCoincidenciaNombre(string Nombre)
        {
            string[] parametros = { "_Nombre" };
            if (Acceso.GetTabla("PuestoBuscarCoincidenciaNombre", parametros, Nombre).Rows.Count > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void PuestoAlta(int Id)
        {
            string[] parametros = { "_Id" };
            Acceso.ExeProcedimiento("PuestoAlta",parametros,Id);
        }

        public void PuestoBaja(int Id)
        {
            string[] parametros = { "_Id" };
            Acceso.ExeProcedimiento("PuestoBaja", parametros, Id);
        }

        public void PuestoRegistrar(string Tipo, int NumVacantes, double Sueldo, string Descripcion)
        {
            string[] parametros = { "_Tipo", "_NumVacantes", "_Sueldo", "_Descripcion" };
            Acceso.ExeProcedimiento("PuestoRegistrar", parametros, Tipo, NumVacantes, Sueldo, Descripcion);
        }

        public void PuestoModificar(int Id, string Tipo, int NumVacantes, double Sueldo, string Descripcion)
        {
            string[] parametros = { "_Id", "_Tipo", "_NumVacantes", "_Sueldo", "_Descripcion" };
            Acceso.ExeProcedimiento("PuestoModificar", parametros, Id, Tipo, NumVacantes, Sueldo, Descripcion);
        }
    }
}
