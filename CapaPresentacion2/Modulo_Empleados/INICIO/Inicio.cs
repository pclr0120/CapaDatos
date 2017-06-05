using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpotifyAPI;
using SpotifyAPI.Local;
using SpotifyAPI.Local.Enums;
using SpotifyAPI.Local.Models;

namespace Inicio
{
    public partial class Inicio : Form
    {
        private readonly SpotifyLocalAPI _spotify;

        public Inicio()
        {
            InitializeComponent();
            _spotify = new SpotifyLocalAPI();
            _spotify.OnTrackChange += _spotify_OnTrackChange;
        }
        int second;
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void _spotify_OnTrackChange(object sender, TrackChangeEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => _spotify_OnTrackChange(sender, e)));
                return;
            }
            UpdateTrack(e.NewTrack);
        }
        private Track _currentTrack;
        public async void UpdateTrack(Track track)
        {
            _currentTrack = track;

            if (track.IsAd())
                return; //Don't process further, maybe null values

            SpotifyUri uri = track.TrackResource.ParseUri();

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
               // lbl_no.Visible = true;
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

  

        private void btn_next_Click(object sender, EventArgs e)
        {
            _spotify.Skip();
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            _spotify.Previous();
        }

        private async void btn_play_Click(object sender, EventArgs e)
        {
            MessageBox.Show("click");
            StatusResponse status = _spotify.GetStatus();
            if (status.Playing)
            {
                await _spotify.Pause();
            }
            else await _spotify.Play();
        }
    }
}
