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
        }

        private void rb_clave_CheckedChanged(object sender, EventArgs e)
        {
            txt_curp.Enabled = false;
            txt_clave_empleado.Enabled = true;
        }

        private void ABC_Empleados_Load(object sender, EventArgs e)
        {
            rb_curp.Checked = true;
            txt_clave_empleado.Enabled = false;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {

        }
    }
}
