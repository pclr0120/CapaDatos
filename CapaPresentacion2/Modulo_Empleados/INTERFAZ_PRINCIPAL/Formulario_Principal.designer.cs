namespace EMBLEMA
{
    partial class Formulario_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario_Principal));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_min = new System.Windows.Forms.Button();
            this.class_Ovalo1 = new EMBLEMA.Class_Ovalo();
            this.lbl_emblema = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_control_sesion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_message = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rb_inicio = new System.Windows.Forms.RadioButton();
            this.rb_punto_vta = new System.Windows.Forms.RadioButton();
            this.rb_membre = new System.Windows.Forms.RadioButton();
            this.rb_equipo = new System.Windows.Forms.RadioButton();
            this.rb_empleados = new System.Windows.Forms.RadioButton();
            this.rb_inventario = new System.Windows.Forms.RadioButton();
            this.rb_config = new System.Windows.Forms.RadioButton();
            this.lbl_album = new System.Windows.Forms.Label();
            this.lbl_artista = new System.Windows.Forms.Label();
            this.lbl_cancion = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pb_album = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btn_next = new System.Windows.Forms.PictureBox();
            this.btn_play = new System.Windows.Forms.PictureBox();
            this.btn_previous = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puntoDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membresíasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensage_timer = new System.Windows.Forms.Timer(this.components);
            this.conexion = new System.Windows.Forms.Timer(this.components);
            this.btn_install = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.class_Ovalo1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_album)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_previous)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_min);
            this.panel2.Controls.Add(this.class_Ovalo1);
            this.panel2.Controls.Add(this.lbl_emblema);
            this.panel2.Controls.Add(this.lbl_usuario);
            this.panel2.Controls.Add(this.lbl_control_sesion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1366, 89);
            this.panel2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("NewsGoth Cn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1237, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Sistema EMBLEMA ®";
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.BackColor = System.Drawing.Color.Transparent;
            this.btn_min.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_min.BackgroundImage")));
            this.btn_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Location = new System.Drawing.Point(1326, 0);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(40, 25);
            this.btn_min.TabIndex = 1;
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // class_Ovalo1
            // 
            this.class_Ovalo1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.class_Ovalo1.BackColor = System.Drawing.Color.DarkGray;
            this.class_Ovalo1.Image = ((System.Drawing.Image)(resources.GetObject("class_Ovalo1.Image")));
            this.class_Ovalo1.Location = new System.Drawing.Point(20, 13);
            this.class_Ovalo1.Name = "class_Ovalo1";
            this.class_Ovalo1.Size = new System.Drawing.Size(69, 65);
            this.class_Ovalo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.class_Ovalo1.TabIndex = 12;
            this.class_Ovalo1.TabStop = false;
            // 
            // lbl_emblema
            // 
            this.lbl_emblema.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_emblema.AutoSize = true;
            this.lbl_emblema.Font = new System.Drawing.Font("NewsGoth Cn BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emblema.ForeColor = System.Drawing.Color.White;
            this.lbl_emblema.Location = new System.Drawing.Point(628, 30);
            this.lbl_emblema.Name = "lbl_emblema";
            this.lbl_emblema.Size = new System.Drawing.Size(111, 29);
            this.lbl_emblema.TabIndex = 0;
            this.lbl_emblema.Text = "GYMCENTER";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.Color.White;
            this.lbl_usuario.Location = new System.Drawing.Point(99, 30);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(146, 20);
            this.lbl_usuario.TabIndex = 13;
            this.lbl_usuario.Text = "Nombre de Usuario";
            // 
            // lbl_control_sesion
            // 
            this.lbl_control_sesion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_control_sesion.AutoSize = true;
            this.lbl_control_sesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_control_sesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_control_sesion.ForeColor = System.Drawing.Color.Red;
            this.lbl_control_sesion.Location = new System.Drawing.Point(101, 50);
            this.lbl_control_sesion.Name = "lbl_control_sesion";
            this.lbl_control_sesion.Size = new System.Drawing.Size(83, 12);
            this.lbl_control_sesion.TabIndex = 14;
            this.lbl_control_sesion.Text = "CERRAR SESIÓN";
            this.lbl_control_sesion.Click += new System.EventHandler(this.lbl_control_sesion_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.txt_message);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lbl_album);
            this.panel1.Controls.Add(this.lbl_artista);
            this.panel1.Controls.Add(this.lbl_cancion);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.pb_album);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.btn_next);
            this.panel1.Controls.Add(this.btn_play);
            this.panel1.Controls.Add(this.btn_previous);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 655);
            this.panel1.TabIndex = 8;
            // 
            // txt_message
            // 
            this.txt_message.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_message.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txt_message.FlatAppearance.BorderSize = 0;
            this.txt_message.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_message.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.txt_message.ForeColor = System.Drawing.Color.White;
            this.txt_message.Location = new System.Drawing.Point(0, 388);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(260, 56);
            this.txt_message.TabIndex = 11;
            this.txt_message.Text = "El proceso SpotifyWebHelper no está corriendo!";
            this.txt_message.UseVisualStyleBackColor = false;
            this.txt_message.Visible = false;
            this.txt_message.Click += new System.EventHandler(this.txt_message_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(-3, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "__________________________________________";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rb_inicio);
            this.panel3.Controls.Add(this.rb_punto_vta);
            this.panel3.Controls.Add(this.rb_membre);
            this.panel3.Controls.Add(this.rb_equipo);
            this.panel3.Controls.Add(this.rb_empleados);
            this.panel3.Controls.Add(this.rb_inventario);
            this.panel3.Controls.Add(this.rb_config);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 447);
            this.panel3.TabIndex = 11;
            // 
            // rb_inicio
            // 
            this.rb_inicio.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_inicio.AutoSize = true;
            this.rb_inicio.BackColor = System.Drawing.Color.Transparent;
            this.rb_inicio.BackgroundImage = global::Modulo_Empleados.Properties.Resources.Inicio1;
            this.rb_inicio.Checked = true;
            this.rb_inicio.FlatAppearance.BorderSize = 0;
            this.rb_inicio.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson;
            this.rb_inicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.rb_inicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.rb_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_inicio.Location = new System.Drawing.Point(0, 0);
            this.rb_inicio.MinimumSize = new System.Drawing.Size(260, 60);
            this.rb_inicio.Name = "rb_inicio";
            this.rb_inicio.Size = new System.Drawing.Size(260, 60);
            this.rb_inicio.TabIndex = 6;
            this.rb_inicio.TabStop = true;
            this.rb_inicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_inicio.UseVisualStyleBackColor = false;
            this.rb_inicio.CheckedChanged += new System.EventHandler(this.rb_inicio_CheckedChanged);
            // 
            // rb_punto_vta
            // 
            this.rb_punto_vta.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_punto_vta.AutoSize = true;
            this.rb_punto_vta.BackColor = System.Drawing.Color.Transparent;
            this.rb_punto_vta.BackgroundImage = global::Modulo_Empleados.Properties.Resources.Punto1;
            this.rb_punto_vta.FlatAppearance.BorderSize = 0;
            this.rb_punto_vta.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson;
            this.rb_punto_vta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.rb_punto_vta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.rb_punto_vta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_punto_vta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rb_punto_vta.Location = new System.Drawing.Point(0, 60);
            this.rb_punto_vta.MinimumSize = new System.Drawing.Size(260, 60);
            this.rb_punto_vta.Name = "rb_punto_vta";
            this.rb_punto_vta.Size = new System.Drawing.Size(260, 60);
            this.rb_punto_vta.TabIndex = 7;
            this.rb_punto_vta.UseVisualStyleBackColor = false;
            this.rb_punto_vta.Click += new System.EventHandler(this.rb_punto_vta_CheckedChanged);
            // 
            // rb_membre
            // 
            this.rb_membre.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_membre.AutoSize = true;
            this.rb_membre.BackColor = System.Drawing.Color.Transparent;
            this.rb_membre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rb_membre.BackgroundImage")));
            this.rb_membre.FlatAppearance.BorderSize = 0;
            this.rb_membre.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson;
            this.rb_membre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.rb_membre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.rb_membre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_membre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rb_membre.Location = new System.Drawing.Point(0, 180);
            this.rb_membre.MinimumSize = new System.Drawing.Size(260, 60);
            this.rb_membre.Name = "rb_membre";
            this.rb_membre.Size = new System.Drawing.Size(260, 60);
            this.rb_membre.TabIndex = 8;
            this.rb_membre.UseVisualStyleBackColor = false;
            this.rb_membre.CheckedChanged += new System.EventHandler(this.rb_membre_Click);
            // 
            // rb_equipo
            // 
            this.rb_equipo.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_equipo.AutoSize = true;
            this.rb_equipo.BackColor = System.Drawing.Color.Transparent;
            this.rb_equipo.BackgroundImage = global::Modulo_Empleados.Properties.Resources.Equipo1;
            this.rb_equipo.FlatAppearance.BorderSize = 0;
            this.rb_equipo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson;
            this.rb_equipo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.rb_equipo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.rb_equipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_equipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rb_equipo.Location = new System.Drawing.Point(0, 240);
            this.rb_equipo.MinimumSize = new System.Drawing.Size(260, 60);
            this.rb_equipo.Name = "rb_equipo";
            this.rb_equipo.Size = new System.Drawing.Size(260, 60);
            this.rb_equipo.TabIndex = 9;
            this.rb_equipo.UseVisualStyleBackColor = false;
            this.rb_equipo.CheckedChanged += new System.EventHandler(this.rb_equipo_CheckedChanged);
            // 
            // rb_empleados
            // 
            this.rb_empleados.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_empleados.AutoSize = true;
            this.rb_empleados.BackColor = System.Drawing.Color.Transparent;
            this.rb_empleados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rb_empleados.BackgroundImage")));
            this.rb_empleados.FlatAppearance.BorderSize = 0;
            this.rb_empleados.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson;
            this.rb_empleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.rb_empleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.rb_empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_empleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rb_empleados.Location = new System.Drawing.Point(0, 300);
            this.rb_empleados.MinimumSize = new System.Drawing.Size(260, 60);
            this.rb_empleados.Name = "rb_empleados";
            this.rb_empleados.Size = new System.Drawing.Size(260, 60);
            this.rb_empleados.TabIndex = 10;
            this.rb_empleados.UseVisualStyleBackColor = false;
            this.rb_empleados.CheckedChanged += new System.EventHandler(this.rb_empleados_CheckedChanged);
            // 
            // rb_inventario
            // 
            this.rb_inventario.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_inventario.AutoSize = true;
            this.rb_inventario.BackColor = System.Drawing.Color.Transparent;
            this.rb_inventario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rb_inventario.BackgroundImage")));
            this.rb_inventario.FlatAppearance.BorderSize = 0;
            this.rb_inventario.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson;
            this.rb_inventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.rb_inventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.rb_inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_inventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rb_inventario.Location = new System.Drawing.Point(0, 120);
            this.rb_inventario.MinimumSize = new System.Drawing.Size(260, 60);
            this.rb_inventario.Name = "rb_inventario";
            this.rb_inventario.Size = new System.Drawing.Size(260, 60);
            this.rb_inventario.TabIndex = 27;
            this.rb_inventario.UseVisualStyleBackColor = false;
            this.rb_inventario.CheckedChanged += new System.EventHandler(this.rb_inventario_CheckedChanged);
            // 
            // rb_config
            // 
            this.rb_config.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_config.AutoSize = true;
            this.rb_config.BackColor = System.Drawing.Color.Transparent;
            this.rb_config.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rb_config.BackgroundImage")));
            this.rb_config.FlatAppearance.BorderSize = 0;
            this.rb_config.FlatAppearance.CheckedBackColor = System.Drawing.Color.Crimson;
            this.rb_config.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.rb_config.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.rb_config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_config.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rb_config.Location = new System.Drawing.Point(0, 360);
            this.rb_config.MinimumSize = new System.Drawing.Size(260, 60);
            this.rb_config.Name = "rb_config";
            this.rb_config.Size = new System.Drawing.Size(260, 60);
            this.rb_config.TabIndex = 11;
            this.rb_config.UseVisualStyleBackColor = false;
            this.rb_config.Click += new System.EventHandler(this.rb_config_CheckedChanged);
            // 
            // lbl_album
            // 
            this.lbl_album.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_album.AutoSize = true;
            this.lbl_album.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_album.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_album.Location = new System.Drawing.Point(93, 519);
            this.lbl_album.Name = "lbl_album";
            this.lbl_album.Size = new System.Drawing.Size(47, 18);
            this.lbl_album.TabIndex = 31;
            this.lbl_album.Text = "Álbum";
            // 
            // lbl_artista
            // 
            this.lbl_artista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_artista.AutoSize = true;
            this.lbl_artista.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_artista.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_artista.Location = new System.Drawing.Point(93, 501);
            this.lbl_artista.Name = "lbl_artista";
            this.lbl_artista.Size = new System.Drawing.Size(47, 18);
            this.lbl_artista.TabIndex = 30;
            this.lbl_artista.Text = "Artista";
            // 
            // lbl_cancion
            // 
            this.lbl_cancion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_cancion.AutoSize = true;
            this.lbl_cancion.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cancion.ForeColor = System.Drawing.Color.White;
            this.lbl_cancion.Location = new System.Drawing.Point(93, 483);
            this.lbl_cancion.Name = "lbl_cancion";
            this.lbl_cancion.Size = new System.Drawing.Size(142, 18);
            this.lbl_cancion.TabIndex = 11;
            this.lbl_cancion.Text = "Título de la canción";
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(80, 621);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 29;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // pb_album
            // 
            this.pb_album.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pb_album.BackColor = System.Drawing.Color.Transparent;
            this.pb_album.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_album.Image = ((System.Drawing.Image)(resources.GetObject("pb_album.Image")));
            this.pb_album.Location = new System.Drawing.Point(12, 471);
            this.pb_album.Name = "pb_album";
            this.pb_album.Size = new System.Drawing.Size(75, 75);
            this.pb_album.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_album.TabIndex = 28;
            this.pb_album.TabStop = false;
            this.pb_album.Click += new System.EventHandler(this.pb_album_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(49, 621);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 24);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 26;
            this.pictureBox6.TabStop = false;
            // 
            // btn_next
            // 
            this.btn_next.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next.Image = ((System.Drawing.Image)(resources.GetObject("btn_next.Image")));
            this.btn_next.Location = new System.Drawing.Point(187, 578);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(15, 15);
            this.btn_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_next.TabIndex = 23;
            this.btn_next.TabStop = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_play
            // 
            this.btn_play.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_play.Image = ((System.Drawing.Image)(resources.GetObject("btn_play.Image")));
            this.btn_play.Location = new System.Drawing.Point(108, 567);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(40, 40);
            this.btn_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_play.TabIndex = 21;
            this.btn_play.TabStop = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_previous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_previous.Image = ((System.Drawing.Image)(resources.GetObject("btn_previous.Image")));
            this.btn_previous.Location = new System.Drawing.Point(53, 578);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(15, 15);
            this.btn_previous.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_previous.TabIndex = 22;
            this.btn_previous.TabStop = false;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.puntoDeVentaToolStripMenuItem,
            this.membresíasToolStripMenuItem,
            this.visitasToolStripMenuItem,
            this.equipoToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.configuracionesToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.windowToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1366, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // puntoDeVentaToolStripMenuItem
            // 
            this.puntoDeVentaToolStripMenuItem.Name = "puntoDeVentaToolStripMenuItem";
            this.puntoDeVentaToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.puntoDeVentaToolStripMenuItem.Text = "Punto de Venta";
            // 
            // membresíasToolStripMenuItem
            // 
            this.membresíasToolStripMenuItem.Name = "membresíasToolStripMenuItem";
            this.membresíasToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.membresíasToolStripMenuItem.Text = "Clientes";
            // 
            // visitasToolStripMenuItem
            // 
            this.visitasToolStripMenuItem.Name = "visitasToolStripMenuItem";
            this.visitasToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.visitasToolStripMenuItem.Text = "Visitas";
            // 
            // equipoToolStripMenuItem
            // 
            this.equipoToolStripMenuItem.Name = "equipoToolStripMenuItem";
            this.equipoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.equipoToolStripMenuItem.Text = "Equipo";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // configuracionesToolStripMenuItem
            // 
            this.configuracionesToolStripMenuItem.Name = "configuracionesToolStripMenuItem";
            this.configuracionesToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.configuracionesToolStripMenuItem.Text = "Configuraciones";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.windowToolStripMenuItem.Text = "Ventanas";
            // 
            // mensage_timer
            // 
            this.mensage_timer.Tick += new System.EventHandler(this.mensage_timer_Tick);
            // 
            // conexion
            // 
            this.conexion.Tick += new System.EventHandler(this.conexion_Tick);
            // 
            // btn_install
            // 
            this.btn_install.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_install.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_install.FlatAppearance.BorderSize = 0;
            this.btn_install.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_install.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.btn_install.ForeColor = System.Drawing.Color.White;
            this.btn_install.Location = new System.Drawing.Point(260, 113);
            this.btn_install.Name = "btn_install";
            this.btn_install.Size = new System.Drawing.Size(1106, 39);
            this.btn_install.TabIndex = 12;
            this.btn_install.Text = "Ups :( Parece que no hemos podido encontrar Spotify en tu computadora. Puedes des" +
    "cargarlo dando click en este cuadro de texto";
            this.btn_install.UseVisualStyleBackColor = false;
            this.btn_install.Visible = false;
            this.btn_install.Click += new System.EventHandler(this.btn_install_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(756, 189);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(243, 13);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://www.spotify.com/mx/download/windows/";
            this.linkLabel1.Visible = false;
            // 
            // Formulario_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_install);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Formulario_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMBLEMA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Formulario_Principal_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.class_Ovalo1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_album)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_previous)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Label lbl_emblema;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rb_inicio;
        private System.Windows.Forms.RadioButton rb_config;
        private System.Windows.Forms.RadioButton rb_empleados;
        private System.Windows.Forms.RadioButton rb_equipo;
        private System.Windows.Forms.RadioButton rb_membre;
        private System.Windows.Forms.RadioButton rb_punto_vta;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox btn_next;
        private System.Windows.Forms.PictureBox btn_previous;
        private System.Windows.Forms.PictureBox btn_play;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puntoDeVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membresíasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private Class_Ovalo class_Ovalo1;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_control_sesion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_inventario;
        private System.Windows.Forms.Label lbl_album;
        private System.Windows.Forms.Label lbl_artista;
        private System.Windows.Forms.Label lbl_cancion;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pb_album;
        private System.Windows.Forms.Timer mensage_timer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button txt_message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer conexion;
        private System.Windows.Forms.Button btn_install;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

