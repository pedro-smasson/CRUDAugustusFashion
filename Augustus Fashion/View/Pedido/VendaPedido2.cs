using Augustus_Fashion.Controller;
using Augustus_Fashion.MensagemGlobal;
using Augustus_Fashion.Model;
using Augustus_Fashion.Model.Venda;
using System;
using System.Windows.Forms;

namespace Augustus_Fashion.View.Pedido
{
    public partial class VendaPedido2 : Form
    {
        ClienteControl _clientecontrol = new ClienteControl();
        PedidoModel _pedido = new PedidoModel();
        MensagemAlerta _mensagemAlerta = new MensagemAlerta();

        public VendaPedido2(int idFuncionario)
        {
            InitializeComponent();
            _pedido.IdFuncionario = idFuncionario;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void VendaPedido2_Load(object sender, EventArgs e)
        {
            dgvCliente.DataSource = _clientecontrol.ListarClientes();
            dgvCliente.Columns["Endereco"].Visible = false;
            dgvCliente.Columns["Limite"].Visible = false;
            dgvCliente.Columns["LimiteGasto"].Visible = false;
            btnAvancar.Enabled = false;
        }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var nome = dgvCliente.SelectedRows[0].Cells[1].Value;
            txtSelecionado.Text = nome.ToString();

            _pedido.IdCliente = (int)dgvCliente.SelectedRows[0].Cells[0].Value;
            _pedido.Limite = (decimal)dgvCliente.SelectedRows[0].Cells[5].Value;
            _pedido.LimiteGasto = (decimal)dgvCliente.SelectedRows[0].Cells[6].Value;
            btnAvancar.Enabled = true;
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            if (txtSelecionado.Text == "")
            {
                _mensagemAlerta.Mensagem("Selecione o Cliente!");
            }
            Hide();
            VendaPedido3 telaVenda3 = new VendaPedido3(_pedido);
            telaVenda3.ShowDialog();
            Show();
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            dgvCliente.DataSource = _clientecontrol.BuscarLista(txtCliente.Text);

            if (txtCliente.Text == "%")
            {
                dgvCliente.DataSource = _clientecontrol.ListarClientes();
                txtCliente.Text = "";
            }
        }
    }
}