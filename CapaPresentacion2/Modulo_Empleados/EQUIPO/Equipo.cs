using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_Equipo
{
    public partial class Modulo_Equipo : Form
    {
        public Modulo_Equipo()
        {
            InitializeComponent();
        }

        private void Modulo_Equipo_Load(object sender, EventArgs e)
        {
            TabControl_Equipo.Dock = DockStyle.Fill;
        }

        private void btn_clasif_Click(object sender, EventArgs e)
        {
            TabControl_Equipo.SelectedTab = TabEquipo_Clas_Lista;
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            TabControl_Equipo.SelectedTab = TabEquipo_Reportes;
        }

        private void btn_retorno4_Click(object sender, EventArgs e)
        {
            TabControl_Equipo.SelectedTab = TabEquipo_Lista;
        }

        private void TabEquipo_Lista_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea salir?" + Environment.NewLine + "Si usted lo hace se perderán todos los datos ingresados", "Cancelar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                TabControl_Equipo.SelectedTab = TabEquipo_Lista;
            }
            else if (result == DialogResult.No) { }
        }
    }
}
