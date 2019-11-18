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
            this.txtPlacaDespesa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGravarDespesa = new System.Windows.Forms.Button();
            this.txtNatureza = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExcluirDespesa = new System.Windows.Forms.Button();
            this.btnEditarDespesa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Natureza";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Comentario";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(530, 68);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(244, 79);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // txtValorDespesa
            // 
            this.txtValorDespesa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorDespesa.Location = new System.Drawing.Point(239, 68);
            this.txtValorDespesa.MaxLength = 20;
            this.txtValorDespesa.Name = "txtValorDespesa";
            this.txtValorDespesa.Size = new System.Drawing.Size(100, 20);
            this.txtValorDespesa.TabIndex = 4;
            // 
            // txtPlacaDespesa
            // 
            this.txtPlacaDespesa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlacaDespesa.Location = new System.Drawing.Point(530, 175);
            this.txtPlacaDespesa.Name = "txtPlacaDespesa";
            this.txtPlacaDespesa.Size = new System.Drawing.Size(100, 20);
            this.txtPlacaDespesa.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Placa";
            // 
            // btnGravarDespesa
            // 
            this.btnGravarDespesa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGravarDespesa.FlatAppearance.BorderSize = 0;
            this.btnGravarDespesa.Location = new System.Drawing.Point(699, 225);
            this.btnGravarDespesa.Name = "btnGravarDespesa";
            this.btnGravarDespesa.Size = new System.Drawing.Size(75, 23);
            this.btnGravarDespesa.TabIndex = 8;
            this.btnGravarDespesa.Text = "Gravar";
            this.btnGravarDespesa.UseVisualStyleBackColor = true;
            // 
            // txtNatureza
            // 
            this.txtNatureza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNatureza.Location = new System.Drawing.Point(239, 109);
            this.txtNatureza.MaxLength = 20;
            this.txtNatureza.Name = "txtNatureza";
            this.txtNatureza.Size = new System.Drawing.Size(100, 20);
            this.txtNatureza.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(955, 354);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnExcluirDespesa
            // 
            this.btnExcluirDespesa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirDespesa.FlatAppearance.BorderSize = 0;
            this.btnExcluirDespesa.Location = new System.Drawing.Point(780, 225);
            this.btnExcluirDespesa.Name = "btnExcluirDespesa";
            this.btnExcluirDespesa.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirDespesa.TabIndex = 11;
            this.btnExcluirDespesa.Text = "Excluir";
            this.btnExcluirDespesa.UseVisualStyleBackColor = true;
            // 
            // btnEditarDespesa
            // 
            this.btnEditarDespesa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarDespesa.FlatAppearance.BorderSize = 0;
            this.btnEditarDespesa.Location = new System.Drawing.Point(618, 225);
            this.btnEditarDespesa.Name = "btnEditarDespesa";
            this.btnEditarDespesa.Size = new System.Drawing.Size(75, 23);
            this.btnEditarDespesa.TabIndex = 12;
            this.btnEditarDespesa.Text = "Editar";
            this.btnEditarDespesa.UseVisualStyleBackColor = true;
            // 
            // FrmDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1084, 672);
            this.Controls.Add(this.btnEditarDespesa);
            this.Controls.Add(this.btnExcluirDespesa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNatureza);
            this.Controls.Add(this.btnGravarDespesa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPlacaDespesa);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtValorDespesa;
        private System.Windows.Forms.TextBox txtPlacaDespesa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGravarDespesa;
        private System.Windows.Forms.TextBox txtNatureza;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExcluirDespesa;
        private System.Windows.Forms.Button btnEditarDespesa;
    }
}