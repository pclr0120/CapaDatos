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
    /// Lógica de interacción para MensajeOk.xaml
    /// </summary>
    public partial class MensajeOk : Window
    {
        public MensajeOk(string titulo,string mensaje)
        {
            InitializeComponent();
            lblMensajeT.Content = titulo;
            lblMensajeM.Content = mensaje;
        }

        private void BtSi_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
