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
    public partial class ABC_Empleados : Form
    {
        public ABC_Empleados()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rb_lista_CheckedChanged(object sender, EventArgs e)
        {
            txt_curp.Enabled = false;
            txt_clave_empleado.Enabled = false;
        }

        private void rb_curp_CheckedChanged(object sender, EventArgs e)
        {
            txt_curp.Enabled = true;
            txt_clave_empleado.Enabled = false;
            txt_curp.Focus();
        }

        private void rb_clave_CheckedChanged(object sender, EventArgs e)
        {
            txt_curp.Enabled = false;
            txt_clave_empleado.Enabled = true;
            txt_clave_empleado.Focus();
        }

        private void ABC_Empleados_Load(object sender, EventArgs e)
        {
            rb_curp.Checked = true;
            txt_clave_empleado.Enabled = false;
            txt_curp.Focus();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Datos_Usuario Confirmar = new Datos_Usuario();
            Confirmar.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_clave_empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //Valido que al dar enter sea como dar siguiente
            {
                //Insertar codigo
            }
            else if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) //Valido solo numeros y teclas de control sean permitidas
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
