namespace Modulo_Empleados.INTERFAZ_PRINCIPAL.LOGIN
{
    partial class EnviarEmail
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_enviar_email = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese su direccion de correo electronico para recuperar su contraseña";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(49, 97);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(463, 22);
            this.txt_email.TabIndex = 1;
            // 
            // btn_enviar_email
            // 
            this.btn_enviar_email.Location = new System.Drawing.Point(150, 144);
            this.btn_enviar_email.Name = "btn_enviar_email";
            this.btn_enviar_email.Size = new System.Drawing.Size(135, 36);
            this.btn_enviar_email.TabIndex = 2;
            this.btn_enviar_email.Text = "Enviar Correo (F1)";
            this.btn_enviar_email.UseVisualStyleBackColor = true;
            this.btn_enviar_email.Click += new System.EventHandler(this.btn_enviar_email_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(292, 144);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(120, 36);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar (F2)";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // EnviarEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(561, 217);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_enviar_email);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnviarEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnviarEmail";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EnviarEmail_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_enviar_email;
        private System.Windows.Forms.Button btn_cancelar;
    }
}