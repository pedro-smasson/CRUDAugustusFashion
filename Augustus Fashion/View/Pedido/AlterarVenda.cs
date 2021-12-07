using Augustus_Fashion.Controller;
using Augustus_Fashion.Model;
using Augustus_Fashion.Model.Produto;
using Augustus_Fashion.Model.Venda;
using Augustus_Fashion.ValueObjects;
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

            this.dgvCarrinho.Columns["IdPedido"].Visible = false;
            this.dgvCarrinho.Columns["IdVenda"].Visible = false;
            this.dgvCarrinho.Columns["PrecoCustoUnitario"].Visible = false;
            this.dgvCarrinho.Columns["DescontoUnitario"].Visible = false;
            this.dgvCarrinho.Columns["PrecoBrutoUnitario"].Visible = false;
            this.dgvCarrinho.Columns["PrecoBrutoTotal"].Visible = false;
            this.dgvCarrinho.Columns["PrecoLiquidoUnitario"].Visible = false;
            this.dgvCarrinho.Columns["PrecoLiquidoTotal"].Visible = true;

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

                vendaControl.AlterarVenda(_pedido);
                MessageBox.Show("Venda alterada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha no Cadastro! " + ex.Message);
            }
        }

        private void btnAdicionar_Click(object sender, System.EventArgs e)
        {
            PedidoProdutoModel produtoPedido = new PedidoProdutoModel
            {
                IdProduto = Convert.ToInt32(lblIdProduto.Text),
                NomeProduto = txtSelecionado.Text,
                DescontoUnitario = Dinheiro.RemoverFormatacao(txtDesconto.Text),
                QuantidadeProduto = Convert.ToInt32(nudQuantidade.Value),
                PrecoBrutoUnitario = Dinheiro.RemoverFormatacao(txtPrecoVenda.Text),
                PrecoCustoUnitario = Dinheiro.RemoverFormatacao(txtPrecoCusto.Text)
            };

            _pedido.AdicionarProduto(produtoPedido);

            var source = new BindingSource
            {
                DataSource = _pedido.Produtos
            };

            dgvCarrinho.DataSource = source;

            CalcularLucro();
            CalcularPrecoLiquido();
            txtTotalVenda.Text = _pedido.PrecoASerExibidoNoFinal().ToString();
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
            if (!Testes.ValidarDesconto(Convert.ToDecimal(txtDesconto.Text)))
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
            var precoLiquido = (Dinheiro.RemoverFormatacao(txtPrecoVenda.Text) - Dinheiro.RemoverFormatacao(txtDesconto.Text)) * nudQuantidade.Value;
            txtPrecoLiquido.Text = precoLiquido.ToString("c");
        }

        private void AlterarVenda_Load(object sender, EventArgs e)
        {
            //dgvCarrinho.Rows[0].Cells[0].Value = _pedido.IdPedido;
            //dgvCarrinho.Columns["IdPedido"].Visible = false;
            //dgvCarrinho.DataSource = _pedido.Produtos;

            dgvProduto.DataSource = _produtoControl.ListarProduto;
            dgvProduto.Columns["PrecoCusto"].Visible = false;

            txtDesconto.Text = (0).ToString();

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
            txtPrecoLiquido.Text = (produto.PrecoVenda.RetornarValorEmDecimal() - Convert.ToDecimal(txtDesconto.Text)).ToString("c");
            txtPrecoCusto.Text = produto.PrecoCusto.ToString();
        }

        private ProdutoModel BuscarModelProdutoSelecionado()
        {
            var id = dgvProduto.SelectedRows[0].Cells[0].Value;
            return _produtoControl.Buscar((int)id);
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

        private void nudQuantidade_ValueChanged(object sender, EventArgs e)
        {
            CalcularPrecoLiquido();
            QuantidadeMaiorQueEstoque(SelecionarValorEstoque());
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

        private void btnInativar_Click(object sender, EventArgs e)
        {
            _vendaControl.DesativarVenda(_pedido);

            MessageBox.Show("Pedido inativado com sucesso!");
            this.Hide();
            telaInicial telaInicial = new telaInicial();
            telaInicial.ShowDialog();
            this.Close();
        }

        //LAMBDAS
        public int SelecionarValorEstoque() => (int)dgvProduto.SelectedRows[0].Cells[4].Value;
        private void CalcularLucro() => txtLucro.Text = _pedido.Lucro.ToString();

        private void txtPrecoVenda_TextChanged(object sender, EventArgs e) => CalcularPrecoLiquido();
        private void nudQuantidade_KeyUp(object sender, KeyEventArgs e) => CalcularPrecoLiquido();
        private void txtDesconto_TextChanged(object sender, EventArgs e) => CalcularPrecoLiquido();

        private void btnVoltar_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.OK;
    }
}
