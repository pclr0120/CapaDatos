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

namespace CapaPresentacion.Mensaje
{
    /// <summary>
    /// Lógica de interacción para MensajeCaptura.xaml
    /// </summary>
    public partial class MensajeCaptura : Window
    {
        public int valor { get; set; }
        public bool Opc { get; set; }
        public bool Solo { get; set; }
        public MensajeCaptura(string titulo,string mesanje,string bt1,string btn2,bool solo)
        {
            InitializeComponent();
            lblMensajeM.Content = mesanje;
            lblMensajeT.Content = titulo;
            this.txt_valor.Focus();
            BtSi.Content = bt1;
            BtNo.Content = btn2;
            Solo = solo;
        }
        void aceptar()
        {
            
            if (txt_valor.Text != "")
            {
                Opc = true;
                this.Close();
                valor = Convert.ToInt16(txt_valor.Text);
            }
            else
            {
                MessageBox.Show( "Capture un valor para continuar","Captura");
                txt_valor.Focus();
            }
        }
        private void BtSi_Click(object sender, RoutedEventArgs e)
        {
            aceptar();
        }

        private void BtNo_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
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
        public void SoloLetras(TextCompositionEventArgs e)
        {
            //se convierte a Ascci del la tecla presionada 
            int ascci = Convert.ToInt32(Convert.ToChar(e.Text));
            //verificamos que se encuentre en ese rango que son entre el 0 y el 9 
            if (ascci >= 48 && ascci <= 57)
                e.Handled = false;
            else e.Handled = true;
        }



        private void txt_valor_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Solo)
                SoloNumeros(e);
            else
                txtletras(e);

        }

        private void txtletras( TextCompositionEventArgs e)
        {
            int ascci = Convert.ToInt32(Convert.ToChar(e.Text));
            if (ascci >= 65 && ascci <= 90 || ascci >= 97 && ascci <= 122)
                e.Handled = false;
            else e.Handled = true;
        }
        #region ControlTeclas   

      
        public void EvaluarTecla(object sender, KeyEventArgs e)
        {
            if (Key.F1 == e.Key)
            {

                aceptar();
                


            }
            if (Key.F2 == e.Key)
            {

                valor = 0;
                this.Close();


            }




        }

        #endregion
    }
}
