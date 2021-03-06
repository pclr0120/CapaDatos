﻿namespace LOGIN
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.txt_user = new System.Windows.Forms.MaskedTextBox();
            this.txt_pass = new System.Windows.Forms.MaskedTextBox();
            this.lbl_resul = new System.Windows.Forms.Label();
            this.link_lbl_pass = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.BackgroundImage")));
            this.btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btn_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Location = new System.Drawing.Point(445, 1);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(45, 20);
            this.btn_cerrar.TabIndex = 5;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_min
            // 
            this.btn_min.BackColor = System.Drawing.Color.Transparent;
            this.btn_min.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_min.BackgroundImage")));
            this.btn_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Location = new System.Drawing.Point(419, 1);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(26, 20);
            this.btn_min.TabIndex = 4;
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(163, 24);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(170, 159);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 4;
            this.logo.TabStop = false;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.BackColor = System.Drawing.Color.Crimson;
            this.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_ingresar.Location = new System.Drawing.Point(59, 434);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(371, 73);
            this.btn_ingresar.TabIndex = 3;
            this.btn_ingresar.Text = "I N G R E S A R";
            this.btn_ingresar.UseVisualStyleBackColor = false;
            this.btn_ingresar.Click += new System.EventHandler(this.txt_ingresar_Click);
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(96)))), ((int)(((byte)(108)))));
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.txt_user.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_user.Location = new System.Drawing.Point(144, 267);
            this.txt_user.Name = "txt_user";
            this.txt_user.PromptChar = ' ';
            this.txt_user.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_user.ShortcutsEnabled = false;
            this.txt_user.Size = new System.Drawing.Size(247, 25);
            this.txt_user.TabIndex = 1;
            this.txt_user.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.txt_user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_user_KeyPress);
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(96)))), ((int)(((byte)(108)))));
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.txt_pass.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_pass.Location = new System.Drawing.Point(144, 315);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(247, 25);
            this.txt_pass.TabIndex = 2;
            this.txt_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pass_KeyPress);
            // 
            // lbl_resul
            // 
            this.lbl_resul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_resul.AutoSize = true;
            this.lbl_resul.BackColor = System.Drawing.Color.Transparent;
            this.lbl_resul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resul.ForeColor = System.Drawing.Color.Red;
            this.lbl_resul.Location = new System.Drawing.Point(148, 364);
            this.lbl_resul.Name = "lbl_resul";
            this.lbl_resul.Size = new System.Drawing.Size(195, 15);
            this.lbl_resul.TabIndex = 8;
            this.lbl_resul.Text = "Usuario y/o contraseña incorrectos";
            this.lbl_resul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_resul.Visible = false;
            // 
            // link_lbl_pass
            // 
            this.link_lbl_pass.AutoSize = true;
            this.link_lbl_pass.BackColor = System.Drawing.Color.Transparent;
            this.link_lbl_pass.Location = new System.Drawing.Point(194, 398);
            this.link_lbl_pass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.link_lbl_pass.Name = "link_lbl_pass";
            this.link_lbl_pass.Size = new System.Drawing.Size(113, 13);
            this.link_lbl_pass.TabIndex = 9;
            this.link_lbl_pass.TabStop = true;
            this.link_lbl_pass.Text = "Olvido su contraseña?";
            this.link_lbl_pass.Visible = false;
            this.link_lbl_pass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_lbl_pass_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(491, 625);
            this.Controls.Add(this.link_lbl_pass);
            this.Controls.Add(this.lbl_resul);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_cerrar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.MaskedTextBox txt_user;
        private System.Windows.Forms.MaskedTextBox txt_pass;
        private System.Windows.Forms.Label lbl_resul;
        private System.Windows.Forms.LinkLabel link_lbl_pass;
    }
}

