using Augustus_Fashion.Controller;
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

        private void ListarProduto_Load(object sender, EventArgs e)
        {
            dgvProduto.DataSource = _produtoControl.ListarProduto;
        }

        private void buscarNome_Click(object sender, EventArgs e)
        {
            dgvProduto.DataSource = _produtoControl.BuscarLista(txtNome.Text);

            if (txtNome.Text == "%")
            {
                dgvProduto.DataSource = _produtoControl.ListarTodosOsProdutos;
                txtNome.Text = "";
            }
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            telaInicial ti = new telaInicial();
            ti.ShowDialog();
            Close();
        }

        private void FecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            cadastroCliente cc = new cadastroCliente();
            cc.ShowDialog();
            this.Close();
        }

        private void fUNCIONÁRIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            CadastroFuncionario cf = new CadastroFuncionario();
            cf.ShowDialog();
            this.Close();
        }

        private void cLIENTESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            ListarCliente lc = new ListarCliente();
            lc.ShowDialog();
            this.Close();
        }

        private void fUNCIONÁRIOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            ListarFuncionario lf = new ListarFuncionario();
            lf.ShowDialog();
            this.Close();
        }

        private void lISTAGEMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void cADASTROToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            CadastroProduto cp = new CadastroProduto();
            cp.ShowDialog();
            Close();
        }

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
            if(_produtoModel.StatusProduto == false) 
            {
                //this.dgvProduto.Columns["Status"].Visible = false;
                //dgvProduto.DataSource = 
                return true;
            }
            return false;
        }
    }
}
