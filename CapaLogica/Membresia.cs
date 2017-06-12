using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaLogica
{
    public class Membresia
    {
        public int IdMembresia { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Descripcion { get; set; }
        public char Estatus { get; set; }

        Accesodatos Acceso = new Accesodatos();

        string[] parametros = { "_IdMembresia", "_Nombre", "_Precio", "_Descripcion", "_Estatus" };

        public void MembresiaRegistrar(string Nombre, string Precio,string Duracion, string Descripcion)
        {
            string[] parametros = { "_Nombre", "_Precio", "_Duracion", "_Descripcion"};
            Acceso.ExeProcedimiento("MembresiaRegistrar", parametros, Nombre, Precio, Duracion, Descripcion);
        }

        public void MembresiaModificar(int Id,string Nombre, string Precio, string Duracion, string Descripcion)
        {
            string[] parametros = { "_Id", "_Nombre", "_Precio", "_Duracion", "_Descripcion" };
            Acceso.ExeProcedimiento("MembresiaModificar", parametros, Id, Nombre, Precio, Duracion, Descripcion);
        }

        public void MembresiaAlta(int IdMembresia)
        {
            string[] parametros = { "_IdMembresia"};
            Acceso.ExeProcedimiento("MembresiaAlta", parametros, IdMembresia);
        }

        public void MembresiaBaja(int IdMembresia)
        {
            string[] parametros = { "_IdMembresia" };
            Acceso.ExeProcedimiento("MembresiaBaja", parametros, IdMembresia);
        }

        public DataTable MembresiaBuscar()
        {
            string[] parametros = { };
            DataTable Tabla = Acceso.GetTabla("MembresiaBuscar", parametros);
            return Tabla;
        }

        public DataTable MembresiaBuscarNombre(string Nombre)
        {
            string[] parametros = { "_Nombre"};
            DataTable Tabla = Acceso.GetTabla("MembresiaBuscarNombre", parametros,Nombre);
            return Tabla;
        }

        public DataTable MembresiaBuscarActiva()
        {
            string[] parametros = { };
            DataTable Tabla = Acceso.GetTabla("MembresiaBuscarActiva", parametros);
            return Tabla;
        }
        public DataTable MembresiaBuscarInactiva()
        {
            string[] parametros = { };
            DataTable Tabla = Acceso.GetTabla("MembresiaBuscarInactiva", parametros);
            return Tabla;
        }

        public DataTable MembresiaBuscarPrecio()
        {
            string[] parametros = { };
            DataTable Tabla = Acceso.GetTabla("MembresiaBuscarPrecio", parametros);
            return Tabla;
        }

        public DataTable MembresiaBuscarDatos(int Id)
        {
            string[] parametros = { "_Id"};
            DataTable Tabla = Acceso.GetTabla("MembresiaBuscarDatos",parametros,Id);
            return Tabla;
        }

        public int MembresiaBuscarCoincidenciaNombre(string Nombre)
        {
            string[] parametros = { "_Nombre" };
            if (Acceso.GetTabla("MembresiaBuscarCoincidenciaNombre", parametros, Nombre).Rows.Count > 0)
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
