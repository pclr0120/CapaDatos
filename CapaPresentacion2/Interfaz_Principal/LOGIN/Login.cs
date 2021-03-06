﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoP 
{
    public partial class Login : Form
    {
        int ex, ey;
        bool arrastre;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Bitmap b = (Bitmap)logo.Image;
            IntPtr pIcon = b.GetHicon();
            Icon i = Icon.FromHandle(pIcon);
            this.Icon = i;
            i.Dispose();
            txt_user.Focus();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ex = e.X;
            ey = e.Y;
            arrastre = true;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (arrastre) 
            {
                this.Location = this.PointToScreen(new Point(MousePosition.X - Location.X - ex, MousePosition.Y - Location.Y - ey));
            
            }

            //If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            arrastre = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("Está seguro que desea salir?", "GYMCENTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
               if(result == DialogResult.Yes)
            {
                this.Close();
            }
               else if (result == DialogResult.No) { }
            
            
        }

        private void txt_ingresar_Click(object sender, EventArgs e)
        {

        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
