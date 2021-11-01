using System;
using System.Windows.Forms;
using Augustus_Fashion.Model;
using Augustus_Fashion.Controller;

namespace Augustus_Fashion.View
{
    public partial class ListarFuncionario : Form
    {
        FuncionarioModel funcmodel = new FuncionarioModel();
        FuncionarioControl funccontrol = new FuncionarioControl();
        public ListarFuncionario()
        {
            InitializeComponent();
        }

        private void ListarFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'crudDataSet1.funcionario'. Você pode movê-la ou removê-la conforme necessário.
            //this.funcionarioTableAdapter.Fill(this.crudDataSet2.funcionario);
            dgvFuncionario.DataSource = funccontrol.ListarFuncionarios();

        }

        private void ListarFuncionario_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'crudDataSet2.funcionario'. Você pode movê-la ou removê-la conforme necessário.
            //this.funcionarioTableAdapter.Fill(this.crudDataSet2.funcionario);
            dgvFuncionario.DataSource = funccontrol.ListarFuncionarios();

        }

        private void buscarNome_Click_1(object sender, EventArgs e)
        {
            dgvFuncionario.DataSource = funccontrol.BuscarLista(textBox1.Text);

            if (textBox1.Text == "%")
            {
                dgvFuncionario.DataSource = funccontrol.ListarFuncionarios();
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AlterarFuncionario af = new AlterarFuncionario();
            af.Show();
            var id = SelecionarFuncModel();
            var cliente = funccontrol.Buscar(id);
            af.dadosDe(cliente);
            af.Show();
        }

        public int SelecionarFuncModel()
        {
            int id = Convert.ToInt32(dgvFuncionario.SelectedRows[0].Cells[0].Value);
            return id;
        }
    }
}
