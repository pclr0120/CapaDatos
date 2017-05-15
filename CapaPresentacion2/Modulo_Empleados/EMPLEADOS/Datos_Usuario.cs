using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_Empleados
{
    public partial class Datos_Usuario : Form
    {
        public Datos_Usuario()
        {
            InitializeComponent();
        }

        public int respuesta;

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            respuesta = 1;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            respuesta = 0;
            this.Close();
        }
    }
}
