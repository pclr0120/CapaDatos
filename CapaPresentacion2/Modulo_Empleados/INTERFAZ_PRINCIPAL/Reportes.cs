using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_Empleados.INTERFAZ_PRINCIPAL
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            tabControl_Reportes.Dock = DockStyle.Fill;
            rb_punto_vta.Checked = true;
        }

        private void rb_punto_vta_CheckedChanged(object sender, EventArgs e)
        {
            tabControl_Reportes.SelectedTab = tab_punto;
        }

        private void rb_inventario_CheckedChanged(object sender, EventArgs e)
        {
            tabControl_Reportes.SelectedTab = tab_inv;
        }

        private void rb_membre_CheckedChanged(object sender, EventArgs e)
        {
            tabControl_Reportes.SelectedTab = tab_clientes;
        }

        private void rb_equipo_CheckedChanged(object sender, EventArgs e)
        {
            tabControl_Reportes.SelectedTab = tab_equipo;
        }

        private void rb_empleados_CheckedChanged(object sender, EventArgs e)
        {
            tabControl_Reportes.SelectedTab = tab_empleados;
        }
    }
}
