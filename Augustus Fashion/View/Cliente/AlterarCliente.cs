using Augustus_Fashion.Controller;
using Augustus_Fashion.Model;
using Augustus_Fashion.MensagemGlobal;
using System;
using System.Windows.Forms;

namespace Augustus_Fashion.View
{
    public partial class AlterarCliente : Form
    {
        ClienteModel _clientemodel = new ClienteModel();
        ClienteControl _clientecontrol = new ClienteControl();
        MensagemErro _mensagemErro = new MensagemErro();
        MensagemInfo _mensagemInfo = new MensagemInfo();

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
            cepCliente.Text = cliente.Endereco.Cep.ToString();
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

                try
                {
                    new ClienteControl().AlterarCliente(_clientemodel);
                    _mensagemInfo.Mensagem("Cliente Alterado com Sucesso!");

                }
                catch 
                {
                    _mensagemErro.Mensagem("Falha na Alteração!");
                }

                Hide();
                ListarCliente listarCliente = new ListarCliente();
                listarCliente.ShowDialog();
                this.Close();
            }
        }

        public void ExcluirCliente_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                _clientecontrol.ExcluirCliente(_clientemodel);
                _mensagemInfo.Mensagem("Cliente deletado com sucesso!");

                Hide();
                ListarCliente listarCliente = new ListarCliente();
                listarCliente.ShowDialog();
                this.Close();
            }

            else
            {
                _mensagemErro.Mensagem("Falha na Exclusão");
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

        private void AlterarCliente_Load(object sender, EventArgs e)
        {
            btnAlterar.Enabled = true;
        }

        private bool ValidarSexo()
        {
            if (sexoMascCliente.Checked == true)
            {
                return true;
            }
            else if (sexoFemCliente.Checked == true)
            {
                return true;
            }
            else if (sexOtherCliente.Checked == true)
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

            if (!Validacoes.ValidarString(nomeCliente.Text))
            {
                _mensagemErro.Mensagem("Nome inválido");
                return false;
            }

            else if (!Validacoes.ValidarEmail(emailCliente.Text))
            {
                _mensagemErro.Mensagem("Email inválido");
                return false;
            }

            else if (!Validacoes.ValidarDatas(datanascCliente.Text))
            {
                _mensagemErro.Mensagem("Data de Nascimento inválida");
                return false;
            }

            else if (!Validacoes.ValidarCpf(cpfCliente.Text))
            {
                _mensagemErro.Mensagem("CPF inválido");
                return false;
            }

            else if (!ValidarSexo())
            {
                _mensagemErro.Mensagem("Sexo inválido");
                return false;
            }

            else if (!Validacoes.ValidarStringENumeric(ruaCliente.Text))
            {
                _mensagemErro.Mensagem("Rua inválida");
                return false;
            }

            else if (!Validacoes.ValidarString(bairroCliente.Text))
            {
                _mensagemErro.Mensagem("Bairro inválido");
                return false;
            }

            else if (!Validacoes.ValidarCep(cepCliente.Text))
            {
                _mensagemErro.Mensagem("CEP inválido");
                return false;
            }

            else if (!Validacoes.ValidarNumeric(numeroCliente.Text))
            {
                _mensagemErro.Mensagem("Número inválido");
                return false;
            }

            else if (!Validacoes.ValidarCelular(celularCliente.Text))
            {
                _mensagemErro.Mensagem("Celular inválido");
                return false;
            }

            else if (!Validacoes.ValidarString(cidadeCliente.Text))
            {
                _mensagemErro.Mensagem("Cidade inválida");
                return false;
            }

            else if (string.IsNullOrEmpty(estadoCliente.Text))
            {
                _mensagemErro.Mensagem("Estado inválido");
                return false;
            }

            else if (!Validacoes.ValidarNumeric(valorLimiteCliente.Text))
            {
                _mensagemErro.Mensagem("Valor limite inválido");
                return false;
            }

            else
            {
                return true;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}