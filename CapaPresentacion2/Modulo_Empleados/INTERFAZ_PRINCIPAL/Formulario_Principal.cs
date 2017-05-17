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
using CapaLogica;


namespace EMBLEMA
{
    public partial class Formulario_Principal : Form
    {
        public int ID;
        CapaLogica.Empleados E = new CapaLogica.Empleados();
        CapaLogica.Login L = new CapaLogica.Login();

        public Formulario_Principal()
        {
            InitializeComponent();
        }
        Modulo_Empleados.Empleados Empleados = new Modulo_Empleados.Empleados();
        Modulo_Clientes.Clientes Clientes = new Modulo_Clientes.Clientes();


        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void rb_empleados_CheckedChanged(object sender, EventArgs e)
        {
            Empleados.MdiParent = this;
            Empleados.WindowState = FormWindowState.Maximized;
            Empleados.Dock = DockStyle.Fill;
            Empleados.TabControl_Empleados.SelectedTab = Empleados.TabEmpleados_Lista;
            Empleados.dgv_e.DataSource = E.EmpleadoBuscar();
            Empleados.Show();
        }
        private void rb_membre_Click(object sender, EventArgs e)
        {
            Clientes.MdiParent = this;
            Clientes.WindowState = FormWindowState.Maximized;
            Clientes.Dock = DockStyle.Fill;
            Clientes.TabControl_Clientes.SelectedTab = Clientes.TabClientes_Lista;
            Clientes.Show();
        }
        private void rb_config_CheckedChanged(object sender, EventArgs e)
        {
            //TabControlPrincipal.SelectedTab = tabPage_config;
        }
        
        

        private void Formulario_Principal_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
            DataRow row = L.LoginDatosUsuario(ID).Rows[0]; //La variable --row-- recive una tabla con todos los datos del usurio logeado
            lbl_usuario.Text = row["Nom"].ToString() + " " + row["App"].ToString() + " " + row["Apm"].ToString(); //Concateno solo las columnas del nombre en el lbl_usuario
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
    }
}
