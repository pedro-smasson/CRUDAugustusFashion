using Augustus_Fashion.Controller;
using Augustus_Fashion.Model;
using Augustus_Fashion.Model.Produto;
using Augustus_Fashion.Model.Venda;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Augustus_Fashion.View.Pedido
{
    public partial class VendaPedido3 : Form
    {
        ProdutoControl _produtocontrol = new ProdutoControl();
        ProdutoModel _produtomodel = new ProdutoModel();

        List<CarrinhoModel> _carrinho = new List<CarrinhoModel>();

        public VendaPedido3()
        {
            InitializeComponent();
        }

        private void VendaPedido3_Load(object sender, EventArgs e)
        {
            dgvProduto.DataSource = _produtocontrol.ListarProduto();
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            dgvProduto.DataSource = _produtocontrol.BuscarLista(txtProduto.Text);

            if(txtProduto.Text == "%") 
            {
                dgvProduto.DataSource = _produtocontrol.ListarProduto();
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
            
            txtSelecionado.Text = nome.ToString();
            txtPrecoVenda.Text = precovenda.ToString();

            // 3 = estoque
        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            CarrinhoModel carrinhoModel = new CarrinhoModel();
            carrinhoModel.NomeProduto = txtSelecionado.Text;
            carrinhoModel.Desconto = Convert.ToInt32(txtDesconto.Text);
            carrinhoModel.QuantidadeProduto = Convert.ToInt32(nudQuantidade.Value);
            //carrinhoModel.PrecoFinal();

            _carrinho.Add(carrinhoModel);

            foreach (var itens in _carrinho)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvCarrinho);

                row.Cells[0].Value = itens.NomeProduto;
                row.Cells[1].Value = itens.PrecoFinal.ToString("c");
                row.Cells[2].Value = itens.QuantidadeProduto;
                dgvCarrinho.Rows.Add(row);
            }
        }

        private void nudQuantidade_ValueChanged(object sender, EventArgs e)
        {
            nudQuantidade.Maximum = 5000;
            QuantidadeMaiorQueEstoque(SelecionarValorEstoque());         
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
            return (int)dgvProduto.SelectedRows[0].Cells[3].Value;       
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Validar()) 
            {
                MessageBox.Show("Teste");
            }
        }

        private bool Validar()
        {
            if (!Testes.ValidarDesconto(float.Parse(txtDesconto.Text)))
            {
                MessageBox.Show("Desconto Inválido!");
                return false;
            }
            return true;
        }
    }
}
