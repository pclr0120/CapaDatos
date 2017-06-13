using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_Empleados.INTERFAZ_PRINCIPAL.LOGIN
{
    public partial class EnviarEmail : Form
    {
        public EnviarEmail()
        {
            InitializeComponent();
        }

        private void btn_enviar_email_Click(object sender, EventArgs e)
        {
            enviarEmail();
        }

        public void enviarEmail()
        {
            if (txt_email.Text == "")
            {
                MessageBox.Show("Debe ingresar una direccion de correo valida");
                txt_email.Focus();
            }
            else
            {
                MessageBox.Show("Se ha enviado un correo con sus datos");
                this.Close();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea salir?" + Environment.NewLine + "Si usted lo hace se perderán todos los datos ingresados", "Cancelar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if (result == DialogResult.No) { }
        }

        private void EnviarEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F1)))
            {
                enviarEmail();
            }
            else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F2)))
            {
                this.Close();
            }
        }
    }
}
