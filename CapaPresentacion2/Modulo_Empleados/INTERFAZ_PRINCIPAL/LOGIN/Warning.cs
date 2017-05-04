using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOGIN;
using System.Threading;
using EMBLEMA;

namespace Modulo_Empleados.INTERFAZ_PRINCIPAL.LOGIN
{
    public partial class Warning : Form
    {
        public Warning()
        {
            InitializeComponent();
        }
        int a = 0;
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            pb_progress.Visible = true;
            lbl_cerrando.Visible = true;
            //Formulrio ---- Soy un comentario
            Formulario_Principal frp =  new Formulario_Principal();
            frp.Close();
            timer1.Start();
        }

        private void exe()
        {
            Login Sesion = new Login();
            Sesion.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (a < 30) a++;
            else
            {
                exe();
                timer1.Stop();
                this.Close();
            }
        }

        private void Warning_Load(object sender, EventArgs e)
        {
            a = 0;
        }
    }
}
