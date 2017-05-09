using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_Empleados
{
    public partial class Autentificar_Nuevo_Empleado : Form
    {
        public Autentificar_Nuevo_Empleado()
        {
            InitializeComponent();
        }
        int ex, ey;
        bool arrastre;

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Autentificar_Nuevo_Empleado_Load(object sender, EventArgs e)
        {
            
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ex = e.X;
            ey = e.Y;
            arrastre = true;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            arrastre = false;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (arrastre)
            {
                this.Location = this.PointToScreen(new Point(MousePosition.X - Location.X - ex, MousePosition.Y - Location.Y - ey));

            }
            //If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
        }
        public string CURP; //variable para pasar informacion
        public int valor;
        private void btn_nuevo_empleado_Click(object sender, EventArgs e)
        {
            //TabControlEmpleados.SelectedTab = TabEmpleados_Registro;
            CURP = txt_curp2.Text;
            valor = 1;
            //asignamos a la variable lo capturado en el textbox

        }
        }
}
