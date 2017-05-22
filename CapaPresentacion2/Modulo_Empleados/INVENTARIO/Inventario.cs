using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_Inventario
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            TabControl_Inventario.Dock = DockStyle.Fill;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea salir?" + Environment.NewLine + "Si usted lo hace se perderán todos los datos ingresados", "Cancelar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                TabControl_Inventario.SelectedTab = TabInv_Lista;
            }
            else if (result == DialogResult.No) { }
        }

        private void btn_retorno4_Click(object sender, EventArgs e)
        {
            TabControl_Inventario.SelectedTab = TabInv_Lista;
        }

        private void btn_clas_prod_Click(object sender, EventArgs e)
        {
            TabControl_Inventario.SelectedTab = TabInv_Clas_Lista;
        }

        private void TabNuevo_prod_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_surtir_Click(object sender, EventArgs e)
        {
            TabControl_Inventario.SelectedTab = TabInv_surtir;
        }

        private void btn_regis_prod_Click(object sender, EventArgs e)
        {
            TabControl_Inventario.SelectedTab = TabInv_nuevo_prod;
        }
    }
}
