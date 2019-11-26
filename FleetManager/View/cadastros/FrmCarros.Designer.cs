namespace View.cadastros
{
    partial class FrmCarros
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
            this.components = new System.ComponentModel.Container();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblRenavam = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.txtRenavam = new System.Windows.Forms.TextBox();
            this.btnSalvarCarro = new System.Windows.Forms.Button();
            this.btnExcluirCarro = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.ltModelo = new System.Windows.Forms.ListBox();
            this.veiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controleCarroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtAno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleCarroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(110, 37);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(40, 13);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa :";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(107, 71);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(43, 13);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Marca :";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(118, 101);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(32, 13);
            this.lblAno.TabIndex = 2;
            this.lblAno.Text = "Ano :";
            // 
            // lblRenavam
            // 
            this.lblRenavam.AutoSize = true;
            this.lblRenavam.Location = new System.Drawing.Point(464, 71);
            this.lblRenavam.Name = "lblRenavam";
            this.lblRenavam.Size = new System.Drawing.Size(59, 13);
            this.lblRenavam.TabIndex = 5;
            this.lblRenavam.Text = "Renavam :";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(494, 33);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(29, 13);
            this.lblCor.TabIndex = 4;
            this.lblCor.Text = "Cor :";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(171, 30);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(194, 20);
            this.txtPlaca.TabIndex = 13;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(171, 64);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(194, 20);
            this.txtMarca.TabIndex = 14;
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(550, 30);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(188, 20);
            this.txtCor.TabIndex = 16;
            // 
            // txtRenavam
            // 
            this.txtRenavam.Location = new System.Drawing.Point(550, 64);
            this.txtRenavam.Name = "txtRenavam";
            this.txtRenavam.Size = new System.Drawing.Size(188, 20);
            this.txtRenavam.TabIndex = 17;
            // 
            // btnSalvarCarro
            // 
            this.btnSalvarCarro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarCarro.FlatAppearance.BorderSize = 0;
            this.btnSalvarCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarCarro.Location = new System.Drawing.Point(540, 168);
            this.btnSalvarCarro.Name = "btnSalvarCarro";
            this.btnSalvarCarro.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarCarro.TabIndex = 19;
            this.btnSalvarCarro.Text = "Salvar";
            this.btnSalvarCarro.UseVisualStyleBackColor = true;
            this.btnSalvarCarro.Click += new System.EventHandler(this.btnSalvarCarro_Click);
            // 
            // btnExcluirCarro
            // 
            this.btnExcluirCarro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirCarro.FlatAppearance.BorderSize = 0;
            this.btnExcluirCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCarro.Location = new System.Drawing.Point(644, 168);
            this.btnExcluirCarro.Name = "btnExcluirCarro";
            this.btnExcluirCarro.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirCarro.TabIndex = 20;
            this.btnExcluirCarro.Text = "Excluir";
            this.btnExcluirCarro.UseVisualStyleBackColor = true;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(85, 139);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(58, 13);
            this.lblCategoria.TabIndex = 24;
            this.lblCategoria.Text = "Categoria :";
            // 
            // ltModelo
            // 
            this.ltModelo.BackColor = System.Drawing.SystemColors.Control;
            this.ltModelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ltModelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ltModelo.FormattingEnabled = true;
            this.ltModelo.Items.AddRange(new object[] {
            "Passeio",
            "Caminhão",
            "Passageiros"});
            this.ltModelo.Location = new System.Drawing.Point(171, 139);
            this.ltModelo.Name = "ltModelo";
            this.ltModelo.Size = new System.Drawing.Size(120, 52);
            this.ltModelo.TabIndex = 27;
            // 
            // veiculoBindingSource
            // 
            this.veiculoBindingSource.DataMember = "veiculo";
            // 
            // controleCarroBindingSource
            // 
            this.controleCarroBindingSource.DataSource = typeof(Control.ControleCarro);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(88, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(882, 360);
            this.dataGridView1.TabIndex = 28;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(171, 94);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(194, 20);
            this.txtAno.TabIndex = 15;
            // 
            // FrmCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 672);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ltModelo);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.btnExcluirCarro);
            this.Controls.Add(this.btnSalvarCarro);
            this.Controls.Add(this.txtRenavam);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lblRenavam);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblPlaca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCarros";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCarros";
            this.Load += new System.EventHandler(this.FrmCarros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleCarroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblRenavam;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtRenavam;
        private System.Windows.Forms.Button btnSalvarCarro;
        private System.Windows.Forms.Button btnExcluirCarro;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ListBox ltModelo;
        private System.Windows.Forms.BindingSource veiculoBindingSource;
        private System.Windows.Forms.BindingSource controleCarroBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAno;
    }
}