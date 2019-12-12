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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMemo = new System.Windows.Forms.RichTextBox();
            this.txtValorDespesa = new System.Windows.Forms.TextBox();
            this.txtPlacaDespesa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGravarDespesa = new System.Windows.Forms.Button();
            this.txtNatureza = new System.Windows.Forms.TextBox();
            this.dtFinanceiro = new System.Windows.Forms.DataGridView();
            this.btnExcluirDespesa = new System.Windows.Forms.Button();
            this.btnBaixar = new System.Windows.Forms.Button();
            this.btnEstornar = new System.Windows.Forms.Button();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinanceiro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(74, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Natureza :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(56, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Comentario :";
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(148, 198);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(123, 79);
            this.txtMemo.TabIndex = 5;
            this.txtMemo.Text = "";
            // 
            // txtValorDespesa
            // 
            this.txtValorDespesa.Location = new System.Drawing.Point(148, 29);
            this.txtValorDespesa.MaxLength = 20;
            this.txtValorDespesa.Name = "txtValorDespesa";
            this.txtValorDespesa.Size = new System.Drawing.Size(123, 20);
            this.txtValorDespesa.TabIndex = 1;
            // 
            // txtPlacaDespesa
            // 
            this.txtPlacaDespesa.Location = new System.Drawing.Point(148, 115);
            this.txtPlacaDespesa.Name = "txtPlacaDespesa";
            this.txtPlacaDespesa.Size = new System.Drawing.Size(123, 20);
            this.txtPlacaDespesa.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(90, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Placa :";
            // 
            // btnGravarDespesa
            // 
            this.btnGravarDespesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravarDespesa.FlatAppearance.BorderSize = 0;
            this.btnGravarDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravarDespesa.ForeColor = System.Drawing.Color.White;
            this.btnGravarDespesa.Location = new System.Drawing.Point(115, 315);
            this.btnGravarDespesa.Name = "btnGravarDespesa";
            this.btnGravarDespesa.Size = new System.Drawing.Size(75, 23);
            this.btnGravarDespesa.TabIndex = 8;
            this.btnGravarDespesa.Text = "Gravar";
            this.btnGravarDespesa.UseVisualStyleBackColor = true;
            this.btnGravarDespesa.Click += new System.EventHandler(this.btnGravarDespesa_Click);
            // 
            // txtNatureza
            // 
            this.txtNatureza.Location = new System.Drawing.Point(148, 70);
            this.txtNatureza.MaxLength = 20;
            this.txtNatureza.Name = "txtNatureza";
            this.txtNatureza.Size = new System.Drawing.Size(123, 20);
            this.txtNatureza.TabIndex = 2;
            // 
            // dtFinanceiro
            // 
            this.dtFinanceiro.AllowUserToResizeColumns = false;
            this.dtFinanceiro.AllowUserToResizeRows = false;
            this.dtFinanceiro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFinanceiro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtFinanceiro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtFinanceiro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.dtFinanceiro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtFinanceiro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtFinanceiro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtFinanceiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtFinanceiro.EnableHeadersVisualStyles = false;
            this.dtFinanceiro.Location = new System.Drawing.Point(338, 29);
            this.dtFinanceiro.Name = "dtFinanceiro";
            this.dtFinanceiro.ReadOnly = true;
            this.dtFinanceiro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtFinanceiro.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtFinanceiro.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtFinanceiro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtFinanceiro.Size = new System.Drawing.Size(734, 518);
            this.dtFinanceiro.TabIndex = 10;
            // 
            // btnExcluirDespesa
            // 
            this.btnExcluirDespesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirDespesa.FlatAppearance.BorderSize = 0;
            this.btnExcluirDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirDespesa.ForeColor = System.Drawing.Color.White;
            this.btnExcluirDespesa.Location = new System.Drawing.Point(196, 372);
            this.btnExcluirDespesa.Name = "btnExcluirDespesa";
            this.btnExcluirDespesa.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirDespesa.TabIndex = 11;
            this.btnExcluirDespesa.Text = "Excluir";
            this.btnExcluirDespesa.UseVisualStyleBackColor = true;
            this.btnExcluirDespesa.Click += new System.EventHandler(this.btnExcluirDespesa_Click);
            // 
            // btnBaixar
            // 
            this.btnBaixar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaixar.FlatAppearance.BorderSize = 0;
            this.btnBaixar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaixar.ForeColor = System.Drawing.Color.White;
            this.btnBaixar.Location = new System.Drawing.Point(115, 371);
            this.btnBaixar.Name = "btnBaixar";
            this.btnBaixar.Size = new System.Drawing.Size(75, 23);
            this.btnBaixar.TabIndex = 18;
            this.btnBaixar.Text = "Baixar";
            this.btnBaixar.UseVisualStyleBackColor = true;
            this.btnBaixar.Click += new System.EventHandler(this.btnBaixar_Click);
            // 
            // btnEstornar
            // 
            this.btnEstornar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstornar.FlatAppearance.BorderSize = 0;
            this.btnEstornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstornar.ForeColor = System.Drawing.Color.White;
            this.btnEstornar.Location = new System.Drawing.Point(196, 315);
            this.btnEstornar.Name = "btnEstornar";
            this.btnEstornar.Size = new System.Drawing.Size(75, 23);
            this.btnEstornar.TabIndex = 19;
            this.btnEstornar.Text = "Estornar";
            this.btnEstornar.UseVisualStyleBackColor = true;
            this.btnEstornar.Click += new System.EventHandler(this.btnEstornar_Click);
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(148, 158);
            this.txtDepartamento.MaxLength = 20;
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(123, 20);
            this.txtDepartamento.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(39, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Departamento :";
            // 
            // FrmDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(1084, 672);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEstornar);
            this.Controls.Add(this.btnBaixar);
            this.Controls.Add(this.btnExcluirDespesa);
            this.Controls.Add(this.dtFinanceiro);
            this.Controls.Add(this.txtNatureza);
            this.Controls.Add(this.btnGravarDespesa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPlacaDespesa);
            this.Controls.Add(this.txtValorDespesa);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDespesa";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDespesa";
            this.Load += new System.EventHandler(this.FrmDespesa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtFinanceiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtMemo;
        private System.Windows.Forms.TextBox txtValorDespesa;
        private System.Windows.Forms.TextBox txtPlacaDespesa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGravarDespesa;
        private System.Windows.Forms.TextBox txtNatureza;
        private System.Windows.Forms.DataGridView dtFinanceiro;
        private System.Windows.Forms.Button btnExcluirDespesa;
        private System.Windows.Forms.Button btnBaixar;
        private System.Windows.Forms.Button btnEstornar;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label label5;
    }
}