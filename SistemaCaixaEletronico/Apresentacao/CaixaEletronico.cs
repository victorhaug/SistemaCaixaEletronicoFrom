using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaCaixaEletronico.Modelo;

namespace SistemaCaixaEletronico.Apresentacao
{
    public partial class CaixaEletronico : Form
    {
        public CaixaEletronico()
        {
            InitializeComponent();
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            controller.Sacar(txbSacar.Text);
            MessageBox.Show(controller.nota_100 +  " notas de 100");
            MessageBox.Show(controller.nota_50 + " notas de 50");
            MessageBox.Show(controller.nota_20 + " notas de 20");
            MessageBox.Show(controller.nota_10 + " notas de 10");
        }

        private void txbSacar_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txbSacar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {

        }
    }
}
