using Augustus_Fashion.Controller;
using Augustus_Fashion.MensagemGlobal;
using Augustus_Fashion.Model;
using Augustus_Fashion.Model.Produto;
using System;
using System.Windows.Forms;

namespace Augustus_Fashion.View
{
    public partial class CadastroProduto : Form
    {
        ProdutoModel _produtoModel = new ProdutoModel();
        ProdutoControl _produtoControl = new ProdutoControl();
        MensagemErro _mensagemErro = new MensagemErro();
        MensagemInfo _mensagemInfo = new MensagemInfo();

        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void FecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            telaInicial ti = new telaInicial();
            ti.ShowDialog();
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            codProduto.Text = "";
            codBarrasProduto.Text = "";
            nomeProduto.Text = "";
            fabricanteProduto.Text = "";
            precoVendaProduto.Text = "";
            precoCustoProduto.Text = "";
            estoqueProduto.Text = "";
            chkAtivo.Checked = false;
        }

        private bool Validar()
        {
            if (!Validacoes.ValidarNumeric(codBarrasProduto.Text))
            {
                _mensagemErro.Mensagem("Informe um Código de Barras válido!");
                return false;
            }
            else if (!Validacoes.ValidarNumeric(precoVendaProduto.Text))
            {
                _mensagemErro.Mensagem("Informe um Preço de Venda válido!");
                return false;
            }
            else if (!Validacoes.ValidarNumeric(precoCustoProduto.Text))
            {
                _mensagemErro.Mensagem("Informe um Preço de Custo válido!");
                return false;
            }
            else if (!Validacoes.ValidarString(nomeProduto.Text))
            {
                _mensagemErro.Mensagem("Informe um Nome válido!");
                return false;
            }
            else if (!Validacoes.ValidarFabricante(fabricanteProduto.Text))
            {
                _mensagemErro.Mensagem("Informe um Fabricante válido!");
                return false;
            }
            else if (!Validacoes.ValidarNumeric(estoqueProduto.Text))
            {
                _mensagemErro.Mensagem("Informe uma quantidade de Estoque válida!");
                return false;
            }
            return true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                _produtoModel.CodBarra = codBarrasProduto.Text;
                _produtoModel.PrecoVenda = Convert.ToDecimal(precoVendaProduto.Text);
                _produtoModel.PrecoCusto = Convert.ToDecimal(precoCustoProduto.Text);
                _produtoModel.Nome = nomeProduto.Text;
                _produtoModel.Fabricante = fabricanteProduto.Text;
                _produtoModel.Estoque = Convert.ToInt32(estoqueProduto.Text);

                _produtoModel.StatusProduto = chkAtivo.Checked;

                try
                {
                    _produtoControl.CadastrarProduto(_produtoModel);
                    _mensagemInfo.Mensagem("Produto Cadastrado com Sucesso!");

                    codProduto.Text = "";
                    codBarrasProduto.Text = "";
                    nomeProduto.Text = "";
                    fabricanteProduto.Text = "";
                    precoVendaProduto.Text = "";
                    precoCustoProduto.Text = "";
                    estoqueProduto.Text = "";
                    chkAtivo.Checked = false;
                }
                catch
                {
                    _mensagemErro.Mensagem("Falha no Cadastro!");
                }
            }
        }
    }
}