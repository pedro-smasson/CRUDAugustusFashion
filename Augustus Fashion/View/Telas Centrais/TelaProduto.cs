using Augustus_Fashion.View.Produto;
using System;
using System.Windows.Forms;

namespace Augustus_Fashion.View.Telas_Centrais
{
    public partial class TelaProduto : Form
    {
        public TelaProduto() => InitializeComponent();

        private void pctCadastro_Click(object sender, EventArgs e)
        {
            Hide();
            CadastroProduto cadastroProduto = new CadastroProduto();
            cadastroProduto.ShowDialog();
            Close();
        }

        private void pctLista_Click(object sender, EventArgs e)
        {
            Hide();
            ListarProduto listarProduto = new ListarProduto();
            listarProduto.ShowDialog();
            Close();
        }
    }
}