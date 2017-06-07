namespace Inicio
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_temp = new System.Windows.Forms.Label();
            this.lbl_ciudad = new System.Windows.Forms.Label();
            this.lbl_dia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picture_clima = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_precip = new System.Windows.Forms.Label();
            this.lbl_hum = new System.Windows.Forms.Label();
            this.lbl_viento = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_next = new System.Windows.Forms.PictureBox();
            this.btn_play = new System.Windows.Forms.PictureBox();
            this.btn_previous = new System.Windows.Forms.PictureBox();
            this.group = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timer_clima = new System.Windows.Forms.Timer(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.lbl_tiempo = new System.Windows.Forms.Label();
            this.lbl_no = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_clima)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_previous)).BeginInit();
            this.group.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 57);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(452, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(644, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 477);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_temp
            // 
            this.lbl_temp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_temp.AutoSize = true;
            this.lbl_temp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_temp.Font = new System.Drawing.Font("Arial Narrow", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temp.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_temp.Location = new System.Drawing.Point(787, 206);
            this.lbl_temp.Name = "lbl_temp";
            this.lbl_temp.Size = new System.Drawing.Size(135, 110);
            this.lbl_temp.TabIndex = 7;
            this.lbl_temp.Text = "00";
            // 
            // lbl_ciudad
            // 
            this.lbl_ciudad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ciudad.AutoSize = true;
            this.lbl_ciudad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_ciudad.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ciudad.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_ciudad.Location = new System.Drawing.Point(650, 107);
            this.lbl_ciudad.Name = "lbl_ciudad";
            this.lbl_ciudad.Size = new System.Drawing.Size(107, 33);
            this.lbl_ciudad.TabIndex = 8;
            this.lbl_ciudad.Text = "Ciudad";
            // 
            // lbl_dia
            // 
            this.lbl_dia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dia.AutoSize = true;
            this.lbl_dia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_dia.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dia.ForeColor = System.Drawing.Color.Gray;
            this.lbl_dia.Location = new System.Drawing.Point(651, 140);
            this.lbl_dia.Name = "lbl_dia";
            this.lbl_dia.Size = new System.Drawing.Size(41, 25);
            this.lbl_dia.TabIndex = 9;
            this.lbl_dia.Text = "Día";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(668, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Clima";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // picture_clima
            // 
            this.picture_clima.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picture_clima.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picture_clima.Image = ((System.Drawing.Image)(resources.GetObject("picture_clima.Image")));
            this.picture_clima.Location = new System.Drawing.Point(656, 206);
            this.picture_clima.Name = "picture_clima";
            this.picture_clima.Size = new System.Drawing.Size(125, 125);
            this.picture_clima.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_clima.TabIndex = 11;
            this.picture_clima.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(895, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "°C";
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_busqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busqueda.ForeColor = System.Drawing.Color.Gray;
            this.txt_busqueda.Location = new System.Drawing.Point(644, 60);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(250, 22);
            this.txt_busqueda.TabIndex = 13;
            this.txt_busqueda.Text = "Buscar ciudad";
            this.txt_busqueda.Click += new System.EventHandler(this.txt_busqueda_Click);
            this.txt_busqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_busqueda_KeyPress);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscar.BackColor = System.Drawing.Color.DimGray;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.ForeColor = System.Drawing.Color.LightGray;
            this.btn_buscar.Location = new System.Drawing.Point(890, 57);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(74, 26);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // lbl_precip
            // 
            this.lbl_precip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_precip.AutoSize = true;
            this.lbl_precip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_precip.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precip.ForeColor = System.Drawing.Color.Gray;
            this.lbl_precip.Location = new System.Drawing.Point(730, 359);
            this.lbl_precip.Name = "lbl_precip";
            this.lbl_precip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_precip.Size = new System.Drawing.Size(117, 21);
            this.lbl_precip.TabIndex = 14;
            this.lbl_precip.Text = "Precipitaciones";
            this.lbl_precip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_hum
            // 
            this.lbl_hum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_hum.AutoSize = true;
            this.lbl_hum.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_hum.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hum.ForeColor = System.Drawing.Color.Gray;
            this.lbl_hum.Location = new System.Drawing.Point(730, 380);
            this.lbl_hum.Name = "lbl_hum";
            this.lbl_hum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_hum.Size = new System.Drawing.Size(80, 21);
            this.lbl_hum.TabIndex = 15;
            this.lbl_hum.Text = "Humedad";
            this.lbl_hum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_viento
            // 
            this.lbl_viento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_viento.AutoSize = true;
            this.lbl_viento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_viento.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_viento.ForeColor = System.Drawing.Color.Gray;
            this.lbl_viento.Location = new System.Drawing.Point(730, 401);
            this.lbl_viento.Name = "lbl_viento";
            this.lbl_viento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_viento.Size = new System.Drawing.Size(55, 21);
            this.lbl_viento.TabIndex = 16;
            this.lbl_viento.Text = "Viento";
            this.lbl_viento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("NewsGoth Cn BT", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(50, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(455, 115);
            this.label9.TabIndex = 18;
            this.label9.Text = "BIENVENIDO";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btn_next);
            this.panel2.Controls.Add(this.btn_play);
            this.panel2.Controls.Add(this.btn_previous);
            this.panel2.Controls.Add(this.group);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 477);
            this.panel2.TabIndex = 17;
            // 
            // btn_next
            // 
            this.btn_next.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_next.BackColor = System.Drawing.Color.Transparent;
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next.Image = ((System.Drawing.Image)(resources.GetObject("btn_next.Image")));
            this.btn_next.Location = new System.Drawing.Point(521, 400);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(30, 30);
            this.btn_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_next.TabIndex = 26;
            this.btn_next.TabStop = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_play
            // 
            this.btn_play.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_play.BackColor = System.Drawing.Color.Transparent;
            this.btn_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_play.Image = ((System.Drawing.Image)(resources.GetObject("btn_play.Image")));
            this.btn_play.Location = new System.Drawing.Point(282, 371);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(80, 80);
            this.btn_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_play.TabIndex = 24;
            this.btn_play.TabStop = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_previous.BackColor = System.Drawing.Color.Transparent;
            this.btn_previous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_previous.Image = ((System.Drawing.Image)(resources.GetObject("btn_previous.Image")));
            this.btn_previous.Location = new System.Drawing.Point(94, 400);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(30, 30);
            this.btn_previous.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_previous.TabIndex = 25;
            this.btn_previous.TabStop = false;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // group
            // 
            this.group.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.group.BackColor = System.Drawing.Color.Transparent;
            this.group.Controls.Add(this.label11);
            this.group.Controls.Add(this.label10);
            this.group.Controls.Add(this.label9);
            this.group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.group.Location = new System.Drawing.Point(45, 119);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(554, 239);
            this.group.TabIndex = 21;
            this.group.TabStop = false;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(86, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(382, 40);
            this.label11.TabIndex = 19;
            this.label11.Text = "Da click en el ícono para sincronizar EMBLEMA® con tu \r\nmúsica favorita de tu cue" +
    "nta de Spotify®";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(61, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(432, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "¿Que tal si comienzas poniendo algo de música?";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(679, 471);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(264, 54);
            this.label12.TabIndex = 21;
            this.label12.Text = "Esté siempre prevenido\r\nConsulte el clima para predecir la asistencia\r\nde sus cli" +
    "entes :)";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_clima
            // 
            this.timer_clima.Tick += new System.EventHandler(this.timer_clima_Tick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(644, 471);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(250, 63);
            this.webBrowser1.TabIndex = 22;
            this.webBrowser1.Url = new System.Uri("https://www.google.com.mx/?gws_rd=ssl#q=clima+Los Mochis", System.UriKind.Absolute);
            this.webBrowser1.Visible = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // lbl_tiempo
            // 
            this.lbl_tiempo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_tiempo.AutoSize = true;
            this.lbl_tiempo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_tiempo.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tiempo.ForeColor = System.Drawing.Color.Gray;
            this.lbl_tiempo.Location = new System.Drawing.Point(652, 168);
            this.lbl_tiempo.Name = "lbl_tiempo";
            this.lbl_tiempo.Size = new System.Drawing.Size(34, 21);
            this.lbl_tiempo.TabIndex = 23;
            this.lbl_tiempo.Text = "Día";
            // 
            // lbl_no
            // 
            this.lbl_no.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_no.AutoSize = true;
            this.lbl_no.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_no.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_no.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_no.Location = new System.Drawing.Point(650, 85);
            this.lbl_no.Name = "lbl_no";
            this.lbl_no.Size = new System.Drawing.Size(232, 18);
            this.lbl_no.TabIndex = 24;
            this.lbl_no.Text = "No se encontró la ciudad especificada";
            this.lbl_no.Visible = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(964, 534);
            this.Controls.Add(this.lbl_no);
            this.Controls.Add(this.lbl_tiempo);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_viento);
            this.Controls.Add(this.lbl_hum);
            this.Controls.Add(this.lbl_precip);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_busqueda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picture_clima);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_dia);
            this.Controls.Add(this.lbl_ciudad);
            this.Controls.Add(this.lbl_temp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_clima)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_previous)).EndInit();
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_temp;
        private System.Windows.Forms.Label lbl_ciudad;
        private System.Windows.Forms.Label lbl_dia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picture_clima;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_precip;
        private System.Windows.Forms.Label lbl_hum;
        private System.Windows.Forms.Label lbl_viento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer timer_clima;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label lbl_tiempo;
        private System.Windows.Forms.Label lbl_no;
        public System.Windows.Forms.GroupBox group;
        public System.Windows.Forms.PictureBox btn_next;
        public System.Windows.Forms.PictureBox btn_play;
        public System.Windows.Forms.PictureBox btn_previous;
        public System.Windows.Forms.Panel panel2;
    }
}

