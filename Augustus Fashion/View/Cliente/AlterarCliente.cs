using Augustus_Fashion.Controller;
using Augustus_Fashion.Model;
using Augustus_Fashion.MensagemGlobal;
using System;
using System.Windows.Forms;
using Augustus_Fashion.InstanciarTela;

namespace Augustus_Fashion.View
{
    public partial class AlterarCliente : Form
    {
        ClienteModel _clientemodel = new ClienteModel();
        ClienteControl _clientecontrol = new ClienteControl();
        MensagemErro _mensagemErro = new MensagemErro();
        MensagemInfo _mensagemInfo = new MensagemInfo();

        public AlterarCliente() => InitializeComponent();

        public void DadosDoCliente(ClienteModel cliente)
        {
            idCliente.Text = cliente.IdPessoa.ToString();
            nomeCliente.Text = cliente.Nome;
            ruaCliente.Text = cliente.Endereco.Rua;
            bairroCliente.Text = cliente.Endereco.Bairro;
            numeroCliente.Text = cliente.Endereco.Numero;
            celularCliente.Text = cliente.Celular;
            cidadeCliente.Text = cliente.Endereco.Cidade;
            estadoCliente.Text = cliente.Endereco.Estado;
            emailCliente.Text = cliente.Email;
            complementoCliente.Text = cliente.Endereco.Complemento;
            cpfCliente.Text = cliente.Cpf.ToString();
            cepCliente.Text = cliente.Endereco.Cep.ToString();
            valorLimiteCliente.Text = cliente.Limite.ToString();
            datanascCliente.Text = cliente.Nascimento.ToString();

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
                PreencherCamposDaModelCliente(_clientemodel);
                try
                {
                    _clientecontrol.AlterarCliente(_clientemodel);
                    _mensagemInfo.Mensagem("Cliente Alterado com Sucesso!");

                    Hide();
                    ListarCliente listarCliente = new ListarCliente();
                    listarCliente.ShowDialog();
                    Close();
                }
                catch
                {
                    _mensagemErro.Mensagem("Falha na Alteração!");
                }
            }
        }

        private void PreencherCamposDaModelCliente(ClienteModel clientemodel)
        {
            _clientemodel.Nome = nomeCliente.Text;
            _clientemodel.Email = emailCliente.Text;
            _clientemodel.Cpf = cpfCliente.Text;
            _clientemodel.Endereco.Rua = ruaCliente.Text;
            _clientemodel.Endereco.Bairro = bairroCliente.Text;
            _clientemodel.Endereco.Cep = cepCliente.Text;
            _clientemodel.Endereco.Numero = numeroCliente.Text;
            _clientemodel.Endereco.Cidade = cidadeCliente.Text;
            _clientemodel.Endereco.Estado = estadoCliente.Text;
            _clientemodel.Endereco.Complemento = complementoCliente.Text;
            _clientemodel.Celular = celularCliente.Text;
            _clientemodel.Nascimento = Convert.ToDateTime(datanascCliente.Text);
            _clientemodel.Limite = Convert.ToDecimal(valorLimiteCliente.Text);

            if (sexoMascCliente.Checked == true)
                _clientemodel.Sexo = "M";
            else if (sexoFemCliente.Checked == true)
                _clientemodel.Sexo = "F";
            else if (sexOtherCliente.Checked == true)
                _clientemodel.Sexo = "O";
        }

        public void ExcluirCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    _clientecontrol.ExcluirCliente(_clientemodel);
                    _mensagemInfo.Mensagem("Cliente deletado com sucesso!");

                    Hide();
                    ListarCliente listarCliente = new ListarCliente();
                    listarCliente.ShowDialog();
                    Close();
                }
            }
            catch
            {
                _mensagemErro.Mensagem("O cliente está vinculado a uma compra, impossível excluir!");
            }
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Instanciar.TelaInicial();
            Close();
        }

        private void FecharToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        private void AlterarCliente_Load(object sender, EventArgs e) => btnAlterar.Enabled = true;

        private bool ValidarSexo()
        {
            if (sexoMascCliente.Checked == true || sexoFemCliente.Checked == true || sexOtherCliente.Checked == true)
                return true;

            return false;
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
            return true;
        }

        private void btnVoltar_Click(object sender, EventArgs e) => DialogResult = DialogResult.OK;
    }
}