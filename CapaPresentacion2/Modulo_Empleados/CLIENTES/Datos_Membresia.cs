using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_Empleados.CLIENTES
{
    public partial class Datos_Membresia : Form
    {
        public Datos_Membresia()
        {
            InitializeComponent();
        }

        public int respuesta = 0;

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            respuesta = 0;
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            respuesta = 1;
            this.Close();
        }

        private void Datos_Membresia_KeyUp(object sender, KeyEventArgs e)
        {
            if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F1))) 
            {
                respuesta = 1;
                this.Close();
            }
            else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Escape)))
            {
                respuesta = 0;
                this.Close();
            }
        }
    }
}
