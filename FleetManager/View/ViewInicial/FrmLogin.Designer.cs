namespace View
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.reUsuarioLogin = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.retSenhaLogin = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.retCardLogin = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.txtUsuarioLogin = new System.Windows.Forms.TextBox();
            this.txtSenhaLogin = new System.Windows.Forms.TextBox();
            this.lnkRecuperarSenha = new System.Windows.Forms.LinkLabel();
            this.lblErroLogin = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.reUsuarioLogin,
            this.retSenhaLogin,
            this.retCardLogin});
            this.shapeContainer1.Size = new System.Drawing.Size(450, 700);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // reUsuarioLogin
            // 
            this.reUsuarioLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.reUsuarioLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(135)))), ((int)(((byte)(195)))));
            this.reUsuarioLogin.CornerRadius = 9;
            this.reUsuarioLogin.Enabled = false;
            this.reUsuarioLogin.Location = new System.Drawing.Point(113, 390);
            this.reUsuarioLogin.Name = "reUsuarioLogin";
            this.reUsuarioLogin.SelectionColor = System.Drawing.Color.WhiteSmoke;
            this.reUsuarioLogin.Size = new System.Drawing.Size(238, 32);
            // 
            // retSenhaLogin
            // 
            this.retSenhaLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(105)))), ((int)(((byte)(180)))));
            this.retSenhaLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(135)))), ((int)(((byte)(195)))));
            this.retSenhaLogin.CornerRadius = 9;
            this.retSenhaLogin.Enabled = false;
            this.retSenhaLogin.Location = new System.Drawing.Point(113, 454);
            this.retSenhaLogin.Name = "retSenhaLogin";
            this.retSenhaLogin.SelectionColor = System.Drawing.Color.WhiteSmoke;
            this.retSenhaLogin.Size = new System.Drawing.Size(240, 31);
            // 
            // retCardLogin
            // 
            this.retCardLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(105)))), ((int)(((byte)(180)))));
            this.retCardLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(125)))), ((int)(((byte)(254)))));
            this.retCardLogin.BorderWidth = 6;
            this.retCardLogin.CornerRadius = 90;
            this.retCardLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(135)))), ((int)(((byte)(195)))));
            this.retCardLogin.FillGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(105)))), ((int)(((byte)(180)))));
            this.retCardLogin.Location = new System.Drawing.Point(-3, 266);
            this.retCardLogin.Name = "retCardLogin";
            this.retCardLogin.Size = new System.Drawing.Size(455, 550);
            this.retCardLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseDown);
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(105)))), ((int)(((byte)(165)))));
            this.txtUsuarioLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuarioLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioLogin.ForeColor = System.Drawing.Color.LightGray;
            this.txtUsuarioLogin.Location = new System.Drawing.Point(116, 397);
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.Size = new System.Drawing.Size(235, 17);
            this.txtUsuarioLogin.TabIndex = 6;
            this.txtUsuarioLogin.Text = "Digite seu Usuario";
            this.txtUsuarioLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsuarioLogin.Enter += new System.EventHandler(this.txtUsuarioLogin_Enter);
            this.txtUsuarioLogin.Leave += new System.EventHandler(this.txtUsuarioLogin_Leave);
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(105)))), ((int)(((byte)(165)))));
            this.txtSenhaLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenhaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaLogin.ForeColor = System.Drawing.Color.LightGray;
            this.txtSenhaLogin.Location = new System.Drawing.Point(116, 461);
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.Size = new System.Drawing.Size(235, 17);
            this.txtSenhaLogin.TabIndex = 7;
            this.txtSenhaLogin.Text = "Digite sua Senha";
            this.txtSenhaLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSenhaLogin.Enter += new System.EventHandler(this.txtSenhaLogin_Enter);
            this.txtSenhaLogin.Leave += new System.EventHandler(this.txtSenhaLogin_Leave);
            // 
            // lnkRecuperarSenha
            // 
            this.lnkRecuperarSenha.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(135)))), ((int)(((byte)(195)))));
            this.lnkRecuperarSenha.AutoSize = true;
            this.lnkRecuperarSenha.BackColor = System.Drawing.Color.Transparent;
            this.lnkRecuperarSenha.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(35)))), ((int)(((byte)(56)))));
            this.lnkRecuperarSenha.Location = new System.Drawing.Point(236, 552);
            this.lnkRecuperarSenha.Name = "lnkRecuperarSenha";
            this.lnkRecuperarSenha.Size = new System.Drawing.Size(115, 13);
            this.lnkRecuperarSenha.TabIndex = 0;
            this.lnkRecuperarSenha.TabStop = true;
            this.lnkRecuperarSenha.Text = "Esqueceu sua Senha?";
            this.lnkRecuperarSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRecuperarSenha_LinkClicked);
            // 
            // lblErroLogin
            // 
            this.lblErroLogin.AutoSize = true;
            this.lblErroLogin.ForeColor = System.Drawing.Color.Silver;
            this.lblErroLogin.Image = global::View.Properties.Resources.importancia;
            this.lblErroLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErroLogin.Location = new System.Drawing.Point(163, 498);
            this.lblErroLogin.Name = "lblErroLogin";
            this.lblErroLogin.Size = new System.Drawing.Size(132, 13);
            this.lblErroLogin.TabIndex = 10;
            this.lblErroLogin.Text = "Usuario ou Senha Invalido";
            this.lblErroLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblErroLogin.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(105)))), ((int)(((byte)(165)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(108)))), ((int)(((byte)(185)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(105)))), ((int)(((byte)(165)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.Image = global::View.Properties.Resources.icon_access;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.Location = new System.Drawing.Point(116, 545);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLogin.Size = new System.Drawing.Size(80, 24);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::View.Properties.Resources.fechar;
            this.pictureBox3.Location = new System.Drawing.Point(427, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::View.Properties.Resources.minimize;
            this.pictureBox4.Location = new System.Drawing.Point(401, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(21, 21);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::View.Properties.Resources.Logo2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = global::View.Properties.Resources.AvatarLogin;
            this.pictureBox2.Location = new System.Drawing.Point(144, 175);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(154, 149);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseDown);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(105)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(450, 700);
            this.Controls.Add(this.lblErroLogin);
            this.Controls.Add(this.lnkRecuperarSenha);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtSenhaLogin);
            this.Controls.Add(this.txtUsuarioLogin);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Opacity = 0.93D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape retCardLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape reUsuarioLogin;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape retSenhaLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtUsuarioLogin;
        private System.Windows.Forms.TextBox txtSenhaLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lnkRecuperarSenha;
        private System.Windows.Forms.Label lblErroLogin;
    }
}

