using Augustus_Fashion.Controller;
using Augustus_Fashion.MensagemGlobal;
using Augustus_Fashion.Model;
using System;
using System.Windows.Forms;

namespace Augustus_Fashion.View
{
    public partial class CadastroFuncionario : Form
    {
        FuncionarioModel _funcionarioModel = new FuncionarioModel();
        FuncionarioControl _funcionarioControl = new FuncionarioControl();
        MensagemErro _mensagemErro = new MensagemErro();
        MensagemInfo _mensagemInfo = new MensagemInfo();

        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void FecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Limpar()
        {
            nomeFuncionario.Text = "";
            emailFuncionario.Text = "";
            datanascFuncionario.Text = "";
            cpfFuncionario.Text = "";
            ruaFuncionario.Text = "";
            bairroFuncionario.Text = "";
            cepFuncionario.Text = "";
            numeroFuncionario.Text = "";
            celularFuncionario.Text = "";
            cidadeFuncionario.Text = "";
            estadoFuncionario.Text = "";
            complementoFuncionario.Text = "";
            salarioFuncionario.Text = "";
            comissaoFuncionario.Text = "";
            agenciaFuncionario.Text = "";
            numContaFuncionario.Text = "";
            codContaFuncionario.Text = "";
            sexoMascFuncionario.Checked = false;
            sexoFemFuncionario.Checked = false;
            sexOtherFuncionario.Checked = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try 
            {
                if (Validar())
                {
                    _funcionarioModel.Nome = nomeFuncionario.Text;
                    _funcionarioModel.Email = emailFuncionario.Text;
                    _funcionarioModel.Nascimento = Convert.ToDateTime(datanascFuncionario.Text);
                    _funcionarioModel.Cpf = cpfFuncionario.Text;
                    _funcionarioModel.Endereco.Rua = ruaFuncionario.Text;
                    _funcionarioModel.Endereco.Bairro = bairroFuncionario.Text;
                    _funcionarioModel.Endereco.Cep = cepFuncionario.Text;
                    _funcionarioModel.Endereco.Numero = numeroFuncionario.Text;
                    _funcionarioModel.Endereco.Cidade = cidadeFuncionario.Text;
                    _funcionarioModel.Endereco.Estado = estadoFuncionario.Text;
                    _funcionarioModel.Endereco.Complemento = complementoFuncionario.Text;
                    _funcionarioModel.Celular = celularFuncionario.Text;
                    _funcionarioModel.Salario = salarioFuncionario.Text;
                    _funcionarioModel.Agencia = agenciaFuncionario.Text;
                    _funcionarioModel.Comissao = comissaoFuncionario.Text;
                    _funcionarioModel.NumConta = numContaFuncionario.Text;
                    _funcionarioModel.CodConta = codContaFuncionario.Text;

                    if (sexoMascFuncionario.Checked == true)
                        _funcionarioModel.Sexo = "M";
                    else if (sexoFemFuncionario.Checked == true)
                        _funcionarioModel.Sexo = "F";
                    else
                        _funcionarioModel.Sexo = "O";

                    _funcionarioControl.CadastrarFuncionario(_funcionarioModel);
                    _mensagemInfo.Mensagem("Funcionário Cadastrado com Sucesso!");

                    Limpar();
                }
            }
            catch 
            {
                _mensagemErro.Mensagem("Falha no cadastro!");
            }
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            telaInicial telaInicial = new telaInicial();
            telaInicial.ShowDialog();
            this.Close();
        }

        private bool ValidarSexo()
        {
            return sexoMascFuncionario.Checked == true || sexoFemFuncionario.Checked == true || sexOtherFuncionario.Checked == true;
        }

        private bool Validar()
        {

            if (!Validacoes.ValidarString(nomeFuncionario.Text))
            {
                _mensagemErro.Mensagem("Nome inválido");
                return false;
            }

            else if (!Validacoes.ValidarEmail(emailFuncionario.Text))
            {
                _mensagemErro.Mensagem("Email inválido");
                return false;
            }

            else if (!Validacoes.ValidarDatas(datanascFuncionario.Text))
            {
                _mensagemErro.Mensagem("Data de Nascimento inválida");
                return false;
            }

            else if (!Validacoes.ValidarCpf(cpfFuncionario.Text))
            {
                _mensagemErro.Mensagem("CPF inválido");
                return false;
            }

            else if (!ValidarSexo())
            {
                _mensagemErro.Mensagem("Sexo inválido");
                return false;
            }

            else if (!Validacoes.ValidarStringENumeric(ruaFuncionario.Text))
            {
                _mensagemErro.Mensagem("Rua inválida");
                return false;
            }

            else if (!Validacoes.ValidarString(bairroFuncionario.Text))
            {
                _mensagemErro.Mensagem("Bairro inválido");
                return false;
            }

            else if (!Validacoes.ValidarCep(cepFuncionario.Text))
            {
                _mensagemErro.Mensagem("CEP inválido");
                return false;
            }

            else if (!Validacoes.ValidarNumeric(numeroFuncionario.Text))
            {
                _mensagemErro.Mensagem("Número inválido");
                return false;
            }

            else if (!Validacoes.ValidarCelular(celularFuncionario.Text))
            {
                _mensagemErro.Mensagem("Celular inválido");
                return false;
            }

            else if (!Validacoes.ValidarString(cidadeFuncionario.Text))
            {
                _mensagemErro.Mensagem("Cidade inválida");
                return false;
            }

            else if (string.IsNullOrEmpty(estadoFuncionario.Text))
            {
                _mensagemErro.Mensagem("Estado inválido");
                return false;
            }

            else if (!Validacoes.ValidarNumeric(salarioFuncionario.Text))
            {
                _mensagemErro.Mensagem("Salário inválido");
                return false;
            }

            else if (!Validacoes.ValidarPorcentagem(comissaoFuncionario.Text))
            {
                _mensagemErro.Mensagem("Comissão inválida");
                return false;
            }

            else if (!Validacoes.ValidarNumeric(agenciaFuncionario.Text))
            {
                _mensagemErro.Mensagem("Agência inválida");
                return false;
            }

            else if (!Validacoes.ValidarNumeric(numContaFuncionario.Text))
            {
                _mensagemErro.Mensagem("Número da Conta inválido");
                return false;
            }

            else if (!Validacoes.ValidarNumeric(codContaFuncionario.Text))
            {
                _mensagemErro.Mensagem("Código da Conta inválido");
                return false;
            }
            return true;
        }
    }
}