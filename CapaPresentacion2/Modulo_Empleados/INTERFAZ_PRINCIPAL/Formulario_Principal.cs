using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using Modulo_Empleados;
using CapaLogica;
using SpotifyAPI;
using SpotifyAPI.Local;
using SpotifyAPI.Local.Enums;
using SpotifyAPI.Local.Models;
using CapaPresentacion;


namespace EMBLEMA
{
    public partial class Formulario_Principal : Form
    {
        public int ID;
        CapaLogica.Empleados E = new CapaLogica.Empleados();
        CapaLogica.Login L = new CapaLogica.Login();
        CapaLogica.Puesto P = new CapaLogica.Puesto();
        CapaLogica.Usuarios U = new CapaLogica.Usuarios();
        CapaLogica.Equipo Eq = new CapaLogica.Equipo();
        CapaLogica.Cliente C = new CapaLogica.Cliente();
        

        private readonly SpotifyLocalAPI _spotify;

        private Track _currentTrack;


        public Formulario_Principal()
        {
            InitializeComponent();

            _spotify = new SpotifyLocalAPI();
            _spotify.OnTrackChange += _spotify_OnTrackChange;

            lbl_artista.Click += (sender, args) => System.Diagnostics.Process.Start(lbl_artista.Tag.ToString());
            lbl_album.Click += (sender, args) => System.Diagnostics.Process.Start(lbl_album.Tag.ToString());
            lbl_cancion.Click += (sender, args) => System.Diagnostics.Process.Start(lbl_cancion.Tag.ToString());

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

        public void Connect()
        {
            if (!SpotifyLocalAPI.IsSpotifyRunning())
            {
                txt_message.Text = "Spotify no se está ejecutando!";
                mensage_timer.Start();
                return;
            }
            if (!SpotifyLocalAPI.IsSpotifyWebHelperRunning())
            {
                txt_message.Text = "El proceso SpotifyWebHelper no está corriendo!";
                mensage_timer.Start();
                return;
            }

            bool successful = _spotify.Connect();
            if (successful)
            {
                
                txt_message.Text = "Conexión con Spotify exitosa";
                mensage_timer.Start();
                pb_album.Enabled = false;
                pb_album.Cursor = Cursors.Arrow;
                UpdateInfos();
                _spotify.ListenForEvents = true;
            }
            else
            {
                DialogResult res = MessageBox.Show(@"No se ha podido establecer conexion con el cliente de Spotify. Lo intentamos de nuevo?", @"Spotify", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                    Connect();
            }
        }

        public void UpdateInfos()
        {
            StatusResponse status = _spotify.GetStatus();
            if (status == null)
                return;

            if (status.Track != null) //Update track infos
                UpdateTrack(status.Track);
        }

        public async void UpdateTrack(Track track)
        {
            _currentTrack = track;

            if (track.IsAd())
                return; //Don't process further, maybe null values

            lbl_cancion.Text = track.TrackResource.Name;
            lbl_cancion.Tag = track.TrackResource.Uri;

            lbl_artista.Text = track.ArtistResource.Name;
            lbl_artista.Tag = track.ArtistResource.Uri;

            lbl_album.Text = track.AlbumResource.Name;
            lbl_album.Tag = track.AlbumResource.Uri;

            SpotifyUri uri = track.TrackResource.ParseUri();
            
            Ventana_Inicio.panel2.BackgroundImage = await track.GetAlbumArtAsync(AlbumArtSize.Size640);
            SpotifyOn();
            pb_album.Image = await track.GetAlbumArtAsync(AlbumArtSize.Size160);
            SpotifyFlag = true;
        }


        Modulo_Empleados.Empleados Empleados = new Modulo_Empleados.Empleados();
        Modulo_Clientes.Clientes Clientes = new Modulo_Clientes.Clientes();
        Modulo_Equipo.Modulo_Equipo Equipo = new Modulo_Equipo.Modulo_Equipo();
        Modulo_Inventario.Inventario Inventario = new Modulo_Inventario.Inventario();
        public Modulo_Config.Configuraciones Configuraciones = new Modulo_Config.Configuraciones();
        Inicio.Inicio Ventana_Inicio = new Inicio.Inicio();
        CapaPresentacion.VENTA.PuntoVenta Punto = new CapaPresentacion.VENTA.PuntoVenta();
        Modulo_Empleados.INTERFAZ_PRINCIPAL.Reportes Reportes = new Modulo_Empleados.INTERFAZ_PRINCIPAL.Reportes();
        


        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void rb_empleados_CheckedChanged(object sender, EventArgs e)
        {
            Empleados.MdiParent = this;
            Empleados.WindowState = FormWindowState.Maximized;
            Empleados.Dock = DockStyle.Fill;
            Empleados.TabControl_Empleados.SelectedTab = Empleados.TabEmpleados_Lista;
            Empleados.dgv_e.DataSource = E.EmpleadoBuscar();
            Empleados.Show();
        }
        private void rb_membre_Click(object sender, EventArgs e)
        {
            Clientes.MdiParent = this;
            Clientes.WindowState = FormWindowState.Maximized;
            Clientes.Dock = DockStyle.Fill;
            Clientes.TabControl_Clientes.SelectedTab = Clientes.TabClientes_Lista;
            Clientes.dgv_c.DataSource = C.ClienteBuscar();
            Clientes.Show();
        }
        
        private void rb_config_CheckedChanged(object sender, EventArgs e)
        {
            Modulo_Config.Confirm_User Configuracion = new Modulo_Config.Confirm_User(this);
            DataRow row = E.EmpleadoBuscarDatos(Convert.ToInt32(ID)).Rows[0]; //La variable --row-- recive una tabla con todos los datos del empleado a modificar
            Configuracion.txt_puesto.Text = row["Tipo"].ToString();
            Configuracion.txt_nombre.Text = lbl_usuario.Text;
            Configuracion.ShowDialog();
            if (Configuracion.valor == 1)
            {
                Configuraciones.MdiParent = this;
                Configuraciones.WindowState = FormWindowState.Maximized;
                Configuraciones.TabControl_Config.Dock = DockStyle.Fill;
                Configuraciones.Dock = DockStyle.Fill;
                Configuraciones.dgv_usuarios.DataSource = U.UsuarioBuscar();
                Configuraciones.Show();
            }
            
        }
        
        private void Formulario_Principal_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
            DataRow row = L.LoginDatosUsuario(ID).Rows[0]; //La variable --row-- recive una tabla con todos los datos del usurio logeado
            lbl_usuario.Text = row["Nom"].ToString() + " " + row["App"].ToString() + " " + row["Apm"].ToString(); //Concateno solo las columnas del nombre en el lbl_usuario
            rb_inicio.Checked = true;
            SpotifyOff();
            Ver_Inicio();
            Ventana_Inicio.Show();
            panel3.HorizontalScroll.Maximum = 0;
            panel3.AutoScroll = false;
            panel3.VerticalScroll.Visible = false;
            panel3.AutoScroll = true;
            //this.AutoScroll = true;
            //this.VerticalScroll.Visible = false;

        }
        void Ver_Inicio()
        {
            Ventana_Inicio.MdiParent = this;
            Ventana_Inicio.WindowState = FormWindowState.Maximized;
            Ventana_Inicio.Dock = DockStyle.Fill;
        }
        
        void SpotifyOn()
        {
            Ventana_Inicio.group.Visible = false;
            Ventana_Inicio.btn_play.Visible = true;
            Ventana_Inicio.btn_next.Visible = true;
            Ventana_Inicio.btn_previous.Visible = true;
        }

        void SpotifyOff()
        {
            
            Ventana_Inicio.group.Visible = true;
            Ventana_Inicio.btn_play.Visible = false;
            Ventana_Inicio.btn_next.Visible = false;
            Ventana_Inicio.btn_previous.Visible = false;
            
        }

        private void lbl_control_sesion_Click(object sender, EventArgs e)
        {
            Modulo_Empleados.INTERFAZ_PRINCIPAL.LOGIN.Warning adver = new Modulo_Empleados.INTERFAZ_PRINCIPAL.LOGIN.Warning();
            adver.Show();
        }

        private void rb_equipo_CheckedChanged(object sender, EventArgs e)
        {
            Equipo.MdiParent = this;
            Equipo.WindowState = FormWindowState.Maximized;
            Equipo.Dock = DockStyle.Fill;
            Equipo.Show();
            Equipo.cb_clasificacion.DisplayMember = "Nombre";
            Equipo.cb_clasificacion.DataSource = Eq.EquipoBuscarClasificaciones();
            Equipo.dgv_e.DataSource = Eq.EquipoBuscar();
            Equipo.IdUsuario = ID;
        }

        private void rb_inventario_CheckedChanged(object sender, EventArgs e)
        {
            Inventario.MdiParent = this;
            Inventario.WindowState = FormWindowState.Maximized;
            Inventario.Dock = DockStyle.Fill;
            Inventario.Show();
        }
        bool SpotifyFlag = false;
        private void rb_inicio_CheckedChanged(object sender, EventArgs e)
        {
            Ver_Inicio();
            if (SpotifyFlag)
            {
                SpotifyOn();
            }
            else { SpotifyOff(); }

            
        }
        int second = 0;
        private void mensage_timer_Tick(object sender, EventArgs e)
        {
            
            txt_message.Visible = true;
            second++;
            if (second >= 30)
            {
                txt_message.Visible = false;
                mensage_timer.Stop();
                second = 0;
            }
        }

        private void pb_album_Click(object sender, EventArgs e)
        {
            try
            {
                //Abrir_Spotify();
                //txt_message.Visible = true;
                //txt_message.Text = "Espere...";
                //conexion.Start();
            }
            catch (Exception exc)
            {
                btn_install.Visible = true;
                txt_message.Text = exc.ToString();
            }
            
            
        }

        void Abrir_Spotify()
        {
            Process p = new Process();
            p.StartInfo.FileName = "cmd";
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
            p.Start();
            p.StandardInput.WriteLine(@"cd/ & cd Users/%Username% & start AppData/Roaming/Spotify/Spotify.exe");
            p.StandardInput.Flush();
            p.StandardInput.Close();
            p.Close();
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
            StatusResponse status = _spotify.GetStatus();
            if (status.Playing)
            {
                await _spotify.Pause();
            }
            else await _spotify.Play();
        }

        private void txt_message_Click(object sender, EventArgs e)
        {

        }
        int a;
        private void conexion_Tick(object sender, EventArgs e)
        {
            if (a < 30) a++;
            else
            {
                Connect();
                conexion.Stop();
                a = 0;
            }
        }

        private void btn_install_Click(object sender, EventArgs e)
        {
            Process.Start(linkLabel1.Text);
            btn_install.Visible = false;
        }

        private void rb_punto_vta_CheckedChanged(object sender, EventArgs e)
        {
            Punto.Show();
        }

        private void rb_reportes_CheckedChanged(object sender, EventArgs e)
        {
            Reportes.Show();
        }
    }
}
