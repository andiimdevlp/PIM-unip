namespace View.cadastros
{
    partial class FrmContrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContrato));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.txtIe = new System.Windows.Forms.TextBox();
            this.txtContrato = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.btnAdicionarPlaca = new System.Windows.Forms.Button();
            this.btnCadastrarContrato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Periodo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Placa (s)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "IE";
            // 
            // txtCliente
            // 
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliente.Location = new System.Drawing.Point(121, 50);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(213, 20);
            this.txtCliente.TabIndex = 8;
            // 
            // txtPlaca
            // 
            this.txtPlaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlaca.Location = new System.Drawing.Point(121, 156);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(77, 20);
            this.txtPlaca.TabIndex = 11;
            // 
            // dtInicio
            // 
            this.dtInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtInicio.Location = new System.Drawing.Point(119, 221);
            this.dtInicio.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dtInicio.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(105, 20);
            this.dtInicio.TabIndex = 12;
            this.dtInicio.Value = new System.DateTime(2019, 11, 9, 0, 0, 0, 0);
            // 
            // dtFim
            // 
            this.dtFim.CustomFormat = "";
            this.dtFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtFim.Location = new System.Drawing.Point(264, 221);
            this.dtFim.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dtFim.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(104, 20);
            this.dtFim.TabIndex = 13;
            this.dtFim.Value = new System.DateTime(2019, 11, 9, 0, 0, 0, 0);
            // 
            // txtIe
            // 
            this.txtIe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIe.Location = new System.Drawing.Point(121, 101);
            this.txtIe.Name = "txtIe";
            this.txtIe.Size = new System.Drawing.Size(177, 20);
            this.txtIe.TabIndex = 14;
            // 
            // txtContrato
            // 
            this.txtContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContrato.Location = new System.Drawing.Point(641, 50);
            this.txtContrato.Name = "txtContrato";
            this.txtContrato.Size = new System.Drawing.Size(412, 512);
            this.txtContrato.TabIndex = 16;
            this.txtContrato.Text = resources.GetString("txtContrato.Text");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(348, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "ID Cliente";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdCliente.Location = new System.Drawing.Point(422, 50);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(99, 20);
            this.txtIdCliente.TabIndex = 18;
            // 
            // btnAdicionarPlaca
            // 
            this.btnAdicionarPlaca.FlatAppearance.BorderSize = 0;
            this.btnAdicionarPlaca.Location = new System.Drawing.Point(264, 156);
            this.btnAdicionarPlaca.Name = "btnAdicionarPlaca";
            this.btnAdicionarPlaca.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarPlaca.TabIndex = 19;
            this.btnAdicionarPlaca.Text = "Adicionar";
            this.btnAdicionarPlaca.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarContrato
            // 
            this.btnCadastrarContrato.FlatAppearance.BorderSize = 0;
            this.btnCadastrarContrato.Location = new System.Drawing.Point(293, 312);
            this.btnCadastrarContrato.Name = "btnCadastrarContrato";
            this.btnCadastrarContrato.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarContrato.TabIndex = 20;
            this.btnCadastrarContrato.Text = "Cadastrar";
            this.btnCadastrarContrato.UseVisualStyleBackColor = true;
            // 
            // FrmContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 672);
            this.Controls.Add(this.btnCadastrarContrato);
            this.Controls.Add(this.btnAdicionarPlaca);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtContrato);
            this.Controls.Add(this.txtIe);
            this.Controls.Add(this.dtFim);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmContrato";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmContrato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.TextBox txtIe;
        private System.Windows.Forms.RichTextBox txtContrato;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Button btnAdicionarPlaca;
        private System.Windows.Forms.Button btnCadastrarContrato;
    }
}