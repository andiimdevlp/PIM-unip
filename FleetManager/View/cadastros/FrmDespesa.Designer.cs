namespace View.cadastros
{
    partial class FrmDespesa
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtValorDespesa = new System.Windows.Forms.TextBox();
            this.cbTipoDespesa = new System.Windows.Forms.CheckedListBox();
            this.txtPlacaDespesa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGravarDespesa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Comentario";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(419, 59);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(244, 79);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // txtValorDespesa
            // 
            this.txtValorDespesa.Location = new System.Drawing.Point(128, 59);
            this.txtValorDespesa.MaxLength = 20;
            this.txtValorDespesa.Name = "txtValorDespesa";
            this.txtValorDespesa.Size = new System.Drawing.Size(100, 20);
            this.txtValorDespesa.TabIndex = 4;
            // 
            // cbTipoDespesa
            // 
            this.cbTipoDespesa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbTipoDespesa.FormattingEnabled = true;
            this.cbTipoDespesa.Items.AddRange(new object[] {
            "Multa",
            "Garagem",
            "Pedagios",
            "Abastecimento",
            "Manutenção",
            "Impostos",
            "Outros"});
            this.cbTipoDespesa.Location = new System.Drawing.Point(128, 107);
            this.cbTipoDespesa.Name = "cbTipoDespesa";
            this.cbTipoDespesa.Size = new System.Drawing.Size(102, 105);
            this.cbTipoDespesa.TabIndex = 5;
            // 
            // txtPlacaDespesa
            // 
            this.txtPlacaDespesa.Location = new System.Drawing.Point(419, 166);
            this.txtPlacaDespesa.Name = "txtPlacaDespesa";
            this.txtPlacaDespesa.Size = new System.Drawing.Size(100, 20);
            this.txtPlacaDespesa.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Placa";
            // 
            // btnGravarDespesa
            // 
            this.btnGravarDespesa.FlatAppearance.BorderSize = 0;
            this.btnGravarDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravarDespesa.Location = new System.Drawing.Point(588, 216);
            this.btnGravarDespesa.Name = "btnGravarDespesa";
            this.btnGravarDespesa.Size = new System.Drawing.Size(75, 23);
            this.btnGravarDespesa.TabIndex = 8;
            this.btnGravarDespesa.Text = "Gravar";
            this.btnGravarDespesa.UseVisualStyleBackColor = true;
            // 
            // FrmDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 672);
            this.Controls.Add(this.btnGravarDespesa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPlacaDespesa);
            this.Controls.Add(this.cbTipoDespesa);
            this.Controls.Add(this.txtValorDespesa);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDespesa";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDespesa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtValorDespesa;
        private System.Windows.Forms.CheckedListBox cbTipoDespesa;
        private System.Windows.Forms.TextBox txtPlacaDespesa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGravarDespesa;
    }
}