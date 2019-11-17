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

namespace View
{
    public partial class FrmRecoverPassword : Form
    {
        public FrmRecoverPassword()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var user = new UsuarioModel();
            var result = user.recoverPassword(txtUserEmail.Text);
            lblResposta.Text = result;
        }

        private void txtUserEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtUserEmail.Text == "Digite Aqui!")
            {
                txtUserEmail.Text = "";
                txtUserEmail.ForeColor = Color.LightGray;
            }
        }

        private void txtUserEmail_MouseLeave(object sender, EventArgs e)
        {
            if (txtUserEmail.Text == "")
            {
                txtUserEmail.Text = "Digite Aqui!";
                txtUserEmail.ForeColor = Color.LightGray;
            }
        }
    }
}
