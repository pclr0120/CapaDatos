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

namespace CapaPresentacion.Mensaje
{
    /// <summary>
    /// Lógica de interacción para MensajeCaptura.xaml
    /// </summary>
    public partial class MensajeCaptura : Window
    {
        public double Total { get; set; }
        public int valor { get; set; }
        public int valor5 { get; set; }
        public string valor3 { get; set; }
        public double valor2 { get; set; }
        public bool Opc { get; set; }
        public string Opc2 { get; set; }
        public bool Solo { get; set; }
        public MensajeCaptura(string titulo,string mesanje,string bt1,string btn2,bool solo,string tipo)
        {
            InitializeComponent();
            lblMensajeM.Content = mesanje;
            lblMensajeT.Content = titulo;
            this.txt_valor.Focus();
            
            BtSi.Content = bt1;
            BtNo.Content = btn2;
            Opc2 = tipo;
            Solo = solo;
            if (btn2 == "")
            {
                BtNo.IsEnabled = false;
             
            }
        }
        
        void aceptar()
        {
            
            if (txt_valor.Text != ""&& txt_valor.Text!="0")
            {
                Opc = true;


                if (Opc2 == "double" && Total <= Convert.ToDouble(txt_valor.Text))
                {
                    this.Close();
                    valor2 = Convert.ToDouble(txt_valor.Text);
                }
                else if (Opc2 == "double" && Total > Convert.ToDouble(txt_valor.Text))
                {

                    MessageBox.Show("El pago debe ser mayor al total a pagar");
                    txt_valor.Focus();
                }

                if (Opc2 == "int")
                {
                    valor = Convert.ToInt32(txt_valor.Text);
                    this.Close();
                }
                if (Opc2 == "string")
                {
                    valor3 = txt_valor.Text;
                    this.Close();
                }


                if (Opc2 == "intEliminarRegistro")
                {
                    
                    valor = Convert.ToInt32(txt_valor.Text);
                    if (valor > valor5) {
                        MessageBox.Show("Capture un registro Existente en la venta");
                    }
                    else {
                        this.Close();
                    }
                        
                }

            }
            else
            {
                MessageBox.Show( "no se acepta valores en 0","Captura");
                txt_valor.Focus();
            }
        }
        private void BtSi_Click(object sender, RoutedEventArgs e)
        {
            aceptar();
        }

        private void BtNo_Click(object sender, RoutedEventArgs e)
        {
            valor = 0;
            valor2 = 0;
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
                valor2 = 0;
                valor3 = "0";
                this.Close();


            }




        }

        #endregion

        private void txt_valor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                aceptar();
               

            }
        }
    }
}
