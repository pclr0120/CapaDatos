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

        public int idMembrecia { get; set; }
        public int idCliente { get; set; }
        public int  Tipo { get; set; }
        public string codigo { get; set; }



        Accesodatos Acceso = new Accesodatos();
       public  int Vincular(int codigo,int idm)
        {

            string[] parametros = { "_idCliente",
"_idme" };
            return Acceso.ExeProcedimiento("MEMBRECIA_VINCULARCLIENTE", parametros, codigo,idm);

        }

        public DataTable buscarCliente(string Codigo)

        {

            string[] parametros = { "_codigo" };


            return Acceso.GetTabla("Membresia_Vincular_buscarCliente", parametros, Codigo);

        }
        public DataTable buscarTipoMembrecia(string Codigo)

        {

            string[] parametros = { "_Nombre" };


            return Acceso.GetTabla("Membresia_Vincular_buscartipoMembre", parametros, Codigo);

        }
        public DataTable buscarTipoNombremembrecia(string Codigo)

        {

            string[] parametros = { "idd" };


            return Acceso.GetTabla("Venta_consulta_nombreProducto", parametros, Codigo);

        }

    }
}
