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

namespace CapaPresentacion.VENTA
{
    /// <summary>
    /// Lógica de interacción para ConsultaProducto.xaml
    /// </summary>
    public partial class ConsultaProducto : Window
    {
        Producto p = new Producto();
        private DataTable tablap = new DataTable();
        public ConsultaProducto()
        {
           
            InitializeComponent();
            txtProducto.Focus();
           
            tablap = p.ConsultaProductoDetalle("0");
            dataGrid.ItemsSource = p.ConsultaDetallePProducto("0");
            txtProducto.Text = "";
        }

        void filtro()
        {

           
            tablap.DefaultView.RowFilter = "Codigo LIKE '%" + txtProducto.Text + "%'";
            dataGrid.ItemsSource = tablap.DefaultView;
            dataGrid.Items.Refresh();
          
        }

        private void txtProducto_TextChanged(object sender, TextChangedEventArgs e)
        {
            filtro();
        }
        public void EvaluarTecla(object sender, KeyEventArgs e)
        {
            if (Key.F1 == e.Key)
            {
                this.Close();
            }
         

        


        }

        private void txtProducto_KeyDown(object sender, KeyEventArgs e)
        {
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

        private void txtProducto_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
