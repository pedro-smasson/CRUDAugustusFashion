using Augustus_Fashion.InstanciarTela;
using Augustus_Fashion.View.Pedido;
using Augustus_Fashion.View.Relatorios;
using System;
using System.Windows.Forms;

namespace Augustus_Fashion.View.Telas_Centrais
{
    public partial class TelaPedido : Form
    {
        public TelaPedido() => InitializeComponent();

        private void pctCadastro_Click(object sender, EventArgs e)
        {
            Hide();
            VendaPedido efetuarVenda = new VendaPedido();
            efetuarVenda.ShowDialog();
            Close();
        }

        private void pctLista_Click(object sender, EventArgs e)
        {
            Hide();
            ListagemPedido listarPedido = new ListagemPedido();
            listarPedido.ShowDialog();
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            RelatorioCliente relatorioCliente = new RelatorioCliente();
            relatorioCliente.ShowDialog();
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Hide();
            RelatorioVenda relatorioVenda = new RelatorioVenda();
            relatorioVenda.ShowDialog();
            Close();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Instanciar.TelaInicial();
            Close();
        }

        private void fECHARToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();
    }
}