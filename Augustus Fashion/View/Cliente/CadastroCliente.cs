using Augustus_Fashion.Controller;
using Augustus_Fashion.InstanciarTela;
using Augustus_Fashion.MensagemGlobal;
using Augustus_Fashion.Model;
using System;
using System.Windows.Forms;

namespace Augustus_Fashion
{

    public partial class cadastroCliente : Form
    {
        ClienteModel _clientemodel = new ClienteModel();
        MensagemInfo _mensagemInfo = new MensagemInfo();
        MensagemErro _mensagemErro = new MensagemErro();

        public cadastroCliente() => InitializeComponent();

        private void btnLimpar_Click(object sender, EventArgs e) => Instanciar.LimparCampos(this);

        private void btnSalvar_Click(object sender, EventArgs e)
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
                _clientemodel.Limite = Convert.ToDecimal(valorLimiteCliente.Text);

                if (sexoMascCliente.Checked == true)
                    _clientemodel.Sexo = "M";
                else if (sexoFemCliente.Checked == true)
                    _clientemodel.Sexo = "F";
                else if (sexOtherCliente.Checked == true)
                    _clientemodel.Sexo = "O";

                try
                {
                    new ClienteControl().CadastrarCliente(_clientemodel);
                    _mensagemInfo.Mensagem("Cliente Cadastrado com Sucesso!");

                    Instanciar.LimparCampos(this);
                }
                catch
                {
                    _mensagemErro.Mensagem("Falha no Cadastro!");
                }
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
            else if (string.IsNullOrEmpty(valorLimiteCliente.Text)) 
            {
                _mensagemErro.Mensagem("Limite inválido!");
                return false;
            }
            return true;
        }

        private bool ValidarSexo()
        {
            if (sexoMascCliente.Checked == true || sexoFemCliente.Checked == true || sexOtherCliente.Checked == true)
                return true;

            return false;
        }

        private void FecharToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Instanciar.TelaInicial();
            Close();
        }

        private void valorLimiteCliente_KeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == ',');
    }
}