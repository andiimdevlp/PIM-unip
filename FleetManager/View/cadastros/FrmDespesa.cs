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

            }
        }
    }
}
