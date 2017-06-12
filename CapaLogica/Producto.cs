using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaLogica
{
    public class auxiliaridInventario
    {
        public string medida { get; set; }
        public string proveedor { get; set; }
        public string familia { get; set; }
        public string promocion { get; set; }
        Accesodatos Acceso = new Accesodatos();
        DataTable ModificarObtnerProductoSelecgrid(string codigo)
        {

            string[] parametros = { "_codigo" };
            return Acceso.GetTabla("Invetario_Modificar_obtenerDAtosIdReales", parametros, codigo);

        }
       public  List<auxiliaridInventario> lt = new List<auxiliaridInventario>();
        public List<auxiliaridInventario> ModificarObtenerProductoSelecgrid(string codigo)
        {
            try
            {

                foreach (DataRow row in ModificarObtnerProductoSelecgrid(codigo).Rows)
                {


                    ///=====

                    auxiliaridInventario p =new auxiliaridInventario();




               
                    p.proveedor = row.Field<string>("Marca");
                    p.medida = row.Field<string>("Medida");
                    p.familia = row.Field<string>("Familia");

                    if (row.Field<object>("Descripcion") == null)
                    {
                    }
                    else
                    {
                        p.promocion = row.Field<string>("Descripcion");
                    }

                   lt.Add(p);




                    ///=====
                }


            }
            catch (Exception e)
            {

                //MessageBox.Show("Error en la consulta Consule consulte Administrador:" + e, "Mensaje Error");
            }
            return lt;

        }

       
    }
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
        public object IdPromocion { get; set; }
        public double PrecioMin { get; set; }
        public int IdUnidad { get; set; }
        public int IdFamilia { get; set; }
        public int IdProveedor { get; set; }
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
        public DataTable OStock(string codigo)
        {


            string[] parametros = { "id" };
            return Acceso.GetTabla("Venta_ActulizarStock", parametros, codigo);


        }

        public List<Producto> Obtenerstock(string Codigo)
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

        #region Inventario


        /// <summary> añadir mas stock
        public int añadirMasProducto(string codigo,int stock)
        {
           
            string[] parametros = { "_codigo","_Stock" };
            return Acceso.ExeProcedimiento("inventario_añadirMasProducto", parametros, codigo,stock);

        }
        public DataTable AñandirmasMostrarinfoStock(string codigo)
        {
            
            string[] parametros = { "_codigo" };
            return Acceso.GetTabla("inventario_añadirmasMostrarStock", parametros, codigo);

        }
        /// </summary>
        /// <returns></returns>
        public DataTable ConsultaMedida()
        {
            int codigo=0;
            string[] parametros = { "Codigo" };
            return Acceso.GetTabla("Inventario_UnidadMEdida_Query", parametros, codigo);

        }
        public DataTable ConsultaFamilia()
        {
            int codigo = 0;
            string[] parametros = { "Codigo" };
            return Acceso.GetTabla("Inventario_Familia_Query", parametros, codigo);

        }
        public DataTable Proveedor()
        {
            int codigo = 0;
            string[] parametros = { "Codigo" };
            return Acceso.GetTabla("Inventario_Proveedor_Query", parametros, codigo);

        }


        public DataTable PromocionesQuery ()
        {
            int codigo = 0;
            string[] parametros = { "Codigo" };
            return Acceso.GetTabla("Inventario_Promocion_Query", parametros, codigo);

        }

        //cuando registre  hay que vrificar que no exista ese producto con ese nombre y conese codigo


        public bool TrueCodigoBarraRegistrado(string codigo)
        {
           
            string[] parametros = { "_codigo" };
            return Acceso.GetTabla("Inventario_CodigodeBarraValidarSiextiste", parametros, codigo).Rows.GetEnumerator().MoveNext();

        }
        public bool validarNombre(string codigo)
        {

            string[] parametros = { "_codigo" };
            return Acceso.GetTabla("Inventario_validarnombreProdcuto", parametros, codigo).Rows.GetEnumerator().MoveNext();

        }
        public int RegistrarProducto()
        {
   
             string[] parametros = { "_Codigo","_Nombre","_Descripcion", "_IdProvedor", "_Stock", "_StockMin", "_Costo", "_Precio", "_Iva", "_Promocion", "_IdPromocion", "_PrecioMinimo", "_IdUnidadMedida", "_IdFamilia", "_Estatus", "_FechaCaducidad" };
            return Acceso.ExeProcedimiento("Inventario_ProductoNuevo_Registrar", parametros,Codigo,Nombre,Descripcion,IdProveedor,Stock,StockMin,Costo,Precio,IVA,Promocion,IdPromocion,PrecioMin,IdUnidad,IdFamilia,Estatus,FechaCaducidad );

        }

        public DataTable MostrartodoProducto()
        {
            int codigo = 0;
            string[] parametros = { "_codigo" };
            return Acceso.GetTabla("Inventario_MostrarTodosProducto", parametros, codigo);

        }
        public DataTable MostrartodoProductoActivos(string codigo)
        {
            
            string[] parametros = { "_codigo" };
            return Acceso.GetTabla("Inventario_MostrarTodosProductoActivos", parametros, codigo);

        }
         DataTable ModificarObtnerProductoSelecgrid(string codigo)
        {

            string[] parametros = { "_codigo" };
            return Acceso.GetTabla("Invetario_Modificar_obtenerDAtos", parametros, codigo);

        }
        public List<Producto> ModificarObtenerProductoSelecgrid(string codigo)
        {
            List<Producto> lt = new List<Producto>();
            try
            {

                foreach (DataRow row in ModificarObtnerProductoSelecgrid(codigo).Rows)
                {


                    ///=====
                    /// 
                   
                                       Producto p = new Producto();
                  



                    p.Codigo = row["Codigo"].ToString();
                    p.Nombre = row["Nombre"].ToString();
                    p.Precio = row.Field<double>("Precio");
                    p.Descripcion = row.Field<string>("Descripcion");
                    p.FechaCaducidad = row.Field<string>("FechaCaducidad");
                    p.Costo= row.Field<double>("Costo");
                    p.PrecioMin= row.Field<double>("PrecioMinimo");
                    p.IVA = row.Field<double>("IVA");
                    p.Stock = row.Field<int>("Stock");
                    p.StockMin = row.Field<int>("StockMin");
                    p.IdUnidad = row.Field<int>("IdUnidadMedida");
                    p.IdFamilia = row.Field<int>("IdFamilia");
                    p.IdProveedor = row.Field<int>("IdProvedor");
                    p.Estatus = row.Field<string>("Estatus");
                   p.Promocion = row.Field<string>("Promocion");
                    if (row.Field<object>("IdPromocion") == null)
                    {
                    }
                    else {
                        p.IdPromocion = row.Field<int>("IdPromocion");
                    }
                  
                    lt.Add(p);




                    ///=====
                }


            }
            catch (Exception e)
            {

                //MessageBox.Show("Error en la consulta Consule consulte Administrador:" + e, "Mensaje Error");
            }
            return lt;

        }


        public int inventarioModificarProducto(int codigo, string _nom, string _desc, string _prove, string _stock, string _stockmin, string _costo, string _precio, string _iva, string _promo, string _idpromo_, string _preciomin, string _idMedida, string _familia, string _estatus, string _fechacad) {
            string[] parametros = { "_Codigo", "_Nombre", "_Descripcion", "_IdProvedor", "_Stock", "_StockMin", "_Costo", "_Precio", "_Iva", "_Promocion", "_IdPromocion", "_PrecioMinimo", "_IdUnidadMedida", "_IdFamilia", "_Estatus", "_FechaCaducidad" };
            return Acceso.ExeProcedimiento("Inventario_modificarProducto", parametros,codigo, _nom,_desc,_prove,_stock,_stockmin,_costo,_precio,_iva,_promo,_idpromo_,_preciomin,_idMedida,_familia,_estatus,_fechacad);


        }
        #endregion


        public int ModificarAltaBaja(string codigo,string estatus)
        {
            string[] parametros = { "_Codigo","_Estatus" };
            return Acceso.ExeProcedimiento("Inventario_UpdateAltaBaja", parametros, codigo,estatus);

        }
        public DataTable EstatusbajaAlta(string codigo)
        {
            string[] parametros = { "_codigo" };
            return Acceso.GetTabla("Inventario_ConsultaAltaBaja", parametros,codigo);

        }


    }
}
