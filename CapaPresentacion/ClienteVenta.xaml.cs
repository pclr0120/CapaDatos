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

namespace CapaPresentacion
{
    /// <summary>
    /// Lógica de interacción para ClienteVenta.xaml
    /// </summary>
    public partial class ClienteVenta : Window
    {
        public ClienteVenta(int id)
        {
            InitializeComponent();
            c.IdVenta = id;
           
        }
        bool control = true;
        int banderacontrol = 0;
        public void EvaluarTecla(object sender, KeyEventArgs e)
        {


            if (banderacontrol == 0)
            {

                control = false;
             
                if (Key.F1 == e.Key)
                {
                    VincularXcodigo();


                }

                if (Key.F2 == e.Key)
                {

                    this.Close();


                }
              
               


            }
            banderacontrol += 1;
            if (banderacontrol > 1)
            {
                banderacontrol = 0;
            }

        }

        CapaLogica.ClienteVenta c = new CapaLogica.ClienteVenta();
        void VincularXcodigo()
        {
            pbar.Value = 15;
          
            if (siExisteClientexCo().Rows.GetEnumerator().MoveNext())
            {
                try
                {

                    if (txtBuscar.Text != "")
                    {
                        pbar.Value = 30;
                    
                        pbar.Value = 50;
                    
                        c.VincularClientexCodigo(c.IdVenta, txtBuscar.Text.ToString());
                        pbar.Value = 100;
                 
                        MessageBox.Show("Venta vinculada al cliente Exitosamente","Mensaje");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un codigo correcto", "Error");
                        txtBuscar.Focus();
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error Contacte a su Administrador error:" + e.ToString());
                }

            }
            else
            {

                MessageBox.Show("No Se encontro ningun Cliente con ese codigo");
                pbar.Value = 0;
              
            }
        }
       public  DataTable siExisteClientexCo()
        {
           return c.buscarCliente(txtBuscar.Text,"none","co");

        }

        private void btnbuscar_Click(object sender, RoutedEventArgs e)
        {
            VincularXcodigo();
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

        private void btnbuscar_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }
    }
}
