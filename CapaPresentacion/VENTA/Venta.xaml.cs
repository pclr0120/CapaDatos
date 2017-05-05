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

        //Producto producto = new Producto();
        //List<Producto> ListaProducto = new List<Producto>();
        VentaMaestra Vm = new VentaMaestra();
     
        public void AgregarProducto()
        {
            dataGrid.ItemsSource = Vm.CProducto(TxtCodigo.Text); //agrega al datagrid los productos
            dataGrid.Items.Refresh();
            if (Vm.Encontrado != true)
                MessageBox.Show("Producto no encontrado");
            calVenta();  //acutliza los totaltes
        }

     



        public void calVenta()
        {
            LblIVA.Content = "$" + Vm.IVA.ToString();
            LblSubtotal.Content = "$" + Vm.Subtotal.ToString();
            LblTotal.Content = "$" + Vm.Total.ToString();

        }

     

 
        public void Eliminar()
        {
            dataGrid.ItemsSource = Vm.EliminarProducto(TxtCodigo.Text);
            dataGrid.Items.Refresh();
            calVenta();
          
        }

        #endregion


        #region FinalizarLAVenta
        public void RealizarVenta()
        {
            Vm.InsertarVentaMaestra(Vm.IdUsuario, Vm.IdCliente, Vm.CantidadProducto, Vm.Total, Vm.IVA, Vm.Subtotal);
            

        }


        #endregion


    }
}
