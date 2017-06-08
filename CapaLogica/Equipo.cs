using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaLogica
{
    public class Equipo
    {
        public int IdEquipo { get; set; }
        public int IdClasificacion { get; set; }
        public string Nombre { get; set; }
        public int Costo { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Estatus { get; set; }
        Accesodatos Acceso = new Accesodatos();

        public DataTable EquipoBuscar()
        {
            string[] parametros = { "_Id" };
            DataTable Tabla = Acceso.GetTabla("EquipoBuscar", parametros, IdEquipo);
            return Tabla;
        }

        public DataTable EquipoBuscarEstatus(string Estatus)
        {
            string[] parametros = { "_Estatus" };
            DataTable Tabla = Acceso.GetTabla("EquipoBuscarEstatus", parametros, Estatus);
            return Tabla;
        }

        public void EquipoBaja(int Id)
        {
            string[] parametros = { "_Id" };
            Acceso.ExeProcedimiento("EquipoBaja", parametros, Id);
        }

        public DataTable EquipoBuscarDatos(int Id)
        {
            string[] parametros = { "_Id" };
            DataTable Tabla = Acceso.GetTabla("EquipoBuscarDatos", parametros, Id);
            return Tabla;
        }

        public void EquipoRegistrar(string IdClasificacion, string Nombre, int Costo, string Codigo, string Descripcion)
        {
            string[] parametros = { "_IdClasificacion", "_Nombre", "_Costo", "_Codigo", "_Descripcion" };
            Acceso.ExeProcedimiento("EquipoRegistrar", parametros, IdClasificacion, Nombre, Costo, Codigo, Descripcion);
        }

        public void EquipoModificar(int Id, string IdClasificacion, string Nombre, int Costo, string Codigo, string Descripcion)
        {
            string[] parametros = { "_Id", "_IdClasificacion", "_Nombre", "_Costo", "_Codigo", "_Descripcion" };
            Acceso.ExeProcedimiento("EquipoModificar", parametros, Id, IdClasificacion, Nombre, Costo, Codigo, Descripcion);
        }

        public DataTable EquipoBuscarClasificaciones()
        {
            string[] parametros = { "_Nombre" };
            DataTable Tabla = Acceso.GetTabla("EquipoBuscarClasificaciones", parametros, Nombre);
            return Tabla;
        }

        public DataTable EquipoBuscarPorClasificacion(string IdClasificacion)
        {
            string[] parametros = { "_IdClasificacion" };
            DataTable Tabla = Acceso.GetTabla("EquipoBuscarPorClasificacion", parametros, IdClasificacion);
            return Tabla;
        }

        public DataTable EquipoBuscarNombre(string Nombre)
        {
            string[] parametros = { "_Nombre" };
            DataTable Tabla = Acceso.GetTabla("EquipoBuscarNombre", parametros, Nombre);
            return Tabla;
        }

        public int EquipoBuscarCoincidenciaNumeroSerie(string Nombre)
        {
            string[] parametros = { "_Nombre" };
            if (Acceso.GetTabla("EquipoBuscarCoincidenciaNumeroSerie", parametros, Nombre).Rows.Count > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public DataTable EquipoBuscarSeriales()
        {
            string[] parametros = { "_Id" };
            DataTable Tabla = Acceso.GetTabla("EquipoBuscarSeriales", parametros, IdEquipo);
            return Tabla;
        }

        public DataTable EquipoEstadoBuscar()
        {
            string[] parametros = { "_Id" };
            DataTable Tabla = Acceso.GetTabla("EquipoEstadoBuscar", parametros, IdEquipo);
            return Tabla;
        }

        public DataTable EquipoEstadoUltimoId()
        {
            string[] parametros = { "_Id" };
            DataTable Tabla = Acceso.GetTabla("EquipoEstadoBuscar", parametros, IdEquipo);
            return Tabla;
        }

        public void EquipoEstadoRegistrarRE(int IdUsuario)
        {
            string[] parametros = { "_IdUsuario" };
            Acceso.ExeProcedimiento("EquipoEstadoRegistrarRE", parametros, IdUsuario);
        }

        public void EquipoEstadoRegistrarDRE(int IdReporte, string Codigo, string Descripcion)
        {
            string[] parametros = { "_IdReporte" , "_Codigo", "_Descripcion" };
            Acceso.ExeProcedimiento("EquipoEstadoRegistrarDRE", parametros, IdReporte, Codigo, Descripcion);
        }

        public DataTable EquipoEstadoBuscarDetalleReporte(int IdReporte)
        {
            string[] parametros = { "_IdReporte" };
            DataTable Tabla = Acceso.GetTabla("EquipoEstadoBuscarDetalleReporte", parametros, IdReporte);
            return Tabla;
        }
    }
}
