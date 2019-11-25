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
            
        }
        private void MostrarCarro()
        {
            dataGridView1.DataSource = objetoControleCarro.MostrarCarro();
        }
    }
}
