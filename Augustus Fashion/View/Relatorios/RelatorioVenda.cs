using Augustus_Fashion.Controller;
using Augustus_Fashion.Model;
using System;
using System.Windows.Forms;

namespace Augustus_Fashion.View.Relatorios
{
    public partial class RelatorioVenda : Form
    {
        ProdutoControl _produtoController;
        FiltrosControl _filtrosController;
        FiltrosProdutoModel _filtrosModel;

        public RelatorioVenda()
        {
            InitializeComponent();
           _filtrosModel = new FiltrosProdutoModel();
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

        private void fECHARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RelatorioVenda_Load(object sender, EventArgs e)
        {
            dgvVenda.DataSource = _produtoController.ListarProduto;
        }

        private void FiltrosPreenchidos()
        {
            _filtrosModel.IdCliente = Convert.ToInt32(txtIdCliente.Text);
            _filtrosModel.NomeProduto = txtNomeProduto.Text;
            _filtrosModel.DataInicial = dtpDataInicial.Value;
            _filtrosModel.DataFinal = dtpDataFinal.Value;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            FiltrosPreenchidos();
            dgvVenda.DataSource = _filtrosController.QueryFiltragemProduto(_filtrosModel);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
           txtIdCliente.Text = "";
           txtIdCliente.Text = "";
        }
    }
}
