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

namespace CapaPresentacion
{
    /// <summary>
    /// Lógica de interacción para VincularMembreciaxaml.xaml
    /// </summary>
    public partial class VincularMembreciaxaml : Window
    {
        string mem;
        public VincularMembreciaxaml(string idmebrecia)
        {
            InitializeComponent();
            mem = idmebrecia;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        CapaLogica.VincularMembrecia v = new VincularMembrecia();
        void vincular() {
            v.Vincular(txtCodigo.Content.ToString(),mem);

        }
    }
}
