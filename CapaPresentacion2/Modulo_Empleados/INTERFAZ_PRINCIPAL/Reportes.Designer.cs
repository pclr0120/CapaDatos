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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.class_Ovalo1 = new EMBLEMA.Class_Ovalo();
            this.lbl_emblema = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.tabControl_Reportes = new System.Windows.Forms.TabControl();
            this.tab_punto = new System.Windows.Forms.TabPage();
            this.ch_empleado = new System.Windows.Forms.CheckBox();
            this.ch_producto = new System.Windows.Forms.CheckBox();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_inicial = new System.Windows.Forms.DateTimePicker();
            this.dtp_final = new System.Windows.Forms.DateTimePicker();
            this.cb_empleado = new System.Windows.Forms.ComboBox();
            this.cb_producto = new System.Windows.Forms.ComboBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.VentaGananciasDiarias2 = new Modulo_Empleados.INTERFAZ_PRINCIPAL.VentaGananciasDiarias();
            this.tab_inv = new System.Windows.Forms.TabPage();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.InventarioMostrarStock2 = new Modulo_Empleados.INTERFAZ_PRINCIPAL.InventarioMostrarStock();
            this.tab_clientes = new System.Windows.Forms.TabPage();
            this.crystalReportViewer3 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ClientesActivos2 = new Modulo_Empleados.INTERFAZ_PRINCIPAL.ClientesActivos();
            this.tab_equipo = new System.Windows.Forms.TabPage();
            this.crystalReportViewer4 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.EquiposActivos2 = new Modulo_Empleados.INTERFAZ_PRINCIPAL.EquiposActivos();
            this.tab_empleados = new System.Windows.Forms.TabPage();
            this.crystalReportViewer5 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.EmpleadosActivos2 = new Modulo_Empleados.INTERFAZ_PRINCIPAL.EmpleadosActivos();
            this.ClientesActivos1 = new Modulo_Empleados.INTERFAZ_PRINCIPAL.ClientesActivos();
            this.EquiposActivos1 = new Modulo_Empleados.INTERFAZ_PRINCIPAL.EquiposActivos();
            this.EmpleadosActivos1 = new Modulo_Empleados.INTERFAZ_PRINCIPAL.EmpleadosActivos();
            this.panel4 = new System.Windows.Forms.Panel();
            this.VentaGananciasDiarias1 = new Modulo_Empleados.INTERFAZ_PRINCIPAL.VentaGananciasDiarias();
            this.InventarioMostrarStock1 = new Modulo_Empleados.INTERFAZ_PRINCIPAL.InventarioMostrarStock();
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
            this.panel1.Location = new System.Drawing.Point(0, 110);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 588);
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
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 540);
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
            this.rb_equipo.Location = new System.Drawing.Point(0, 225);
            this.rb_equipo.Margin = new System.Windows.Forms.Padding(4);
            this.rb_equipo.MinimumSize = new System.Drawing.Size(347, 74);
            this.rb_equipo.Name = "rb_equipo";
            this.rb_equipo.Size = new System.Drawing.Size(347, 74);
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
            this.rb_punto_vta.Location = new System.Drawing.Point(0, 4);
            this.rb_punto_vta.Margin = new System.Windows.Forms.Padding(4);
            this.rb_punto_vta.MinimumSize = new System.Drawing.Size(347, 74);
            this.rb_punto_vta.Name = "rb_punto_vta";
            this.rb_punto_vta.Size = new System.Drawing.Size(347, 74);
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
            this.rb_membre.Location = new System.Drawing.Point(0, 151);
            this.rb_membre.Margin = new System.Windows.Forms.Padding(4);
            this.rb_membre.MinimumSize = new System.Drawing.Size(347, 74);
            this.rb_membre.Name = "rb_membre";
            this.rb_membre.Size = new System.Drawing.Size(347, 74);
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
            this.rb_empleados.Location = new System.Drawing.Point(0, 299);
            this.rb_empleados.Margin = new System.Windows.Forms.Padding(4);
            this.rb_empleados.MinimumSize = new System.Drawing.Size(347, 74);
            this.rb_empleados.Name = "rb_empleados";
            this.rb_empleados.Size = new System.Drawing.Size(347, 74);
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
            this.rb_inventario.Location = new System.Drawing.Point(0, 78);
            this.rb_inventario.Margin = new System.Windows.Forms.Padding(4);
            this.rb_inventario.MinimumSize = new System.Drawing.Size(347, 74);
            this.rb_inventario.Name = "rb_inventario";
            this.rb_inventario.Size = new System.Drawing.Size(347, 74);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1215, 110);
            this.panel2.TabIndex = 10;
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
            this.button1.Location = new System.Drawing.Point(1161, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 31);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.btn_min.Location = new System.Drawing.Point(1113, 0);
            this.btn_min.Margin = new System.Windows.Forms.Padding(4);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(53, 31);
            this.btn_min.TabIndex = 1;
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // class_Ovalo1
            // 
            this.class_Ovalo1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.class_Ovalo1.BackColor = System.Drawing.Color.Transparent;
            this.class_Ovalo1.Image = ((System.Drawing.Image)(resources.GetObject("class_Ovalo1.Image")));
            this.class_Ovalo1.Location = new System.Drawing.Point(27, 16);
            this.class_Ovalo1.Margin = new System.Windows.Forms.Padding(4);
            this.class_Ovalo1.Name = "class_Ovalo1";
            this.class_Ovalo1.Size = new System.Drawing.Size(92, 80);
            this.class_Ovalo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.class_Ovalo1.TabIndex = 12;
            this.class_Ovalo1.TabStop = false;
            // 
            // lbl_emblema
            // 
            this.lbl_emblema.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_emblema.AutoSize = true;
            this.lbl_emblema.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emblema.ForeColor = System.Drawing.Color.White;
            this.lbl_emblema.Location = new System.Drawing.Point(533, 37);
            this.lbl_emblema.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_emblema.Name = "lbl_emblema";
            this.lbl_emblema.Size = new System.Drawing.Size(206, 36);
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
            this.lbl_usuario.Location = new System.Drawing.Point(132, 28);
            this.lbl_usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(202, 55);
            this.lbl_usuario.TabIndex = 13;
            this.lbl_usuario.Text = "REPORTES";
            // 
            // tabControl_Reportes
            // 
            this.tabControl_Reportes.Controls.Add(this.tab_punto);
            this.tabControl_Reportes.Controls.Add(this.tab_inv);
            this.tabControl_Reportes.Controls.Add(this.tab_clientes);
            this.tabControl_Reportes.Controls.Add(this.tab_equipo);
            this.tabControl_Reportes.Controls.Add(this.tab_empleados);
            this.tabControl_Reportes.Location = new System.Drawing.Point(368, 151);
            this.tabControl_Reportes.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl_Reportes.Name = "tabControl_Reportes";
            this.tabControl_Reportes.SelectedIndex = 0;
            this.tabControl_Reportes.Size = new System.Drawing.Size(799, 522);
            this.tabControl_Reportes.TabIndex = 11;
            // 
            // tab_punto
            // 
            this.tab_punto.Controls.Add(this.ch_empleado);
            this.tab_punto.Controls.Add(this.ch_producto);
            this.tab_punto.Controls.Add(this.btn_actualizar);
            this.tab_punto.Controls.Add(this.label2);
            this.tab_punto.Controls.Add(this.label1);
            this.tab_punto.Controls.Add(this.dtp_inicial);
            this.tab_punto.Controls.Add(this.dtp_final);
            this.tab_punto.Controls.Add(this.cb_empleado);
            this.tab_punto.Controls.Add(this.cb_producto);
            this.tab_punto.Controls.Add(this.crystalReportViewer1);
            this.tab_punto.Location = new System.Drawing.Point(4, 25);
            this.tab_punto.Margin = new System.Windows.Forms.Padding(4);
            this.tab_punto.Name = "tab_punto";
            this.tab_punto.Padding = new System.Windows.Forms.Padding(4);
            this.tab_punto.Size = new System.Drawing.Size(791, 493);
            this.tab_punto.TabIndex = 0;
            this.tab_punto.Text = "Punto de Venta";
            this.tab_punto.UseVisualStyleBackColor = true;
            // 
            // ch_empleado
            // 
            this.ch_empleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ch_empleado.AutoSize = true;
            this.ch_empleado.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_empleado.Location = new System.Drawing.Point(490, 292);
            this.ch_empleado.Name = "ch_empleado";
            this.ch_empleado.Size = new System.Drawing.Size(133, 31);
            this.ch_empleado.TabIndex = 11;
            this.ch_empleado.Text = "Empleado";
            this.ch_empleado.UseVisualStyleBackColor = true;
            this.ch_empleado.CheckedChanged += new System.EventHandler(this.ch_empleado_CheckedChanged);
            // 
            // ch_producto
            // 
            this.ch_producto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ch_producto.AutoSize = true;
            this.ch_producto.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_producto.Location = new System.Drawing.Point(490, 192);
            this.ch_producto.Name = "ch_producto";
            this.ch_producto.Size = new System.Drawing.Size(125, 31);
            this.ch_producto.TabIndex = 10;
            this.ch_producto.Text = "Producto";
            this.ch_producto.UseVisualStyleBackColor = true;
            this.ch_producto.CheckedChanged += new System.EventHandler(this.ch_producto_CheckedChanged);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_actualizar.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.Location = new System.Drawing.Point(400, 403);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(381, 57);
            this.btn_actualizar.TabIndex = 9;
            this.btn_actualizar.Text = "Actualizar información";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(420, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha final:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha inicial:";
            // 
            // dtp_inicial
            // 
            this.dtp_inicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_inicial.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_inicial.Location = new System.Drawing.Point(400, 39);
            this.dtp_inicial.Name = "dtp_inicial";
            this.dtp_inicial.Size = new System.Drawing.Size(381, 35);
            this.dtp_inicial.TabIndex = 1;
            this.dtp_inicial.Value = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            // 
            // dtp_final
            // 
            this.dtp_final.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_final.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_final.Location = new System.Drawing.Point(400, 139);
            this.dtp_final.Name = "dtp_final";
            this.dtp_final.Size = new System.Drawing.Size(381, 35);
            this.dtp_final.TabIndex = 2;
            // 
            // cb_empleado
            // 
            this.cb_empleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_empleado.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_empleado.FormattingEnabled = true;
            this.cb_empleado.Location = new System.Drawing.Point(400, 339);
            this.cb_empleado.Name = "cb_empleado";
            this.cb_empleado.Size = new System.Drawing.Size(381, 35);
            this.cb_empleado.TabIndex = 4;
            // 
            // cb_producto
            // 
            this.cb_producto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_producto.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_producto.FormattingEnabled = true;
            this.cb_producto.Location = new System.Drawing.Point(400, 239);
            this.cb_producto.Name = "cb_producto";
            this.cb_producto.Size = new System.Drawing.Size(381, 35);
            this.cb_producto.TabIndex = 3;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.VentaGananciasDiarias2;
            this.crystalReportViewer1.Size = new System.Drawing.Size(390, 485);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // tab_inv
            // 
            this.tab_inv.Controls.Add(this.crystalReportViewer2);
            this.tab_inv.Location = new System.Drawing.Point(4, 25);
            this.tab_inv.Margin = new System.Windows.Forms.Padding(4);
            this.tab_inv.Name = "tab_inv";
            this.tab_inv.Padding = new System.Windows.Forms.Padding(4);
            this.tab_inv.Size = new System.Drawing.Size(791, 493);
            this.tab_inv.TabIndex = 1;
            this.tab_inv.Text = "Inventario";
            this.tab_inv.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = 0;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer2.Location = new System.Drawing.Point(4, 4);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.ReportSource = this.InventarioMostrarStock2;
            this.crystalReportViewer2.Size = new System.Drawing.Size(783, 485);
            this.crystalReportViewer2.TabIndex = 0;
            // 
            // tab_clientes
            // 
            this.tab_clientes.Controls.Add(this.crystalReportViewer3);
            this.tab_clientes.Location = new System.Drawing.Point(4, 25);
            this.tab_clientes.Margin = new System.Windows.Forms.Padding(4);
            this.tab_clientes.Name = "tab_clientes";
            this.tab_clientes.Padding = new System.Windows.Forms.Padding(4);
            this.tab_clientes.Size = new System.Drawing.Size(791, 493);
            this.tab_clientes.TabIndex = 2;
            this.tab_clientes.Text = "Clientes";
            this.tab_clientes.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer3
            // 
            this.crystalReportViewer3.ActiveViewIndex = 0;
            this.crystalReportViewer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer3.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer3.Location = new System.Drawing.Point(4, 4);
            this.crystalReportViewer3.Name = "crystalReportViewer3";
            this.crystalReportViewer3.ReportSource = this.ClientesActivos2;
            this.crystalReportViewer3.Size = new System.Drawing.Size(783, 485);
            this.crystalReportViewer3.TabIndex = 0;
            // 
            // tab_equipo
            // 
            this.tab_equipo.Controls.Add(this.crystalReportViewer4);
            this.tab_equipo.Location = new System.Drawing.Point(4, 25);
            this.tab_equipo.Margin = new System.Windows.Forms.Padding(4);
            this.tab_equipo.Name = "tab_equipo";
            this.tab_equipo.Padding = new System.Windows.Forms.Padding(4);
            this.tab_equipo.Size = new System.Drawing.Size(791, 493);
            this.tab_equipo.TabIndex = 3;
            this.tab_equipo.Text = "Equipo";
            this.tab_equipo.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer4
            // 
            this.crystalReportViewer4.ActiveViewIndex = 0;
            this.crystalReportViewer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer4.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer4.Location = new System.Drawing.Point(4, 4);
            this.crystalReportViewer4.Name = "crystalReportViewer4";
            this.crystalReportViewer4.ReportSource = this.EquiposActivos2;
            this.crystalReportViewer4.Size = new System.Drawing.Size(783, 485);
            this.crystalReportViewer4.TabIndex = 0;
            // 
            // tab_empleados
            // 
            this.tab_empleados.Controls.Add(this.crystalReportViewer5);
            this.tab_empleados.Location = new System.Drawing.Point(4, 25);
            this.tab_empleados.Margin = new System.Windows.Forms.Padding(4);
            this.tab_empleados.Name = "tab_empleados";
            this.tab_empleados.Padding = new System.Windows.Forms.Padding(4);
            this.tab_empleados.Size = new System.Drawing.Size(791, 493);
            this.tab_empleados.TabIndex = 4;
            this.tab_empleados.Text = "Empleados";
            this.tab_empleados.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer5
            // 
            this.crystalReportViewer5.ActiveViewIndex = 0;
            this.crystalReportViewer5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer5.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer5.Location = new System.Drawing.Point(4, 4);
            this.crystalReportViewer5.Name = "crystalReportViewer5";
            this.crystalReportViewer5.ReportSource = this.EmpleadosActivos2;
            this.crystalReportViewer5.Size = new System.Drawing.Size(783, 485);
            this.crystalReportViewer5.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Location = new System.Drawing.Point(347, 110);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(867, 31);
            this.panel4.TabIndex = 15;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 698);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tabControl_Reportes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
            this.tab_punto.PerformLayout();
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
        private System.Windows.Forms.TabPage tab_inv;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabPage tab_clientes;
        private System.Windows.Forms.TabPage tab_equipo;
        private System.Windows.Forms.TabPage tab_empleados;
        /*private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_venta;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_inventario;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_cliente;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_equipo;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_empleado;*/
        private EquiposActivos EquiposActivos1;
        private EmpleadosActivos EmpleadosActivos1;
        private ClientesActivos ClientesActivos1;
        private VentaGananciasDiarias VentaGananciasDiarias1;
        private InventarioMostrarStock InventarioMostrarStock1;
        private VentaGananciasDiarias VentaGananciasDiarias2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private InventarioMostrarStock InventarioMostrarStock2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer3;
        private ClientesActivos ClientesActivos2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer4;
        private EquiposActivos EquiposActivos2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer5;
        private EmpleadosActivos EmpleadosActivos2;
        private System.Windows.Forms.TabPage tab_punto;
        private System.Windows.Forms.DateTimePicker dtp_inicial;
        private System.Windows.Forms.DateTimePicker dtp_final;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_actualizar;
        public System.Windows.Forms.ComboBox cb_empleado;
        public System.Windows.Forms.ComboBox cb_producto;
        private System.Windows.Forms.CheckBox ch_empleado;
        private System.Windows.Forms.CheckBox ch_producto;
        //private ClientesVisitas ClientesVisitas1;
        /*private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer3;
private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer4;
private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer5;*/
    }
}