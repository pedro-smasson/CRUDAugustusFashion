using Augustus_Fashion.Controller;
using Augustus_Fashion.MensagemGlobal;
using Augustus_Fashion.Model.Produto;
using Augustus_Fashion.Model.Venda;
using Augustus_Fashion.ValueObjects;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Augustus_Fashion.View.Pedido
{
    public partial class VendaPedido3 : Form
    {
        ProdutoControl _produtoControl = new ProdutoControl();
        PedidoModel _pedido;
        MensagemErro _mensagemErro = new MensagemErro();
        MensagemInfo _mensagemInfo = new MensagemInfo();
        MensagemAlerta _mensagemAlerta = new MensagemAlerta();

        string[] Scopes = { GmailService.Scope.GmailSend };
        string ApplicationName = "GmailApp";

        public VendaPedido3(PedidoModel pedido)
        {
            InitializeComponent();
            _pedido = pedido;
        }

        private void VendaPedido3_Load(object sender, EventArgs e)
        {
            dgvProduto.DataSource = _produtoControl.ListarProduto;
            dgvProduto.Columns["PrecoCusto"].Visible = false;

            txtDesconto.Text = ("R$ " + 0).ToString();

            lblCliente.Text = _pedido.IdCliente.ToString();
            lblFuncionario.Text = _pedido.IdFuncionario.ToString();

            if (VerificarSeHojeEhAniversarioDoCliente())
            {
                _mensagemInfo.Mensagem("Hoje é Aniversário deste cliente!");
            }
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

        private void btnVoltar_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.OK;

        private void dgvProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var nome = dgvProduto.SelectedRows[0].Cells[1].Value;
            var precovenda = dgvProduto.SelectedRows[0].Cells[2].Value;
            var produto = BuscarModelProdutoSelecionado();

            txtSelecionado.Text = nome.ToString();
            txtPrecoVenda.Text = precovenda.ToString();
            lblIdProduto.Text = produto.IdProduto.ToString();
            txtPrecoLiquido.Text = (produto.PrecoVenda.RetornarValorEmDecimal() - Dinheiro.RemoverFormatacao(txtDesconto.Text)).ToString("c");
            txtPrecoCusto.Text = produto.PrecoCusto.ToString();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            if (VerificarSePrecoLiquidoEhNegativo())
            {

                PedidoProdutoModel produtoPedido = new PedidoProdutoModel();

                produtoPedido.IdProduto = Convert.ToInt32(lblIdProduto.Text);
                produtoPedido.NomeProduto = txtSelecionado.Text;
                produtoPedido.DescontoUnitario = Dinheiro.RemoverFormatacao(txtDesconto.Text);
                produtoPedido.QuantidadeProduto = Convert.ToInt32(nudQuantidade.Value);
                produtoPedido.PrecoBrutoUnitario = Dinheiro.RemoverFormatacao(txtPrecoVenda.Text);
                produtoPedido.PrecoCustoUnitario = Dinheiro.RemoverFormatacao(txtPrecoCusto.Text);

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
                txtTotalVenda.Text = _pedido.PrecoASerExibidoNoFinal().ToString();
            }
        }

        private void nudQuantidade_ValueChanged(object sender, EventArgs e)
        {
            QuantidadeMaiorQueEstoque(SelecionarValorEstoque());
            CalcularPrecoLiquido();
        }

        private bool VerificarSePrecoLiquidoEhNegativo()
        {
            if (Dinheiro.RemoverFormatacao(txtDesconto.Text) > Dinheiro.RemoverFormatacao(txtPrecoLiquido.Text))
            {
                _mensagemAlerta.Mensagem("Impossível o Desconto ser maior que o Preço Líquido!");
                txtDesconto.Text = txtPrecoVenda.Text;
                return false;
            }
            return true;
        }

        public bool QuantidadeMaiorQueEstoque(int estoque)
        {
            if (nudQuantidade.Value > estoque)
            {
                _mensagemAlerta.Mensagem("Impossível a Quantidade ser maior que o Estoque!");
                nudQuantidade.Value = SelecionarValorEstoque();
                return false;
            }
            return true;
        }
        public int SelecionarValorEstoque()
        {
            return (int)dgvProduto.SelectedRows[0].Cells[4].Value;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            _pedido.DataPedido = DateTime.Today;
            if (ValidarProdutosDoPedido() && Validar())
            {
                CadastrarVenda();
                EnviarEmail();

                Hide();
                telaInicial telaInicial = new telaInicial();
                telaInicial.ShowDialog();
                Close();
            }
        }

        private void CadastrarVenda()
        {
            try
            {
                var vendaControl = new VendaControl();

                vendaControl.CadastrarVenda(_pedido);
                _mensagemInfo.Mensagem("Venda efetuada com sucesso!");
            }
            catch
            {
                _mensagemErro.Mensagem("Falha no Cadastro!");
            }
        }

        private bool ValidarProdutosDoPedido()
        {
            if (_pedido.Produtos.Any())
                return true;

            _mensagemErro.Mensagem("Erro! Carrinho vazio");
            return false;
        }

        private void CalcularPrecoLiquido()
        {
            var precoLiquido = (Dinheiro.RemoverFormatacao(txtPrecoVenda.Text) - Dinheiro.RemoverFormatacao(txtDesconto.Text)) * nudQuantidade.Value;
            txtPrecoLiquido.Text = precoLiquido.ToString("c");
        }

        private void CalcularLucro() => txtLucro.Text = _pedido.Lucro.ToString();

        private void ExibirTotalDaVenda() => txtTotalVenda.Text = _pedido.PrecoASerExibidoNoFinal().ToString();

        private void txtDesconto_TextChanged(object sender, EventArgs e) => CalcularPrecoLiquido();

        private void txtPrecoVenda_TextChanged(object sender, EventArgs e) => CalcularPrecoLiquido();

        private void cbFormaDePagamento_SelectedIndexChanged(object sender, EventArgs e) 
            => _pedido.FormaDePagamento = cbFormaDePagamento.Text;

        private void txtDesconto_KeyUp(object sender, KeyEventArgs e) => CalcularPrecoLiquido();

        private void txtTotalVenda_TextChanged(object sender, EventArgs e) => ExibirTotalDaVenda();

        private bool Validar()
        {

            if (String.IsNullOrEmpty(cbFormaDePagamento.Text))
            {
                _mensagemAlerta.Mensagem("Selecione uma Forma de Pagamento válida");
                return false;
            }
            return true;
        }

        private ProdutoModel BuscarModelProdutoSelecionado()
        {
            var id = dgvProduto.SelectedRows[0].Cells[0].Value;
            return _produtoControl.Buscar((int)id);
        }

        public bool VerificarSeHojeEhAniversarioDoCliente()
        {
            if (DateTime.Now.Day == Convert.ToInt32(ClienteControl.BuscarCliente(_pedido.IdCliente).Nascimento.Day)
            && DateTime.Now.Month == Convert.ToInt32(ClienteControl.BuscarCliente(_pedido.IdCliente).Nascimento.Month))
            {
                return true;
            }
            return false;
        }

        public void EnviarEmail()
        {
            UserCredential credencial;
            using (FileStream stream = new FileStream(Application.StartupPath + @"/arquivoimportante.json", FileMode.Open, FileAccess.Read))
            {
                string caminho = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                caminho = Path.Combine(caminho, ".credentials/gmail-dotnet-quickstart.json");
                credencial = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.FromStream(stream).Secrets, Scopes,
                "user", CancellationToken.None, new FileDataStore(caminho, true)).Result;
            }
            dgvCarrinho.DataSource = null;
            dgvCarrinho.AutoGenerateColumns = false;

            var source = new BindingSource
            {
                DataSource = _pedido.Produtos
            };

            dgvCarrinho.DataSource = source;
            try
            {
                string mensagem =
                $"To: {ClienteControl.BuscarCliente(_pedido.IdCliente).Email}\r\n" +
                $"Subject: {"A Augustus Fashion agradece!"}\r\n" +
                $"Content-Type: text/html;charset=utf-8\r\n\r\n<h1>{$"Olá, {ClienteControl.BuscarCliente(_pedido.IdCliente).Nome}! Obrigado pela preferência :D<br><br> Seu Pedido feito em {_pedido.DataPedido.Day}/{_pedido.DataPedido.Month} de {_pedido.DataPedido.Year}, é o seguinte:"}</h1><ol>";

                mensagem += "<table border=\"1\"> <tr> <th> Nome </th> <th >Quantidade </th> <th> Preço Unitário </th> <th> Preço Total </th> </tr>";

                foreach (var produto in _pedido.Produtos)
                {
                    mensagem += $"<tr> <td> {produto.NomeProduto} </td> <td> {produto.QuantidadeProduto} </td> <td> {produto.PrecoBrutoUnitario} </td>" +
                    $"<td> {produto.PrecoLiquidoTotal} </td> </tr>";
                }
                mensagem += "</table>";

                var service = new GmailService(new BaseClientService.Initializer() { HttpClientInitializer = credencial, ApplicationName = ApplicationName });
                var msg = new Google.Apis.Gmail.v1.Data.Message();
                msg.Raw = Base64UrlEncode(mensagem.ToString());
                service.Users.Messages.Send(msg, "me").Execute();
                MessageBox.Show("Email enviado com sucesso!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                _mensagemErro.Mensagem("Erro no envio do Email!");
            }
        }

        string Base64UrlEncode(string input)
        {
            var data = Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(data).Replace("+", "-").Replace("/", "_").Replace("=", "");
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var index = dgvCarrinho.SelectedRows[0].Index;

            _pedido.Produtos.RemoveAt(index);

            dgvCarrinho.DataSource = null;
            dgvCarrinho.AutoGenerateColumns = false;

            var source = new BindingSource
            {
                DataSource = _pedido.Produtos
            };

            dgvCarrinho.DataSource = source;

            CalcularLucro();
            CalcularPrecoLiquido();
            txtTotalVenda.Text = _pedido.PrecoASerExibidoNoFinal().ToString();
        }
    }
}