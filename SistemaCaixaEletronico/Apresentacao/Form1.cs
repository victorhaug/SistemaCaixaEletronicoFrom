using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaCaixaEletronico.Apresentacao;
using SistemaCaixaEletronico.Modelo;

namespace SistemaCaixaEletronico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txbSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastra_Click(object sender, EventArgs e)
        {
            Cadastra ca = new Cadastra();
            ca.Show();
        }

        private void btnEntra_Click(object sender, EventArgs e)
        {
            //CaixaEletronico cx = new CaixaEletronico();
            //cx.Show();
            Controller controller = new Controller();
            controller.acessar(txbLogin.Text, txbSenha.Text);
            if (controller.mensagem.Equals(""))
            {
                if (controller.tem)
                {
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CaixaEletronico cx = new CaixaEletronico();
                    cx.Show();
                }
                else
                {
                    MessageBox.Show("Login não encontrado, verificar login e senha", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show(controller.mensagem);
            }
        }

        private void txbLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
