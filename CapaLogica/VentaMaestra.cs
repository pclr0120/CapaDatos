using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class VentaMaestra
    {
        public double Total { get; set; }
        public double Subtotal { get; set; }
        public double IVA { get; set; }
        public double total { get; set; }
        public int CantidadProducto { get; set; }
        public int IdCliente { get; set; }
        public int IdUsuario { get; set; }
        public int IdVenta { get; set; }
  


        Accesodatos Acceso = new Accesodatos();
        ///insertar la venta maestra primero
        public int InsertarVentaMaestra( int IdUsuario, int IdEmpleado, int CantidadProducto, double Total, double IVA, double Subtotal)
        {
            string[] parametros = { "_IdUsuario", "_IdCliente", "_CantidadP", "_Total", "_Iva", "_Subtotal" };
            return Convert.ToInt32(Acceso.ExeProceVenta("FinalizarVenta", parametros, IdUsuario, IdCliente, CantidadProducto, Total, IVA, Subtotal));

        }

        public int InsertarDetalle(int IdUsuario, int IdEmpleado, int CantidadProducto, double Total, double IVA, double Subtotal)
        {
            string[] parametros = { "_IdUsuario", "_IdCliente", "_CantidadP", "_Total", "_Iva", "_Subtotal" };
            return Convert.ToInt32(Acceso.ExeProcedimiento("FinalizarVenta", parametros, IdUsuario, IdCliente, CantidadProducto, Total, IVA, Subtotal));

        }
    }
}
