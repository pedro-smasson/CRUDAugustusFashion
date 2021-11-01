using System;
using System.Windows.Forms;
using Augustus_Fashion.Model;
using Augustus_Fashion.Controller;
using Augustus_Fashion.View;

namespace Augustus_Fashion.View
{
    public partial class ListarCliente : Form
    {
        ClienteModel clientemodel = new ClienteModel();
        ClienteControl clientecontrol = new ClienteControl();

        public ListarCliente()
        {
            InitializeComponent();
        }

        private void ListarCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'crudDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            //this.clienteTableAdapter.Fill(this.crudDataSet.cliente);
            dataGridView1.DataSource = clientecontrol.ListarClientes();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clientecontrol.BuscarLista(textBox1.Text);

            if(textBox1.Text == "%")
            {
                dataGridView1.DataSource = clientecontrol.ListarClientes();
                textBox1.Text = "";
            }
        }

        private void FecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void fUNCIONÁRIOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            ListarFuncionario lf = new ListarFuncionario();
            lf.ShowDialog();
            this.Close();
        }

        public int SelecionarClienteModel()
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            return id;
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            AlterarCliente ac = new AlterarCliente();
            ac.Show();
            var id = SelecionarClienteModel();
            var cliente = clientecontrol.Buscar(id);           
            ac.dadosDe(cliente);
            ac.Show();
            
        }

    }
}
