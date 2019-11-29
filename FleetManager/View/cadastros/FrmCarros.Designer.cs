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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.txtAno = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.controleCarroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleCarroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlaca
            // 
            this.lblPlaca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.ForeColor = System.Drawing.Color.White;
            this.lblPlaca.Location = new System.Drawing.Point(59, 109);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(51, 17);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa :";
            // 
            // lblModelo
            // 
            this.lblModelo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.White;
            this.lblModelo.Location = new System.Drawing.Point(56, 147);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(55, 17);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Marca :";
            // 
            // lblAno
            // 
            this.lblAno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.ForeColor = System.Drawing.Color.White;
            this.lblAno.Location = new System.Drawing.Point(67, 184);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(41, 17);
            this.lblAno.TabIndex = 2;
            this.lblAno.Text = "Ano :";
            // 
            // lblRenavam
            // 
            this.lblRenavam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRenavam.AutoSize = true;
            this.lblRenavam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenavam.ForeColor = System.Drawing.Color.White;
            this.lblRenavam.Location = new System.Drawing.Point(34, 250);
            this.lblRenavam.Name = "lblRenavam";
            this.lblRenavam.Size = new System.Drawing.Size(76, 17);
            this.lblRenavam.TabIndex = 5;
            this.lblRenavam.Text = "Renavam :";
            // 
            // lblCor
            // 
            this.lblCor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCor.AutoSize = true;
            this.lblCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor.ForeColor = System.Drawing.Color.White;
            this.lblCor.Location = new System.Drawing.Point(72, 215);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(38, 17);
            this.lblCor.TabIndex = 4;
            this.lblCor.Text = "Cor :";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlaca.ForeColor = System.Drawing.Color.Black;
            this.txtPlaca.Location = new System.Drawing.Point(120, 102);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(194, 20);
            this.txtPlaca.TabIndex = 13;
            // 
            // txtMarca
            // 
            this.txtMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMarca.ForeColor = System.Drawing.Color.Black;
            this.txtMarca.Location = new System.Drawing.Point(120, 140);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(194, 20);
            this.txtMarca.TabIndex = 14;
            // 
            // txtCor
            // 
            this.txtCor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCor.ForeColor = System.Drawing.Color.Black;
            this.txtCor.Location = new System.Drawing.Point(120, 212);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(194, 20);
            this.txtCor.TabIndex = 16;
            // 
            // txtRenavam
            // 
            this.txtRenavam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRenavam.ForeColor = System.Drawing.Color.Black;
            this.txtRenavam.Location = new System.Drawing.Point(120, 247);
            this.txtRenavam.Name = "txtRenavam";
            this.txtRenavam.Size = new System.Drawing.Size(194, 20);
            this.txtRenavam.TabIndex = 17;
            // 
            // btnSalvarCarro
            // 
            this.btnSalvarCarro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSalvarCarro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarCarro.FlatAppearance.BorderSize = 0;
            this.btnSalvarCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarCarro.ForeColor = System.Drawing.Color.White;
            this.btnSalvarCarro.Location = new System.Drawing.Point(120, 422);
            this.btnSalvarCarro.Name = "btnSalvarCarro";
            this.btnSalvarCarro.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarCarro.TabIndex = 19;
            this.btnSalvarCarro.Text = "Salvar";
            this.btnSalvarCarro.UseVisualStyleBackColor = true;
            this.btnSalvarCarro.Click += new System.EventHandler(this.btnSalvarCarro_Click);
            // 
            // btnExcluirCarro
            // 
            this.btnExcluirCarro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnExcluirCarro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirCarro.FlatAppearance.BorderSize = 0;
            this.btnExcluirCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCarro.ForeColor = System.Drawing.Color.White;
            this.btnExcluirCarro.Location = new System.Drawing.Point(224, 422);
            this.btnExcluirCarro.Name = "btnExcluirCarro";
            this.btnExcluirCarro.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirCarro.TabIndex = 20;
            this.btnExcluirCarro.Text = "Excluir";
            this.btnExcluirCarro.UseVisualStyleBackColor = true;
            this.btnExcluirCarro.Click += new System.EventHandler(this.btnExcluirCarro_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(34, 331);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(77, 17);
            this.lblCategoria.TabIndex = 24;
            this.lblCategoria.Text = "Categoria :";
            // 
            // ltModelo
            // 
            this.ltModelo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.ltModelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ltModelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ltModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltModelo.ForeColor = System.Drawing.Color.White;
            this.ltModelo.FormattingEnabled = true;
            this.ltModelo.Items.AddRange(new object[] {
            "Passeio",
            "Caminhão",
            "Passageiros"});
            this.ltModelo.Location = new System.Drawing.Point(120, 331);
            this.ltModelo.Name = "ltModelo";
            this.ltModelo.Size = new System.Drawing.Size(120, 39);
            this.ltModelo.TabIndex = 27;
            // 
            // veiculoBindingSource
            // 
            this.veiculoBindingSource.DataMember = "veiculo";
            // 
            // txtAno
            // 
            this.txtAno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAno.ForeColor = System.Drawing.Color.Black;
            this.txtAno.Location = new System.Drawing.Point(120, 177);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(194, 20);
            this.txtAno.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Fira Code Retina", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(382, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(660, 348);
            this.dataGridView1.TabIndex = 28;
            // 
            // controleCarroBindingSource
            // 
            this.controleCarroBindingSource.DataSource = typeof(Control.CrudBanco);
            // 
            // FrmCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleCarroBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}