using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaLogica
{
    public class Devoluciones
    {
        public int IdVenta { set; get; }
        public int IdDetalle { set; get; }
        public int Codigo { set; get; }
        public double Iva { set; get; }
        public double Precio { set; get; }
        public string Nombre { set; get; }

        public List<Devoluciones> listaDevoluciones = new List<Devoluciones>();
        Accesodatos Acceso = new Accesodatos();


        DataTable QueryNombrePrducto(int IdVenta)

        {

            string[] parametros = { "idd" };
            return Acceso.GetTabla("Venta_consulta_nombreProducto", parametros, IdVenta);

        }

        bool QueryVentaMaestra(int IdVenta)

        {

            string[] parametros = { "idd" };

            bool B = Acceso.GetTabla("Venta_Devoluciones_queryVentaMaestra", parametros, IdVenta).Rows.GetEnumerator().MoveNext();
            return B;

        }

        #region ConsultaDelle
        DataTable QueryDetalle(int IdVenta)

        {
            if (QueryVentaMaestra(IdVenta)) {
                string[] parametros = { "id" };
                return Acceso.GetTabla("Venta_queryProducto_devoluciones", parametros, IdVenta);
            }
            else {
                return null;
            }
           
        }

        public List<Devoluciones> ConsultaDellateDevolucion(int Idventa)
        {
            try
            {

                foreach (DataRow row in QueryDetalle(Idventa).Rows)
                {



                    ///=====


                    Devoluciones De = new Devoluciones();



                    De.IdDetalle = Convert.ToInt16(row["IdDetalle"]);
                    De.IdVenta = Convert.ToInt32(row["IdVenta"]);
                    // De.Nombre = row["Nombre"].ToString();

                    De.Codigo = Convert.ToInt32(row["Codigo"]);
                    foreach (DataRow row1 in QueryNombrePrducto(De.Codigo).Rows)
                    {
                        De.Nombre = row1["Nombre"].ToString();
                    }

                    De.Precio = row.Field<double>("PrecioProducto");
                    De.Iva = row.Field<double>("Iva");
                    listaDevoluciones.Add(De);




                    ///=====



                }
            }
            catch (Exception e)
            {

                //MessageBox.Show("Error en la consulta Consule consulte Administrador:" + e, "Mensaje Error");
            }
            return listaDevoluciones;

        }
        #endregion

        public int DevolucionfolioTotal(string idVenta)
        {

            bool bandera = listaDevoluciones.Exists(c => c.IdVenta == Convert.ToInt16(idVenta));
            if (bandera)
            {
                string[] parametros = { "idVenta" };
                return Acceso.ExeProcedimiento("Devolucion_Folio", parametros, IdVenta);
            }
            else
            {
                return 0;
            }
        }

        #region ActulizarDatosDEventaDevulta


        public int UpdateProductoDevulto(string IdDetalle)

        {
            bool bandera = listaDevoluciones.Exists(c => c.IdDetalle == Convert.ToInt16(IdDetalle));
            if (bandera)
            {

                int i = listaDevoluciones.FindIndex(c => c.IdDetalle == Convert.ToInt16(IdDetalle));
                IdVenta = listaDevoluciones[i].IdVenta;
                Iva = listaDevoluciones[i].Iva;
                Precio = listaDevoluciones[i].Precio;


                UpdateVentaTotales(IdVenta, Iva, Precio);
                string[] parametros = { "idd" };
                return Acceso.ExeProcedimiento("Venta_devoluciones_ProductoDevolucion", parametros, IdDetalle);
            }
            else
            {
                return 0;
            }

        }
        private int UpdateVentaTotales(int IdVenta, double iva, double PrecioProducto)

        {

            string[] parametros = { "idVenta", "iva", "PrecioProducto" };


            return Acceso.ExeProcedimiento("Venta_devoluciones_updatetotalVenta", parametros, IdVenta, iva, PrecioProducto);
        }

        #endregion

        public List<Devoluciones> Limpiarlista()
        {

            listaDevoluciones = new List<Devoluciones>();
            return listaDevoluciones;
        }
    }
}
