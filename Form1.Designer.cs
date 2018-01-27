namespace login
{
    partial class FrmLogin
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnenviar = new System.Windows.Forms.Button();
            this.lnkRegistrar = new System.Windows.Forms.LinkLabel();
            this.lnkRecordarContra = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(185, 135);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(141, 22);
            this.txtUser.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(185, 173);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(141, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "LOGIN";
            // 
            // btnenviar
            // 
            this.btnenviar.Location = new System.Drawing.Point(197, 217);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(111, 23);
            this.btnenviar.TabIndex = 5;
            this.btnenviar.Text = "Iniciar Sesion";
            this.btnenviar.UseVisualStyleBackColor = true;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // lnkRegistrar
            // 
            this.lnkRegistrar.AutoSize = true;
            this.lnkRegistrar.Location = new System.Drawing.Point(117, 294);
            this.lnkRegistrar.Name = "lnkRegistrar";
            this.lnkRegistrar.Size = new System.Drawing.Size(81, 17);
            this.lnkRegistrar.TabIndex = 6;
            this.lnkRegistrar.TabStop = true;
            this.lnkRegistrar.Text = "Registrarse";
            // 
            // lnkRecordarContra
            // 
            this.lnkRecordarContra.AutoSize = true;
            this.lnkRecordarContra.Location = new System.Drawing.Point(214, 294);
            this.lnkRecordarContra.Name = "lnkRecordarContra";
            this.lnkRecordarContra.Size = new System.Drawing.Size(143, 17);
            this.lnkRecordarContra.TabIndex = 7;
            this.lnkRecordarContra.TabStop = true;
            this.lnkRecordarContra.Text = "Olvide mi Contraseña";
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnenviar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 389);
            this.Controls.Add(this.lnkRecordarContra);
            this.Controls.Add(this.lnkRegistrar);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.LinkLabel lnkRegistrar;
        private System.Windows.Forms.LinkLabel lnkRecordarContra;
    }
}

