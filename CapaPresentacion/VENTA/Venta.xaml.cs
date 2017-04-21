using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Timers;
using System.Windows.Threading;
using CapaLogica;
using System.Data;

namespace CapaPresentacion
{
    /// <summary>
    /// Lógica de interacción para Venta.xaml
    /// </summary>
    public partial class Venta : Window
    {
        public Venta()
        {
            InitializeComponent();
            reloj();
        }
        #region reloj
        public void reloj()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += tickeven;
            timer.Start();



        }

        private void tickeven(object sender, EventArgs e)
        {
            LblReloj.Content= DateTime.Now.ToString();
        }
        #endregion

        #region ControlTeclas   


        public void EvaluarTecla(object sender, KeyEventArgs e)
        {
            if (Key.A == e.Key)
            {

                
                this.Close();


            }

            if (Key.V == e.Key)
            {


                AgregarProducto();


            }
            if (Key.D == e.Key)
            {


                Eliminar();

            }
            if (Key.F1 == e.Key && dataGrid.Items.Count > 0)
            {
                this.Close();
            }

           

        }

        #endregion

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {

        }



        #region  agregarVenta

        Producto producto = new Producto();
        List<Producto> ListaProducto = new List<Producto>();
     
        public void AgregarProducto()
        {
            dataGrid.ItemsSource = CProducto() ;
            dataGrid.Items.Refresh();
            VentaMaestra();
        }

        #endregion
        #region ConsultaProducto

        public List<Producto> CProducto()
        {
            try
            {
                bool Encontrado=false;
                foreach (DataRow row in producto.ConsultaProducto(TxtCodigo.Text).Rows)
                {
                    Encontrado = true;
                    Producto p = new Producto();
                    p.Registro = ListaProducto.Count + 1;
                    p.Nombre = row["Nombre"].ToString();
                    p.Precio = row.Field<double>("Precio");
                    p.IVA = row.Field<double>("IVA");
                    ListaProducto.Add(p);
                }
                if (Encontrado!=true)
                {
                    MessageBox.Show("No se encontro el producto en la Base de datos", "Mensaje Consulta");
                }
                
            }
            catch(Exception e)
            {
                MessageBox.Show( "Error en la consulta Consule consulte Administrador:" + e, "Mensaje Error");
            }
            return ListaProducto;

        }
        #endregion

        VentaMaestra Vm = new VentaMaestra();
        public void VentaMaestra()
        {
            Vm.IVA = 0;
            Vm.Subtotal = 0;
            Vm.Total = 0;
            int c = 0;
            for (int i = 0; i < ListaProducto.Count; i++)
            {

                Vm.IVA += ListaProducto[i].IVA;
                Vm.Subtotal += ListaProducto[i].Precio;
                Vm.Total = Vm.IVA + Vm.Subtotal;

                c += 1;
            }
            LblIVA.Content = "$"+ Vm.IVA.ToString() ;
            LblSubtotal.Content = "$"+ Vm.Subtotal.ToString() ;
            LblTotal.Content = "$"+ Vm.Total.ToString() ;
           
        }

        #region eliminar

        public void ActualizarRegistro()
        {
            int c = 1;
            for (int i = 0; i < ListaProducto.Count; i++)
            {

                ListaProducto[i].Registro = c;
                c += 1;
            }
        }
        public void Eliminar()
        {
            ListaProducto.Remove(ListaProducto.FirstOrDefault(c => c.Registro == int.Parse(TxtCodigo.Text)));
            ActualizarRegistro();
            dataGrid.ItemsSource = ListaProducto;
            dataGrid.Items.Refresh();
            VentaMaestra();
        }

        #endregion

        



    }
}
