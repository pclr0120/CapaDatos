namespace Modulo_Empleados.INTERFAZ_PRINCIPAL
{
    partial class Reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rb_equipo = new System.Windows.Forms.RadioButton();
            this.rb_punto_vta = new System.Windows.Forms.RadioButton();
            this.rb_membre = new System.Windows.Forms.RadioButton();
            this.rb_empleados = new System.Windows.Forms.RadioButton();
            this.rb_inventario = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_min = new System.Windows.Forms.Button();
            this.class_Ovalo1 = new EMBLEMA.Class_Ovalo();
            this.lbl_emblema = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl_Reportes = new System.Windows.Forms.TabControl();
            this.tab_punto = new System.Windows.Forms.TabPage();
            this.tab_inv = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tab_clientes = new System.Windows.Forms.TabPage();
            this.tab_equipo = new System.Windows.Forms.TabPage();
            this.tab_empleados = new System.Windows.Forms.TabPage();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crystalReportViewer3 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crystalReportViewer4 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crystalReportViewer5 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.class_Ovalo1)).BeginInit();
            this.tabControl_Reportes.SuspendLayout();
            this.tab_punto.SuspendLayout();
            this.tab_inv.SuspendLayout();
            this.tab_clientes.SuspendLayout();
            this.tab_equipo.SuspendLayout();
            this.tab_empleados.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 478);
            this.panel1.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.rb_equipo);
            this.panel3.Controls.Add(this.rb_punto_vta);
            this.panel3.Controls.Add(this.rb_membre);
            this.panel3.Controls.Add(this.rb_empleados);
            this.panel3.Controls.Add(this.rb_inventario);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 439);
            this.panel3.TabIndex = 11;
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
            this.rb_equipo.Location = new System.Drawing.Point(0, 183);
            this.rb_equipo.MinimumSize = new System.Drawing.Size(260, 60);
            this.rb_equipo.Name = "rb_equipo";
            this.rb_equipo.Size = new System.Drawing.Size(260, 60);
            this.rb_equipo.TabIndex = 9;
            this.rb_equipo.UseVisualStyleBackColor = false;
            this.rb_equipo.CheckedChanged += new System.EventHandler(this.rb_equipo_CheckedChanged);
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
            this.rb_punto_vta.Location = new System.Drawing.Point(0, 3);
            this.rb_punto_vta.MinimumSize = new System.Drawing.Size(260, 60);
            this.rb_punto_vta.Name = "rb_punto_vta";
            this.rb_punto_vta.Size = new System.Drawing.Size(260, 60);
            this.rb_punto_vta.TabIndex = 7;
            this.rb_punto_vta.UseVisualStyleBackColor = false;
            this.rb_punto_vta.CheckedChanged += new System.EventHandler(this.rb_punto_vta_CheckedChanged);
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
            this.rb_membre.Location = new System.Drawing.Point(0, 123);
            this.rb_membre.MinimumSize = new System.Drawing.Size(260, 60);
            this.rb_membre.Name = "rb_membre";
            this.rb_membre.Size = new System.Drawing.Size(260, 60);
            this.rb_membre.TabIndex = 8;
            this.rb_membre.UseVisualStyleBackColor = false;
            this.rb_membre.CheckedChanged += new System.EventHandler(this.rb_membre_CheckedChanged);
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
            this.rb_empleados.Location = new System.Drawing.Point(0, 243);
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
            this.rb_inventario.Location = new System.Drawing.Point(0, 63);
            this.rb_inventario.MinimumSize = new System.Drawing.Size(260, 60);
            this.rb_inventario.Name = "rb_inventario";
            this.rb_inventario.Size = new System.Drawing.Size(260, 60);
            this.rb_inventario.TabIndex = 27;
            this.rb_inventario.UseVisualStyleBackColor = false;
            this.rb_inventario.CheckedChanged += new System.EventHandler(this.rb_inventario_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_min);
            this.panel2.Controls.Add(this.class_Ovalo1);
            this.panel2.Controls.Add(this.lbl_emblema);
            this.panel2.Controls.Add(this.lbl_usuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(911, 89);
            this.panel2.TabIndex = 10;
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
            this.btn_min.Location = new System.Drawing.Point(835, 0);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(40, 25);
            this.btn_min.TabIndex = 1;
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // class_Ovalo1
            // 
            this.class_Ovalo1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.class_Ovalo1.BackColor = System.Drawing.Color.Transparent;
            this.class_Ovalo1.Image = ((System.Drawing.Image)(resources.GetObject("class_Ovalo1.Image")));
            this.class_Ovalo1.Location = new System.Drawing.Point(20, 13);
            this.class_Ovalo1.Name = "class_Ovalo1";
            this.class_Ovalo1.Size = new System.Drawing.Size(69, 65);
            this.class_Ovalo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.class_Ovalo1.TabIndex = 12;
            this.class_Ovalo1.TabStop = false;
            // 
            // lbl_emblema
            // 
            this.lbl_emblema.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_emblema.AutoSize = true;
            this.lbl_emblema.Font = new System.Drawing.Font("NewsGoth Cn BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emblema.ForeColor = System.Drawing.Color.White;
            this.lbl_emblema.Location = new System.Drawing.Point(400, 30);
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
            this.lbl_usuario.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.Color.White;
            this.lbl_usuario.Location = new System.Drawing.Point(99, 23);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(175, 43);
            this.lbl_usuario.TabIndex = 13;
            this.lbl_usuario.Text = "REPORTES";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(871, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 25);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl_Reportes
            // 
            this.tabControl_Reportes.Controls.Add(this.tab_punto);
            this.tabControl_Reportes.Controls.Add(this.tab_inv);
            this.tabControl_Reportes.Controls.Add(this.tab_clientes);
            this.tabControl_Reportes.Controls.Add(this.tab_equipo);
            this.tabControl_Reportes.Controls.Add(this.tab_empleados);
            this.tabControl_Reportes.Location = new System.Drawing.Point(276, 123);
            this.tabControl_Reportes.Name = "tabControl_Reportes";
            this.tabControl_Reportes.SelectedIndex = 0;
            this.tabControl_Reportes.Size = new System.Drawing.Size(599, 424);
            this.tabControl_Reportes.TabIndex = 11;
            // 
            // tab_punto
            // 
            this.tab_punto.Controls.Add(this.crystalReportViewer1);
            this.tab_punto.Location = new System.Drawing.Point(4, 22);
            this.tab_punto.Name = "tab_punto";
            this.tab_punto.Padding = new System.Windows.Forms.Padding(3);
            this.tab_punto.Size = new System.Drawing.Size(591, 398);
            this.tab_punto.TabIndex = 0;
            this.tab_punto.Text = "Punto de Venta";
            this.tab_punto.UseVisualStyleBackColor = true;
            // 
            // tab_inv
            // 
            this.tab_inv.Controls.Add(this.crystalReportViewer2);
            this.tab_inv.Location = new System.Drawing.Point(4, 22);
            this.tab_inv.Name = "tab_inv";
            this.tab_inv.Padding = new System.Windows.Forms.Padding(3);
            this.tab_inv.Size = new System.Drawing.Size(591, 398);
            this.tab_inv.TabIndex = 1;
            this.tab_inv.Text = "Inventario";
            this.tab_inv.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Location = new System.Drawing.Point(260, 89);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(650, 25);
            this.panel4.TabIndex = 15;
            // 
            // tab_clientes
            // 
            this.tab_clientes.Controls.Add(this.crystalReportViewer3);
            this.tab_clientes.Location = new System.Drawing.Point(4, 22);
            this.tab_clientes.Name = "tab_clientes";
            this.tab_clientes.Padding = new System.Windows.Forms.Padding(3);
            this.tab_clientes.Size = new System.Drawing.Size(591, 398);
            this.tab_clientes.TabIndex = 2;
            this.tab_clientes.Text = "Clientes";
            this.tab_clientes.UseVisualStyleBackColor = true;
            // 
            // tab_equipo
            // 
            this.tab_equipo.Controls.Add(this.crystalReportViewer4);
            this.tab_equipo.Location = new System.Drawing.Point(4, 22);
            this.tab_equipo.Name = "tab_equipo";
            this.tab_equipo.Padding = new System.Windows.Forms.Padding(3);
            this.tab_equipo.Size = new System.Drawing.Size(591, 398);
            this.tab_equipo.TabIndex = 3;
            this.tab_equipo.Text = "Equipo";
            this.tab_equipo.UseVisualStyleBackColor = true;
            // 
            // tab_empleados
            // 
            this.tab_empleados.Controls.Add(this.crystalReportViewer5);
            this.tab_empleados.Location = new System.Drawing.Point(4, 22);
            this.tab_empleados.Name = "tab_empleados";
            this.tab_empleados.Padding = new System.Windows.Forms.Padding(3);
            this.tab_empleados.Size = new System.Drawing.Size(591, 398);
            this.tab_empleados.TabIndex = 4;
            this.tab_empleados.Text = "Empleados";
            this.tab_empleados.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(585, 392);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = -1;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer2.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.Size = new System.Drawing.Size(585, 392);
            this.crystalReportViewer2.TabIndex = 0;
            // 
            // crystalReportViewer3
            // 
            this.crystalReportViewer3.ActiveViewIndex = -1;
            this.crystalReportViewer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer3.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer3.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewer3.Name = "crystalReportViewer3";
            this.crystalReportViewer3.Size = new System.Drawing.Size(585, 392);
            this.crystalReportViewer3.TabIndex = 0;
            // 
            // crystalReportViewer4
            // 
            this.crystalReportViewer4.ActiveViewIndex = -1;
            this.crystalReportViewer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer4.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer4.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewer4.Name = "crystalReportViewer4";
            this.crystalReportViewer4.Size = new System.Drawing.Size(585, 392);
            this.crystalReportViewer4.TabIndex = 0;
            // 
            // crystalReportViewer5
            // 
            this.crystalReportViewer5.ActiveViewIndex = -1;
            this.crystalReportViewer5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer5.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer5.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewer5.Name = "crystalReportViewer5";
            this.crystalReportViewer5.Size = new System.Drawing.Size(585, 392);
            this.crystalReportViewer5.TabIndex = 0;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 567);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tabControl_Reportes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.class_Ovalo1)).EndInit();
            this.tabControl_Reportes.ResumeLayout(false);
            this.tab_punto.ResumeLayout(false);
            this.tab_inv.ResumeLayout(false);
            this.tab_clientes.ResumeLayout(false);
            this.tab_equipo.ResumeLayout(false);
            this.tab_empleados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rb_equipo;
        private System.Windows.Forms.RadioButton rb_punto_vta;
        private System.Windows.Forms.RadioButton rb_membre;
        private System.Windows.Forms.RadioButton rb_empleados;
        private System.Windows.Forms.RadioButton rb_inventario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_min;
        private EMBLEMA.Class_Ovalo class_Ovalo1;
        private System.Windows.Forms.Label lbl_emblema;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.TabControl tabControl_Reportes;
        private System.Windows.Forms.TabPage tab_punto;
        private System.Windows.Forms.TabPage tab_inv;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabPage tab_clientes;
        private System.Windows.Forms.TabPage tab_equipo;
        private System.Windows.Forms.TabPage tab_empleados;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer4;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer5;
    }
}