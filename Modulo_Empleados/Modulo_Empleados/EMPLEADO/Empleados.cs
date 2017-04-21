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

namespace Modulo_Empleados
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
          
            
            InitializeComponent();
        }
        string accion;
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
            /*Deberá mostrar un nuevo formulario donde se le permita al usuario elegir si ya cuenta
             con la C.U.R.P. del empleado o si desea encontrarlo en la lista de empleados*/
            ABC_Empleados ABC_Alta = new ABC_Empleados();
            ABC_Alta.lbl_accion.Text = "Dar de alta a empleado existente";
            accion = "A";
            ABC_Alta.Show();
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
        }

        private void btn_puesto_lista_Click(object sender, EventArgs e)
        {
            TabControl_Empleados.SelectedTab = TabPuesto_Lista;
        }

        private void btn_retorno2_Click(object sender, EventArgs e)
        {
            TabControl_Empleados.SelectedTab = Empleados_Inicio;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
