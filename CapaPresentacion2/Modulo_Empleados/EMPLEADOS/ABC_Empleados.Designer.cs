namespace Modulo_Empleados
{
    partial class ABC_Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABC_Empleados));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_clave_empleado = new System.Windows.Forms.TextBox();
            this.rb_clave = new System.Windows.Forms.RadioButton();
            this.btn_ok = new System.Windows.Forms.Button();
            this.txt_curp = new System.Windows.Forms.TextBox();
            this.rb_lista = new System.Windows.Forms.RadioButton();
            this.rb_curp = new System.Windows.Forms.RadioButton();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.lbl_accion = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.txt_clave_empleado);
            this.panel2.Controls.Add(this.rb_clave);
            this.panel2.Controls.Add(this.btn_ok);
            this.panel2.Controls.Add(this.txt_curp);
            this.panel2.Controls.Add(this.rb_lista);
            this.panel2.Controls.Add(this.rb_curp);
            this.panel2.Controls.Add(this.btn_cerrar);
            this.panel2.Controls.Add(this.lbl_accion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 264);
            this.panel2.TabIndex = 9;
            // 
            // txt_clave_empleado
            // 
            this.txt_clave_empleado.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clave_empleado.Location = new System.Drawing.Point(64, 155);
            this.txt_clave_empleado.Name = "txt_clave_empleado";
            this.txt_clave_empleado.Size = new System.Drawing.Size(195, 26);
            this.txt_clave_empleado.TabIndex = 8;
            // 
            // rb_clave
            // 
            this.rb_clave.AutoSize = true;
            this.rb_clave.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_clave.ForeColor = System.Drawing.Color.White;
            this.rb_clave.Location = new System.Drawing.Point(46, 127);
            this.rb_clave.Name = "rb_clave";
            this.rb_clave.Size = new System.Drawing.Size(189, 22);
            this.rb_clave.TabIndex = 7;
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
            this.btn_ok.Font = new System.Drawing.Font("Open Sans", 8.25F);
            this.btn_ok.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ok.Location = new System.Drawing.Point(480, 218);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(139, 34);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "ACEPTAR";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // txt_curp
            // 
            this.txt_curp.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_curp.Location = new System.Drawing.Point(64, 83);
            this.txt_curp.Name = "txt_curp";
            this.txt_curp.Size = new System.Drawing.Size(282, 26);
            this.txt_curp.TabIndex = 5;
            // 
            // rb_lista
            // 
            this.rb_lista.AutoSize = true;
            this.rb_lista.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_lista.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rb_lista.Location = new System.Drawing.Point(46, 203);
            this.rb_lista.Name = "rb_lista";
            this.rb_lista.Size = new System.Drawing.Size(227, 22);
            this.rb_lista.TabIndex = 4;
            this.rb_lista.Text = "Seleccionar empleado de una lista";
            this.rb_lista.UseVisualStyleBackColor = true;
            this.rb_lista.CheckedChanged += new System.EventHandler(this.rb_lista_CheckedChanged);
            // 
            // rb_curp
            // 
            this.rb_curp.AutoSize = true;
            this.rb_curp.Checked = true;
            this.rb_curp.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_curp.ForeColor = System.Drawing.Color.White;
            this.rb_curp.Location = new System.Drawing.Point(46, 55);
            this.rb_curp.Name = "rb_curp";
            this.rb_curp.Size = new System.Drawing.Size(120, 22);
            this.rb_curp.TabIndex = 3;
            this.rb_curp.TabStop = true;
            this.rb_curp.Text = "Ingresar C.U.R.P";
            this.rb_curp.UseVisualStyleBackColor = true;
            this.rb_curp.CheckedChanged += new System.EventHandler(this.rb_curp_CheckedChanged);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.BackgroundImage")));
            this.btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Location = new System.Drawing.Point(585, 0);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(45, 25);
            this.btn_cerrar.TabIndex = 2;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // lbl_accion
            // 
            this.lbl_accion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_accion.AutoSize = true;
            this.lbl_accion.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_accion.ForeColor = System.Drawing.Color.White;
            this.lbl_accion.Location = new System.Drawing.Point(12, 9);
            this.lbl_accion.Name = "lbl_accion";
            this.lbl_accion.Size = new System.Drawing.Size(270, 18);
            this.lbl_accion.TabIndex = 0;
            this.lbl_accion.Text = "Accion a dempeñar de este formulario";
            // 
            // ABC_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 264);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ABC_Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ABC_Empleados_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.RadioButton rb_lista;
        private System.Windows.Forms.RadioButton rb_curp;
        private System.Windows.Forms.TextBox txt_curp;
        private System.Windows.Forms.Button btn_ok;
        public System.Windows.Forms.Label lbl_accion;
        private System.Windows.Forms.TextBox txt_clave_empleado;
        private System.Windows.Forms.RadioButton rb_clave;
    }
}