using Augustus_Fashion.Controller;
using Augustus_Fashion.InstanciarTela;
using Augustus_Fashion.MensagemGlobal;
using Augustus_Fashion.Model;
using Augustus_Fashion.Model.Relatorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Augustus_Fashion.View.Relatorios
{
    public partial class RelatorioVenda : Form
    {
        ProdutoControl _produtoController;
        FiltrosControl _filtrosController;
        FiltrosProdutoModel _filtrosModel = new FiltrosProdutoModel();
        MensagemErro _mensagemErro = new MensagemErro();

        public RelatorioVenda()
        {
            InitializeComponent();
            _filtrosController = new FiltrosControl();
            _produtoController = new ProdutoControl();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Instanciar.TelaInicial();
            Close();
        }

        private void fECHARToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        private void FiltrosPreenchidos()
        {
            _filtrosModel.IdProduto = int.TryParse(txtIdProduto.Text, out int excecao) ? excecao : 0;
            _filtrosModel.NomeProduto = txtNomeProduto.Text;
            _filtrosModel.DataInicial = dtpDataInicial.Value;
            _filtrosModel.DataFinal = dtpDataFinal.Value;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacoes.VerificarSeDataInicialEhMaiorQueDataFinal(dtpDataInicial.Value, dtpDataFinal.Value))
                {
                    FiltrosPreenchidos();
                    var filtrarProduto = _filtrosController.QueryFiltragemProduto(_filtrosModel);
                    dgvVenda.DataSource = filtrarProduto;
                    Totalizadores(filtrarProduto);
                    dgvVenda.Columns[0].HeaderText = "ID Produto";
                    dgvVenda.Columns[1].HeaderText = "Nome";
                    dgvVenda.Columns[2].HeaderText = "Quantidade";
                    dgvVenda.Columns[3].HeaderText = "Total Desconto";
                    dgvVenda.Columns[4].HeaderText = "Total Bruto";
                    dgvVenda.Columns[5].HeaderText = "Preço de Custo";
                    dgvVenda.Columns[6].HeaderText = "Lucro Total";
                }
                else
                {
                    _mensagemErro.Mensagem("A Data Inicial é maior que a Data Final!");
                    dtpDataInicial.Value = DateTime.Today;
                }
            }
            catch
            {
                _mensagemErro.Mensagem("Erro na filtragem!");
            }
        }

        private void Totalizadores(List<RelatorioProdutosModel> total)
        {
            lblDesconto.Text = total.Sum(x => (x.Desconto)).ToString();
            lblLucroTotal.Text = total.Sum(x => (x.Lucro.RetornarValorEmDecimal())).ToString();
            lblQuantidade.Text = total.Sum(x => (x.Quantidade)).ToString();
            lblTotalBruto.Text = total.Sum(x => x.TotalBruto.RetornarValorEmDecimal()).ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e) => Instanciar.LimparCampos(this);
    }
}