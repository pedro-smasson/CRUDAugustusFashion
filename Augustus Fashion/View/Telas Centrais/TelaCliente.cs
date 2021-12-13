using System;
using System.Windows.Forms;

namespace Augustus_Fashion.View.Telas_Centrais
{
    public partial class TelaCliente : Form
    {
        public TelaCliente()
        {
            InitializeComponent();
        }

        private void pctCadastro_Click(object sender, EventArgs e)
        {
            Hide();
            cadastroCliente cadastroCliente = new cadastroCliente();
            cadastroCliente.ShowDialog();
            Close();
        }

        private void pctLista_Click(object sender, EventArgs e)
        {
            Hide();
            ListarCliente listarCliente = new ListarCliente();
            listarCliente.ShowDialog();
            Close();
        }
    }
}