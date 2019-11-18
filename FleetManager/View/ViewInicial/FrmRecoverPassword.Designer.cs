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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblResposta = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.reRecovery = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblRecuperar
            // 
            this.lblRecuperar.AutoSize = true;
            this.lblRecuperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperar.ForeColor = System.Drawing.Color.LightGray;
            this.lblRecuperar.Location = new System.Drawing.Point(48, 31);
            this.lblRecuperar.Name = "lblRecuperar";
            this.lblRecuperar.Size = new System.Drawing.Size(196, 15);
            this.lblRecuperar.TabIndex = 1;
            this.lblRecuperar.Text = "Digite seu Usuario ou E-mail:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.lblResposta.Location = new System.Drawing.Point(48, 131);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(0, 13);
            this.lblResposta.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Location = new System.Drawing.Point(426, 166);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(62, 22);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // reRecovery
            // 
            this.reRecovery.BackColor = System.Drawing.Color.WhiteSmoke;
            this.reRecovery.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(135)))), ((int)(((byte)(195)))));
            this.reRecovery.CornerRadius = 9;
            this.reRecovery.Enabled = false;
            this.reRecovery.Location = new System.Drawing.Point(130, 55);
            this.reRecovery.Name = "reRecovery";
            this.reRecovery.SelectionColor = System.Drawing.Color.WhiteSmoke;
            this.reRecovery.Size = new System.Drawing.Size(278, 25);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.reRecovery});
            this.shapeContainer1.Size = new System.Drawing.Size(500, 200);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(105)))), ((int)(((byte)(165)))));
            this.txtUserEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserEmail.ForeColor = System.Drawing.Color.LightGray;
            this.txtUserEmail.Location = new System.Drawing.Point(135, 62);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(264, 13);
            this.txtUserEmail.TabIndex = 2;
            this.txtUserEmail.Text = "Digite Aqui!";
            this.txtUserEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserEmail.TextChanged += new System.EventHandler(this.txtUserEmail_TextChanged);
            this.txtUserEmail.Enter += new System.EventHandler(this.txtUserEmail_Enter);
            this.txtUserEmail.MouseLeave += new System.EventHandler(this.txtUserEmail_MouseLeave);
            // 
            // FrmRecoverPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(105)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(500, 200);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtUserEmail);
            this.Controls.Add(this.lblRecuperar);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRecoverPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRecoverPassword";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmRecoverPassword_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecuperar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Button btnCancelar;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape reRecovery;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.TextBox txtUserEmail;
    }
}