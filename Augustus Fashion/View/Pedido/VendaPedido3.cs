using Augustus_Fashion.Controller;
using Augustus_Fashion.Model;
using Augustus_Fashion.Model.Produto;
using Augustus_Fashion.Model.Venda;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Augustus_Fashion.View.Pedido
{
    public partial class VendaPedido3 : Form
    {
        ProdutoControl _produtoControl = new ProdutoControl();
        PedidoModel _pedido;


        public VendaPedido3(PedidoModel pedido)
        {
            InitializeComponent();
            _pedido = pedido;
        }

        private void VendaPedido3_Load(object sender, EventArgs e)
        {
            dgvProduto.DataSource = _produtoControl.ListarProduto;
            dgvProduto.Columns["PrecoCusto"].Visible = false;

            txtDesconto.Text = (0).ToString().ColocarFormatacaoNoPreco();

            lblCliente.Text = _pedido.IdCliente.ToString();
            lblFuncionario.Text = _pedido.IdFuncionario.ToString();
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            dgvProduto.DataSource = _produtoControl.BuscarLista(txtProduto.Text);

            if (txtProduto.Text == "%")
            {
                dgvProduto.DataSource = _produtoControl.ListarProduto;
                txtProduto.Text = "";
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void dgvProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var nome = dgvProduto.SelectedRows[0].Cells[1].Value;
            var precovenda = dgvProduto.SelectedRows[0].Cells[2].Value;
            //var precocusto = dgvProduto.SelectedRows[0].Cells[3].Value;
            var produto = BuscarModelProdutoSelecionado();

            txtSelecionado.Text = nome.ToString();
            txtPrecoVenda.Text = precovenda.ToString();
            lblIdProduto.Text = produto.IdProduto.ToString();
            txtPrecoLiquido.Text = (produto.PrecoVenda.DecimalOuZero() - txtDesconto.Text.DecimalOuZero()).ToString("c");
            txtPrecoCusto.Text = produto.PrecoCusto.ToString();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            PedidoProdutoModel produtoPedido = new PedidoProdutoModel();

            produtoPedido.IdProduto = Convert.ToInt32(lblIdProduto.Text);
            produtoPedido.NomeProduto = txtSelecionado.Text;
            produtoPedido.Desconto = Convert.ToDecimal(txtDesconto.Text.ColocarFormatacaoNoPreco());
            produtoPedido.QuantidadeProduto = Convert.ToInt32(nudQuantidade.Value);
            produtoPedido.PrecoBruto = Convert.ToDecimal(txtPrecoVenda.Text);
            produtoPedido.PrecoCusto = txtPrecoCusto.Text.DecimalOuZero();

            _pedido.AdicionarProduto(produtoPedido);

            dgvCarrinho.DataSource = null;
            dgvCarrinho.AutoGenerateColumns = false;

            var source = new BindingSource
            {
                DataSource = _pedido.Produtos
            };

            dgvCarrinho.DataSource = source;

            CalcularLucro();
            CalcularPrecoLiquido();
            txtTotalVenda.Text = _pedido.PrecoASerExibidoNoFinal().ToString("c");
        }

        private void nudQuantidade_ValueChanged(object sender, EventArgs e)
        {
            nudQuantidade.Maximum = 5000;
            QuantidadeMaiorQueEstoque(SelecionarValorEstoque());
            CalcularPrecoLiquido();
        }

        public bool QuantidadeMaiorQueEstoque(int estoque)
        {
            if (nudQuantidade.Value > estoque)
            {
                MessageBox.Show("Impossível a Quantidade ser maior que o Estoque!");
                nudQuantidade.Value = SelecionarValorEstoque();
                return false;
            }
            return true;
        }
        public int SelecionarValorEstoque()
        {
            return (int)dgvProduto.SelectedRows[0].Cells[4].Value;
        }

        // CADASTRO DA VENDA
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (!ValidarProdutosDoPedido() && Validar())
            return;

            CadastrarVenda();

            Hide();
            telaInicial telaInicial = new telaInicial();
            telaInicial.ShowDialog();
            Close();

        }


        private void CadastrarVenda()
        {
            try
            {
                var vendaControl = new VendaControl();

                vendaControl.CadastrarVenda(_pedido, _pedido.Produtos);
                MessageBox.Show("Venda efetuada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha no Cadastro! " + ex.Message);
            }
        }

        private bool ValidarProdutosDoPedido()
        {

            if (_pedido.Produtos.Any())
                return true;

            MessageBox.Show("Erro! Carrinho vazio");
            return false;

        }

        private void CalcularLucro() 
        {
            txtLucro.Text = _pedido.Lucro.ToString("c");
        }

        private void CalcularPrecoLiquido()
        {
            var precoLiquido = (txtPrecoVenda.Text.DecimalOuZero() - txtDesconto.Text.ColocarFormatacaoNoPreco().DecimalOuZero()) * Convert.ToDecimal(nudQuantidade.Value);
            txtPrecoLiquido.Text = precoLiquido.ToString("c");
        }
        private void ExibirTotalDaVenda()
        {
            txtTotalVenda.Text = _pedido.PrecoASerExibidoNoFinal().ToString("c");
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e) => CalcularPrecoLiquido();

        private void txtPrecoVenda_TextChanged(object sender, EventArgs e) => CalcularPrecoLiquido();

        private void cbFormaDePagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            _pedido.FormaDePagamento = cbFormaDePagamento.Text;
        }

        private void txtDesconto_KeyUp(object sender, KeyEventArgs e) => CalcularPrecoLiquido();

        private bool Validar()
        {
            if (!Testes.ValidarDesconto(float.Parse(txtDesconto.Text)))
            {
                MessageBox.Show("Desconto Inválido!");
                return false;
            }
            if (!Testes.ValidarNumeric(txtLucro.Text))
            {
                MessageBox.Show("Lucro Inválido!");
                return false;
            }
            if (!Testes.ValidarNumeric(txtPrecoLiquido.Text))
            {
                MessageBox.Show("Preço Líquido Inválido!");
                return false;
            }
            if (!Testes.ValidarNumeric(txtTotalVenda.Text))
            {
                MessageBox.Show("Total de Venda Inválido!");
                return false;
            }
            return true;
        }

        private ProdutoModel BuscarModelProdutoSelecionado() 
        {
            var id = dgvProduto.SelectedRows[0].Cells[0].Value;
            return _produtoControl.Buscar((int)id);
        }

        private void txtTotalVenda_TextChanged(object sender, EventArgs e)
        {
            ExibirTotalDaVenda();
        }
    }
}
