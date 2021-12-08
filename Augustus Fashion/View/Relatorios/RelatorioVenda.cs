using Augustus_Fashion.Controller;
using Augustus_Fashion.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Augustus_Fashion.View.Relatorios
{
    public partial class RelatorioVenda : Form
    {
        ProdutoControl _produtoController = new ProdutoControl();
        FiltrosControl _filtrosController = new FiltrosControl();

        public RelatorioVenda()
        {
            InitializeComponent();
            cbFiltrosSimples.DropDownWidth = DropDownWidth(cbFiltrosSimples);
            cbFiltrosAvancados.DropDownWidth = DropDownWidth(cbFiltrosAvancados);
        }

        int DropDownWidth(ComboBox comboBox)
        {
            int maiorTamanho = 0, temp = 0;
            foreach (var itens in comboBox.Items)
            {
                temp = TextRenderer.MeasureText(itens.ToString(), comboBox.Font).Width;
                if (temp > maiorTamanho)
                {
                    maiorTamanho = temp;
                }
            }
            return maiorTamanho;
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

        private void QualFiltroEstaSelecionado() 
        {
            if(cbFiltrosSimples.Text == "Produtos com Maior Estoque") 
                dgvVenda.DataSource = _filtrosController.ProdutoComMaiorEstoque();

            else if(cbFiltrosSimples.Text == "Produtos com Menor Estoque")
                dgvVenda.DataSource = _filtrosController.ProdutoComMenorEstoque();

            else if(cbFiltrosSimples.Text == "Vendas Mais Rentáveis") 
                dgvVenda.DataSource = _filtrosController.VendasMaisRentaveis();

            else if (cbFiltrosSimples.Text == "Vendas Menos Rentáveis")
                dgvVenda.DataSource = _filtrosController.VendasMenosRentaveis();

            else if(cbFiltrosSimples.Text == "Produtos Mais Vendidos")
                dgvVenda.DataSource = _filtrosController.ProdutosMaisVendidos();

            else if (cbFiltrosSimples.Text == "Produtos Menos Vendidos")
                dgvVenda.DataSource = _filtrosController.ProdutosMenosVendidos();

        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            QualFiltroEstaSelecionado();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cbFiltrosSimples.SelectedItem = null;
            cbFiltrosAvancados.SelectedItem = null;
        }
    }
}
