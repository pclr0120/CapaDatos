using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        int second;
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            timer_clima.Start();
        }
        void Navegar()
        {
            try
            {
                lbl_ciudad.Text = webBrowser1.Document.GetElementById("wob_loc").InnerText;
                lbl_dia.Text = webBrowser1.Document.GetElementById("wob_dts").InnerText;
                lbl_tiempo.Text = webBrowser1.Document.GetElementById("wob_dc").InnerText;
                lbl_temp.Text = webBrowser1.Document.GetElementById("wob_tm").InnerText;
                lbl_precip.Text = "Prov. de Precipitaciones: " + webBrowser1.Document.GetElementById("wob_pp").InnerText;
                lbl_hum.Text = "Humedad: " + webBrowser1.Document.GetElementById("wob_hm").InnerText;
                lbl_viento.Text = "Viento: " + webBrowser1.Document.GetElementById("wob_ws").InnerText;
                picture_clima.ImageLocation = webBrowser1.Document.GetElementById("wob_tci").GetAttribute("src");
            }

            catch (Exception ex)
            {
                lbl_no.Visible = true;
            }

            second = second + 1;

            if (second == 1000)
            {
                timer_clima.Stop();
                second = 0;
                webBrowser1.Refresh();
                timer_clima.Start();
            }
        }
        private void timer_clima_Tick(object sender, EventArgs e)
        {
            Navegar();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com.mx/?gws_rd=ssl#q=clima+" + txt_busqueda.Text);
        }

        private void txt_busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                webBrowser1.Navigate("https://www.google.com.mx/?gws_rd=ssl#q=clima+" + txt_busqueda.Text);
                lbl_no.Visible = false;
            }
        }

        private void txt_busqueda_Click(object sender, EventArgs e)
        {
            txt_busqueda.SelectAll();
            lbl_no.Visible = false;
        }
    }
}
