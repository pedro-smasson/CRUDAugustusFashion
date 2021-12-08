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

        public enum FiltroSimples
        {
            ProdutoMaisVendido = 0,
            ProdutoMenosVendido = 1,
            MaiorEstoque = 2,
            MenorEstoque = 3,
            VendaMaisRentavel = 4,
            VendaMenosRentavel = 5
        }

        public enum FiltroAvancado 
        {
            Top5ProdutosMaisVendidos = 0,
            Top5ProdutosMenosVendidos = 1
        }

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
            if (cbFiltrosSimples.SelectedIndex == 0)
                dgvVenda.DataSource = _filtrosController.ProdutosMaisVendidos();

            else if (cbFiltrosSimples.SelectedIndex == 1)
                dgvVenda.DataSource = _filtrosController.ProdutosMenosVendidos();

            else if (cbFiltrosSimples.SelectedIndex == 2)
            { 
                dgvVenda.DataSource = _filtrosController.ProdutoComMaiorEstoque();
                dgvVenda.Columns["Total"].Visible = false;
            }
            else if (cbFiltrosSimples.SelectedIndex == 3) 
            {
                dgvVenda.DataSource = _filtrosController.ProdutoComMenorEstoque();
                dgvVenda.Columns["Total"].Visible = false;
            }  

            else if (cbFiltrosSimples.SelectedIndex == 4)
                dgvVenda.DataSource = _filtrosController.VendasMaisRentaveis();

            else if (cbFiltrosSimples.SelectedIndex == 5)
                dgvVenda.DataSource = _filtrosController.VendasMenosRentaveis();

            else if (cbFiltrosAvancados.SelectedIndex == 0) 
            {
                dgvVenda.DataSource = _filtrosController.Os5ProdutosMaisVendidos();
                dgvVenda.Columns["Estoque"].Visible = false;
            } 
            else if(cbFiltrosAvancados.SelectedIndex == 1) 
            {
                dgvVenda.DataSource = _filtrosController.Os5ProdutosMenosVendidos();
                dgvVenda.Columns["Estoque"].Visible = false;
            }
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
