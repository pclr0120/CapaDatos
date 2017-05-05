﻿using CapaDatos;
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
  


        Accesodatos Acceso = new Accesodatos();
        ///insertar la venta maestra primero
    


        #region insertarventa
        /// <summary>
        /// ///Metodo para agregar Al grid Los producto a comprar
        /// </summary>
        Producto producto = new Producto();
        List<Producto> ListaProducto = new List<Producto>();
       public  bool Encontrado;
        public List<Producto> CProducto(string Codigo)
        {
            try
            {
                 Encontrado = false;
                foreach (DataRow row in producto.ConsultaProducto(Codigo).Rows)
                {
                    Encontrado = true;
                    Producto p = new Producto();
                    p.Registro = ListaProducto.Count + 1;
                    p.Codigo = row["Codigo"].ToString();
                    p.Nombre = row["Nombre"].ToString();
                    p.Precio = row.Field<double>("Precio");
                    p.IVA = row.Field<double>("IVA");
                    ListaProducto.Add(p);
                    CalVenta();
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

        public List<Producto> EliminarProducto(string codigo)
        {
            ListaProducto.Remove(ListaProducto.FirstOrDefault(c => c.Registro == int.Parse(codigo)));
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

                string[] parametros = { "_IdUsuario", "_IdCliente", "_CantidadP", "_Total", "_Iva", "_Subtotal" };
                IdVenta = Convert.ToInt32(Acceso.ExeProceVenta("FinalizarVenta", parametros, IdUsuario, IdCliente, CantidadProducto, Total, IVA, Subtotal));

                string[] parametros2 = { "_IdVenta", "_Codigo", "_PrecioProducto" };
                for (int i = 0; i < ListaProducto.Count; i++)
                {
                    Acceso.ExeProcedimiento("I_DetalleVenta", parametros2, IdVenta, ListaProducto[i].Codigo, ListaProducto[i].Precio);
                }
                return 1;
            }
            catch(Exception ) {
                return 0;
            }
        
        }

      

    }
}
