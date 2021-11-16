using Augustus_Fashion.Controller;
using Augustus_Fashion.Model.Venda;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Augustus_Fashion.View.Pedido
{
    public partial class VendaPedido3 : Form
    {
        ProdutoControl _produtocontrol = new ProdutoControl();

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
            txtSelecionado.Text = nome.ToString();
        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            CarrinhoModel carrinhoModel = new CarrinhoModel();
            carrinhoModel.NomeProduto = txtSelecionado.Text;

            _carrinho.Add(carrinhoModel);

            foreach (var itens in _carrinho)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvCarrinho);

                row.Cells[0].Value = itens.NomeProduto;
                dgvCarrinho.Rows.Add(row);
            }
        }
    }
}
