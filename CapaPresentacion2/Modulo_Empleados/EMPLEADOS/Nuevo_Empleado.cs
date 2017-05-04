﻿using System;
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
    public partial class Nuevo_Empleado : Form
    {
        public Nuevo_Empleado()
        {
            InitializeComponent();
        }

        private void txt_curp_TextChanged(object sender, EventArgs e)
        {

        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            txt_curp2.Enabled = false;
            groupBox1.Enabled = true;
            lbl_curp.Enabled = false;
            rb_curp.Checked = true;
            txt_clave_empleado.Enabled = false;
            txt_curp.Focus();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            txt_curp2.Enabled = true;
            txt_curp2.Focus();
            groupBox1.Enabled = false;
            lbl_curp.Enabled = true;
        }

        private void Nuevo_Empleado_Load(object sender, EventArgs e)
        {
            rb_nuevo.Checked = true;
            txt_curp2.Enabled = true;
            groupBox1.Enabled = false;
            txt_curp2.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void rb_curp_CheckedChanged(object sender, EventArgs e)
        {
            txt_curp.Enabled = true;
            txt_clave_empleado.Enabled = false;
            txt_curp.Focus();
        }

        private void rb_clave_CheckedChanged(object sender, EventArgs e)
        {
            txt_curp.Enabled = false;
            txt_clave_empleado.Enabled = true;
            txt_clave_empleado.Focus();
        }

        private void rb_lista_CheckedChanged(object sender, EventArgs e)
        {
            txt_curp.Enabled = false;
            txt_clave_empleado.Enabled = false;
        }
    }
}