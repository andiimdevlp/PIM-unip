namespace View
{
    partial class FrmRecoverPassword
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
            this.lblRecuperar = new System.Windows.Forms.Label();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblResposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRecuperar
            // 
            this.lblRecuperar.AutoSize = true;
            this.lblRecuperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperar.ForeColor = System.Drawing.Color.LightGray;
            this.lblRecuperar.Location = new System.Drawing.Point(48, 36);
            this.lblRecuperar.Name = "lblRecuperar";
            this.lblRecuperar.Size = new System.Drawing.Size(196, 15);
            this.lblRecuperar.TabIndex = 0;
            this.lblRecuperar.Text = "Digite seu Usuario ou E-mail:";
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(105)))), ((int)(((byte)(165)))));
            this.txtUserEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserEmail.ForeColor = System.Drawing.Color.LightGray;
            this.txtUserEmail.Location = new System.Drawing.Point(131, 62);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(251, 13);
            this.txtUserEmail.TabIndex = 1;
            this.txtUserEmail.Text = "Digite Aqui!";
            this.txtUserEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserEmail.TextChanged += new System.EventHandler(this.txtUserEmail_TextChanged);
            this.txtUserEmail.MouseLeave += new System.EventHandler(this.txtUserEmail_MouseLeave);
            // 
            // btnEnviar
            // 
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.LightGray;
            this.btnEnviar.Location = new System.Drawing.Point(307, 94);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.ForeColor = System.Drawing.Color.LightGray;
            this.lblResposta.Location = new System.Drawing.Point(48, 134);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(0, 13);
            this.lblResposta.TabIndex = 3;
            // 
            // FrmRecoverPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(105)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(528, 218);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtUserEmail);
            this.Controls.Add(this.lblRecuperar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRecoverPassword";
            this.Text = "FrmRecoverPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecuperar;
        private System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblResposta;
    }
}