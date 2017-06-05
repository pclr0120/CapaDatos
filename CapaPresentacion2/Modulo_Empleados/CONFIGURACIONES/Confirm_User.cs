using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_Config 
{
    public partial class Confirm_User : Form
    {
        EMBLEMA.Formulario_Principal frp;
        int ID;
        public Confirm_User(EMBLEMA.Formulario_Principal frp)
        {
            InitializeComponent();
            this.frp = frp;
            this.ID = frp.ID;
        }
       
        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int valor;

        //Procedimiento ingresar para el evento enter en el txt_pass y al presionar el btn_ingresar
        private void ingresar()
        {
            CapaLogica.Login l = new CapaLogica.Login();
            if (txt_pass.Text != "")
            {
                if (l.CheckLogin(Convert.ToInt32(this.ID), txt_pass.Text) == 1)
                {
                    valor = 1;
                    this.Close();
                }
                else
                {
                    lbl_resul.Text = "La contraseña ingresada no es correcta";
                    lbl_resul.Visible = true;
                }
            }
            else
            {
                lbl_resul.Text = "Ingrese la CONTRASEÑA del usuario";
                lbl_resul.Visible = true;
            }
            
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            ingresar();
        }

        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //Valido que al dar enter se ejecute el procedimiento ingresar
            {
                ingresar();
            }
        }
    }
}
