using Augustus_Fashion.Controller;
using Augustus_Fashion.Model;
using System;
using System.Windows.Forms;

namespace Augustus_Fashion.View
{
    public partial class AlterarCliente : Form
    {
        ClienteModel clientemodel = new ClienteModel();
        ClienteControl clientecontrol = new ClienteControl();

        public AlterarCliente()
        {
            InitializeComponent();
        }

        public void dadosDe(ClienteModel cliente)
        {
            idCliente.Text = cliente.id.ToString();
            nomeCliente.Text = cliente.nome;
            emailCliente.Text = cliente.email;
            datanascCliente.Text = cliente.nascimento.ToString();
            cpfCliente.Text = cliente.cpf;
            ruaCliente.Text = cliente.rua;
            bairroCliente.Text = cliente.bairro;
            cepCliente.Text = cliente.cep;
            numeroCliente.Text = cliente.numero;
            celularCliente.Text = cliente.celular;
            cidadeCliente.Text = cliente.cidade;
            estadoCliente.Text = cliente.estado;
            complementoCliente.Text = cliente.complemento;
            valorLimiteCliente.Text = cliente.limite;

            if (cliente.sexo == "M")
                sexoMascCliente.Checked = true;
            else if (cliente.sexo == "F")
                sexoFemCliente.Checked = true;
            else if (cliente.sexo == "O")
                sexOtherCliente.Checked = true;

            clientemodel = cliente;

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (Validar()) 
            {
                clientemodel.nome = nomeCliente.Text;
                clientemodel.email = emailCliente.Text;
                clientemodel.nascimento = Convert.ToDateTime(datanascCliente.Text);
                clientemodel.cpf = cpfCliente.Text;
                clientemodel.rua = ruaCliente.Text;
                clientemodel.bairro = bairroCliente.Text;
                clientemodel.cep = cepCliente.Text;
                clientemodel.numero = numeroCliente.Text;
                clientemodel.cidade = cidadeCliente.Text;
                clientemodel.estado = estadoCliente.Text;
                clientemodel.complemento = complementoCliente.Text;
                clientemodel.celular = celularCliente.Text;
                clientemodel.limite = valorLimiteCliente.Text;

                if (sexoMascCliente.Checked == true)
                    clientemodel.sexo = "M";
                else if (sexoFemCliente.Checked == true)
                    clientemodel.sexo = "F";
                else if (sexOtherCliente.Checked == true)
                    clientemodel.sexo = "O";

                clientecontrol.AlterarCliente(clientemodel);

                Hide();
                ListarCliente lc = new ListarCliente();
                lc.ShowDialog();
                this.Close();
            }

            else 
            {
                MessageBox.Show("Corrija os Campos Incorretos!");
            }
            
        }

        public void ExcluirCliente_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                clientecontrol.ExcluirCliente(clientemodel);

                Hide();
                ListarCliente lc = new ListarCliente();
                lc.ShowDialog();
                this.Close();
            }

            else 
            {
                MessageBox.Show("Falha na Exclusão");
            }

        }

            private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            telaInicial ti = new telaInicial();
            ti.ShowDialog();
            this.Close();
        }

        private void FecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void AlterarCliente_Load(object sender, EventArgs e)
        {
            btnAlterar.Enabled = true;
        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
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

        private bool Validar()
        {

            if (string.IsNullOrEmpty(nomeCliente.Text))
            {
                MessageBox.Show("Nome inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(emailCliente.Text))
            {
                MessageBox.Show("Email inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(datanascCliente.Text))
            {
                MessageBox.Show("Data de Nascimento inválida");
                return false;
            }
            else if (string.IsNullOrEmpty(cpfCliente.Text))
            {
                MessageBox.Show("CPF inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(sexoCliente.Text))
            {
                MessageBox.Show("Sexo inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(ruaCliente.Text))
            {
                MessageBox.Show("Rua inválida");
                return false;
            }
            else if (string.IsNullOrEmpty(bairroCliente.Text))
            {
                MessageBox.Show("Bairro inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(cepCliente.Text))
            {
                MessageBox.Show("CEP inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(numeroCliente.Text))
            {
                MessageBox.Show("Número inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(celularCliente.Text))
            {
                MessageBox.Show("Celular inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(cidadeCliente.Text))
            {
                MessageBox.Show("Cidade inválida");
                return false;
            }
            else if (string.IsNullOrEmpty(estadoCliente.Text))
            {
                MessageBox.Show("Estado inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(valorLimiteCliente.Text))
            {
                MessageBox.Show("Valor limite inválido");
                return false;
            }

            else
            {
                return true;
            }
        }
    }
}
