using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_Inventario.mensajes
{
    public partial class mensajeConfirmacion : Form
    {

        public bool valor { get; set; }
        string bt11, bt22, textt, stock;

        private void mensajeConfirmacion_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((int)e.KeyChar == (int)Keys.F1)
            {

                valor = true;
                this.Close();
            }
            if ((int)e.KeyChar == (int)Keys.F2)
            {
                valor = false;
                this.Close();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valor = true;
            this.Close();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            valor = false;
            this.Close();
        }

        public mensajeConfirmacion(string texto,string b1, string b2,string valorr)
        {
            InitializeComponent();
            label1.Text = texto+valorr;
            button1.Text = b1;
            button2.Text = b2;


            
            
        }

    }
}
