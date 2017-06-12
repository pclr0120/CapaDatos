using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaLogica
{
   public  class VincularMembrecia
    {

        public string idMembrecia { get; set; }
        public string idCliente { get; set; }
        public string  Tipo { get; set; }



        Accesodatos Acceso = new Accesodatos();
       public  int Vincular(string codigo,string idm)
        {

            string[] parametros = { "_idCliente",
"_idme" };
            return Acceso.ExeProcedimiento("MEMBRECIA_VINCULARCLIENTE", parametros, codigo,idm);

        }

    }
}
