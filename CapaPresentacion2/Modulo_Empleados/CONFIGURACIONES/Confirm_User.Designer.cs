namespace Modulo_Config
{
    partial class Confirm_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirm_User));
            this.class_Ovalo1 = new EMBLEMA.Class_Ovalo();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_puesto = new System.Windows.Forms.TextBox();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.lbl_cerrar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_pass = new System.Windows.Forms.MaskedTextBox();
            this.lbl_resul = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.class_Ovalo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // class_Ovalo1
            // 
            this.class_Ovalo1.BackColor = System.Drawing.Color.DarkGray;
            this.class_Ovalo1.Image = ((System.Drawing.Image)(resources.GetObject("class_Ovalo1.Image")));
            this.class_Ovalo1.Location = new System.Drawing.Point(122, 60);
            this.class_Ovalo1.Name = "class_Ovalo1";
            this.class_Ovalo1.Size = new System.Drawing.Size(120, 120);
            this.class_Ovalo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.class_Ovalo1.TabIndex = 0;
            this.class_Ovalo1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NewsGoth BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "C O N F I R M A R   I D E N T I D A D";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nombre.Location = new System.Drawing.Point(13, 186);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(338, 21);
            this.txt_nombre.TabIndex = 2;
            this.txt_nombre.Text = "Nombre de empleado";
            this.txt_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_puesto
            // 
            this.txt_puesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_puesto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_puesto.Enabled = false;
            this.txt_puesto.Font = new System.Drawing.Font("NewsGoth Cn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_puesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_puesto.Location = new System.Drawing.Point(-2, 213);
            this.txt_puesto.Name = "txt_puesto";
            this.txt_puesto.Size = new System.Drawing.Size(369, 18);
            this.txt_puesto.TabIndex = 3;
            this.txt_puesto.Text = "PUESTO";
            this.txt_puesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.BackColor = System.Drawing.Color.Crimson;
            this.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_ingresar.Location = new System.Drawing.Point(-2, 366);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(369, 73);
            this.btn_ingresar.TabIndex = 4;
            this.btn_ingresar.Text = "I N G R E S A R";
            this.btn_ingresar.UseVisualStyleBackColor = false;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // lbl_cerrar
            // 
            this.lbl_cerrar.AutoSize = true;
            this.lbl_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_cerrar.Font = new System.Drawing.Font("NewsGoth BT", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cerrar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_cerrar.Location = new System.Drawing.Point(163, 466);
            this.lbl_cerrar.Name = "lbl_cerrar";
            this.lbl_cerrar.Size = new System.Drawing.Size(40, 15);
            this.lbl_cerrar.TabIndex = 5;
            this.lbl_cerrar.Text = "Cerrar";
            this.lbl_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_cerrar.Click += new System.EventHandler(this.lbl_cerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 270);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(96)))), ((int)(((byte)(108)))));
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.txt_pass.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_pass.Location = new System.Drawing.Point(80, 285);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(255, 25);
            this.txt_pass.TabIndex = 1;
            this.txt_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pass_KeyPress);
            // 
            // lbl_resul
            // 
            this.lbl_resul.AutoSize = true;
            this.lbl_resul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_resul.Font = new System.Drawing.Font("NewsGoth BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resul.ForeColor = System.Drawing.Color.Red;
            this.lbl_resul.Location = new System.Drawing.Point(77, 333);
            this.lbl_resul.Name = "lbl_resul";
            this.lbl_resul.Size = new System.Drawing.Size(225, 15);
            this.lbl_resul.TabIndex = 8;
            this.lbl_resul.Text = "La contraseña ingresada no es correcta";
            this.lbl_resul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_resul.Visible = false;
            // 
            // Confirm_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(365, 502);
            this.Controls.Add(this.lbl_resul);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_cerrar);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.txt_puesto);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.class_Ovalo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Confirm_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirm_User";
            ((System.ComponentModel.ISupportInitialize)(this.class_Ovalo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EMBLEMA.Class_Ovalo class_Ovalo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Label lbl_cerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox txt_pass;
        public System.Windows.Forms.TextBox txt_nombre;
        public System.Windows.Forms.TextBox txt_puesto;
        private System.Windows.Forms.Label lbl_resul;
    }
}