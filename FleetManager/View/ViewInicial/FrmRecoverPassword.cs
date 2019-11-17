using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FrmRecoverPassword_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void txtUserEmail_Enter(object sender, EventArgs e)
        {
            if (txtUserEmail.Text == "Digite Aqui!")
            {
                txtUserEmail.Text = "";
                txtUserEmail.ForeColor = Color.LightGray;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
