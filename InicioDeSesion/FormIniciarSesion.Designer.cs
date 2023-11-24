namespace InicioDeSesion
{
    partial class FormIniciarSesion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbEresNuevo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbUser = new System.Windows.Forms.TextBox();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.ptbInicio = new System.Windows.Forms.PictureBox();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(142)))), ((int)(((byte)(151)))));
            this.panel1.Controls.Add(this.btnRegistrarse);
            this.panel1.Controls.Add(this.lbEresNuevo);
            this.panel1.Controls.Add(this.ptbInicio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(639, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 611);
            this.panel1.TabIndex = 0;
            // 
            // lbEresNuevo
            // 
            this.lbEresNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEresNuevo.AutoSize = true;
            this.lbEresNuevo.BackColor = System.Drawing.Color.Transparent;
            this.lbEresNuevo.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEresNuevo.ForeColor = System.Drawing.Color.Black;
            this.lbEresNuevo.Location = new System.Drawing.Point(84, 216);
            this.lbEresNuevo.Name = "lbEresNuevo";
            this.lbEresNuevo.Size = new System.Drawing.Size(303, 56);
            this.lbEresNuevo.TabIndex = 1;
            this.lbEresNuevo.Text = "Eres nuevo?";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(155, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Iniciar sesión";
            // 
            // txtbUser
            // 
            this.txtbUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtbUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.txtbUser.Location = new System.Drawing.Point(180, 289);
            this.txtbUser.Name = "txtbUser";
            this.txtbUser.Size = new System.Drawing.Size(263, 26);
            this.txtbUser.TabIndex = 2;
            this.txtbUser.Text = "Usuario";
            this.txtbUser.Enter += new System.EventHandler(this.txtbUser_Enter);
            this.txtbUser.Leave += new System.EventHandler(this.txtbUser_Leave);
            // 
            // txtbPassword
            // 
            this.txtbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtbPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.txtbPassword.Location = new System.Drawing.Point(180, 376);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.Size = new System.Drawing.Size(263, 26);
            this.txtbPassword.TabIndex = 2;
            this.txtbPassword.Text = "Contraseña";
            this.txtbPassword.Enter += new System.EventHandler(this.txtbPassword_Enter);
            this.txtbPassword.Leave += new System.EventHandler(this.txtbPassword_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(134, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(370, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "                                                                                 " +
    "                                        ";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIniciar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIniciar.Location = new System.Drawing.Point(236, 442);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(128, 38);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // ptbInicio
            // 
            this.ptbInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbInicio.Image = global::InicioDeSesion.Properties.Resources.pexels_anna_shvets_3786157;
            this.ptbInicio.Location = new System.Drawing.Point(0, 0);
            this.ptbInicio.Name = "ptbInicio";
            this.ptbInicio.Size = new System.Drawing.Size(445, 611);
            this.ptbInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbInicio.TabIndex = 4;
            this.ptbInicio.TabStop = false;
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarse.FlatAppearance.BorderSize = 0;
            this.btnRegistrarse.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrarse.Location = new System.Drawing.Point(165, 350);
            this.btnRegistrarse.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(112, 41);
            this.btnRegistrarse.TabIndex = 2;
            this.btnRegistrarse.Text = "Registrate";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // FormIniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtbPassword);
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "FormIniciarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IniciarSesion";
            this.Load += new System.EventHandler(this.FormIniciarSesion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbUser;
        private System.Windows.Forms.Label lbEresNuevo;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.PictureBox ptbInicio;
        private System.Windows.Forms.Button btnRegistrarse;
    }
}

