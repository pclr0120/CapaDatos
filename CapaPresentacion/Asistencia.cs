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

namespace CapaPresentacion
{
    public partial class Asistencia : Form
    {
        string cod;
        public Asistencia(string codigo)
        {
            InitializeComponent();
            cod = codigo;
            mostrarInfo();
          lbl_resul.Text= DateTime.Now.ToString();

        }
        CapaLogica.Asistencia a = new CapaLogica.Asistencia();
        DataTable dt;
        void mostrarInfo() {
            try
            {

                //mejorar verificas si existe primero
               dt= a.consultarCliente(cod);
                if (dt != null)
                {


                    txt_nombre.Text = dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString() + " " + dt.Rows[0][3].ToString();
                    //txt_membre.Text = dt.Rows[0][4].ToString();
                }
                else {
                    MessageBox.Show("No se encontro ");
                }
               

            }
            catch (Exception e) {

                MessageBox.Show("Error");
            }

        }

        void registrar() {
            try
            {
                a.RegistrarAsistencia(dt.Rows[0][0].ToString());
                MessageBox.Show("Registrado");
                this.Close();
            }
            catch (Exception e) {

                MessageBox.Show("Error  consulte con su administrador");
            }
        }
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            registrar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
