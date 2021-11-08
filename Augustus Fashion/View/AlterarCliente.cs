using Augustus_Fashion.Controller;
using Augustus_Fashion.Model;
using System;
using System.Windows.Forms;

namespace Augustus_Fashion.View
{
    public partial class AlterarCliente : Form
    {
        ClienteModel _clientemodel = new ClienteModel();
        ClienteControl _clientecontrol = new ClienteControl();

        public AlterarCliente()
        {
            InitializeComponent();
        }

        public void dadosDe(ClienteModel cliente)
        {
            idCliente.Text = cliente.IdPessoa.ToString();
            nomeCliente.Text = cliente.Nome;
            emailCliente.Text = cliente.Email;
            datanascCliente.Text = cliente.Nascimento.ToString();
            cpfCliente.Text = cliente.Cpf.ToString();
            ruaCliente.Text = cliente.Endereco.Rua;
            bairroCliente.Text = cliente.Endereco.Bairro;
            cepCliente.Text = cliente.Endereco.Cep;
            numeroCliente.Text = cliente.Endereco.Numero;
            celularCliente.Text = cliente.Celular;
            cidadeCliente.Text = cliente.Endereco.Cidade;
            estadoCliente.Text = cliente.Endereco.Estado;
            complementoCliente.Text = cliente.Endereco.Complemento;
            valorLimiteCliente.Text = cliente.Limite;

            if (cliente.Sexo == "M")
                sexoMascCliente.Checked = true;
            else if (cliente.Sexo == "F")
                sexoFemCliente.Checked = true;
            else if (cliente.Sexo == "O")
                sexOtherCliente.Checked = true;

            _clientemodel = cliente;

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (Validar()) 
            {
                _clientemodel.Nome = nomeCliente.Text;
                _clientemodel.Email = emailCliente.Text;
                _clientemodel.Nascimento = Convert.ToDateTime(datanascCliente.Text);
                _clientemodel.Cpf = cpfCliente.Text;
                _clientemodel.Endereco.Rua = ruaCliente.Text;
                _clientemodel.Endereco.Bairro = bairroCliente.Text;
                _clientemodel.Endereco.Cep = cepCliente.Text;
                _clientemodel.Endereco.Numero = numeroCliente.Text;
                _clientemodel.Endereco.Cidade = cidadeCliente.Text;
                _clientemodel.Endereco.Estado = estadoCliente.Text;
                _clientemodel.Endereco.Complemento = complementoCliente.Text;
                _clientemodel.Celular = celularCliente.Text;
                _clientemodel.Limite = valorLimiteCliente.Text;

                if (sexoMascCliente.Checked == true)
                    _clientemodel.Sexo = "M";
                else if (sexoFemCliente.Checked == true)
                    _clientemodel.Sexo = "F";
                else if (sexOtherCliente.Checked == true)
                    _clientemodel.Sexo = "O";

                _clientecontrol.AlterarCliente(_clientemodel);

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
                _clientecontrol.ExcluirCliente(_clientemodel);

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

        private bool ValidarSexo() 
        {
            if(sexoMascCliente.Checked == true) 
            {
                return true;
            }
            else if(sexoFemCliente.Checked == true) 
            {
                return true;
            }
            else if(sexOtherCliente.Checked == true) 
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        private bool Validar()
        {

            if (!Testes.ValidarString(nomeCliente.Text))
            {
                MessageBox.Show("Nome inválido");
                return false;
            }

            else if (!Testes.ValidarEmail(emailCliente.Text))
            {
                MessageBox.Show("Email inválido");
                return false;
            }

            else if (!Testes.ValidarDataNasc(datanascCliente.Text))
            {
                MessageBox.Show("Data de Nascimento inválida");
                return false;
            }

            else if (!Testes.ValidarCpf(cpfCliente.Text))
            {
                MessageBox.Show("CPF inválido");
                return false;
            }

            else if (!ValidarSexo())
            {
                MessageBox.Show("Sexo inválido");
                return false;
            }

            else if (!Testes.ValidarStringENumeric(ruaCliente.Text))
            {
                MessageBox.Show("Rua inválida");
                return false;
            }

            else if (!Testes.ValidarString(bairroCliente.Text))
            {
                MessageBox.Show("Bairro inválido");
                return false;
            }

            else if (!Testes.ValidarCep(cepCliente.Text))
            {
                MessageBox.Show("CEP inválido");
                return false;
            }

            else if (!Testes.ValidarNumeric(numeroCliente.Text))
            {
                MessageBox.Show("Número inválido");
                return false;
            }

            else if (!Testes.ValidarCelular(celularCliente.Text))
            {
                MessageBox.Show("Celular inválido");
                return false;
            }

            else if (!Testes.ValidarString(cidadeCliente.Text))
            {
                MessageBox.Show("Cidade inválida");
                return false;
            }

            else if (string.IsNullOrEmpty(estadoCliente.Text))
            {
                MessageBox.Show("Estado inválido");
                return false;
            }

            else if (!Testes.ValidarNumeric(valorLimiteCliente.Text))
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
