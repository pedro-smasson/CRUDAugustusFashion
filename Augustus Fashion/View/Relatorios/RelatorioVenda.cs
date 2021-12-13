using Augustus_Fashion.Controller;
using Augustus_Fashion.MensagemGlobal;
using Augustus_Fashion.Model;
using System;
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
            this.Hide();
            telaInicial telaInicial = new telaInicial();
            telaInicial.ShowDialog();
            this.Close();
        }

        private void fECHARToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        private void RelatorioVenda_Load(object sender, EventArgs e) => dgvVenda.DataSource = _produtoController.ListarProduto;

        private void FiltrosPreenchidos()
        {
            _filtrosModel.IdProduto = int.TryParse(txtIdProduto.Text, out int excecao) ? excecao : 0;
            _filtrosModel.NomeProduto = txtNomeProduto.Text;
            _filtrosModel.DataInicial = dtpDataInicial.Value;
            _filtrosModel.DataFinal = dtpDataFinal.Value;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (Validacoes.VerificarSeDataInicialEhMaiorQueDataFinal(dtpDataInicial.Value, dtpDataFinal.Value))
            {
                FiltrosPreenchidos();
                dgvVenda.DataSource = _filtrosController.QueryFiltragemProduto(_filtrosModel);
            }
            _mensagemErro.Mensagem("A Data Inicial é maior que a Data Final!");
            dtpDataInicial.Value = DateTime.Today;
        }

        private void btnLimpar_Click(object sender, EventArgs e) => Limpar();

        private void Limpar()
        {
            txtIdProduto.Text = "";
            txtNomeProduto.Text = "";
            dtpDataInicial.Value = DateTime.Today;
            dtpDataFinal.Value = DateTime.Today;
        }
    }
}