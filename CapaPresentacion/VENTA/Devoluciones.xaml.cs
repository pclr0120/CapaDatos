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

namespace CapaPresentacion.VENTA
{
    /// <summary>
    /// Lógica de interacción para Devoluciones.xaml
    /// </summary>
    public partial class Devoluciones : Window
    {
        CapaLogica.Devoluciones D = new CapaLogica.Devoluciones();
        public Devoluciones()
        {
            InitializeComponent();
            Mensaje.MensajeCaptura ms = new Mensaje.MensajeCaptura("Devoluciones", "Ingrese #Folio:", "Continuar F1", "Cancelar F2", true, "int");

            ms.ShowDialog();
            if (D.ConsultaDellateDevolucion(ms.valor).Count > 0)
            {

              //  D.ConsultaDellateDevolucion(ms.valor);
                ConsultaDetalle();
                txtFolio.Text = ms.valor.ToString();
            }
            else
            {
                if (ms.valor != 0)
                {
                    while (D.ConsultaDellateDevolucion(ms.valor).Count == 0)
                    {
                        MessageBox.Show("no se encontro ningun resultado", "Buscando");
                        Mensaje.MensajeCaptura mss = new Mensaje.MensajeCaptura("Devoluciones", "Ingrese #Folio:", "Continuar F1", "Cancelar F2", true, "int");
                        mss.ShowDialog();

                        if (D.ConsultaDellateDevolucion(mss.valor).Count > 0)
                        {

                            ConsultaDetalle();
                            txtFolio.Text = mss.valor.ToString();
                            break;
                        }

                        if (mss.valor == 0)
                        {
                            this.Close();
                            break;
                        }
                    }
                }
                else {
                    this.Close();
                }
            }
           
           
        }


        public void ConsultaDetalle()
        {
            try
            {

                dataGrid.Items.Refresh();
                dataGrid.ItemsSource = D.listaDevoluciones;
                dataGrid.Items.Refresh();
            }
            catch (Exception e) {

                MessageBox.Show("error","dasd");
            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DevolucionFolio();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DevolucionProducto();
        }

        void DevolucionFolio() {
            banderacontrol += 1;
            Mensaje.Mesaje m = new Mensaje.Mesaje("Confirmacion","Deseas Cancelar ticket?","SI F1","No F2");
            m.ShowDialog();
            if (m.Si)
            {
                if (txtFolio.Text.Length > 0)
                {
                    try
                    {
                        if (D.DevolucionfolioTotal(txtFolio.Text) > 0)
                        {
                            MessageBox.Show("Devolucion Exitosa", "Mensaje");
                            txtid.Clear();
                            limpiargrid();

                        }
                        else
                        {
                            MessageBox.Show("No existe ese producto intente con otro", "Mensaje");
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Error consulte con su administrador. Error:" + e.ToString(), "Mensaje Error");
                    }
                }
                else
                {

                    MessageBox.Show("Capture el folio ", "Error");
                }
                this.Close();
            }
          
        }

        void DevolucionProducto()
        {

            banderacontrol += 1;
            Mensaje.Mesaje m = new Mensaje.Mesaje("Confimacion", "Deseas Cancelar Producto", "SI F1", "No F2");
            m.ShowDialog();
            if (m.Si)
            {
                if (txtid.Text.Length > 0)
                {
                    try
                    {
                        if (D.UpdateProductoDevulto(txtid.Text) > 0)
                        {
                            MessageBox.Show("Devolucion Exitosa", "Mensaje");
                            txtid.Clear();
                            limpiargrid();

                        }
                        else
                        {
                            MessageBox.Show("No existe ese folio intente con otro", "Mensaje");
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Error consulte con su administrador. Error:" + e.ToString(), "Mensaje Error");
                    }

                }
                else
                {

                    MessageBox.Show("Capture el id ", "Error");
                }

            }

        }


        public void SoloNumeros(TextCompositionEventArgs e)
        {
            //se convierte a Ascci del la tecla presionada 
            int ascci = Convert.ToInt32(Convert.ToChar(e.Text));
            //verificamos que se encuentre en ese rango que son entre el 0 y el 9 
            if (ascci >= 48 && ascci <= 57)
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtid_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
           
            SoloNumeros(e);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        int banderacontrol = 0;

        public void EvaluarTecla(object sender, KeyEventArgs e)
        {


            if (banderacontrol == 0)
            {

               
              
              
                if (Key.F1 == e.Key)
                {
                    DevolucionFolio();


                }

                if (Key.F2 == e.Key)
                {
               
                    DevolucionProducto();


                }
                if (Key.F3 == e.Key)
                {
                    this.Close();


                }
             


            }
            banderacontrol += 1;
            if (banderacontrol > 2)
            {
                banderacontrol = 0;
            }

        }

        void limpiargrid() {

            dataGrid.ItemsSource = null;
            dataGrid.Items.Refresh();//para limpiar la venta
            D.Limpiarlista();
            D.ConsultaDellateDevolucion(Convert.ToInt32(txtFolio.Text));

            ConsultaDetalle();
        }
    }
}
