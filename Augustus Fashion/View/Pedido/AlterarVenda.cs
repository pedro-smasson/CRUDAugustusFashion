using Augustus_Fashion.Controller;
using Augustus_Fashion.Model;
using Augustus_Fashion.Model.Produto;
using Augustus_Fashion.Model.Venda;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Augustus_Fashion.View.Pedido
{
    public partial class AlterarVenda : Form
    {
        PedidoModel _pedido;
        ProdutoControl _produtoControl = new ProdutoControl();
        VendaControl _vendaControl = new VendaControl();

        public AlterarVenda(PedidoModel pedido)
        {
            InitializeComponent();
            _pedido = pedido;
        }

        public void DadosDaVenda() 
        {
            dgvCarrinho.DataSource = _pedido.Produtos;

            this.dgvCarrinho.Columns["PrecoCusto"].Visible = false;
            this.dgvCarrinho.Columns["PrecoBruto"].Visible = false;
            this.dgvCarrinho.Columns["Desconto"].Visible = false;
            this.dgvCarrinho.Columns["PrecoLiquido"].Visible = false;
            this.dgvCarrinho.Columns["IdVenda"].Visible = false;

            cbFormaDePagamento.Text = _pedido.FormaDePagamento.ToString();
            lblCliente.Text = _pedido.IdCliente.ToString();
            lblFuncionario.Text = _pedido.IdFuncionario.ToString();
            txtTotalVenda.Text = _pedido.PrecoTotal.ToString();
        }

        private void AlterarDadosDaVenda()
        {
            try
            {
                var vendaControl = new VendaControl();

                vendaControl.AlterarVenda(_pedido, _pedido.Produtos);
                MessageBox.Show("Venda alterada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha no Cadastro! " + ex.Message);
            }
        }

        private void btnAdicionar_Click(object sender, System.EventArgs e)
        {

            PedidoProdutoModel produtoPedido = new PedidoProdutoModel();

            produtoPedido.IdProduto = Convert.ToInt32(lblIdProduto.Text);
            produtoPedido.NomeProduto = txtSelecionado.Text;
            produtoPedido.Desconto = Convert.ToDecimal(txtDesconto.Text.ColocarFormatacaoNoPreco());
            produtoPedido.QuantidadeProduto = Convert.ToInt32(nudQuantidade.Value);
            produtoPedido.PrecoBruto = Convert.ToDecimal(txtPrecoVenda.Text);
            produtoPedido.PrecoCusto = txtPrecoCusto.Text.DecimalOuZero();

            _pedido.AdicionarProduto(produtoPedido);


            var source = new BindingSource
            {
                DataSource = _pedido.Produtos
            };

            dgvCarrinho.DataSource = source;

            CalcularLucro();
            CalcularPrecoLiquido();
            txtTotalVenda.Text = _pedido.PrecoASerExibidoNoFinal().ToString("c");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarProdutosDoPedido() && Validar())
                return;

            AlterarDadosDaVenda();
            Hide();
            telaInicial telaInicial = new telaInicial();
            telaInicial.ShowDialog();
            Close();
        }

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

        private bool ValidarProdutosDoPedido()
        {
            if (_pedido.Produtos.Any())
                return true;

            MessageBox.Show("Erro! Carrinho vazio");
            return false;
        }

        private void CalcularPrecoLiquido()
        {
            var precoLiquido = (txtPrecoVenda.Text.DecimalOuZero() - txtDesconto.Text.ColocarFormatacaoNoPreco().DecimalOuZero()) * Convert.ToDecimal(nudQuantidade.Value);
            txtPrecoLiquido.Text = precoLiquido.ToString("c");
        }

        private void CalcularLucro()
        {
            txtLucro.Text = _pedido.Lucro.ToString("c");
        }

        private void AlterarVenda_Load(object sender, EventArgs e)
        {
            dgvCarrinho.Rows[0].Cells[0].Value = _pedido.IdPedido;
            dgvCarrinho.Columns["IdPedido"].Visible = false;
            dgvCarrinho.DataSource = _pedido.Produtos;

            dgvProduto.DataSource = _produtoControl.ListarProduto;
            dgvProduto.Columns["PrecoCusto"].Visible = false;

            txtDesconto.Text = (0).ToString().ColocarFormatacaoNoPreco();

            lblCliente.Text = _pedido.IdCliente.ToString();
            lblFuncionario.Text = _pedido.IdFuncionario.ToString();
        }

        private void dgvProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var nome = dgvProduto.SelectedRows[0].Cells[1].Value;
            var precovenda = dgvProduto.SelectedRows[0].Cells[2].Value;
            var produto = BuscarModelProdutoSelecionado();

            txtSelecionado.Text = nome.ToString();
            txtPrecoVenda.Text = precovenda.ToString();
            lblIdProduto.Text = produto.IdProduto.ToString();
            txtPrecoLiquido.Text = (produto.PrecoVenda - txtDesconto.Text.DecimalOuZero()).ToString("c");
            txtPrecoCusto.Text = produto.PrecoCusto.ToString();
        }

        private ProdutoModel BuscarModelProdutoSelecionado()
        {
                var id = dgvProduto.SelectedRows[0].Cells[0].Value;
                return _produtoControl.Buscar((int)id);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
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

        private void nudQuantidade_ValueChanged(object sender, EventArgs e)
        {
            nudQuantidade.Maximum = 5000;
            QuantidadeMaiorQueEstoque(SelecionarValorEstoque());
            CalcularPrecoLiquido();
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e) => CalcularPrecoLiquido();

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            dgvProduto.DataSource = _produtoControl.BuscarLista(txtProduto.Text);

            if (txtProduto.Text == "%")
            {
                dgvProduto.DataSource = _produtoControl.ListarProduto;
                txtProduto.Text = "";
            }
        }

        private void btnInativar_Click(object sender, EventArgs e)
        {
            _vendaControl.DesativarVenda(_pedido, _pedido.Produtos);

            MessageBox.Show("Pedido inativado com sucesso!");
            this.Hide();
            telaInicial telaInicial = new telaInicial();
            telaInicial.ShowDialog();
            this.Close();
        }
    }
}
