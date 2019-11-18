namespace View.financeiro
{
    partial class FrmContasPagar
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
            this.lblNatureza = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblEmissao = new System.Windows.Forms.Label();
            this.lblVencimento = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnBaixar = new System.Windows.Forms.Button();
            this.btnVoltarBaixa = new System.Windows.Forms.Button();
            this.dbContasPagas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbContasPagas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNatureza
            // 
            this.lblNatureza.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNatureza.AutoSize = true;
            this.lblNatureza.Location = new System.Drawing.Point(191, 73);
            this.lblNatureza.Name = "lblNatureza";
            this.lblNatureza.Size = new System.Drawing.Size(50, 13);
            this.lblNatureza.TabIndex = 0;
            this.lblNatureza.Text = "Natureza";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(648, 73);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblEmissao
            // 
            this.lblEmissao.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEmissao.AutoSize = true;
            this.lblEmissao.Location = new System.Drawing.Point(191, 149);
            this.lblEmissao.Name = "lblEmissao";
            this.lblEmissao.Size = new System.Drawing.Size(46, 13);
            this.lblEmissao.TabIndex = 2;
            this.lblEmissao.Text = "Emissão";
            // 
            // lblVencimento
            // 
            this.lblVencimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVencimento.AutoSize = true;
            this.lblVencimento.Location = new System.Drawing.Point(648, 149);
            this.lblVencimento.Name = "lblVencimento";
            this.lblVencimento.Size = new System.Drawing.Size(63, 13);
            this.lblVencimento.TabIndex = 3;
            this.lblVencimento.Text = "Vencimento";
            // 
            // lblValor
            // 
            this.lblValor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(191, 208);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(264, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox2.Location = new System.Drawing.Point(264, 201);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox3.Location = new System.Drawing.Point(264, 142);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(717, 142);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(717, 66);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
            // 
            // btnBaixar
            // 
            this.btnBaixar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBaixar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaixar.Location = new System.Drawing.Point(651, 200);
            this.btnBaixar.Name = "btnBaixar";
            this.btnBaixar.Size = new System.Drawing.Size(60, 20);
            this.btnBaixar.TabIndex = 10;
            this.btnBaixar.Text = "Baixar";
            this.btnBaixar.UseVisualStyleBackColor = true;
            // 
            // btnVoltarBaixa
            // 
            this.btnVoltarBaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltarBaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltarBaixa.Location = new System.Drawing.Point(746, 200);
            this.btnVoltarBaixa.Name = "btnVoltarBaixa";
            this.btnVoltarBaixa.Size = new System.Drawing.Size(71, 20);
            this.btnVoltarBaixa.TabIndex = 11;
            this.btnVoltarBaixa.Text = "Voltar Baixa";
            this.btnVoltarBaixa.UseVisualStyleBackColor = true;
            // 
            // dbContasPagas
            // 
            this.dbContasPagas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbContasPagas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dbContasPagas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dbContasPagas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbContasPagas.Location = new System.Drawing.Point(57, 301);
            this.dbContasPagas.Name = "dbContasPagas";
            this.dbContasPagas.Size = new System.Drawing.Size(951, 324);
            this.dbContasPagas.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Registros de Contas";
            // 
            // FrmContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1084, 672);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbContasPagas);
            this.Controls.Add(this.btnVoltarBaixa);
            this.Controls.Add(this.btnBaixar);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblVencimento);
            this.Controls.Add(this.lblEmissao);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNatureza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmContasPagar";
            this.Opacity = 0.9D;
            this.Text = "FrmContasPagar";
            ((System.ComponentModel.ISupportInitialize)(this.dbContasPagas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNatureza;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEmissao;
        private System.Windows.Forms.Label lblVencimento;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnBaixar;
        private System.Windows.Forms.Button btnVoltarBaixa;
        private System.Windows.Forms.DataGridView dbContasPagas;
        private System.Windows.Forms.Label label1;
    }
}