using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaLogica
{
    public class Producto
    {
        public int Registro { get; set; }   //solo para el datagrid de la venta

        public int IdProducto { get; set; }
        public string Codigo { get; set; }
        public int Stock { get; set; }
        public int StockMin { get; set; }
        public double Costo { get; set; }
        public double Precio { get; set; }
        public string Promocion { get; set; }
        public int IdPromocion { get; set; }
        public double PrecioMin { get; set; }
        public int IdUnidad { get; set; }
        public int IdFamilia{ get; set; }
        public string FechaCaducidad { get; set; }
        public string Estatus { get; set; }
        public string Nombre { get; set; }
        public double IVA { get; set; }


        Accesodatos Acceso = new Accesodatos();
        //dsdds
        public DataTable ConsultaProducto(string codigo)
        {
            string[] parametros = { "_codigo" };
            return Acceso.GetTabla("CProducto", parametros,codigo);

        }



    }
}
