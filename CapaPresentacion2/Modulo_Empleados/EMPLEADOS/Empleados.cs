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
        string accion;
        Puesto P = new Puesto();
        CapaLogica.Empleados E = new CapaLogica.Empleados();
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
            Autentificar_Nuevo_Empleado Nuevo_Empleado = new Autentificar_Nuevo_Empleado();
            DialogResult res = Nuevo_Empleado.ShowDialog(this);
            //Nuevo_Empleado.MdiParent = this;
            if (res == DialogResult.OK)
            {
                //recuperando la variable publica del formulario 2
                Console.Beep();

                lbl_curp_nvo_empleado.Text = Nuevo_Empleado.CURP; //asignamos al texbox el dato de la variable
                TabControl_Empleados.SelectedTab = TabEmpleados_Registro;
            }
        }

        private void btn_retorno_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea salir?" + Environment.NewLine + "Si usted lo hace se perderán todos los datos ingresados", "Cancelar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                TabControl_Empleados.SelectedTab = Empleados_Inicio;
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
            //TabControlEmpleados.SelectedTab = TabPuesto_Registro;
            /*Deberá mostrar un nuevo formulario donde se le permita al usuario elegir si ya cuenta
             con la C.U.R.P. del empleado o si desea encontrarlo en la lista de empleados*/
            ABC_Empleados ABC_Modificar = new ABC_Empleados();
            ABC_Modificar.lbl_accion.Text = "Modificar datos de empleado";
            accion = "M";
            ABC_Modificar.Show();
        }
        private void btn_alta_empleado_Click(object sender, EventArgs e)
        {
            // Esto es un comentario momentaneo para checar el tab del registro del empleados
            Nuevo_Empleado Nuevo = new Nuevo_Empleado();
            Nuevo.ShowDialog();
            if (Nuevo.valor == 1)
            {
                MessageBox.Show(Nuevo.valor.ToString());
            }
            //TabControl_Empleados.SelectedTab = TabEmpleados_Registro;
        }
        private void btn_baja_empleado_Click(object sender, EventArgs e)
        {
            //TabControlEmpleados.SelectedTab = TabPuesto_Registro;
            /*Deberá mostrar un nuevo formulario donde se le permita al usuario elegir si ya cuenta
             con la C.U.R.P. del empleado o si desea encontrarlo en la lista de empleados*/
            ABC_Empleados ABC_Baja = new ABC_Empleados();
            ABC_Baja.lbl_accion.Text = "Dar de baja a un empleado";
            accion = "B";
            ABC_Baja.Show();
        }

        private void btn_nvo_puesto_Click(object sender, EventArgs e)
        {
            TabControl_Empleados.SelectedTab = TabPuesto_Registro;
            txt_nom.Clear(); //Limpio todo los campos de registro
            txt_num_vac.Value = 0;
            txt_sueldo.Clear();
            txt_desc.Clear();
        }

        private void btn_puesto_lista_Click(object sender, EventArgs e)
        {
            TabControl_Empleados.SelectedTab = TabPuesto_Lista;
            dgv_puestos.DataSource = P.PuestoBuscar();
        }

        private void btn_retorno2_Click(object sender, EventArgs e)
        {
            TabControl_Empleados.SelectedTab = Empleados_Inicio;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Boton registrar un nuevo puesto
            TabControl_Empleados.SelectedTab = TabPuesto_Registro;
            txt_nom.Clear(); //Limpio todo los campos de registro
            txt_num_vac.Value = 0;
            txt_sueldo.Clear();
            txt_desc.Clear();
        }

        private void TabPuesto_Lista_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedValueChanged(object sender, EventArgs e)
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

        private void btn_mod_Click(object sender, EventArgs e)
        {
            modificar();
        }

        void modificar()
        {
            if (dgv_puestos.SelectedRows.Count == 1)
            {
                Id_modificar = Convert.ToInt32(dgv_puestos.CurrentRow.Cells[0].Value);
                txt_nombre.Text = Convert.ToString(dgv_puestos.CurrentRow.Cells[1].Value); //Ingreso los datos que necesito al formulario para que se vean los datos actuales de la tabla
                txt_numero_vacantes.Value = Convert.ToInt32(dgv_puestos.CurrentRow.Cells[4].Value);
                txt_sueld.Text = Convert.ToString(dgv_puestos.CurrentRow.Cells[5].Value);
                txt_descripcion.Text = Convert.ToString(dgv_puestos.CurrentRow.Cells[6].Value);
                TabControl_Empleados.SelectedTab = TabPuesto_Mod; //Cambio de Tab
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos un puesto para modificarlo.");
            }
        }
        
        private void btn_alta_Click(object sender, EventArgs e)
        {
            if (dgv_puestos.SelectedRows.Count == 1)
            {
                if (Convert.ToString(dgv_puestos.CurrentRow.Cells[3].Value) == "I")
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
                {
                    MessageBox.Show("Debe seleccionar un puesto INACTIVO para darlo de alta.");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos un puesto para darlo de alta.");
            }
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            if (dgv_puestos.SelectedRows.Count == 1)
            {
                if (Convert.ToString(dgv_puestos.CurrentRow.Cells[3].Value) == "A")
                {
                    DialogResult result = MessageBox.Show("Está seguro que desea dar de BAJA el puesto seleccionado?", "GYMCENTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        P.PuestoBaja(Convert.ToInt32(dgv_puestos.CurrentRow.Cells[0].Value));
                        dgv_puestos.DataSource = P.PuestoBuscar();
                        cb_filtro.Text = "TODOS";
                    }
                    else if (result == DialogResult.No) { }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un puesto ACTIVO para darlo de baja.");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos un puesto para darlo de baja.");
            }
        }

        private void txt_buscar_puesto_TextChanged(object sender, EventArgs e)
        {
            dgv_puestos.DataSource = P.PuestoBuscarNombre(txt_buscar_puesto.Text);
        }

        private void txt_buscar_puesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)) //Valido solo numeros y teclas de control sean permitidas
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)) //Valido solo numeros y teclas de control sean permitidas
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_nom_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar)) //Valido solo numeros y teclas de control sean permitidas
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_sueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) //Valido solo numeros y teclas de control sean permitidas
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_num_vac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar)) //Valido solo numeros y teclas de control sean permitidas
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (txt_nom.Text != "")
            {
                if (Convert.ToString(txt_num_vac.Value) != "")
                {
                    if (txt_sueldo.Text != "")
                    {
                        if (txt_desc.Text != "")
                        {
                            P.PuestoRegistrar(txt_nom.Text,Convert.ToInt32(txt_num_vac.Value), Convert.ToDouble(txt_sueldo.Text),txt_desc.Text);
                            MessageBox.Show("Puesto REGISTRADO exitosamente.");
                            TabControl_Empleados.SelectedTab = TabPuesto_Lista;
                            dgv_puestos.DataSource = P.PuestoBuscar();
                            cb_filtro.Text = "TODOS";
                        }
                        else
                        {
                            MessageBox.Show("Debe escribir la DESCRIPCION del puesto para registrarlo.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe escribir el SUELDO del puesto para registrarlo.");
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar el NUMERO MAXIMO DE VACANTES del puesto para registrarlo.");
                }
            }
            else
            {
                MessageBox.Show("Debe escribir el NOMBRE del puesto para registrarlo.");
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar)) //Valido solo numeros y teclas de control sean permitidas
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_numero_vacantes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar)) //Valido solo numeros y teclas de control sean permitidas
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_sueld_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) //Valido solo numeros y teclas de control sean permitidas
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public int Id_modificar;
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text != "")
            {
                if (Convert.ToString(txt_numero_vacantes.Value) != "")
                {
                    if (txt_sueld.Text != "")
                    {
                        if (txt_descripcion.Text != "")
                        {
                            P.PuestoModificar(Id_modificar, txt_nombre.Text, Convert.ToInt32(txt_numero_vacantes.Value), Convert.ToDouble(txt_sueld.Text), txt_descripcion.Text);
                            MessageBox.Show("Puesto MODIFICADO exitosamente.");
                            TabControl_Empleados.SelectedTab = TabPuesto_Lista;
                            dgv_puestos.DataSource = P.PuestoBuscar();
                            cb_filtro.Text = "TODOS";
                        }
                        else
                        {
                            MessageBox.Show("Debe escribir la DESCRIPCION del puesto para modificar el registro.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe escribir el SUELDO del puesto para modificar el registro.");
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar el NUMERO MAXIMO DE VACANTES del puesto para modificar el registro.");
                }
            }
            else
            {
                MessageBox.Show("Debe escribir el NOMBRE del puesto para modificar el registro.");
            }
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

        private void cb_filtro_e_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_buscar_e_TextChanged(object sender, EventArgs e)
        {
            dgv_e.DataSource = E.EmpleadoBuscarNombre(txt_buscar_e.Text);
        }

        private void txt_buscar_e_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)) //Valido solo numeros y teclas de control sean permitidas
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btn_alta_e_Click(object sender, EventArgs e)
        {
            if (dgv_e.SelectedRows.Count == 1)
            {
                if (Convert.ToString(dgv_e.CurrentRow.Cells[15].Value) == "I")
                {
                    Datos_Usuario DU = new Datos_Usuario(); //Creo el formulario
                    DU.lbl_accion.Text = "Confimar ALTA de empleado."; //Asigno valores a los valores del formulario
                    DU.lbl_nombre.Text = Convert.ToString(dgv_e.CurrentRow.Cells[2].Value) + " " + Convert.ToString(dgv_e.CurrentRow.Cells[3].Value) + " " + Convert.ToString(dgv_e.CurrentRow.Cells[4].Value);
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
                    {
                        MessageBox.Show("Accion CANCELADA.");
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un empleado INACTIVO para darlo de alta.");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un solo empleado para darlo de alta.");
            }
        }

        private void btn_baja_e_Click(object sender, EventArgs e)
        {
            if (dgv_e.SelectedRows.Count == 1)
            {
                if (Convert.ToString(dgv_e.CurrentRow.Cells[15].Value) == "A")
                {
                    Datos_Usuario DU = new Datos_Usuario(); //Creo el formulario
                    DU.lbl_accion.Text = "Confimar BAJA de empleado."; //Asigno valores a los valores del formulario
                    DU.lbl_nombre.Text = Convert.ToString(dgv_e.CurrentRow.Cells[2].Value) + " " + Convert.ToString(dgv_e.CurrentRow.Cells[3].Value) + " " + Convert.ToString(dgv_e.CurrentRow.Cells[4].Value);
                    DU.lbl_curp.Text = Convert.ToString(dgv_e.CurrentRow.Cells[1].Value);
                    DU.lbl_clave.Text = Convert.ToString(dgv_e.CurrentRow.Cells[0].Value);
                    DU.ShowDialog();
                    if (DU.respuesta == 1)
                    {
                        E.EmpleadoBaja(Convert.ToInt32(dgv_e.CurrentRow.Cells[0].Value));
                        dgv_e.DataSource = E.EmpleadoBuscar();
                        cb_filtro.Text = "TODOS";
                        MessageBox.Show("Empleado dado de BAJA exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("Accion CANCELADA.");
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un empleado ACTIVO para darlo de baja.");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un solo empleado para darlo de baja.");
            }
        }

        private void btn_reg_e_Click(object sender, EventArgs e)
        {
        }
    }
}
