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
    /// Lógica de interacción para VincularMembreciaxaml.xaml
    /// </summary>
    public partial class VincularMembreciaxaml : Window
    {
        int mem;
        public string codigo { get; set; }
        public VincularMembreciaxaml()
        {
            InitializeComponent();
            txtCodigo.Focus();
          
        }
        bool bander = false;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            vincular();

        }


        CapaLogica.VincularMembrecia v = new VincularMembrecia();
        bool b = false;
      
        void vincular() {
            b = false;
            if (txtCodigo.Text.Length > 0 && txtCodigo_Copy.Text.Length > 0)
            {
                DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();
                DataTable dt3 = new DataTable();


                try
                {
                  
                    dt2 = v.buscarTipoNombremembrecia(txtCodigo_Copy.Text);

                    if (dt2.Rows.GetEnumerator().MoveNext())
                    {
                     
                            dt3 = v.buscarTipoMembrecia(dt2.Rows[0][0].ToString());
                        if (dt2!=null) {
                            if (dt2.Rows.Count > 0) {
                                try
                                {
                                    mem = Convert.ToInt32(dt3.Rows[0][0]);
                                    b = true;
                                }
                                catch (Exception e) {
                  
                                }
                                
                             
                            }
                        }
                        
                    }
                }
                catch (Exception e) {
                    MessageBox.Show(e.ToString());
                }
                if (b)
                {
                    dt = v.buscarCliente(txtCodigo.Text);
                    if (dt.Rows.GetEnumerator().MoveNext())
                    {
                        string usuario = dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString() + " " + dt.Rows[0][3].ToString();
                        Mensaje.Mesaje confir = new Mensaje.Mesaje("NOTIFICACION", "Cliente:" + usuario + ". Es correcto?", "SI F1", "NO F2");
                        confir.ShowDialog();


                        if (confir.Si)
                        {


                            if (v.Vincular(Convert.ToInt32(dt.Rows[0][0]), mem) == 1)
                            {

                                MessageBox.Show("LA vinculacion se realizara cuando se realize la venta");
                                codigo = txtCodigo_Copy.Text;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Error");
                            }

                        }

                        else
                        {
                            MessageBox.Show("Capture los dos campos para continuar");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontro  ningun cliente con ese codigo.");
                    }
                }
                else {
                    MessageBox.Show("membresia no encontrada");
                }
            }
            else
            {
                MessageBox.Show("Capture los dos campos para continuar");
            }


        }

        private void txtCodigo_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtCodigo_Copy_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            SoloNumeros(e);
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

        private void txtCodigo_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {

                txtCodigo_Copy.Focus();

            }
        }

        private void txtCodigo_Copy_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && txtCodigo.Text.Length>0)
            {

                vincular();

            }
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

                    vincular();


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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
