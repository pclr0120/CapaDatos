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
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public int StockMin { get; set; }
        public bool Stock0 { get; set; }
        public double Costo { get; set; }
        public double Precio { get; set; }
        public string Promocion { get; set; }
        public int IdPromocion { get; set; }
        public double PrecioMin { get; set; }
        public int IdUnidad { get; set; }
        public int IdFamilia { get; set; }
        public string FechaCaducidad { get; set; }
        public string Estatus { get; set; }
        public string Nombre { get; set; }
        public double IVA { get; set; }
        public List<Producto> ListaProducto2 = new List<Producto>();

        Accesodatos Acceso = new Accesodatos();
        //pclr
        public DataTable ConsultaProducto(string codigo)
        {
            string[] parametros = { "_codigo" };
            return Acceso.GetTabla("Venta_ConsultarProducto", parametros, codigo);

        }
        public DataTable OStock(int codigo)
        {


            string[] parametros = { "id" };
            return Acceso.GetTabla("Venta_ActulizarStock", parametros, codigo);


        }

        public List<Producto> Obtenerstock(int Codigo)
        {
            try
            {

                foreach (DataRow row in OStock(Codigo).Rows)
                {


                    ///=====





                    Stock = row.Field<int>("Stock");
                    StockMin = row.Field<int>("StockMin");






                    ///=====
                }


            }
            catch (Exception e)
            {

                //MessageBox.Show("Error en la consulta Consule consulte Administrador:" + e, "Mensaje Error");
            }
            return ListaProducto2;

        }


        public DataTable ConsultaProductoDetalle(string codigo)
        {
            string[] parametros = { "id" };
            return (Acceso.GetTabla("Venta_ConsultaDetalleProducto", parametros, codigo));

        }

        public List<Producto> ConsultaDetallePProducto(string Codigo)
        {
            try
            {

                foreach (DataRow row in ConsultaProductoDetalle(Codigo).Rows)
                {


                    ///=====

                    Producto p = new Producto();
                    if (ListaProducto2.Count == 0)
                    {
                        p.Registro = 1;
                    }
                    else
                    {
                        p.Registro = ListaProducto2.Count + 1;
                    }



                    p.Codigo = row["Codigo"].ToString();
                    p.Nombre = row["Nombre"].ToString();
                    p.Precio = row.Field<double>("Precio");
                    p.Descripcion = row.Field<string>("Descripcion");
                    p.FechaCaducidad = row.Field<string>("FechaCaducidad");
                    ListaProducto2.Add(p);




                    ///=====
                }


            }
            catch (Exception e)
            {

                //MessageBox.Show("Error en la consulta Consule consulte Administrador:" + e, "Mensaje Error");
            }
            return ListaProducto2;

        }

    }
}
