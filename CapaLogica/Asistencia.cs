using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaLogica
{
   public class Asistencia
    {
        public string codigopersonal { get; set; }
        public string nombre { get; set; }
        public string tipomembresia {get; set;}
        Accesodatos acce = new Accesodatos();
        public DataTable consultarCliente(string codigo) {


                string[] parametros = { "_codigo" };
                return acce.GetTabla("ASISTECIA_queryINFOCLIENTE", parametros, codigo);

            }
        public int RegistrarAsistencia(string codigo)
        {


            string[] parametros = { "_codigo" };
            return acce.ExeProcedimiento("ASISTECIA_RegistrarAsistenciaCliente", parametros, codigo);

        }
    }
}
