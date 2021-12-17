using Augustus_Fashion.Controller;
using Augustus_Fashion.InstanciarTela;
using Augustus_Fashion.MensagemGlobal;
using Augustus_Fashion.Model.Venda;
using System;
using System.Windows.Forms;

namespace Augustus_Fashion.View.Pedido
{
    public partial class VendaPedido : Form
    {
        FuncionarioControl _funcionariocontrol = new FuncionarioControl();
        MensagemErro _mensagemErro = new MensagemErro();

        PedidoModel _pedidoModel = new PedidoModel();

        public VendaPedido()
        {
            InitializeComponent();
        }

        public int SelecionarFuncionarioModel()
        {
            int id = Convert.ToInt32(dgvFuncionario.SelectedRows[0].Cells[1].Value);
            return id;
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            dgvFuncionario.DataSource = _funcionariocontrol.BuscarLista(txtFuncionario.Text);

            if (txtFuncionario.Text == "%")
            {
                dgvFuncionario.DataSource = _funcionariocontrol.ListarFuncionarios();
                txtFuncionario.Text = "";
            }
        }

        private void VendaPedido_Load(object sender, EventArgs e)
        {
            dgvFuncionario.DataSource = _funcionariocontrol.ListarFuncionarios();
            this.dgvFuncionario.Columns["Endereco"].Visible = false;
            btnAvancar.Enabled = false;
        }

        private void dgvFuncionario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var nome = dgvFuncionario.SelectedRows[0].Cells[1].Value;
            txtSelecionado.Text = nome.ToString();

            _pedidoModel.IdFuncionario = (int)dgvFuncionario.SelectedRows[0].Cells[0].Value;
            btnAvancar.Enabled = true;
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            if (txtSelecionado.Text == "")
            {
                _mensagemErro.Mensagem("Selecione o Funcionário");
            }
            this.Hide();
            VendaPedido2 telaVenda2 = new VendaPedido2(_pedidoModel.IdFuncionario);
            telaVenda2.ShowDialog();
            this.Show();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Instanciar.TelaInicial();
            Close();
        }

        private void fECHARToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();
    }
}