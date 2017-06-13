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
    public partial class AgregarStock : Form
    {

        public AgregarStock()
        {
            InitializeComponent();
            txtCodigo.LostFocus += TxtCodigo_LostFocus;
  
        }

      

        Producto p = new Producto();
        bool controlenter=true;
        private void TxtCodigo_LostFocus(object sender, EventArgs e)
        {
            if (controlenter) {
                Mostrarproducto();
            }
        }
        void Mostrarproducto() {

            if (txtCodigo.Text.Length > 0)
            {
                try
                {
                    DataTable temp;
                    temp = p.AñandirmasMostrarinfoStock(txtCodigo.Text);
                    if (temp.Rows.Count>0 )
                    {
                        txtNombre.Text = temp.Rows[0][0].ToString();
                        txtstockActual.Text = temp.Rows[0][1].ToString();
                    }
                    else {
                        MessageBox.Show("no existe ese producto");
                    }
                }
                catch (Exception ee)
                {

                    MessageBox.Show("Error consulte con su administrador:" + ee.ToString() + "---Consultar producto");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length > 0 && txtNombre.Text.Length > 0 && txtañadirProduct.Text.Length > 0)
            {

                txtCodigo.Enabled = false;
                txtañadirProduct.Enabled = false;
              
                mensajes.mensajeConfirmacion mc = new mensajes.mensajeConfirmacion("se añadira al stock:", "SI F1", "NO F2", txtañadirProduct.Text);
                mc.ShowDialog();
                if (mc.valor) {
                    try
                    {
                        p.añadirMasProducto(txtCodigo.Text, Convert.ToInt32(txtañadirProduct.Text));
                       
                        
                        mensajeConfirmacion mcc = new mensajeConfirmacion("Desea a actualizar el stock a otro producto?", "SI F1", "NO F2", "");
                        mcc.ShowDialog();
                        if (mcc.valor) {
                            limpiar();
                          
                        }
                    }
                    catch (Exception ee) {
                        MessageBox.Show("Error consulte con su administrador:" + ee.ToString() + "AgregarstockError", "Error");
                    }
                }

            }
            else {

                MessageBox.Show("Verifique los campos, los campor requeridos estan marcados con un *", "Mensaje");
                
            }
        }

        void salir() {
            mensajeConfirmacion mc = new mensajeConfirmacion("Seguro que desea salir?", "SI F1", "NO F2", "");

            mc.ShowDialog();
            if (mc.valor)
            {
                this.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            salir();
        
        }

        void limpiar() {
            txtCodigo.Focus();
            txtañadirProduct.Clear();
            txtañadirProduct.Enabled = true;
            txtCodigo.Clear();
            txtCodigo.Enabled = true;
            txtNombre.Clear();
            txtstockActual.Clear();


        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                controlenter = false;
                Mostrarproducto();
            }
        }

        private void AgregarStock_KeyPress(object sender, KeyPressEventArgs e)
       {
           
           if ((int)e.KeyChar == (int)Keys.F1)
            {
               
                Mostrarproducto();
            }
            if ((int)e.KeyChar == (int)Keys.F2) {
                salir();
            }
            if ((int)e.KeyChar == (int)Keys.F3)
            {
                limpiar();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txtañadirProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
        public void SoloNumeros(KeyPressEventArgs e)
        {

            int ascci = Convert.ToInt32(Convert.ToChar(e.KeyChar));
            //verificamos que se encuentre en ese rango que son entre el 0 y el 9 


            if ((ascci >= 48 && ascci <= 57) || ascci == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

            }
        }
    }
}
