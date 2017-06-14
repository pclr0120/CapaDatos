using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaLogica
{
    public class Reportes
    {
        public int Id { get; set; }
        Accesodatos Acceso = new Accesodatos();

        public DataTable ReporteBuscarProductos()
        {
            string[] parametros = { "_Id" };
            DataTable Tabla = Acceso.GetTabla("ReporteBuscarProductos", parametros, Id);
            return Tabla;
        }

        public DataTable ReporteBuscarUsuarios()
        {
            string[] parametros = { "_Id" };
            DataTable Tabla = Acceso.GetTabla("ReporteBuscarUsuarios", parametros, Id);
            return Tabla;
        }
    }
}
