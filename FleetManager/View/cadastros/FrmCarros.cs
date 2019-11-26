using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;

namespace View.cadastros
{
    public partial class FrmCarros : Form
    {
        ControleCarro objetoControleCarro = new ControleCarro();
        public FrmCarros()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void FrmCarros_Load(object sender, EventArgs e)
        {
            MostrarCarro();
        }
        private void MostrarCarro()
        {
            ControleCarro objetoCarro = new ControleCarro();
            dataGridView1.DataSource = objetoCarro.MostrarCarro();
        }

        private void btnSalvarCarro_Click(object sender, EventArgs e)
        {
            try
            {
                string modelo = ltModelo.Text.ToString();
                objetoControleCarro.InsertCarro(txtPlaca.Text, modelo, txtCor.Text, txtAno.Text, txtRenavam.Text, txtMarca.Text);
                MessageBox.Show("Veiculo cadastrado!");
                MostrarCarro();
            }
            catch(Exception)
            {
                MessageBox.Show("O veiculo não inserido.\nCertifique-se de preencher os dados\ncorretos e não repetidos. ");
            }
            txtAno.Clear();
            txtCor.Clear();
            txtMarca.Clear();
            txtPlaca.Clear();
            txtRenavam.Clear();
            ltModelo.ClearSelected();
        }
    }
}
