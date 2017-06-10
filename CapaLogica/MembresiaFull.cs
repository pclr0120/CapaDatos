using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaLogica
{
    public class MembresiaFull
    {
        public int IdMembresia { get; set; }
        public int IdCliente { get; set; }
        public int IdTipoMembresia { get; set; }
        public DateTime FechaRegistro { get; set; }

        Accesodatos Acceso = new Accesodatos();

        string[] parametros = { "_IdMembresia","_IdCliente", "_IdTipoMembresia" };

        public DataTable RMembresiaBuscar()
        {
            string[] parametros = { };
            DataTable Tabla = Acceso.GetTabla("RMembresiaBuscar", parametros);
            return Tabla;
        }
        public DataTable RMembresiaBuscarActiva()
        {
            string[] parametros = { };
            DataTable Tabla = Acceso.GetTabla("RMembresiaBuscarActiva", parametros);
            return Tabla;
        }
        public DataTable RMembresiaBuscarInactiva()
        {
            string[] parametros = { };
            DataTable Tabla = Acceso.GetTabla("RMembresiaBuscarInactiva", parametros);
            return Tabla;
        }
        
    }
}
