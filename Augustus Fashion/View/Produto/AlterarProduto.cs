using Augustus_Fashion.Controller;
using Augustus_Fashion.Model.Produto;
using System;
using System.Windows.Forms;

namespace Augustus_Fashion.View.Produto
{
    public partial class AlterarProduto : Form
    {
        ProdutoControl _produtoControl = new ProdutoControl();
        ProdutoModel _produtoModel = new ProdutoModel();

        public AlterarProduto()
        {
            InitializeComponent();
        }

        public void dadosDe(ProdutoModel produto)
        {
            codProduto.Text = produto.IdProduto.ToString();
            idProduto.Text = produto.IdProduto.ToString();
            codBarrasProduto.Text = produto.CodBarra.ToString();
            nomeProduto.Text = produto.Nome;
            fabricanteProduto.Text = produto.Fabricante;
            precoVendaProduto.Text = Convert.ToDecimal(produto.PrecoVenda).ToString();
            precoCustoProduto.Text = produto.PrecoCusto.ToString();
            estoqueProduto.Text = produto.Estoque.ToString();
            chkAtivo.Checked = produto.StatusProduto;

            _produtoModel = produto;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
           

            _produtoControl.ExcluirProduto(_produtoModel);
            MessageBox.Show("Produto deletado com sucesso!");

            Hide();
            ListarProduto listarProduto = new ListarProduto();
            listarProduto.ShowDialog();
            Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            _produtoModel.Nome = nomeProduto.Text;
            _produtoModel.CodBarra = codBarrasProduto.Text;
            _produtoModel.PrecoCusto = Convert.ToDecimal(precoCustoProduto.Text);
            _produtoModel.PrecoVenda = Convert.ToDecimal(precoVendaProduto.Text);
            _produtoModel.Fabricante = fabricanteProduto.Text;
            _produtoModel.Estoque = Convert.ToInt32(estoqueProduto.Text);
            _produtoModel.StatusProduto = chkAtivo.Checked;

            try 
            {
                _produtoControl.AlterarProduto(_produtoModel);
                MessageBox.Show("Produto Alterado!");

                Hide();
                ListarProduto listarProduto = new ListarProduto();
                listarProduto.ShowDialog();
                Close();
            }catch(Exception ex) 
            {
                MessageBox.Show("Erro na Alteração! " + ex.Message);
            }
           
        }

        private void FecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            telaInicial telaInicial = new telaInicial();
            telaInicial.ShowDialog();
            Close();
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            cadastroCliente cadastrarCliente = new cadastroCliente();
            cadastrarCliente.ShowDialog();
            Close();
        }

        private void fUNCIONÁRIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            CadastroFuncionario cadastrarFuncionario = new CadastroFuncionario();
            cadastrarFuncionario.ShowDialog();
            Close();
        }

        private void cLIENTESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            ListarCliente listarCliente = new ListarCliente();
            listarCliente.ShowDialog();
            Close();
        }

        private void fUNCIONÁRIOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            ListarFuncionario listarFuncionario = new ListarFuncionario();
            listarFuncionario.ShowDialog();
            Close();
        }

        private void cAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
