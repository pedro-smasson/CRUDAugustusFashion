using Augustus_Fashion.View.Telas_Centrais;
using System;
using System.Windows.Forms;

namespace Augustus_Fashion.View
{

    public partial class telaInicial : Form
    {
        public telaInicial()
        {
            InitializeComponent();
        }

        private void pbCliente_Click(object sender, EventArgs e)
        {
            Hide();
            TelaCliente telaCliente = new TelaCliente();
            telaCliente.ShowDialog();
            Close();
        }

        private void pbProduto_Click(object sender, EventArgs e)
        {
            Hide();
            TelaProduto telaProduto = new TelaProduto();
            telaProduto.ShowDialog();
            Close();
        }

        private void pbFuncionario_Click(object sender, EventArgs e)
        {
            Hide();
            TelaFuncionario telaFuncionario = new TelaFuncionario();
            telaFuncionario.ShowDialog();
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            TelaPedido telaPedido = new TelaPedido();
            telaPedido.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}