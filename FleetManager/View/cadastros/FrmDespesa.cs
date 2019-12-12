using Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.cadastros
{
    public partial class FrmDespesa : Form
    {
        CrudBanco objetoFinanceiro = new CrudBanco();
        public FrmDespesa()
        {
            InitializeComponent();
        }

        private void FrmDespesa_Load(object sender, EventArgs e)
        {
            MostrarFinanceiro();
        }

        private void MostrarFinanceiro()
        {
            CrudBanco objetoFinan = new CrudBanco();
            dtFinanceiro.DataSource = objetoFinan.MostrarFin();
        }

        private void btnGravarDespesa_Click(object sender, EventArgs e)
        {
            try
            {
                objetoFinanceiro.InsertFin(txtValorDespesa.Text, txtNatureza.Text, txtDepartamento.Text, txtMemo.Text, txtPlacaDespesa.Text);
                MessageBox.Show("Despesa cadastrado!");
                MostrarFinanceiro();

            }
            catch (Exception ex)
            {
                MessageBox.Show("O despesa não inserida.\nCertifique-se de preencher os dados\ncorretos e não repetidos."+ex);
            }
            txtValorDespesa.Clear();
            txtNatureza.Clear();
            txtDepartamento.Clear();
            txtMemo.Clear();
            txtPlacaDespesa.Clear();
        }

        private void btnBaixar_Click(object sender, EventArgs e)
        {
            if (dtFinanceiro.SelectedRows.Count > 0)
            {
                txtValorDespesa.Text = dtFinanceiro.CurrentRow.Cells["NUM"].Value.ToString();

                txtValorDespesa.ForeColor = Color.Transparent;

                objetoFinanceiro.BaixarFin(txtValorDespesa.Text);
                MessageBox.Show("Despesa baixada!");
                MostrarFinanceiro();
            }
            txtValorDespesa.Clear();
        }

        private void btnEstornar_Click(object sender, EventArgs e)
        {
            if (dtFinanceiro.SelectedRows.Count > 0)
            {
                txtValorDespesa.Text = dtFinanceiro.CurrentRow.Cells["NUM"].Value.ToString();

                txtValorDespesa.ForeColor = Color.Transparent;
                txtMemo.ForeColor = Color.Transparent;

                objetoFinanceiro.EstornoFin(txtValorDespesa.Text, txtMemo.Text);
                MessageBox.Show("Baixa estornada!");
                MostrarFinanceiro();
            }
            txtValorDespesa.Clear();
        }
    }
}
