using Augustus_Fashion.Controller;
using Augustus_Fashion.InstanciarTela;
using System;
using System.Windows.Forms;

namespace Augustus_Fashion.View
{
    public partial class ListarCliente : Form
    {
        ClienteControl _clientecontrol = new ClienteControl();

        public ListarCliente() => InitializeComponent();

        private void ListarCliente_Load(object sender, EventArgs e) => dgvCliente.DataSource = _clientecontrol.ListarClientes();

        private void button1_Click(object sender, EventArgs e)
        {
            dgvCliente.DataSource = _clientecontrol.BuscarLista(textBox1.Text);

            if (textBox1.Text == "%")
            {
                dgvCliente.DataSource = _clientecontrol.ListarClientes();
                textBox1.Text = "";
            }
        }

        private void FecharToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Instanciar.TelaInicial();
            Close();
        }

        public int SelecionarClienteModel()
        {
            int id = Convert.ToInt32(dgvCliente.SelectedRows[0].Cells[0].Value);
            return id;
        }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AlterarCliente alterarCliente = new AlterarCliente();
            var id = SelecionarClienteModel();
            var cliente = _clientecontrol.Buscar(id);
            alterarCliente.DadosDoCliente(cliente);
            alterarCliente.ShowDialog();
        }
    }
}