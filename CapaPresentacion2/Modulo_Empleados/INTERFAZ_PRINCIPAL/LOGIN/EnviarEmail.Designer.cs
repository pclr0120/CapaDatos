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
            this.label1.Font = new System.Drawing.Font("NewsGoth BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese su direccion de correo electronico para \r\nrecuperar su contraseña";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(36, 79);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(348, 28);
            this.txt_email.TabIndex = 1;
            // 
            // btn_enviar_email
            // 
            this.btn_enviar_email.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar_email.Location = new System.Drawing.Point(84, 136);
            this.btn_enviar_email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_enviar_email.Name = "btn_enviar_email";
            this.btn_enviar_email.Size = new System.Drawing.Size(135, 29);
            this.btn_enviar_email.TabIndex = 2;
            this.btn_enviar_email.Text = "Enviar Correo (F1)";
            this.btn_enviar_email.UseVisualStyleBackColor = true;
            this.btn_enviar_email.Click += new System.EventHandler(this.btn_enviar_email_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(225, 136);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(111, 29);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar (F2)";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // EnviarEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(421, 176);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_enviar_email);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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