using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaLogica
{
    public class ClienteVenta
    {

        public int IdVenta { get; set; }
        public int IdCliente { get; set; }
        public string Nombre { get; set; }

        Accesodatos Acceso = new Accesodatos();

       public  int VincularClientexCodigo(int IdVenta,string Codigo)

        {
            int co = Convert.ToInt32(Codigo);
            string[] parametros = { "iddVenta","CodigoPersonalCliente" };

            return Acceso.ExeProcedimiento("VentaVincularClientexCodigo", parametros, IdVenta,co);

        }

        public DataTable buscarCliente( string Codigo,string nombre,string busqueda)

        {

            string[] parametros = {  "Codigo","Nombree","busqueda" };


            return Acceso.GetTabla("BuscarClienteXcodigoPersonal", parametros,Codigo,nombre,busqueda);

        }

    }
}
