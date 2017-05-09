namespace Modulo_Empleados
{
    partial class Autentificar_Nuevo_Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autentificar_Nuevo_Empleado));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.lbl_emblema = new System.Windows.Forms.Label();
            this.btn_nuevo_empleado = new System.Windows.Forms.Button();
            this.txt_curp2 = new System.Windows.Forms.MaskedTextBox();
            this.lbl_curp = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.btn_nuevo_empleado);
            this.panel2.Controls.Add(this.txt_curp2);
            this.panel2.Controls.Add(this.lbl_curp);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btn_cerrar);
            this.panel2.Controls.Add(this.lbl_emblema);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 248);
            this.panel2.TabIndex = 8;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
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
            this.btn_cerrar.Location = new System.Drawing.Point(545, 0);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(45, 25);
            this.btn_cerrar.TabIndex = 2;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // lbl_emblema
            // 
            this.lbl_emblema.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_emblema.AutoSize = true;
            this.lbl_emblema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emblema.ForeColor = System.Drawing.Color.Black;
            this.lbl_emblema.Location = new System.Drawing.Point(10, 4);
            this.lbl_emblema.Name = "lbl_emblema";
            this.lbl_emblema.Size = new System.Drawing.Size(255, 16);
            this.lbl_emblema.TabIndex = 0;
            this.lbl_emblema.Text = "Autentificación de Nuevo Empleado";
            // 
            // btn_nuevo_empleado
            // 
            this.btn_nuevo_empleado.BackColor = System.Drawing.Color.LightGray;
            this.btn_nuevo_empleado.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_nuevo_empleado.FlatAppearance.BorderSize = 0;
            this.btn_nuevo_empleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_nuevo_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_empleado.Font = new System.Drawing.Font("Open Sans", 8.25F);
            this.btn_nuevo_empleado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_nuevo_empleado.Location = new System.Drawing.Point(440, 202);
            this.btn_nuevo_empleado.Name = "btn_nuevo_empleado";
            this.btn_nuevo_empleado.Size = new System.Drawing.Size(139, 34);
            this.btn_nuevo_empleado.TabIndex = 2;
            this.btn_nuevo_empleado.Text = "ACEPTAR";
            this.btn_nuevo_empleado.UseVisualStyleBackColor = false;
            this.btn_nuevo_empleado.Click += new System.EventHandler(this.btn_nuevo_empleado_Click);
            // 
            // txt_curp2
            // 
            this.txt_curp2.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.txt_curp2.Location = new System.Drawing.Point(179, 117);
            this.txt_curp2.Mask = ">LLLL999999LLLLLL99";
            this.txt_curp2.Name = "txt_curp2";
            this.txt_curp2.Size = new System.Drawing.Size(304, 26);
            this.txt_curp2.TabIndex = 21;
            // 
            // lbl_curp
            // 
            this.lbl_curp.AutoSize = true;
            this.lbl_curp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_curp.ForeColor = System.Drawing.Color.Black;
            this.lbl_curp.Location = new System.Drawing.Point(176, 87);
            this.lbl_curp.Name = "lbl_curp";
            this.lbl_curp.Size = new System.Drawing.Size(110, 16);
            this.lbl_curp.TabIndex = 22;
            this.lbl_curp.Text = "Ingresar C.U.R.P.";
            // 
            // Autentificar_Nuevo_Empleado
            // 
            this.AcceptButton = this.btn_nuevo_empleado;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.CancelButton = this.btn_cerrar;
            this.ClientSize = new System.Drawing.Size(591, 248);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Autentificar_Nuevo_Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autentificar_Nuevo_Empleado";
            this.Load += new System.EventHandler(this.Autentificar_Nuevo_Empleado_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label lbl_emblema;
        private System.Windows.Forms.Button btn_nuevo_empleado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox txt_curp2;
        private System.Windows.Forms.Label lbl_curp;
    }
}