using Augustus_Fashion.Controller;
using Augustus_Fashion.InstanciarTela;
using System;
using System.Windows.Forms;

namespace Augustus_Fashion.View
{
    public partial class ListarFuncionario : Form
    {
        FuncionarioControl _funcionariocontrol = new FuncionarioControl();

        public ListarFuncionario() => InitializeComponent();

        private void ListarFuncionario_Load(object sender, EventArgs e) =>
            dgvFuncionario.DataSource = _funcionariocontrol.ListarFuncionarios();

        private void buscarNome_Click_1(object sender, EventArgs e)
        {
            dgvFuncionario.DataSource = _funcionariocontrol.BuscarLista(textBox1.Text);

            if (textBox1.Text == "%")
            {
                dgvFuncionario.DataSource = _funcionariocontrol.ListarFuncionarios();
                textBox1.Text = "";
            }
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Instanciar.TelaInicial();
            Close();
        }

        private void FecharToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        public int SelecionarFuncionarioModel()
        {
            int id = Convert.ToInt32(dgvFuncionario.SelectedRows[0].Cells[0].Value);
            return id;
        }

        private void dgvFuncionario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AlterarFuncionario alterarFuncionario = new AlterarFuncionario();
            var id = SelecionarFuncionarioModel();
            var cliente = _funcionariocontrol.Buscar(id);
            alterarFuncionario.dadosDe(cliente);
            alterarFuncionario.Show();
        }
    }
}