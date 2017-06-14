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

namespace CapaPresentacion
{
    /// <summary>
    /// Lógica de interacción para CantidadProducto.xaml
    /// </summary>
    public partial class CantidadProducto : Window
    {

        public int registro;
        public int cantidad;
        int rango;
        public CantidadProducto(int rango)
        {
            InitializeComponent();
            txtR.Focus();
            this.rango =rango;
        }
        bool control = true;
        int banderacontrol = 0;
        public void EvaluarTecla(object sender, KeyEventArgs e)
        {

          
            if (banderacontrol == 0)
            {

                control = false;
             
             
                }
                if (Key.F1 == e.Key)
                {
                Aceptar();
                    


                }

                if (Key.F2 == e.Key)
                {

                cancelar();


                }
        


            
            banderacontrol += 1;
            if (banderacontrol > 1)
            {
                banderacontrol = 0;
            }

        }
         
        void Aceptar()
        {
            if (txtcantidad.Text != "0" && txtR.Text != "0")
            {



                if (txtcantidad.Text.Length > 0 && txtR.Text.Length > 0)
                {
                    registro = Convert.ToInt32(txtR.Text.ToString());
                    cantidad = Convert.ToInt32(txtcantidad.Text.ToString());
                   
                    if (registro <= rango)
                    {
                        this.Close();
                    }
                    else
                    {

                        MessageBox.Show("No se encuentra ese registro capture uno que exista.");
                        txtR.Focus();
                    }
                }
                else
                {

                    MessageBox.Show("Capture todos los campos para continuar.");
                }
            }
            else {
                MessageBox.Show("No se acepta Valor 0.");
            }
            }

        void cancelar() {

            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Aceptar();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            cancelar();
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

        private void txtR_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtcantidad_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtR_PreviewKeyUp(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {


                txtcantidad.Focus();

            }
        }

        private void txtcantidad_PreviewKeyUp(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {

                Aceptar();

            }
        }
    }
}
