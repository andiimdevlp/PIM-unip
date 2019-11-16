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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtUsuarioLogin_Enter(object sender, EventArgs e)
        {
            if(txtUsuarioLogin.Text == "Digite seu Usuario")
            {
                txtUsuarioLogin.Text = "";
                txtUsuarioLogin.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuarioLogin_Leave(object sender, EventArgs e)
        {
            if(txtUsuarioLogin.Text == "")
            {
                txtUsuarioLogin.Text = "Digite seu Usuario";
                txtUsuarioLogin.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtSenhaLogin_Enter(object sender, EventArgs e)
        {
            if (txtSenhaLogin.Text == "Digite sua Senha")
            {
                txtSenhaLogin.Text = "";
                txtSenhaLogin.ForeColor = Color.LightGray;
                txtSenhaLogin.UseSystemPasswordChar = true;
            }
        }
        private void txtSenhaLogin_Leave(object sender, EventArgs e)
        {
            if (txtSenhaLogin.Text == "")
            {
                txtSenhaLogin.Text = "Digite sua Senha";
                txtSenhaLogin.ForeColor = Color.WhiteSmoke;
                txtSenhaLogin.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuarioLogin.Text != "Digite seu Usuario" && txtSenhaLogin.Text != "Digite sua Senha")
            {
                UsuarioModel user = new UsuarioModel();
                var validaLogin = user.LoginUser(txtUsuarioLogin.Text, txtSenhaLogin.Text);
                if(validaLogin == true)
                {
                    FrmPainelPrincipal principal = new FrmPainelPrincipal();
                    principal.Show();
                    principal.FormClosed += Logout;
                    this.Hide();
                }
                else
                {
                    msgErro("Usuário ou Senha Incorreto! \n Digite Novamente!");

                    txtUsuarioLogin.Text = "Digite seu Usuario";
                    txtSenhaLogin.Text = "Digite sua Senha";
                }
            }
            else msgErro("Forneça os Dados de Acesso!");
           
        }
        private void msgErro (string msg)
        {
            lblErroLogin.Text = "     " + msg;
            lblErroLogin.Visible = true;
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtUsuarioLogin.Text = "Digite seu Usuario";
            txtSenhaLogin.Text = "Digite sua Senha";
            txtSenhaLogin.UseSystemPasswordChar = false;
            lblErroLogin.Visible = false;
            this.Show();
            //txtUsuarioLogin.Focus();
        }

        private void lnkRecuperarSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recoverPasswor = new FrmRecoverPassword();
            recoverPasswor.ShowDialog();
        }
    }
}
