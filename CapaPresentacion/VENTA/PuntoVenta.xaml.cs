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
using CapaLogica;
using System.Data;
using CapaPresentacion.VENTA;
using System.Windows.Threading;

namespace CapaPresentacion.VENTA
{
    /// <summary>
    /// Lógica de interacción para PuntoVenta.xaml
    /// </summary>
    public partial class PuntoVenta : Window
    {
        public PuntoVenta()
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
            LblReloj.Content = DateTime.Now.ToString();
        }
        #endregion





        #region ControlTeclas   

        VentaMaestra Vm = new VentaMaestra();
        Producto p = new Producto();

        public void EvaluarTecla(object sender, KeyEventArgs e)
        {
            if (Key.F6 == e.Key)
            {
                consultarProducot();
            }
            if (Key.A == e.Key)
            {


                this.Close();


            }
            if (Key.F == e.Key)
            {
                RealizarVenta();

            }

            if (Key.F4 == e.Key)
            {

                AgregarProductoVenta();

            }
            if (Key.F2 == e.Key)
            {
                EliminarProductoVenta();
              
            }
            if (Key.F5 == e.Key && dataGrid.Items.Count > 0)
            {
                CancelarVenta();
            }



        }


        #endregion

        #region comanodos
        void consultarProducot()
        {
            int c = 1;
            if (c == 1)
            {
                ConsultaProducto cp = new ConsultaProducto();
                cp.Show();
            }
        }
        void EliminarProductoVenta()
        {
            int x = 1;
            if (x == 1)
            {
                x = 2;
                if (dataGrid.Items.Count > 0)
                {

                    Mensaje.MensajeCaptura M = new Mensaje.MensajeCaptura("Eliminar producto", "Capture el # registro del producto a eliminar:", "Eliminar F1", "Cancelar F2", true);
                    M.ShowDialog();

                    if (M.valor != 0 && Vm.ListaProducto.Exists(c => c.Registro == M.valor))
                    {
                        Vm.valor = M.valor;   //registro a eliminar
                        Eliminar();
                    }
                    else if(M.valor!=0)
                    {

                        Mensaje.MensajeCaptura M2 = new Mensaje.MensajeCaptura("Eliminar producto", "Capture el # registro del producto a eliminar:", "Eliminar F1", "Cancelar F2", true);
                        M2.ShowDialog();
                    }




                }
            }
        }

        void AgregarProductoVenta()
        {
            int c = 1;
            if (c == 1)
            {
                c = 2;
                Mensaje.MensajeCaptura M = new Mensaje.MensajeCaptura("VENTA MANUAL", "#REGISTRO:", "AGREGAR F1", "CANCELAR F2", true);
                M.ShowDialog();
                if (M.valor > 0)
                    AgregarProducto(M.valor.ToString());
            }
            
        }
        public void AgregarProducto(string codigo)
        {
            dataGrid.ItemsSource = Vm.CProducto(codigo); //agrega al datagrid los productos
            dataGrid.Items.Refresh();
            calVenta();  //acutliza los totaltes
            if (Vm.Encontrado != true)
            {
                MessageBox.Show("Producto no encontrado");

            }
            if (Vm.p.Stock0)
            {
                MessageBox.Show("No se encuentra en stock");
            }

        }
        #endregion
        #region  agregarVenta








        public void calVenta()
        {
            Vm.CalVenta();
            LblIVA.Content = "$" + Vm.IVA.ToString();
            LblSubtotal.Content = "$" + Vm.Subtotal.ToString();
            LblTotal.Content = "$" + Vm.Total.ToString();

        }




        public void Eliminar()
        {
            dataGrid.ItemsSource = Vm.EliminarProducto();
            dataGrid.Items.Refresh();
            calVenta();

        }

        #endregion


        #region FinalizarLAVenta
        public void RealizarVenta()
        {
            if (dataGrid.Items.Count > 0)

                if (Vm.GuardarVenta() == 1)
                {

                    Mensaje.MensajeOk m = new Mensaje.MensajeOk("Mensaje:", "La venta se realizo exitoxamente.");

                    m.ShowDialog();


                    dataGrid.ItemsSource = Vm.LimpiarVenta(); //para limpiar la venta
                    dataGrid.Items.Refresh();//para limpiar la venta
                    calVenta();
                }
                else
                {

                    Mensaje.MensajeOk m = new Mensaje.MensajeOk("Mensaje:Error", "Error, Consulte con su administrador.");

                    m.Show();
                }


            //para limpiar la venta
        }

        public void CancelarVenta()
        {
            int c = 1;
           
            if (c == 1)
            {
                c = 2;
                if (dataGrid.Items.Count > 0)
                {

                    Mensaje.Mesaje Mm = new CapaPresentacion.Mensaje.Mesaje("Cancelar Venta", "Desea Cancelar la venta?", "Si F1", "No F2");
                    Mm.ShowDialog();
                    if (Mm.Si)
                        dataGrid.ItemsSource = null;
                    dataGrid.Items.Refresh();//para limpiar la venta
                    Vm.LimpiarVenta();
                    calVenta();
                }
            }

        }


        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EliminarProductoVenta();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RealizarVenta();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AgregarProductoVenta();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            consultarProducot();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            CancelarVenta();
        }
    }
}
