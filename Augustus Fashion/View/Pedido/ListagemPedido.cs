using Augustus_Fashion.Controller;
using Augustus_Fashion.Model.Venda;
using System;
using System.Windows.Forms;

namespace Augustus_Fashion.View.Pedido
{
    public partial class ListagemPedido : Form
    {
        VendaControl _vendaControl = new VendaControl();
        ListagemVendaModel _listagemVendaModel = new ListagemVendaModel();

        public ListagemPedido()
        {
            InitializeComponent();
        }

        private void ListagemPedido_Load(object sender, EventArgs e)
        {
            dgvPedido.DataSource = _vendaControl.ListarPedidos();

            dgvPedido.Columns[0].HeaderText = "ID Pedido";
            dgvPedido.Columns[1].HeaderText = "Nome Funcionário";
            dgvPedido.Columns[2].HeaderText = "Nome Cliente";
            dgvPedido.Columns[3].HeaderText = "Quantidade";
            dgvPedido.Columns[4].HeaderText = "Preço Total";
            dgvPedido.Columns[5].HeaderText = "Lucro";
            dgvPedido.Columns[6].HeaderText = "Forma de Pagamento";
        }

        private void buscarId_Click(object sender, EventArgs e)
        {
            dgvPedido.DataSource = _vendaControl.BuscarLista(txtBuscarNome.Text);

            if(txtBuscarNome.Text == "%") 
            {
                dgvPedido.DataSource = _vendaControl.ListarPedidos();
                txtBuscarNome.Text = "";
            }
        }

        private void dgvPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = SelecionarVendaModel();
            var venda = _vendaControl.Buscar(id);
            venda.Produtos = _vendaControl.BuscarProdutosDaVenda(id);

            AlterarVenda alterarVenda = new AlterarVenda(venda);
            alterarVenda.DadosDaVenda();
            alterarVenda.ShowDialog();
        }

        public int SelecionarVendaModel() 
        {
            var id = Convert.ToInt32(dgvPedido.SelectedRows[0].Cells[0].Value);
            return id;
        }
    }
}
