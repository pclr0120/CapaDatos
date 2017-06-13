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

namespace Modulo_Inventario.mensajes
{
    public partial class AltaBaja : Form
    {
        Producto p = new Producto();
        public AltaBaja( string valor)
        {
            InitializeComponent();
            try
            {
                consultaproducto();
                txtCodigo.Text = valor;
                txtNombre.Text = d.Rows[0][0].ToString();
                txteActual.Text = d.Rows[0][1].ToString();
            }
            catch (Exception e) {
                MessageBox.Show("Error consulte con su administrador");
            }



        }
        DataTable d;
        void consultaproducto() {
           d= p.EstatusbajaAlta("24");
        }
        string estado;
        void actualizar() {
            if (cbEstatus.SelectedItem != null) {
               estado = cbEstatus.SelectedItem.ToString().Substring(0, 1);
            }

            
            if (cbEstatus.SelectedItem != null && estado != txteActual.Text)
            {
                try
                {

                    p.ModificarAltaBaja(txtCodigo.Text,estado );
                    MessageBox.Show("Se modifico correctamtente");
                    this.Close();
                }
                catch (Exception e)
                {


                    MessageBox.Show("Error consulte con su administrador");
                }
            }
            else {
                MessageBox.Show("Seleccione un estado que sea diferente al actual para continuar");
            }
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mensajeConfirmacion mc = new mensajeConfirmacion("Desea salir?","SI F1", "NO F2","");
            mc.ShowDialog();
            if (mc.valor) {

                this.Close();
            }
        }

        private void AltaBaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.A)
            {

                actualizar();
            }
            if ((int)e.KeyChar == (int)Keys.F2)
            {
                mensajeConfirmacion mc = new mensajeConfirmacion("Desea salir?", "SI F1", "NO F2", "");
                mc.ShowDialog();
                if (mc.valor)
                {

                    this.Close();
                }
            }
            if ((int)e.KeyChar == (int)Keys.F3)
            {
              
            }
        }
    }
}
