using Entidade.Cache;
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
using View.cadastros;
using View.financeiro;

namespace View
{
    public partial class FrmPainelPrincipal : Form
    {
        public FrmPainelPrincipal()
        {
            InitializeComponent();
            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenuVertical.Width == 200)
            {
                pnlMenuVertical.Width = 85;
                Point Financeiro = new Point(12, 174);
                Point Relatorio = new Point(12, 210);

                btnFinanceiro.Location = Financeiro;
                btnRelatorio.Location = Relatorio;

                btnCadastroCarro.Visible = false;
                btnCadastroContrato.Visible = false;
                btnCadastroDespesa.Visible = false;
                btnFinContasPagar.Visible = false;
                btnFinSinistros.Visible = false;
                btnRelGastoFrota.Visible = false;

            }
            else
            {
                pnlMenuVertical.Width = 200;

                Point Financeiro = new Point(12, 270);
                Point Relatorio = new Point(12, 370);

                btnFinanceiro.Location = Financeiro;
                btnRelatorio.Location = Relatorio;

                btnCadastroCarro.Visible = true;
                btnCadastroContrato.Visible = true;
                btnCadastroDespesa.Visible = true;
                btnFinContasPagar.Visible = true;
                btnFinSinistros.Visible = true;
                btnRelGastoFrota.Visible = true;
            }
        }
        private void btnFechar_Click_1(object sender, EventArgs e)
        {

            Application.Exit();
            //FrmLogin chamarlogin = new FrmLogin();
            //chamarlogin.Show();
            //Visible = false;
        }
        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente fazer logoff no sistema?", "Logoff",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            this.Close();
        }
        private void FrmPainelPrincipal_Load (object sender, EventArgs e)
        {
            LoadUserData();
        }
        private void LoadUserData()
        {
            lblNomeLogado.Text = UserLoginCache.NomeUsuario;
            lblCargoLogado.Text = UserLoginCache.NivelAcesso;
            lblEmailLogado.Text = UserLoginCache.EmailUsuario;

            if(UserLoginCache.SexoUsuario == "M")
            {
                avatarMulher.Visible = true;
                avatarHomen.Visible = false;
            }
        }

        //=====================================================================
        //ABERTURA DOS SUB-MENUS COM REDIMENSIONAMENTO DA LOCATION

        private void AbrirFromulario<MainForm>() where MainForm : Form, new()
        {
            Form formulario;
            formulario = pnlView.Controls.OfType<MainForm>().FirstOrDefault();
            if(formulario == null)
            {
                formulario = new MainForm();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                pnlView.Controls.Add(formulario);
                pnlView.Tag = formulario;
                formulario.Show(); ;
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
                formulario.FormBorderStyle = FormBorderStyle.None;
            }
        }
        private void btnCadastroCarro_Click(object sender, EventArgs e)
        {
            AbrirFromulario<FrmCarros>();
        }

        private void btnFinContasPagar_Click(object sender, EventArgs e)
        {
        }

        private void btnCadastroContrato_Click(object sender, EventArgs e)
        {
            AbrirFromulario<FrmContrato>();
        }

        private void btnCadastroDespesa_Click(object sender, EventArgs e)
        {
            AbrirFromulario<FrmDespesa>();
        }
    }
}