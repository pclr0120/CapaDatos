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
    /// Lógica de interacción para Mesaje.xaml
    /// </summary>
    public partial class Mesaje : Window
    {
        public bool Si { get; set; }


        public Mesaje(string Titulo,string mens)
        {
            InitializeComponent();
            lblMensajeT.Content = Titulo;
            lblMensajeM.Content = mens;
        }

        private void BtSi_Click(object sender, RoutedEventArgs e)
        {
            Si = true;
            this.Close();
        }

        private void BtNo_Click(object sender, RoutedEventArgs e)
        {
            Si = false;
            this.Close();
        }
    }
}
