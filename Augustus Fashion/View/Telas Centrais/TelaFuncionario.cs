using Augustus_Fashion.InstanciarTela;
using System;
using System.Windows.Forms;

namespace Augustus_Fashion.View.Telas_Centrais
{
    public partial class TelaFuncionario : Form
    {
        public TelaFuncionario() => InitializeComponent();

        private void pctCadastro_Click(object sender, EventArgs e)
        {
            Hide();
            CadastroFuncionario cadastrarFuncionario = new CadastroFuncionario();
            cadastrarFuncionario.ShowDialog();
            Close();
        }

        private void pctLista_Click(object sender, EventArgs e)
        {
            Hide();
            ListarFuncionario listarFuncionario = new ListarFuncionario();
            listarFuncionario.ShowDialog();
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