using System;
using System.Windows.Forms;
using Augustus_Fashion.Model;
using Augustus_Fashion.Controller;

namespace Augustus_Fashion.View
{
    public partial class ListarFuncionario : Form
    {
        FuncionarioModel _funcmodel = new FuncionarioModel();
        FuncionarioControl _funcionariocontrol = new FuncionarioControl();
        public ListarFuncionario()
        {
            InitializeComponent();
        }

        private void ListarFuncionario_Load(object sender, EventArgs e)
        {
            dgvFuncionario.DataSource = _funcionariocontrol.ListarFuncionarios();

        }

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
            telaInicial ti = new telaInicial();
            ti.ShowDialog();
            this.Close();
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            cadastroCliente cc = new cadastroCliente();
            cc.ShowDialog();
            this.Close();
        }

        private void fUNCIONÁRIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            CadastroFuncionario cf = new CadastroFuncionario();
            cf.ShowDialog();
            this.Close();
        }

        private void cLIENTESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            ListarCliente lc = new ListarCliente();
            lc.ShowDialog();
            this.Close();
        }

        private void FecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fUNCIONÁRIOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            AlterarCliente ac = new AlterarCliente();
            ac.ShowDialog();
            this.Close();
        }

        private void fUNCIONÁRIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            AlterarFuncionario af = new AlterarFuncionario();
            af.ShowDialog();
            this.Close();
        }

        public int SelecionarFuncionarioModel()
        {
            int id = Convert.ToInt32(dgvFuncionario.SelectedRows[0].Cells[0].Value);
            return id;
        }

        private void dgvFuncionario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AlterarFuncionario af = new AlterarFuncionario();
            var id = SelecionarFuncionarioModel();
            var cliente = _funcionariocontrol.Buscar(id);
            af.dadosDe(cliente);
            af.Show();
        }

        private void dgvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
