using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EMBLEMA;
using CapaLogica;
using ProyectoP;

namespace Modulo_Empleados
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        //Variables que se utilizan en todo el codigo
        string accion;
        Puesto P = new Puesto();
        CapaLogica.Empleados E = new CapaLogica.Empleados();
        int ID;
        string Nom_puesto;
        public int Id_modificar;
        string[] DatosE = new string[12];
        string[] DatosP = new string[4];


        private void btn_cambiar_foto_Click(object sender, EventArgs e)
        {
            // Se crea el OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                pb_foto_nvo_empleado.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void btn_nuevo_empleado_Click(object sender, EventArgs e)
        {

        }

        private void btn_retorno_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea salir?" + Environment.NewLine + "Si usted lo hace se perderán todos los datos ingresados", "Cancelar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                TabControl_Empleados.SelectedTab = TabEmpleados_Lista;
            }
            else if (result == DialogResult.No) { }
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            TabControl_Empleados.Dock = DockStyle.Fill;
        }

        private void btn_lista_empleado_Click(object sender, EventArgs e)
        {
            TabControl_Empleados.SelectedTab = TabEmpleados_Lista;
            dgv_e.DataSource = E.EmpleadoBuscar();
        }

        /**************** NOTA IMPORTANTE ****************
         El fomulario utlizado en estas opciones es el mismo.
         Se deberá encontrar manera de modificar su función de acuerdo a sus necesidades
         La variable accion podría hacer eso */
        private void btn_mod_empleado_Click(object sender, EventArgs e)
        {
            
        }
      
        private void btn_baja_empleado_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_nvo_puesto_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_puesto_lista_Click(object sender, EventArgs e)
        {
            TabControl_Empleados.SelectedTab = TabPuesto_Lista;
            dgv_puestos.DataSource = P.PuestoBuscar();
        }

        private void btn_retorno2_Click(object sender, EventArgs e)
        {
            TabControl_Empleados.SelectedTab = TabEmpleados_Lista;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(0,0,0,0,0,e);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PuestoEntradaRegistrar();
        }

        private void TabPuesto_Lista_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedValueChanged(object sender, EventArgs e)
        {
            PuestoFiltro();
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            PuestoEntradaModificar();
        }
        
        private void btn_alta_Click(object sender, EventArgs e)
        {
            PuestoAlta();
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            PuestoBaja();
        }

        private void txt_buscar_puesto_TextChanged(object sender, EventArgs e)
        {
            dgv_puestos.DataSource = P.PuestoBuscarNombre(txt_buscar_puesto.Text);
        }

        private void txt_buscar_puesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1, 0, 1, 0, 1, e);
        }

        private void txt_nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1,0,1,0,0,e);
        }

        private void txt_nom_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1, 0, 1, 0, 1, e);
        }

        private void txt_sueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1,1,0,0,0,e);
        }

        private void txt_num_vac_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1,0,0,0,0,e);
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            PuestoRegistrar();
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1, 0, 1, 0, 1, e);
        }

        private void txt_numero_vacantes_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1,0,0,0,0,e);
        }

        private void txt_sueld_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1,1,0,0,0,e);
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            PuestoModificar();
        }

        private void oval_Button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea salir?" + Environment.NewLine + "Si usted lo hace se perderán todos los datos ingresados", "Cancelar Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                TabControl_Empleados.SelectedTab = TabPuesto_Lista;
            }
            else if (result == DialogResult.No) { }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea salir?" + Environment.NewLine + "Si usted lo hace se perderán todos los datos ingresados", "Cancelar Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                TabControl_Empleados.SelectedTab = TabPuesto_Lista;
            }
            else if (result == DialogResult.No) { }
        }

        private void cb_filtro_e_SelectedValueChanged(object sender, EventArgs e)
        {
            EmpleadoFiltro();
        }

        private void cb_filtro_e_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(0,0,0,0,0,e);
        }

        private void txt_buscar_e_TextChanged(object sender, EventArgs e)
        {
            dgv_e.DataSource = E.EmpleadoBuscarNombre(txt_buscar_e.Text);
        }

        private void txt_buscar_e_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1, 0, 1, 0, 1, e);
        }

        private void btn_alta_e_Click(object sender, EventArgs e)
        {
            EmpleadoAlta();
        }

        private void btn_baja_e_Click(object sender, EventArgs e)
        {
            EmpleadoBaja();
        }

        private void btn_reg_e_Click(object sender, EventArgs e)
        {
            EmpleadoEntradaRegistro();
        }

        private void btn_mod_e_Click(object sender, EventArgs e)
        {
            //ESTE CODIGO NUNCA SE USA

            //TabControlEmpleados.SelectedTab = TabPuesto_Registro;
            /*Deberá mostrar un nuevo formulario donde se le permita al usuario elegir si ya cuenta
             con la C.U.R.P. del empleado o si desea encontrarlo en la lista de empleados*/
            ABC_Empleados ABC_Modificar = new ABC_Empleados();
            ABC_Modificar.lbl_accion.Text = "Modificar datos de empleado";
            accion = "M";
            ABC_Modificar.Show();
        }

        private void btn_puestos_Click(object sender, EventArgs e)
        {
            TabControl_Empleados.SelectedTab = TabPuesto_Lista;
            dgv_puestos.DataSource = P.PuestoBuscar();
        }

        private void oval_Button1_Click(object sender, EventArgs e)
        {
            TabControl_Empleados.SelectedTab = TabEmpleados_Lista;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TabControl_Empleados.SelectedTab = TabEmpleados_Lista;
        }

        private void btn_mod_e_Click_1(object sender, EventArgs e)
        {
            EmpleadoEntradaModificacion();
        }

        private void txt_nom_e_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1, 0, 1, 0, 1, e);
        }

        private void cb_puesto_e_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(0,0,0,0,0,e);
        }

        private void txt_app_e_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1, 0, 1, 0, 1, e);
        }

        private void txt_apm_e_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1, 0, 1, 0, 1, e);
        }

        private void txt_esc_e_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1, 0, 1, 0, 1, e);
        }

        private void txt_num_e_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(0,1,0,0,0,e);
        }

        private void txt_nom_e_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1, 0, 1, 0, 1, e);
        }

        private void txt_app_e_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1,0,1,0,1,e);
        }

        private void txt_apm_e_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1,0,1,0,1,e);
        }

        private void txt_esc_e_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1, 0, 1, 1, 1, e); 
        }

        private void txt_calle_e_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1, 1, 1, 1, 1, e);
        }

        private void txt_col_e_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1,1,1,1,1,e);
        }

        private void txt_num_e_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1, 1, 0, 0, 0, e);
        }

        private void cb_ciudad_e_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(0, 0, 0, 0, 0, e);
        }

        private void txt_tel_e_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(1,1,0,0,0,e);
        }

        private void cb_ent_e_SelectedValueChanged(object sender, EventArgs e)
        {
            cb_mun_e.DisplayMember = "Nombre";
            cb_mun_e.DataSource = E.EmpleadoBuscarMunicipio(cb_ent_e.Text);
            cb_ciudad_e.Text = "";
            cb_ciudad_e.DisplayMember = "Nombre";
            cb_ciudad_e.DataSource = E.EmpleadoBuscarCiudad(cb_ent_e.Text,cb_mun_e.Text);
        }

        private void cb_mun_e_SelectedValueChanged(object sender, EventArgs e)
        {
            cb_ciudad_e.Text = "";
            cb_ciudad_e.DisplayMember = "Nombre";
            cb_ciudad_e.DataSource = E.EmpleadoBuscarCiudad(cb_ent_e.Text, cb_mun_e.Text);
        }

        private void cb_ent_e_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(0, 0, 0, 0, 0, e);
        }

        private void cb_mun_e_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(0, 0, 0, 0, 0, e);
        }

        private void btn_registrar_e_Click(object sender, EventArgs e)
        {
            EmpleadoRegMod();
        }

        private void txt_nom_KeyUp(object sender, KeyEventArgs e)
        {
            ValidarPuestoDisponibleReg();
        }

        private void txt_nombre_KeyUp(object sender, KeyEventArgs e)
        {
            ValidarPuestoDisponibleMod();
        }

        private void cb_ciudad_e_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ValidarCaracteres(0,0,0,0,0,e);
        }
        
        private void TabControl_Empleados_KeyUp(object sender, KeyEventArgs e)
        {
            if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F1)) && TabControl_Empleados.SelectedTab == TabEmpleados_Lista) //TabEmpleados_Lista
            {
                EmpleadoEntradaRegistro();
            }
            else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F2)) && TabControl_Empleados.SelectedTab == TabEmpleados_Lista)
            {
                EmpleadoAlta();
            }
            else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F3)) && TabControl_Empleados.SelectedTab == TabEmpleados_Lista)
            {
                EmpleadoBaja();
            }
            else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F4)) && TabControl_Empleados.SelectedTab == TabEmpleados_Lista)
            {
                EmpleadoEntradaModificacion();
            }
            else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F5)) && TabControl_Empleados.SelectedTab == TabEmpleados_Lista)
            {
                TabControl_Empleados.SelectedTab = TabPuesto_Lista;
                dgv_puestos.DataSource = P.PuestoBuscar();
            }
            else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F1)) && TabControl_Empleados.SelectedTab == TabPuesto_Lista) //TabPuesto_Lista
            {
                PuestoEntradaRegistrar();
            }
            else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F2)) && TabControl_Empleados.SelectedTab == TabPuesto_Lista)
            {
                PuestoAlta();
            }
            else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F3)) && TabControl_Empleados.SelectedTab == TabPuesto_Lista)
            {
                PuestoBaja();
            }
            else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F4)) && TabControl_Empleados.SelectedTab == TabPuesto_Lista)
            {
                PuestoEntradaModificar();
            }
            else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F1)) && TabControl_Empleados.SelectedTab == TabEmpleados_Registro) //TabEmpleados_Registro
            {
                EmpleadoRegMod();
            }
            else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F1)) && TabControl_Empleados.SelectedTab == TabPuesto_Registro) //TabPuesto_Registro
            {
                PuestoRegistrar();
            }
            else if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F1)) && TabControl_Empleados.SelectedTab == TabPuesto_Mod) //TabPuesto_Mod
            {
                PuestoModificar();
            }
        }

        private void btn_retorno3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea salir?" + Environment.NewLine + "Si usted lo hace se perderán todos los datos ingresados", "Cancelar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                TabControl_Empleados.SelectedTab = TabPuesto_Lista;
            }
            else if (result == DialogResult.No) { }
        }

        //FUNCIONES PARA VALIDACIONES
        public void ValidarPuestoDisponibleMod()
        {
            if (P.PuestoBuscarCoincidenciaNombre(txt_nombre.Text) >= 1 && Nom_puesto != txt_nombre.Text)
            {
                lbl_msg_p2.ForeColor = Color.DarkRed;
                lbl_msg_p2.Text = "Nombre de puesto NO disponible";
            }
            else
            {
                lbl_msg_p2.ForeColor = Color.DarkGreen;
                lbl_msg_p2.Text = "Nombre de puesto disponible";
            }
        }

        public void ValidarPuestoDisponibleReg()
        {
            if (P.PuestoBuscarCoincidenciaNombre(txt_nom.Text) >= 1)
            {
                lbl_msg_p.ForeColor = Color.DarkRed;
                lbl_msg_p.Text = "Nombre de puesto NO disponible";
            }
            else
            {
                lbl_msg_p.ForeColor = Color.DarkGreen;
                lbl_msg_p.Text = "Nombre de puesto disponible";
            }
        }

        public void ValidarCaracteres(int Control, int Digit, int Letter, int Punto, int Separator, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) && Control == 1)
            {
                e.Handled = false;
            }
            else if (Char.IsDigit(e.KeyChar) && Digit == 1)
            {
                e.Handled = false;
            }
            else if (Char.IsLetter(e.KeyChar) && Letter == 1)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 46 && Punto == 1)
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar) && Separator == 1)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        //FUNCIONES PARA ACCIONES
        public void EmpleadoRegMod()
        {
            if (txt_nom_e.Text != "")
            {
                if (txt_app_e.Text != "")
                {
                    if (txt_apm_e.Text != "")
                    {
                        if (txt_esc_e.Text != "")
                        {
                            if (txt_calle_e.Text != "")
                            {
                                if (txt_col_e.Text != "")
                                {
                                    if (txt_num_e.Text != "")
                                    {
                                        if (txt_tel_e.Text != "")
                                        {
                                            if (btn_registrar_e.Text == "REGISTRAR NUEVO EMPLEADO")
                                            {
                                                try
                                                {
                                                    E.EmpleadoRegistrar(lbl_curp.Text, txt_nom_e.Text.Trim(), txt_app_e.Text.Trim(), txt_apm_e.Text.Trim(), cb_puesto_e.Text, txt_esc_e.Text.Trim(), txt_calle_e.Text.Trim(), txt_col_e.Text.Trim(), txt_num_e.Text.Trim(), cb_ciudad_e.Text, cb_mun_e.Text, cb_ent_e.Text, txt_tel_e.Text.Trim());
                                                    MessageBox.Show("Empleado registrado correctamente");
                                                    TabControl_Empleados.SelectedTab = TabEmpleados_Lista;
                                                    dgv_e.DataSource = E.EmpleadoBuscar();
                                                    cb_filtro.Text = "TODOS";
                                                }
                                                catch (Exception)
                                                {
                                                    MessageBox.Show("Ocurrio un error al registrar.");
                                                }
                                            }
                                            else
                                            {
                                                try
                                                {
                                                    if (txt_nom_e.Text != DatosE[0] || txt_app_e.Text != DatosE[1] || txt_apm_e.Text != DatosE[2] || cb_puesto_e.Text != DatosE[3] || txt_esc_e.Text != DatosE[4] || txt_calle_e.Text != DatosE[5] || txt_num_e.Text != DatosE[6] || txt_col_e.Text != DatosE[7] || cb_ent_e.Text != DatosE[8] || cb_mun_e.Text != DatosE[9] || cb_ciudad_e.Text != DatosE[10] || txt_tel_e.Text != DatosE[11])
                                                    {
                                                        E.EmpleadoModificar(ID, lbl_curp.Text, txt_nom_e.Text.Trim(), txt_app_e.Text.Trim(), txt_apm_e.Text.Trim(), cb_puesto_e.Text, txt_esc_e.Text.Trim(), txt_calle_e.Text.Trim(), txt_col_e.Text.Trim(), txt_num_e.Text.Trim(), cb_ciudad_e.Text, cb_mun_e.Text, cb_ent_e.Text, txt_tel_e.Text.Trim());
                                                        MessageBox.Show("Empleado modificado correctamente");
                                                        TabControl_Empleados.SelectedTab = TabEmpleados_Lista;
                                                        dgv_e.DataSource = E.EmpleadoBuscar();
                                                        cb_filtro.Text = "TODOS";
                                                    }
                                                    else
                                                        MessageBox.Show("Debe MODIFICAR ALGUN CAMPO para continuar con la operación.");
                                                }
                                                catch (Exception)
                                                {
                                                    MessageBox.Show("Ocurrio un error al modificar.");
                                                }
                                            }
                                        }
                                        else
                                            MessageBox.Show("Debe ingresar el TELEFONO del empleado para guardar sus datos.");
                                    }
                                    else
                                        MessageBox.Show("Debe ingresar el NUMERO DE CASA del empleado para guardar sus datos.");
                                }
                                else
                                    MessageBox.Show("Debe ingresar la COLONIA del empleado para guardar sus datos.");
                            }
                            else
                                MessageBox.Show("Debe ingresar la CALLE del empleado para guardar sus datos.");
                        }
                        else
                            MessageBox.Show("Debe ingresar la ESCOLARIDAD del empleado para guardar sus datos.");
                    }
                    else
                        MessageBox.Show("Debe ingresar el APELLIDO MATERNO del empleado para guardar sus datos.");
                }
                else
                    MessageBox.Show("Debe ingresar el APELLIDO PATERNO del empleado para guardar sus datos.");
            }
            else
                MessageBox.Show("Debe ingresar el NOMBRE del empleado para guardar sus datos.");
        }

        public void EmpleadoEntradaRegistro()
        {
            //Abro el formulario Autentificar_Nuevo_Empleado para validar la Curp del empleado a registrar
            Autentificar_Nuevo_Empleado Nuevo = new Autentificar_Nuevo_Empleado();
            Nuevo.ShowDialog();
            Nuevo.txt_curp.Focus();
            if (Nuevo.valor == 1)//La variable valor me dice si se puede registrar al empleado o no.
            {
                //Rellenos los campos por defecto: lbl_curp, Datos del cb_puesto_e, datos del cb_ciudad_e, datos del cb_mun_e y datos del cb_ent_e
                lbl_curp.Text = Nuevo.CURP;
                cb_puesto_e.DisplayMember = "Tipo";
                cb_puesto_e.DataSource = E.EmpleadoBuscarPuesto();
                cb_ent_e.DisplayMember = "Nombre";
                cb_ent_e.DataSource = E.EmpleadoBuscarEntidad();
                cb_mun_e.DisplayMember = "Nombre";
                cb_mun_e.DataSource = E.EmpleadoBuscarMunicipio("Aguascalientes");
                cb_ciudad_e.DisplayMember = "Nombre";
                cb_ciudad_e.DataSource = E.EmpleadoBuscarCiudad("Aguascalientes", "Aguascalientes");

                //Limpio los campos, por si se ejecuto una modificacion antes del registro
                lbl_accion.Text = "REGISTRO DE NUEVO EMPLEADO";
                btn_registrar_e.Text = "REGISTRAR NUEVO EMPLEADO (F1)";
                txt_nom_e.Clear();
                txt_app_e.Clear();
                txt_apm_e.Clear();
                txt_esc_e.Clear();
                txt_calle_e.Clear();
                txt_col_e.Clear();
                txt_num_e.Clear();
                txt_tel_e.Clear();
                TabControl_Empleados.SelectedTab = TabEmpleados_Registro;
            }
        }

        public void EmpleadoEntradaModificacion()
        {
            if (dgv_e.SelectedRows.Count == 1)
            {
                //Obtengo todos los datos del empleado en una  tabla
                DataRow row = E.EmpleadoBuscarDatos(Convert.ToInt32(dgv_e.CurrentRow.Cells[0].Value)).Rows[0]; //La variable --row-- recive una tabla con todos los datos del empleado a modificar

                //Relleno todos los datos del formulario con los datos de la tabla obtenida
                lbl_accion.Text = "MODIFICAR EMPLEADO";
                btn_registrar_e.Text = "MODIFICAR EMPLEADO (F1)";
                ID = Convert.ToInt32(row["IdEmpleado"].ToString());
                cb_puesto_e.DisplayMember = "Tipo";
                cb_puesto_e.DataSource = E.EmpleadoBuscarPuesto();
                cb_ent_e.DisplayMember = "Nombre";
                cb_ent_e.DataSource = E.EmpleadoBuscarEntidad();
                cb_mun_e.DisplayMember = "Nombre";
                cb_mun_e.DataSource = E.EmpleadoBuscarMunicipio("Aguascalientes");
                cb_ciudad_e.DisplayMember = "Nombre";
                cb_ciudad_e.DataSource = E.EmpleadoBuscarCiudad("Aguascalientes", "Aguascalientes");
                lbl_curp.Text = row["Curp"].ToString();
                txt_nom_e.Text = row["Nombre"].ToString();
                txt_app_e.Text = row["App"].ToString();
                txt_apm_e.Text = row["Apm"].ToString();
                cb_puesto_e.Text = row["Tipo"].ToString();
                txt_esc_e.Text = row["Escolaridad"].ToString();
                txt_calle_e.Text = row["Calle"].ToString();
                txt_col_e.Text = row["Colonia"].ToString();
                txt_num_e.Text = row["Num_ext"].ToString();
                cb_ent_e.Text = row["NomEnt"].ToString();
                cb_mun_e.Text = row["NomMun"].ToString();
                cb_ciudad_e.Text = row["NomCiudad"].ToString();
                txt_tel_e.Text = row["Telefono"].ToString();
                DatosE[0] = txt_nom_e.Text;
                DatosE[1] = txt_app_e.Text;
                DatosE[2] = txt_apm_e.Text;
                DatosE[3] = cb_puesto_e.Text;
                DatosE[4] = txt_esc_e.Text;
                DatosE[5] = txt_calle_e.Text;
                DatosE[6] = txt_num_e.Text;
                DatosE[7] = txt_col_e.Text;
                DatosE[8] = cb_ent_e.Text;
                DatosE[9] = cb_mun_e.Text;
                DatosE[10] = cb_ciudad_e.Text;
                DatosE[11] = txt_tel_e.Text;

                TabControl_Empleados.SelectedTab = TabEmpleados_Registro; //Cambio de Tab
            }
            else
                MessageBox.Show("Debe seleccionar al menos un empleado para modificar sus datos.");
        }

        public void EmpleadoBaja()
        {
            if (dgv_e.SelectedRows.Count == 1)
            {
                if (Convert.ToString(dgv_e.CurrentRow.Cells[3].Value) == "A")
                {
                    Datos_Usuario DU = new Datos_Usuario(); //Creo el formulario
                    DU.lbl_accion.Text = "Confimar BAJA de empleado."; //Asigno valores a los valores del formulario
                    DU.lbl_nombre.Text = Convert.ToString(dgv_e.CurrentRow.Cells[2].Value);
                    DU.lbl_curp.Text = Convert.ToString(dgv_e.CurrentRow.Cells[1].Value);
                    DU.lbl_clave.Text = Convert.ToString(dgv_e.CurrentRow.Cells[0].Value);
                    DU.ShowDialog();
                    if (DU.respuesta == 1)
                    {
                        DataRow row = E.EmpleadoBaja(Convert.ToInt32(dgv_e.CurrentRow.Cells[0].Value)).Rows[0];
                        string res = row["Resultado"].ToString();
                        if (res == "1")
                        {
                            MessageBox.Show("El empleado que intenta dar de baja se encuentra enlazado a un usuario. Modifique los datos de los usuarios registrados bajo este empleado para darlo de baja.");
                        }
                        else
                        {
                            dgv_e.DataSource = E.EmpleadoBuscar();
                            cb_filtro.Text = "TODOS";
                            MessageBox.Show("Empleado dado de BAJA exitosamente.");
                        }
                    }
                    else
                        MessageBox.Show("Accion CANCELADA.");
                }
                else
                    MessageBox.Show("Debe seleccionar un empleado ACTIVO para darlo de baja.");
            }
            else
                MessageBox.Show("Debe seleccionar un solo empleado para darlo de baja.");
        }

        public void EmpleadoAlta()
        {
            if (dgv_e.SelectedRows.Count == 1)
            {
                if (Convert.ToString(dgv_e.CurrentRow.Cells[3].Value) == "I")
                {
                    Datos_Usuario DU = new Datos_Usuario(); //Creo el formulario
                    DU.lbl_accion.Text = "Confimar ALTA de empleado."; //Asigno valores a los valores del formulario
                    DU.lbl_nombre.Text = Convert.ToString(dgv_e.CurrentRow.Cells[2].Value);
                    DU.lbl_curp.Text = Convert.ToString(dgv_e.CurrentRow.Cells[1].Value);
                    DU.lbl_clave.Text = Convert.ToString(dgv_e.CurrentRow.Cells[0].Value);
                    DU.ShowDialog();
                    if (DU.respuesta == 1)
                    {
                        E.EmpleadoAlta(Convert.ToInt32(dgv_e.CurrentRow.Cells[0].Value));
                        dgv_e.DataSource = E.EmpleadoBuscar();
                        cb_filtro.Text = "TODOS";
                        MessageBox.Show("Empleado dado de ALTA exitosamente.");
                    }
                    else
                        MessageBox.Show("Accion CANCELADA.");
                }
                else
                    MessageBox.Show("Debe seleccionar un empleado INACTIVO para darlo de alta.");
            }
            else
                MessageBox.Show("Debe seleccionar un solo empleado para darlo de alta.");
        }

        public void EmpleadoFiltro()
        {
            //Configuracion de los filtros para el dgv_e
            if (cb_filtro_e.Text == "TODOS")
            {
                dgv_e.DataSource = E.EmpleadoBuscar();
            }
            else if (cb_filtro_e.Text == "ACTIVOS")
            {
                dgv_e.DataSource = E.EmpleadoBuscarEstatus("A");
            }
            else
            {
                dgv_e.DataSource = E.EmpleadoBuscarEstatus("I");
            }
        }

        public void PuestoModificar()
        {
            if (txt_nombre.Text != DatosP[0] || txt_numero_vacantes.Text != DatosP[1] || txt_sueld.Text != DatosP[2] || txt_descripcion.Text != DatosP[3])
            {
                if (txt_nombre.Text != "")
                {
                    if (Convert.ToString(txt_numero_vacantes.Value) != "")
                    {
                        if (txt_sueld.Text != "")
                        {
                            if (txt_descripcion.Text != "")
                            {
                                if (lbl_msg_p.Text == "Nombre de puesto disponible")
                                {
                                    P.PuestoModificar(Id_modificar, txt_nombre.Text.Trim(), Convert.ToInt32(txt_numero_vacantes.Value), Convert.ToDouble(txt_sueld.Text.Trim()), txt_descripcion.Text.Trim());
                                    MessageBox.Show("Puesto MODIFICADO exitosamente.");
                                    TabControl_Empleados.SelectedTab = TabPuesto_Lista;
                                    dgv_puestos.DataSource = P.PuestoBuscar();
                                    cb_filtro.Text = "TODOS";
                                }
                                else
                                    MessageBox.Show("Debe ingresar un NOMBRE DISPONIBLE para el puesto.");
                            }
                            else
                                MessageBox.Show("Debe escribir la DESCRIPCION del puesto para modificar el registro.");
                        }
                        else
                            MessageBox.Show("Debe escribir el SUELDO del puesto para modificar el registro.");
                    }
                    else
                        MessageBox.Show("Debe seleccionar el NUMERO MAXIMO DE VACANTES del puesto para modificar el registro.");
                }
                else
                    MessageBox.Show("Debe escribir el NOMBRE del puesto para modificar el registro.");
            }
            else
                MessageBox.Show("Debe MODIFICAR ALGUN CAMPO para continuar con la operación.");
        }

        public void PuestoRegistrar()
        {
            if (txt_nom.Text != "")
            {
                if (Convert.ToString(txt_num_vac.Value) != "")
                {
                    if (txt_sueldo.Text != "")
                    {
                        if (txt_desc.Text != "")
                        {
                            if (lbl_msg_p.Text == "Nombre de puesto disponible")
                            {
                                P.PuestoRegistrar(txt_nom.Text.Trim(), Convert.ToInt32(txt_num_vac.Value), Convert.ToDouble(txt_sueldo.Text.Trim()), txt_desc.Text.Trim());
                                MessageBox.Show("Puesto REGISTRADO exitosamente.");
                                TabControl_Empleados.SelectedTab = TabPuesto_Lista;
                                dgv_puestos.DataSource = P.PuestoBuscar();
                                cb_filtro.Text = "TODOS";
                            }
                            else
                                MessageBox.Show("Debe ingresar un NOMBRE DISPONIBLE para el puesto.");
                        }
                        else
                            MessageBox.Show("Debe escribir la DESCRIPCION del puesto para registrarlo.");
                    }
                    else
                        MessageBox.Show("Debe escribir el SUELDO del puesto para registrarlo.");
                }
                else
                    MessageBox.Show("Debe seleccionar el NUMERO MAXIMO DE VACANTES del puesto para registrarlo.");
            }
            else
                MessageBox.Show("Debe escribir el NOMBRE del puesto para registrarlo.");
        }

        public void PuestoEntradaModificar()
        {
            Nom_puesto = Convert.ToString(dgv_puestos.CurrentRow.Cells[1].Value);
            if (dgv_puestos.SelectedRows.Count == 1)
            {
                Id_modificar = Convert.ToInt32(dgv_puestos.CurrentRow.Cells[0].Value);
                txt_nombre.Text = Convert.ToString(dgv_puestos.CurrentRow.Cells[1].Value); //Ingreso los datos que necesito al formulario para que se vean los datos actuales de la tabla
                DataRow row = P.PuestoBuscarId(Convert.ToInt32(dgv_puestos.CurrentRow.Cells[0].Value)).Rows[0]; //La variable --row-- recive una tabla con todos los datos del puesto seleccionado
                txt_numero_vacantes.Value = Convert.ToInt32(row["NumVacantes"]);
                txt_sueld.Text = row["Sueldo"].ToString();
                txt_descripcion.Text = row["Descripcion"].ToString();
                TabControl_Empleados.SelectedTab = TabPuesto_Mod; //Cambio de Tab
                DatosP[0] = txt_nombre.Text;
                DatosP[1] = txt_numero_vacantes.Text;
                DatosP[2] = txt_sueld.Text;
                DatosP[3] = txt_descripcion.Text;
            }
            else
                MessageBox.Show("Debe seleccionar al menos un puesto para modificarlo.");
        }

        public void PuestoEntradaRegistrar()
        {
            //Boton registrar un nuevo puesto
            TabControl_Empleados.SelectedTab = TabPuesto_Registro;
            txt_nom.Clear(); //Limpio todo los campos de registro
            txt_num_vac.Value = 0;
            txt_sueldo.Clear();
            txt_desc.Clear();
        }

        public void PuestoBaja()
        {
            if (dgv_puestos.SelectedRows.Count == 1)
            {
                if (Convert.ToString(dgv_puestos.CurrentRow.Cells[2].Value) == "A")
                {
                    DialogResult result = MessageBox.Show("Está seguro que desea dar de BAJA el puesto seleccionado?", "GYMCENTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        DataRow row = P.PuestoBaja(Convert.ToInt32(dgv_puestos.CurrentRow.Cells[0].Value)).Rows[0];
                        string res = row["Resultado"].ToString();
                        if (res == "1")
                        {
                            MessageBox.Show("El puesto que intenta dar de baja se encuentra enlazado a un empleado. Modifique los datos de los empleados registrados bajo este puesto para darlo de baja.");
                        }
                        else
                        {
                            dgv_puestos.DataSource = P.PuestoBuscar();
                            cb_filtro.Text = "TODOS";
                        }
                    }
                    else if (result == DialogResult.No) { }
                }
                else
                    MessageBox.Show("Debe seleccionar un puesto ACTIVO para darlo de baja.");
            }
            else
                MessageBox.Show("Debe seleccionar al menos un puesto para darlo de baja.");
        }

        public void PuestoAlta()
        {
            if (dgv_puestos.SelectedRows.Count == 1)
            {
                if (Convert.ToString(dgv_puestos.CurrentRow.Cells[2].Value) == "I")
                {
                    DialogResult result = MessageBox.Show("Está seguro que desea dar de ALTA el puesto seleccionado?", "GYMCENTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        P.PuestoAlta(Convert.ToInt32(dgv_puestos.CurrentRow.Cells[0].Value));
                        dgv_puestos.DataSource = P.PuestoBuscar();
                        cb_filtro.Text = "TODOS";
                    }
                    else if (result == DialogResult.No) { }
                }
                else
                    MessageBox.Show("Debe seleccionar un puesto INACTIVO para darlo de alta.");
            }
            else
                MessageBox.Show("Debe seleccionar al menos un puesto para darlo de alta.");
        }

        public void PuestoFiltro()
        {
            //Configuracion de los filtros para el dgv_puestos
            if (cb_filtro.Text == "TODOS")
            {
                dgv_puestos.DataSource = P.PuestoBuscar();
            }
            else if (cb_filtro.Text == "ACTIVOS")
            {
                dgv_puestos.DataSource = P.PuestoBuscarEstatus("A");
            }
            else
            {
                dgv_puestos.DataSource = P.PuestoBuscarEstatus("I");
            }
        }
    }
}
