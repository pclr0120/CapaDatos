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
        CapaLogica.Puesto P = new CapaLogica.Puesto();
        CapaLogica.Usuarios U = new CapaLogica.Usuarios();
        

        

        public Formulario_Principal()
        {
            InitializeComponent();

            
        }

        Modulo_Empleados.Empleados Empleados = new Modulo_Empleados.Empleados();
        Modulo_Clientes.Clientes Clientes = new Modulo_Clientes.Clientes();
        Modulo_Equipo.Modulo_Equipo Equipo = new Modulo_Equipo.Modulo_Equipo();
        Modulo_Inventario.Inventario Inventario = new Modulo_Inventario.Inventario();
        public Modulo_Config.Configuraciones Configuraciones = new Modulo_Config.Configuraciones();
        Inicio.Inicio Ventana_Inicio = new Inicio.Inicio();
  
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
            Modulo_Config.Confirm_User Configuracion = new Modulo_Config.Confirm_User(this);
            DataRow row = E.EmpleadoBuscarDatos(Convert.ToInt32(ID)).Rows[0]; //La variable --row-- recive una tabla con todos los datos del empleado a modificar
            Configuracion.txt_puesto.Text = row["Tipo"].ToString();
            Configuracion.txt_nombre.Text = lbl_usuario.Text;
            Configuracion.ShowDialog();
            if (Configuracion.valor == 1)
            {
                Configuraciones.MdiParent = this;
                Configuraciones.WindowState = FormWindowState.Maximized;
                Configuraciones.TabControl_Config.Dock = DockStyle.Fill;
                Configuraciones.Dock = DockStyle.Fill;
                Configuraciones.dgv_usuarios.DataSource = U.UsuarioBuscar();
                Configuraciones.Show();
            }
            
        }
        
        private void Formulario_Principal_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
            DataRow row = L.LoginDatosUsuario(ID).Rows[0]; //La variable --row-- recive una tabla con todos los datos del usurio logeado
            lbl_usuario.Text = row["Nom"].ToString() + " " + row["App"].ToString() + " " + row["Apm"].ToString(); //Concateno solo las columnas del nombre en el lbl_usuario
            rb_inicio.Checked = true;
            SpotifyOff();
        }
        
        void SpotifyOn()
        {
            Ventana_Inicio.MdiParent = this;
            Ventana_Inicio.WindowState = FormWindowState.Maximized;
            Ventana_Inicio.Dock = DockStyle.Fill;
            Ventana_Inicio.group.Visible = false;
            Ventana_Inicio.btn_play.Visible = true;
            Ventana_Inicio.btn_next.Visible = true;
            Ventana_Inicio.btn_previous.Visible = true;
            Ventana_Inicio.Show();
        }

        void SpotifyOff()
        {
            Ventana_Inicio.MdiParent = this;
            Ventana_Inicio.WindowState = FormWindowState.Maximized;
            Ventana_Inicio.Dock = DockStyle.Fill;
            Ventana_Inicio.group.Visible = true;
            Ventana_Inicio.btn_play.Visible = false;
            Ventana_Inicio.btn_next.Visible = false;
            Ventana_Inicio.btn_previous.Visible = false;
            Ventana_Inicio.Show();
        }

        private void lbl_control_sesion_Click(object sender, EventArgs e)
        {
            Modulo_Empleados.INTERFAZ_PRINCIPAL.LOGIN.Warning adver = new Modulo_Empleados.INTERFAZ_PRINCIPAL.LOGIN.Warning();
            adver.Show();
        }

        private void rb_equipo_CheckedChanged(object sender, EventArgs e)
        {
            Equipo.MdiParent = this;
            Equipo.WindowState = FormWindowState.Maximized;
            Equipo.Dock = DockStyle.Fill;
            Equipo.Show();
        }

        private void rb_inventario_CheckedChanged(object sender, EventArgs e)
        {
            Inventario.MdiParent = this;
            Inventario.WindowState = FormWindowState.Maximized;
            Inventario.Dock = DockStyle.Fill;
            Inventario.Show();
        }
        bool SpotifyFlag = false;
        private void rb_inicio_CheckedChanged(object sender, EventArgs e)
        {
            if (SpotifyFlag)
            {
                SpotifyOn();
            }
            else SpotifyOff();
        }
    }
}
