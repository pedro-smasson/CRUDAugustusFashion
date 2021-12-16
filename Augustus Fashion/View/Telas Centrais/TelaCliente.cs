using System;
using System.Windows.Forms;
using Augustus_Fashion.InstanciarTela;

namespace Augustus_Fashion.View.Telas_Centrais
{
    public partial class TelaCliente : Form
    {
        public TelaCliente() => InitializeComponent();

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

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Instanciar.TelaInicial();
            Close();
        }

        private void fECHARToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();
    }
}