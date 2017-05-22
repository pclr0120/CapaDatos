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
using CapaPresentacion.VENTA;

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
                ConsultaProducto cp = new ConsultaProducto();
                cp.Show();
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


                AgregarProducto();


            }
            if (Key.D == e.Key)
            {

                if (dataGrid.Items.Count > 0)
                {

                    Mensaje.MensajeCaptura M = new Mensaje.MensajeCaptura("Eliminar producto", "Capture el # registro del producto a eliminar:", "S=Eliminar", "N=Cancelar", true,"int");
                    M.ShowDialog();
                    if (M.Opc)
                    {
                        if (M.valor != 0 && Vm.ListaProducto.Exists(c => c.Registro == M.valor))
                        {
                            Vm.valor = M.valor;   //registro a eliminar
                            Eliminar();
                        }
                        else
                        {
                            MessageBox.Show("No existe el # registro:" + M.valor.ToString(), "Mensaje");
                            Mensaje.MensajeCaptura Mm = new CapaPresentacion.Mensaje.MensajeCaptura("Eliminar producto", "Capture el # registro del producto a eliminar:", "S=Elimnar", "N=Cancelar", true,"int");
                            Mm.ShowDialog();
                        }
                    }



                }
            }
            if (Key.C == e.Key && dataGrid.Items.Count > 0)
            {
                CancelarVenta();
            }



        }

        #endregion

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {

        }



        #region  agregarVenta

        //Producto producto = new Producto();
        //List<Producto> ListaProducto = new List<Producto>();

        public void AgregarProducto()
        {
            dataGrid.ItemsSource = Vm.CProducto(TxtCodigo.Text); //agrega al datagrid los productos
            dataGrid.Items.Refresh();
            calVenta();  //acutliza los totaltes
            if (Vm.Encontrado != true) {
                MessageBox.Show("Producto no encontrado");
             
            }
            if (Vm.p.Stock0) {
                MessageBox.Show("No se encuentra en stock");
            }
              
        }





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
            Mensaje.Mesaje Mm = new CapaPresentacion.Mensaje.Mesaje("Cancelar Venta", "Desea Cancelar la venta", "S=Si", "N=No");
            Mm.ShowDialog();
            if (Mm.Si)
                dataGrid.ItemsSource = null;
            dataGrid.Items.Refresh();//para limpiar la venta
            Vm.LimpiarVenta() ;
            calVenta();

        }


        #endregion


    }
}
