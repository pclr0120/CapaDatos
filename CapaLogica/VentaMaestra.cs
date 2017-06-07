using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
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
        public int valor { get; set; }
        public double Pago { get; set; }
        public double Cambio { get; set; }
     


        Accesodatos Acceso = new Accesodatos();
        ///insertar la venta maestra primero
    


        #region insertarventa
        /// <summary>
        /// ///Metodo para agregar Al grid Los producto a comprar
        /// </summary>
        Producto producto = new Producto();
       public  List<Producto> ListaProducto = new List<Producto>();
       public  bool Encontrado;
        public Producto p = new Producto();
   
        public List<Producto> CProducto(string Codigo)
        {
            try
            {
               p.Stock0 = false;
                 Encontrado = false;
                foreach (DataRow row in producto.ConsultaProducto(Codigo).Rows)
                {
                    Encontrado = true;
                   p.Obtenerstock(Convert.ToInt32(Codigo));
                   
                    ///=====
                    if (p.Stock > 0)
                    {
                        Producto p = new Producto();
                        if (ListaProducto.Count == 0)
                        {
                            p.Registro = 1;
                        }
                        else
                        {
                            p.Registro = ListaProducto.Count + 1;
                        }
                      


                        p.Codigo = row["Codigo"].ToString();
                        p.Nombre = row["Nombre"].ToString();
                        p.Precio = row.Field<double>("Precio");
                        p.IVA = row.Field<double>("IVA");
                        ListaProducto.Add(p);
                        CalVenta();
                        p.Stock = 0;
                    }
                    else
                    {
                        p.Stock0 = true;
                        
                    }
                      
                       
                    ///=====
                }
                if (Encontrado != true)
                {
                 
                    return ListaProducto;
                    //MessageBox.Show("No se encontro el producto en la Base de datos", "Mensaje Consulta");
                }

            }
            catch (Exception e)
            {
                
                //MessageBox.Show("Error en la consulta Consule consulte Administrador:" + e, "Mensaje Error");
            }
            return ListaProducto;

        }

        //calculos de la venta,elimar y actulizar calculos
        #region AgregarVenta
        public void CalVenta()
        {
            IVA = 0;
            Subtotal = 0;
            Total = 0;
            int c = 0;
            for (int i = 0; i < ListaProducto.Count; i++)
            {

                IVA += ListaProducto[i].IVA;
                Subtotal += ListaProducto[i].Precio;
                Total = IVA + Subtotal;

                c += 1;
            }


        }

        public void ActualizarRegistro()
        {
            int c = 1;
            for (int i = 0; i < ListaProducto.Count; i++)
            {

                ListaProducto[i].Registro = c;
                c += 1;
            }
        }

        public List<Producto> EliminarProducto()
        {
            ListaProducto.Remove(ListaProducto.FirstOrDefault(c => c.Registro == valor));
          
        
            ActualizarRegistro();
            
            CalVenta();
            return ListaProducto;
        }
        #endregion
        #endregion

        public int GuardarVenta()
        {
            try
            {

                string[] parametros = { "_IdUsuario", "_IdCliente", "_CantidadP", "_Total", "_Iva", "_Subtotal","_PAGOCON" };
                IdVenta = Convert.ToInt32(Acceso.ExeProceVenta("Venta_FinalizarVenta", parametros, IdUsuario, IdCliente, CantidadProducto, Total, IVA, Subtotal,Pago));
                

                string[] parametros2 = { "_IdVenta", "_Codigo", "_PrecioProducto","_Iva" };
                for (int i = 0; i < ListaProducto.Count; i++)
                {
                    Acceso.ExeProcedimiento("Venta_InsertarDetalleVenta", parametros2, IdVenta, ListaProducto[i].Codigo, ListaProducto[i].Precio,ListaProducto[i].IVA);
                }
                Cambio = Pago - Total;
                return 1;

            }
            catch(Exception ) {
                return 0;
            }
        
        }

      //========CAncelar venta


        public List<Producto> LimpiarVenta()
        {


            ListaProducto = new List<Producto>();
            return ListaProducto;
            IVA = 0;
            Subtotal = 0;
            Total = 0;



        }


    }
}
