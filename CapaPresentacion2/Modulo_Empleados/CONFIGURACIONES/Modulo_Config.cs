using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace Modulo_Config
{
    public partial class Configuraciones : Form
    {
        public Configuraciones()
        {
            InitializeComponent();
        }

        CapaLogica.Usuarios User = new Usuarios();
        CapaLogica.Empleados E = new Empleados();

        private void Configuraciones_Load(object sender, EventArgs e)
        {

        }


        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            TabControl_Config.SelectedTab = TabConfig_Usuario;
            lbl_accion1.Text = "REGISTRAR NUEVO USUARIO";
            lbl_accion2.Text = "NUEVO USUARIO Y PRIVILEGIOS EN EL SISTEMA";
            lbl_empleado.Visible = true;
            cbx_empleado.Visible = true;
            btn_empleado.Visible = true;
            cbx_empleado.DisplayMember = "Nombre";
            cbx_empleado.DataSource = User.Usuario_ObtenerEmpleado();
        }

        int ID;
        private void btn_empleado_Click(object sender, EventArgs e)
        {
            int espacio;
            espacio = cbx_empleado.Text.IndexOf(" ");
            //MessageBox.Show(Convert.ToString(espacio));
            ID = Convert.ToInt16(cbx_empleado.Text.Substring(0, espacio));
            //MessageBox.Show(Convert.ToString(ID));

            if (User.UsuarioNo(ID) == 1)
            {
                MessageBox.Show("El empleado seleccionado ya cuenta con un usuario asignado");
            }
            else
            {
                DataRow row = E.EmpleadoBuscarDatos(ID).Rows[0];
                gbx_empleado.Visible = true;
                gbx_permisos.Visible = true;
                gbx_contra.Visible = true;
                btn_negar.Visible = true;
                btn_permitir.Visible = true;
                btn_ok.Visible = true;
                lbl_id.Text = row["IdEmpleado"].ToString();
                lbl_nombre.Text = row["Nombre"].ToString();
                lbl_app.Text = row["App"].ToString();
                lbl_apm.Text = row["Apm"].ToString();
                lbl_puesto.Text = row["Tipo"].ToString();
            }
        }

        private void btn_negar_Click(object sender, EventArgs e)
        {
            Negar();
        }

        private void Negar()
        {
            cbx_punto.Checked = false;
            cbx_inv.Checked = false;
            cbx_clientes.Checked = false;
            cbx_equipo.Checked = false;
            cbx_emple.Checked = false;
            cbx_config.Checked = false;
        }
        private void btn_permitir_Click(object sender, EventArgs e)
        {
            cbx_punto.Checked = true;
            cbx_inv.Checked = true;
            cbx_clientes.Checked = true;
            cbx_equipo.Checked = true;
            cbx_emple.Checked = true;
            cbx_config.Checked = true;
        }

        public void UsuarioRegMod(int Punto_vta, int Inv, int Clientes, int Equipo, int Empleados, int Config)
        {
            DataRow row = E.EmpleadoBuscarDatos(ID).Rows[0];
            if (btn_ok.Text == "REGISTRAR")
            {
                if (txt_pass.TextLength > 3 & txt_pass.TextLength < 10 & txt_pass.Text != " ")
                {
                    if (txt_pass.Text != txt_pass2.Text)
                    {
                        lbl_nocoin.Visible = true;
                    }
                    else
                    {

                        try
                        {
                            User.UsuarioRegistrar(ID, lbl_nombre.Text.Trim(), lbl_app.Text.Trim(), lbl_apm.Text, row["Telefono"].ToString(), txt_pass2.Text.Trim(), Punto_vta, Inv, Clientes, Equipo, Empleados, Config);
                            MessageBox.Show("Empleado registrado correctamente");
                            TabControl_Config.SelectedTab = TabConfig_Lista;
                            dgv_usuarios.DataSource = User.UsuarioBuscar();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Ocurrio un error al registrar.");
                        }
                    }
                }
                else MessageBox.Show("Ingrese una contraseña para el usuario válida");
            }
            else
            {
                if (gbx_contra.Visible == true)
                {
                    if (txt_pass.TextLength >= 3 & txt_pass.TextLength < 10 & txt_pass.Text != " ")
                    {
                        if (txt_pass.Text != txt_pass2.Text)
                        {
                            lbl_nocoin.Visible = true;
                        }
                        else
                        {
                            try
                            {
                                User.UsuarioModificar(ID, txt_pass2.Text.Trim(), Punto_vta, Inv, Clientes, Equipo, Empleados, Config);
                                MessageBox.Show("Empleado modificado correctamente");
                                TabControl_Config.SelectedTab = TabConfig_Lista;
                                dgv_usuarios.DataSource = User.UsuarioBuscar();
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Ocurrio un error al modificar.");
                            }
                        }
                    }
                    else MessageBox.Show("Ingrese una contraseña para el usuario válida");
                }
                else
                {
                    try
                    {
                        DataRow rowUsuario = User.UsuarioBuscarDatos(ID).Rows[0];
                        //MessageBox.Show(rowUsuario["Pass"].ToString());
                        User.UsuarioModificar(ID, rowUsuario["Pass"].ToString(), Punto_vta, Inv, Clientes, Equipo, Empleados, Config);
                        MessageBox.Show("Empleado modificado correctamente");
                        TabControl_Config.SelectedTab = TabConfig_Lista;
                        dgv_usuarios.DataSource = User.UsuarioBuscar();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocurrio un error al modificar.");
                    }
                }
            }
            
        }

        private void LimpiarTodo()
        {
            gbx_empleado.Visible = false;
            gbx_permisos.Visible = false;
            gbx_contra.Visible = false;
            btn_negar.Visible = false;
            btn_permitir.Visible = false;
            btn_ok.Visible = false;
            lbl_nocoin.Visible = false;
            btn_pass.Visible = false;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
                    lbl_nocoin.Visible = false;
                    int punto = 0, inv = 0, clientes = 0, equipo = 0, emple = 0, config = 0;
                    if (cbx_punto.Checked == true) { punto = 1; }
                    if (cbx_inv.Checked == true) { inv = 1; }
                    if (cbx_clientes.Checked == true) { clientes = 1; }
                    if (cbx_equipo.Checked == true) { equipo = 1; }
                    if (cbx_emple.Checked == true) { emple = 1; }
                    if (cbx_config.Checked == true) { config = 1; }
                    UsuarioRegMod(punto, inv, clientes, equipo, emple, config);
                    LimpiarTodo();
                    Negar();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dgv_usuarios.SelectedRows.Count == 1)
            {
                //Obtengo todos los datos del empleado en una  tabla
                DataRow rowEmpleado = E.EmpleadoBuscarDatos(Convert.ToInt32(dgv_usuarios.CurrentRow.Cells[0].Value)).Rows[0]; //La variable --row-- recive una tabla con todos los datos del empleado a modificar
                DataRow rowUsuario = User.UsuarioBuscarDatos(Convert.ToInt32(dgv_usuarios.CurrentRow.Cells[0].Value)).Rows[0]; //La variable --row-- recive una tabla con todos los datos del empleado a modificar
                //Relleno todos los datos del formulario con los datos de la tabla obtenida
                gbx_empleado.Visible = true;
                lbl_empleado.Visible = false;
                cbx_empleado.Visible = false;
                btn_empleado.Visible = false;
                gbx_permisos.Visible = true;
                btn_pass.Visible = true;
                btn_ok.Visible = true;
                btn_negar.Visible = true;
                btn_permitir.Visible = true;
                lbl_accion1.Text = "MODIFICAR EMPLEADO";
                lbl_accion2.Text = "MOFIFIQUE LOS PRIVILEGIOS DEL USUARIO";
                btn_ok.Text = "MODIFICAR EMPLEADO";
                ID = Convert.ToInt32(rowEmpleado["IdEmpleado"].ToString());
                lbl_id.Text = rowEmpleado["IdEmpleado"].ToString();
                lbl_nombre.Text = rowEmpleado["Nombre"].ToString();
                lbl_app.Text = rowEmpleado["App"].ToString();
                lbl_apm.Text = rowEmpleado["Apm"].ToString();
                lbl_puesto.Text = rowEmpleado["Tipo"].ToString();
                if (rowUsuario["Punto_vta"].ToString() == "1") { cbx_punto.Checked = true; }
                if (rowUsuario["Inventario"].ToString() == "1") { cbx_inv.Checked = true; }
                if (rowUsuario["Equipo"].ToString() == "1") { cbx_equipo.Checked = true; }
                if (rowUsuario["Clientes"].ToString() == "1") { cbx_clientes.Checked = true; }
                if (rowUsuario["Empleados"].ToString() == "1") { cbx_emple.Checked = true; }
                if (rowUsuario["Config"].ToString() == "1") { cbx_config.Checked = true; }
                TabControl_Config.SelectedTab = TabConfig_Usuario; //Cambio de Tab
            }
            else
                MessageBox.Show("Debe seleccionar un usuario para modificar sus datos.");
        }

        private void btn_pass_Click(object sender, EventArgs e)
        {
            gbx_contra.Visible = true;
        }

        private void btn_retorno3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea salir?" + Environment.NewLine + "Si usted lo hace se perderán todos los datos ingresados", "Cancelar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                TabControl_Config.SelectedTab = TabConfig_Lista;
                Negar();
                LimpiarTodo();
            }
            else if (result == DialogResult.No) { }
            
        }

        private void UsuarioAlta()
        {
            if (dgv_usuarios.SelectedRows.Count == 1)
            {
                if (Convert.ToString(dgv_usuarios.CurrentRow.Cells[5].Value) == "I")
                {
                    
                    User.UsuarioAlta(Convert.ToInt32(dgv_usuarios.CurrentRow.Cells[0].Value));
                    dgv_usuarios.DataSource = User.UsuarioBuscar();
                    MessageBox.Show("Empleado dado de ALTA exitosamente.");
                }
                else
                    MessageBox.Show("Debe seleccionar un empleado INACTIVO para darlo de alta.");
            }
            else
                MessageBox.Show("Debe seleccionar un solo usuario para darlo de alta.");
        }

        private void UsuarioBaja()
        {
            if (dgv_usuarios.SelectedRows.Count == 1)
            {
                if (Convert.ToString(dgv_usuarios.CurrentRow.Cells[5].Value) == "A")
                {
                    DialogResult result = MessageBox.Show("Está seguro que desea dar de BAJA a este usuario?" + Environment.NewLine + "Si usted desea continuar, el usuario perderá todos sus permisos", "GYMCENTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        User.UsuarioAlta(Convert.ToInt32(dgv_usuarios.CurrentRow.Cells[0].Value));
                        dgv_usuarios.DataSource = User.UsuarioBuscar();
                        MessageBox.Show("Empleado dado de BAJA exitosamente.");
                    }
                    else if (result == DialogResult.No) { }
                    
                }
                else
                    MessageBox.Show("Debe seleccionar un empleado ACTIVO para darlo de alta.");
            }
            else
                MessageBox.Show("Debe seleccionar un solo usuario para darlo de baja.");
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            UsuarioAlta();
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            UsuarioBaja();
        }
    }
}
