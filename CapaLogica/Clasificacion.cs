using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaLogica
{
    public class Clasificacion
    {
        public int IdClasificacion { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaRegistro { get; set; }
        Accesodatos Acceso = new Accesodatos();

        public DataTable ClasificacionBuscar()
        {
            string[] parametros = { "_Id" };
            DataTable Tabla = Acceso.GetTabla("ClasificacionBuscar", parametros, IdClasificacion);
            return Tabla;
        }

        public DataTable ClasificacionBuscarNombre(string Nombre)
        {
            string[] parametros = { "_Nombre" };
            DataTable Tabla = Acceso.GetTabla("ClasificacionBuscarNombre", parametros, Nombre);
            return Tabla;
        }

        public DataTable ClasificacionEliminar(int IdClasificacion)
        {
            string[] parametros = { "_IdClasificacion" };
            DataTable Tabla = Acceso.GetTabla("ClasificacionEliminar", parametros, IdClasificacion);
            return Tabla;
        }

        public void ClasificacionRegistrar(string Nombre, string Descripcion)
        {
            string[] parametros = { "_Nombre", "_Descripcion" };
            Acceso.ExeProcedimiento("ClasificacionRegistrar", parametros, Nombre, Descripcion);
        }

        public DataTable ClasificacionBuscarDatos(int Id)
        {
            string[] parametros = { "_Id" };
            DataTable Tabla = Acceso.GetTabla("ClasificacionBuscarDatos", parametros, Id);
            return Tabla;
        }

        public void ClasificacionModificar(int Id, string Nombre, string Descripcion)
        {
            string[] parametros = { "_Id", "_Nombre", "_Descripcion" };
            Acceso.ExeProcedimiento("ClasificacionModificar", parametros, Id, Nombre, Descripcion);
        }

        public int ClasificacionBuscarCoincidenciaNombre(string Nombre)
        {
            string[] parametros = { "_Nombre" };
            if (Acceso.GetTabla("ClasificacionBuscarCoincidenciaNombre", parametros, Nombre).Rows.Count > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
