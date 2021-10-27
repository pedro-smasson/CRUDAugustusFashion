using System;
using Augustus_Fashion.Controller;
using Augustus_Fashion.Model;
using System.Windows.Forms;

namespace Augustus_Fashion.View
{

    public partial class ExcluirCliente : Form
    {
        ClienteModel clientemodel = new ClienteModel();
        ClienteControl clientecontrol = new ClienteControl();

        public ExcluirCliente()
        {
            InitializeComponent();
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

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            AlterarCliente ac = new AlterarCliente();
            ac.ShowDialog();
            this.Close();
        }

        private void FecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buscarCliente_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(idCliente.Text))
            {
                clientemodel = clientecontrol.Buscar(Int32.Parse(idCliente.Text));
                btnExcluir.Enabled = true;
            }

            if (clientemodel != null)
            {
                nomeCliente.Text = clientemodel.nome;
                emailCliente.Text = clientemodel.email;
                datanascCliente.Text = clientemodel.nascimento.ToString("dd/MM/yyyy");
                cpfCliente.Text = clientemodel.cpf;
                ruaCliente.Text = clientemodel.rua;
                bairroCliente.Text = clientemodel.bairro;
                cepCliente.Text = clientemodel.cep;
                numeroCliente.Text = clientemodel.numero;
                cidadeCliente.Text = clientemodel.cidade;
                estadoCliente.Text = clientemodel.estado;
                complementoCliente.Text = clientemodel.complemento;
                celularCliente.Text = clientemodel.celular;
                valorLimiteCliente.Text = clientemodel.limite;

                if (clientemodel.sexo == "M")
                    sexoMascCliente.Checked = true;

                else if (clientemodel.sexo == "F")
                    sexoFemCliente.Checked = true;

                else if (clientemodel.sexo == "O")
                    sexOtherCliente.Checked = true;

            }
            else
            {
                MessageBox.Show("ID não cadastrado!");
            }
        }
    

        private void btnExcluir_Click(object sender, EventArgs e)
        {
                clientecontrol.ExcluirCliente(clientemodel);

            nomeCliente.Text = "";
            emailCliente.Text = "";
            datanascCliente.Text = "";
            cpfCliente.Text = "";
            ruaCliente.Text = "";
            bairroCliente.Text = "";
            cepCliente.Text = "";
            numeroCliente.Text = "";
            celularCliente.Text = "";
            cidadeCliente.Text = "";
            estadoCliente.Text = "";
            complementoCliente.Text = "";
            valorLimiteCliente.Text = "";
            sexoMascCliente.Checked = false;
            sexoFemCliente.Checked = false;
            sexOtherCliente.Checked = false;
            idCliente.Text = "";
        }

        private void cLIENTESToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void ExcluirCliente_Load(object sender, EventArgs e)
        {
            btnExcluir.Enabled = false;
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

        private void fUNCIONÁRIOSToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Hide();
            ExcluirFuncionario ef = new ExcluirFuncionario();
            ef.ShowDialog();
            Close();
        }
    }
}
