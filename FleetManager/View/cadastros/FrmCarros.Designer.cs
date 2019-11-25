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
            this.lblAdicionais = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btnSalvarCarro = new System.Windows.Forms.Button();
            this.btnExcluirCarro = new System.Windows.Forms.Button();
            this.lblCombustivel = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.veiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controleCarroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.lblModelo.Location = new System.Drawing.Point(102, 71);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(48, 13);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo :";
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
            // lblAdicionais
            // 
            this.lblAdicionais.AutoSize = true;
            this.lblAdicionais.Location = new System.Drawing.Point(462, 101);
            this.lblAdicionais.Name = "lblAdicionais";
            this.lblAdicionais.Size = new System.Drawing.Size(61, 13);
            this.lblAdicionais.TabIndex = 6;
            this.lblAdicionais.Text = "Adicionais :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(171, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 20);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(171, 94);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(194, 20);
            this.textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(550, 30);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(188, 20);
            this.textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(550, 64);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(188, 20);
            this.textBox5.TabIndex = 17;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(550, 94);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(188, 20);
            this.textBox6.TabIndex = 18;
            // 
            // btnSalvarCarro
            // 
            this.btnSalvarCarro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarCarro.FlatAppearance.BorderSize = 0;
            this.btnSalvarCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarCarro.Location = new System.Drawing.Point(843, 193);
            this.btnSalvarCarro.Name = "btnSalvarCarro";
            this.btnSalvarCarro.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarCarro.TabIndex = 19;
            this.btnSalvarCarro.Text = "Salvar";
            this.btnSalvarCarro.UseVisualStyleBackColor = true;
            // 
            // btnExcluirCarro
            // 
            this.btnExcluirCarro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirCarro.FlatAppearance.BorderSize = 0;
            this.btnExcluirCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCarro.Location = new System.Drawing.Point(947, 193);
            this.btnExcluirCarro.Name = "btnExcluirCarro";
            this.btnExcluirCarro.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirCarro.TabIndex = 20;
            this.btnExcluirCarro.Text = "Excluir";
            this.btnExcluirCarro.UseVisualStyleBackColor = true;
            // 
            // lblCombustivel
            // 
            this.lblCombustivel.AutoSize = true;
            this.lblCombustivel.Location = new System.Drawing.Point(80, 131);
            this.lblCombustivel.Name = "lblCombustivel";
            this.lblCombustivel.Size = new System.Drawing.Size(70, 13);
            this.lblCombustivel.TabIndex = 23;
            this.lblCombustivel.Text = "Combustivel :";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(821, 30);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(58, 13);
            this.lblCategoria.TabIndex = 24;
            this.lblCategoria.Text = "Categoria :";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Indisponivel"});
            this.checkedListBox1.Location = new System.Drawing.Point(550, 131);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(100, 16);
            this.checkedListBox1.TabIndex = 25;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Álcool",
            "Diesel",
            "Flex",
            "Gasolina"});
            this.listBox1.Location = new System.Drawing.Point(171, 131);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 65);
            this.listBox1.TabIndex = 26;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.Control;
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "Passeio",
            "Caminhão",
            "Passageiros"});
            this.listBox2.Location = new System.Drawing.Point(902, 30);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 52);
            this.listBox2.TabIndex = 27;
            // 
            // terraclusterDataSet
            // 
            // 
            // veiculoBindingSource
            // 
            this.veiculoBindingSource.DataMember = "veiculo";
            // 
            // veiculoTableAdapter
            // 
            // 
            // controleCarroBindingSource
            // 
            this.controleCarroBindingSource.DataSource = typeof(Control.ControleCarro);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(159, 304);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 296);
            this.dataGridView1.TabIndex = 28;
            // 
            // FrmCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 672);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblCombustivel);
            this.Controls.Add(this.btnExcluirCarro);
            this.Controls.Add(this.btnSalvarCarro);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblAdicionais);
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
        private System.Windows.Forms.Label lblAdicionais;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btnSalvarCarro;
        private System.Windows.Forms.Button btnExcluirCarro;
        private System.Windows.Forms.Label lblCombustivel;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.BindingSource veiculoBindingSource;
        private System.Windows.Forms.BindingSource controleCarroBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}