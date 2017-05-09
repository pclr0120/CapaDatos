namespace Modulo_Empleados
{
    partial class Nuevo_Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nuevo_Empleado));
            this.rb_clave = new System.Windows.Forms.RadioButton();
            this.btn_ok = new System.Windows.Forms.Button();
            this.rb_lista = new System.Windows.Forms.RadioButton();
            this.rb_curp = new System.Windows.Forms.RadioButton();
            this.lbl_accion = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_clave_empleado = new System.Windows.Forms.MaskedTextBox();
            this.txt_curp = new System.Windows.Forms.MaskedTextBox();
            this.rb_nuevo = new System.Windows.Forms.RadioButton();
            this.rb_existente = new System.Windows.Forms.RadioButton();
            this.lbl_curp = new System.Windows.Forms.Label();
            this.txt_curp2 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_clave
            // 
            this.rb_clave.AutoSize = true;
            this.rb_clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_clave.ForeColor = System.Drawing.Color.White;
            this.rb_clave.Location = new System.Drawing.Point(44, 96);
            this.rb_clave.Name = "rb_clave";
            this.rb_clave.Size = new System.Drawing.Size(195, 20);
            this.rb_clave.TabIndex = 15;
            this.rb_clave.Text = "Ingresar clave de empleado";
            this.rb_clave.UseVisualStyleBackColor = true;
            this.rb_clave.CheckedChanged += new System.EventHandler(this.rb_clave_CheckedChanged);
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ok.BackColor = System.Drawing.Color.LightGray;
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.FlatAppearance.BorderSize = 0;
            this.btn_ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_ok.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ok.Location = new System.Drawing.Point(464, 437);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(139, 34);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "ACEPTAR";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // rb_lista
            // 
            this.rb_lista.AutoSize = true;
            this.rb_lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_lista.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rb_lista.Location = new System.Drawing.Point(44, 172);
            this.rb_lista.Name = "rb_lista";
            this.rb_lista.Size = new System.Drawing.Size(234, 20);
            this.rb_lista.TabIndex = 12;
            this.rb_lista.Text = "Seleccionar empleado de una lista";
            this.rb_lista.UseVisualStyleBackColor = true;
            this.rb_lista.CheckedChanged += new System.EventHandler(this.rb_lista_CheckedChanged);
            // 
            // rb_curp
            // 
            this.rb_curp.AutoSize = true;
            this.rb_curp.Checked = true;
            this.rb_curp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_curp.ForeColor = System.Drawing.Color.White;
            this.rb_curp.Location = new System.Drawing.Point(44, 24);
            this.rb_curp.Name = "rb_curp";
            this.rb_curp.Size = new System.Drawing.Size(128, 20);
            this.rb_curp.TabIndex = 11;
            this.rb_curp.TabStop = true;
            this.rb_curp.Text = "Ingresar C.U.R.P.";
            this.rb_curp.UseVisualStyleBackColor = true;
            this.rb_curp.CheckedChanged += new System.EventHandler(this.rb_curp_CheckedChanged);
            // 
            // lbl_accion
            // 
            this.lbl_accion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_accion.AutoSize = true;
            this.lbl_accion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_accion.ForeColor = System.Drawing.Color.White;
            this.lbl_accion.Location = new System.Drawing.Point(12, 9);
            this.lbl_accion.Name = "lbl_accion";
            this.lbl_accion.Size = new System.Drawing.Size(172, 16);
            this.lbl_accion.TabIndex = 9;
            this.lbl_accion.Text = "Dar de alta a empleado";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.BackColor = System.Drawing.Color.White;
            this.btn_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.BackgroundImage")));
            this.btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Location = new System.Drawing.Point(570, 0);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(45, 25);
            this.btn_cerrar.TabIndex = 5;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_clave_empleado);
            this.groupBox1.Controls.Add(this.txt_curp);
            this.groupBox1.Controls.Add(this.rb_lista);
            this.groupBox1.Controls.Add(this.rb_curp);
            this.groupBox1.Controls.Add(this.rb_clave);
            this.groupBox1.Enabled = false;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(15, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 219);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // txt_clave_empleado
            // 
            this.txt_clave_empleado.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.txt_clave_empleado.Location = new System.Drawing.Point(44, 124);
            this.txt_clave_empleado.Name = "txt_clave_empleado";
            this.txt_clave_empleado.Size = new System.Drawing.Size(189, 26);
            this.txt_clave_empleado.TabIndex = 3;
            this.txt_clave_empleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_clave_empleado_KeyPress);
            // 
            // txt_curp
            // 
            this.txt_curp.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.txt_curp.Location = new System.Drawing.Point(44, 52);
            this.txt_curp.Mask = ">LLLL999999LLLLLL99";
            this.txt_curp.Name = "txt_curp";
            this.txt_curp.Size = new System.Drawing.Size(304, 26);
            this.txt_curp.TabIndex = 2;
            // 
            // rb_nuevo
            // 
            this.rb_nuevo.AutoSize = true;
            this.rb_nuevo.BackColor = System.Drawing.Color.Transparent;
            this.rb_nuevo.Checked = true;
            this.rb_nuevo.FlatAppearance.BorderSize = 0;
            this.rb_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_nuevo.ForeColor = System.Drawing.Color.White;
            this.rb_nuevo.Location = new System.Drawing.Point(41, 67);
            this.rb_nuevo.Name = "rb_nuevo";
            this.rb_nuevo.Size = new System.Drawing.Size(148, 24);
            this.rb_nuevo.TabIndex = 18;
            this.rb_nuevo.TabStop = true;
            this.rb_nuevo.Text = "Nuevo Empleado";
            this.rb_nuevo.UseVisualStyleBackColor = false;
            this.rb_nuevo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.rb_nuevo.Click += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_existente
            // 
            this.rb_existente.AutoSize = true;
            this.rb_existente.FlatAppearance.BorderSize = 0;
            this.rb_existente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_existente.ForeColor = System.Drawing.Color.Transparent;
            this.rb_existente.Location = new System.Drawing.Point(41, 177);
            this.rb_existente.Name = "rb_existente";
            this.rb_existente.Size = new System.Drawing.Size(169, 24);
            this.rb_existente.TabIndex = 19;
            this.rb_existente.Text = "Empleado Existente";
            this.rb_existente.UseVisualStyleBackColor = true;
            this.rb_existente.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            this.rb_existente.Click += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // lbl_curp
            // 
            this.lbl_curp.AutoSize = true;
            this.lbl_curp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_curp.ForeColor = System.Drawing.Color.White;
            this.lbl_curp.Location = new System.Drawing.Point(56, 96);
            this.lbl_curp.Name = "lbl_curp";
            this.lbl_curp.Size = new System.Drawing.Size(110, 16);
            this.lbl_curp.TabIndex = 20;
            this.lbl_curp.Text = "Ingresar C.U.R.P.";
            // 
            // txt_curp2
            // 
            this.txt_curp2.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.txt_curp2.Location = new System.Drawing.Point(59, 126);
            this.txt_curp2.Mask = ">LLLL999999LLLLLL99";
            this.txt_curp2.Name = "txt_curp2";
            this.txt_curp2.Size = new System.Drawing.Size(304, 26);
            this.txt_curp2.TabIndex = 1;
            // 
            // Nuevo_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(615, 483);
            this.Controls.Add(this.txt_curp2);
            this.Controls.Add(this.rb_nuevo);
            this.Controls.Add(this.rb_existente);
            this.Controls.Add(this.lbl_curp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.lbl_accion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Nuevo_Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo_Empleado";
            this.Load += new System.EventHandler(this.Nuevo_Empleado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rb_clave;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.RadioButton rb_lista;
        private System.Windows.Forms.RadioButton rb_curp;
        private System.Windows.Forms.Button btn_cerrar;
        public System.Windows.Forms.Label lbl_accion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_nuevo;
        private System.Windows.Forms.RadioButton rb_existente;
        private System.Windows.Forms.Label lbl_curp;
        private System.Windows.Forms.MaskedTextBox txt_clave_empleado;
        private System.Windows.Forms.MaskedTextBox txt_curp;
        private System.Windows.Forms.MaskedTextBox txt_curp2;
    }
}