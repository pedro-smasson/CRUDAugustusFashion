using Augustus_Fashion.Model;
using Augustus_Fashion.View.Pedido;
using Augustus_Fashion.View.Produto;
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

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            cadastroCliente cadastrarCliente = new cadastroCliente();
            cadastrarCliente.ShowDialog();
            this.Close();
        }

        private void fUNCIONÁRIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            CadastroFuncionario cadastrarFuncionario = new CadastroFuncionario();
            cadastrarFuncionario.ShowDialog();
            this.Close();
        }

        private void FecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cLIENTESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            ListarCliente listarCliente = new ListarCliente();
            listarCliente.ShowDialog();
            this.Close();
        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            AlterarCliente alterarCliente = new AlterarCliente();
            alterarCliente.ShowDialog();
            this.Close();
        }

        private void fUNCIONÁRIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            AlterarFuncionario af = new AlterarFuncionario();
            af.ShowDialog();
            this.Close();
        }

        private void fUNCIONÁRIOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            ListarFuncionario listarFuncionario = new ListarFuncionario();
            listarFuncionario.ShowDialog();
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            CadastroProduto cadastrarProduto = new CadastroProduto();
            cadastrarProduto.ShowDialog();
            Close();

        }

        private void eSTOQUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            ListarProduto listarProduto = new ListarProduto();
            listarProduto.ShowDialog();
            Close();
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

        private void nOVOPEDIDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            VendaPedido novoPedido = new VendaPedido();
            novoPedido.ShowDialog();
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            TelaPedido telaPedido = new TelaPedido();
            telaPedido.ShowDialog();
            Close();
        }
    }
}
