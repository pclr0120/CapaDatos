using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modulo_Empleados;


namespace EMBLEMA
{
    public partial class Formulario_Principal : Form
    {
        public int ID;

        public Formulario_Principal()
        {
            InitializeComponent();
        }
        Modulo_Empleados.Empleados Empleados = new Modulo_Empleados.Empleados();

 
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea salir?", "GYMCENTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                //this.Close();
                Application.Exit();
            }
            else if (result == DialogResult.No) { }
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void rb_inicio_CheckedChanged(object sender, EventArgs e)
        {
            //TabControlPrincipal.SelectedTab = tabPage_inicio;
            //Modulo_Empleados.Empleados newMDIChild = new Modulo_Empleados.Empleados();
            // Set the parent form of the child window.
            //newMDIChild.MdiParent = this;
            // Display the new form.
            //newMDIChild.Show();
            
        }

        private void rb_punto_vta_CheckedChanged(object sender, EventArgs e)
        {
            //TabControlPrincipal.SelectedTab = tabPage_pto_vta;
        }

        private void rb_membre_CheckedChanged(object sender, EventArgs e)
        {
            //TabControlPrincipal.SelectedTab = tabPage_membre;
        }

        private void rb_equipo_CheckedChanged(object sender, EventArgs e)
        {
            //TabControlPrincipal.SelectedTab = tabPage_equipo;
        }

        private void rb_empleados_CheckedChanged(object sender, EventArgs e)
        {
            Empleados.MdiParent = this;
            Empleados.WindowState = FormWindowState.Maximized;
            Empleados.Dock = DockStyle.Fill;
            Empleados.Show();
        }

        private void rb_config_CheckedChanged(object sender, EventArgs e)
        {
            //TabControlPrincipal.SelectedTab = tabPage_config;
        }
        
        

        private void Formulario_Principal_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
            lbl_id.Text = Convert.ToString(ID);
        }

       

        private void lbl_control_sesion_Click(object sender, EventArgs e)
        {
            Modulo_Empleados.INTERFAZ_PRINCIPAL.LOGIN.Warning adver = new Modulo_Empleados.INTERFAZ_PRINCIPAL.LOGIN.Warning();
            adver.Show();
        }

        private void lbl_iniciar_Click(object sender, EventArgs e)
        {
            LOGIN.Login ingreso = new LOGIN.Login();
            ingreso.Show();
        }
    }
}
