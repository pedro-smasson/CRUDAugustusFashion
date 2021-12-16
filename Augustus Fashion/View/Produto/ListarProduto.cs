using Augustus_Fashion.Controller;
using Augustus_Fashion.InstanciarTela;
using Augustus_Fashion.Model.Produto;
using System;
using System.Windows.Forms;

namespace Augustus_Fashion.View.Produto
{
    public partial class ListarProduto : Form
    {
        ProdutoControl _produtoControl = new ProdutoControl();
        ProdutoModel _produtoModel = new ProdutoModel();

        public ListarProduto()
        {
            InitializeComponent();
        }

        private void ListarProduto_Load(object sender, EventArgs e) => dgvProduto.DataSource = _produtoControl.ListarProduto();

        private void buscarNome_Click(object sender, EventArgs e)
        {
            dgvProduto.DataSource = _produtoControl.BuscarLista(txtNome.Text);

            if (txtNome.Text == "%")
            {
                dgvProduto.DataSource = _produtoControl.ListarTodosOsProdutos();
                txtNome.Text = "";
            }
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Instanciar.TelaInicial();
            Close();
        }

        private void FecharToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        public int SelecionarProdutoModel()
        {
            int id = Convert.ToInt32(dgvProduto.SelectedRows[0].Cells[0].Value);
            return id;
        }

        private void dgvProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AlterarProduto alterarProduto = new AlterarProduto();
            var id = SelecionarProdutoModel();
            var cliente = _produtoControl.Buscar(id);
            alterarProduto.dadosDe(cliente);
            alterarProduto.ShowDialog();
        }

        public bool VerificarInatividadeDoProduto()
        {
            if (_produtoModel.StatusProduto == false)
            {
                return true;
            }
            return false;
        }
    }
}