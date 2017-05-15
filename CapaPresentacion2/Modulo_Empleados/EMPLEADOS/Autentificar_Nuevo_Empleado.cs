using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
        public string CURP; //variable para pasar informacion
        public int valor;
        CapaLogica.Empleados E = new CapaLogica.Empleados();

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Autentificar_Nuevo_Empleado_Load(object sender, EventArgs e)
        {
            txt_curp.Focus();
            (panel2 as Control).KeyPress += new KeyPressEventHandler(MyKeyPressEventHandler);
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

        private void btn_nuevo_empleado_Click(object sender, EventArgs e)
        {
            ComprobarCurp();
        }

        private void btn_nuevo_empleado_KeyUp(object sender, KeyEventArgs e)
        {
            if ((Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.F1))) //TabEmpleados_Lista
            {
                ComprobarCurp();
            }
        }

        public void ComprobarCurp()
        {
            //Validacion de la Curp por Expresion Regular
            Regex Val = new Regex(@"^[A-Z][AEIOUX][A-Z]{2}[0-9]{2}(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[01])[HM](AS|B[CS]|C[CLMSH]|D[FG]|G[TR]|HG|JC|M[CNS]|N[ETL]|OC|PL|Q[TR]|S[PLR]|T[CSL]|VZ|YN|ZS)[B-DF-HJ-NP-TV-Z]{3}[0-9]{2}$");
            if (Val.IsMatch(txt_curp.Text))
            {
                if (E.EmpleadoBuscarCurp(txt_curp.Text) == 1)
                {
                    MessageBox.Show("La CURP ingresada se encuantra registrada en el sistema.");
                }
                else
                {
                    CURP = txt_curp.Text;
                    valor = 1;
                }
            }
            else
                MessageBox.Show("Curp escrita incorrectamente."); 
        }

        public void MyKeyPressEventHandler(Object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 112) //TabEmpleados_Lista
            {
                MessageBox.Show("Hola a todos");
                //ComprobarCurp();
            }
        }
    }
}
