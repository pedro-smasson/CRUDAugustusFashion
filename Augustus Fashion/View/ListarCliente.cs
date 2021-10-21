using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Augustus_Fashion.Model;
using Augustus_Fashion.Controller;

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
            this.clienteTableAdapter.Fill(this.crudDataSet.cliente);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clientecontrol.BuscarLista(textBox1.Text);
        }
    }
}
