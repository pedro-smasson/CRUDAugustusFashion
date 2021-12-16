using Augustus_Fashion.Controller;
using Augustus_Fashion.InstanciarTela;
using Augustus_Fashion.MensagemGlobal;
using Augustus_Fashion.Model.Produto;
using System;
using System.Windows.Forms;

namespace Augustus_Fashion.View.Produto
{
    public partial class AlterarProduto : Form
    {
        ProdutoControl _produtoControl = new ProdutoControl();
        ProdutoModel _produtoModel = new ProdutoModel();
        MensagemErro _mensagemErro = new MensagemErro();
        MensagemInfo _mensagemInfo = new MensagemInfo();

        public AlterarProduto() => InitializeComponent();

        public void dadosDe(ProdutoModel produto)
        {
            codProduto.Text = produto.IdProduto.ToString();
            idProduto.Text = produto.IdProduto.ToString();
            codBarrasProduto.Text = produto.CodBarra.ToString();
            nomeProduto.Text = produto.Nome;
            fabricanteProduto.Text = produto.Fabricante;
            precoVendaProduto.Text = produto.PrecoVenda.ToString();
            precoCustoProduto.Text = produto.PrecoCusto.ToString();
            estoqueProduto.Text = produto.Estoque.ToString();
            chkAtivo.Checked = produto.StatusProduto;

            _produtoModel = produto;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                _produtoControl.ExcluirProduto(_produtoModel);
                _mensagemInfo.Mensagem("Produto deletado com sucesso!");

                Hide();
                ListarProduto listarProduto = new ListarProduto();
                listarProduto.ShowDialog();
                Close();
            }
            catch
            {
                _mensagemErro.Mensagem("Falha na exclusão! Erro de Banco de Dados");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            _produtoModel.IdProduto = Convert.ToInt32(idProduto.Text);
            _produtoModel.Nome = nomeProduto.Text;
            _produtoModel.CodBarra = codBarrasProduto.Text;
            _produtoModel.PrecoCusto = precoCustoProduto.Text;
            _produtoModel.PrecoVenda = precoVendaProduto.Text;
            _produtoModel.Fabricante = fabricanteProduto.Text;
            _produtoModel.Estoque = Convert.ToInt32(estoqueProduto.Text);
            _produtoModel.StatusProduto = chkAtivo.Checked;

            try
            {
                _produtoControl.AlterarProduto(_produtoModel);
                _mensagemInfo.Mensagem("Produto Alterado!");

                Hide();
                ListarProduto listarProduto = new ListarProduto();
                listarProduto.ShowDialog();
                Close();
            }
            catch
            {
                _mensagemErro.Mensagem("Falha na Alteração!");
            }
        }

        private void FecharToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Instanciar.TelaInicial();
            Close();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}