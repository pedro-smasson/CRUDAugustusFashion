using Augustus_Fashion.Controller;
using Augustus_Fashion.MensagemGlobal;
using Augustus_Fashion.Model;
using System;
using System.Windows.Forms;

namespace Augustus_Fashion.View
{
    public partial class AlterarFuncionario : Form
    {
        FuncionarioModel _funcionariomodel = new FuncionarioModel();
        FuncionarioControl _funcionariocontrol = new FuncionarioControl();
        MensagemErro _mensagemErro = new MensagemErro();
        MensagemInfo _mensagemInfo = new MensagemInfo();

        public AlterarFuncionario()
        {
            InitializeComponent();
        }

        public void dadosDe(FuncionarioModel funcionarioModel)
        {
            idFuncionario.Text = funcionarioModel.IdPessoa.ToString();
            nomeFuncionario.Text = funcionarioModel.Nome;
            emailFuncionario.Text = funcionarioModel.Email;
            datanascFuncionario.Text = funcionarioModel.Nascimento.ToString();
            cpfFuncionario.Text = funcionarioModel.Cpf.ToString();
            ruaFuncionario.Text = funcionarioModel.Endereco.Rua;
            bairroFuncionario.Text = funcionarioModel.Endereco.Bairro;
            cepFuncionario.Text = funcionarioModel.Endereco.Cep.ToString();
            numeroFuncionario.Text = funcionarioModel.Endereco.Numero;
            celularFuncionario.Text = funcionarioModel.Celular;
            cidadeFuncionario.Text = funcionarioModel.Endereco.Cidade;
            estadoFuncionario.Text = funcionarioModel.Endereco.Estado;
            complementoFuncionario.Text = funcionarioModel.Endereco.Complemento;
            salarioFuncionario.Text = funcionarioModel.Salario;
            comissaoFuncionario.Text = funcionarioModel.Comissao;
            agenciaFuncionario.Text = funcionarioModel.Agencia;
            numContaFuncionario.Text = funcionarioModel.NumConta;
            codContaFuncionario.Text = funcionarioModel.CodConta;

            if (funcionarioModel.Sexo == "M")
                sexoMascFuncionario.Checked = true;
            else if (funcionarioModel.Sexo == "F")
                sexoFemFuncionario.Checked = true;
            else if (funcionarioModel.Sexo == "O")
                sexOtherFuncionario.Checked = true;

            _funcionariomodel = funcionarioModel;
        }

        private void AlterarFuncionario_Load(object sender, EventArgs e)
        {
            btnAlterar.Enabled = true;
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                _funcionariocontrol.ExcluirFuncionario(_funcionariomodel);
                _mensagemInfo.Mensagem("Funcionário deletado com sucesso!");

                Hide();
                ListarFuncionario listarFuncionario = new ListarFuncionario();
                listarFuncionario.ShowDialog();
                this.Close();
            }
            catch
            {
                _mensagemErro.Mensagem("Falha na Exclusão");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            if (Validar())
            {
                _funcionariomodel.Nome = nomeFuncionario.Text;
                _funcionariomodel.Email = emailFuncionario.Text;
                _funcionariomodel.Nascimento = Convert.ToDateTime(datanascFuncionario.Text);
                _funcionariomodel.Cpf = cpfFuncionario.Text;
                _funcionariomodel.Endereco.Rua = ruaFuncionario.Text;
                _funcionariomodel.Endereco.Bairro = bairroFuncionario.Text;
                _funcionariomodel.Endereco.Cep = cepFuncionario.Text;
                _funcionariomodel.Endereco.Numero = numeroFuncionario.Text;
                _funcionariomodel.Endereco.Cidade = cidadeFuncionario.Text;
                _funcionariomodel.Endereco.Estado = estadoFuncionario.Text;
                _funcionariomodel.Endereco.Complemento = complementoFuncionario.Text;
                _funcionariomodel.Celular = celularFuncionario.Text;
                _funcionariomodel.Salario = salarioFuncionario.Text;
                _funcionariomodel.Agencia = agenciaFuncionario.Text;
                _funcionariomodel.Comissao = comissaoFuncionario.Text;
                _funcionariomodel.CodConta = codContaFuncionario.Text;
                _funcionariomodel.NumConta = numContaFuncionario.Text;

                if (sexoMascFuncionario.Checked == true)
                    _funcionariomodel.Sexo = "M";
                else if (sexoFemFuncionario.Checked == true)
                    _funcionariomodel.Sexo = "F";
                else if (sexOtherFuncionario.Checked == true)
                    _funcionariomodel.Sexo = "O";
                try
                {
                    _funcionariocontrol.AlterarFuncionario(_funcionariomodel);
                    _mensagemInfo.Mensagem("Funcionário Alterado com Sucesso!");

                    Hide();
                    ListarFuncionario lc = new ListarFuncionario();
                    lc.ShowDialog();
                    this.Close();
                }
                catch
                {
                    _mensagemErro.Mensagem("Erro no Banco de Dados!");
                }
            }
            else
            {
                _mensagemErro.Mensagem("Corrija os Campos Incorretos!");
            }

        }
        private bool Validar()
        {

            if (string.IsNullOrEmpty(nomeFuncionario.Text))
            {
                _mensagemErro.Mensagem("Nome inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(emailFuncionario.Text))
            {
                _mensagemErro.Mensagem("Email inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(datanascFuncionario.Text))
            {
                _mensagemErro.Mensagem("Data de Nascimento inválida");
                return false;
            }
            else if (string.IsNullOrEmpty(cpfFuncionario.Text))
            {
                _mensagemErro.Mensagem("CPF inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(sexoFuncionario.Text))
            {
                _mensagemErro.Mensagem("Sexo inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(ruaFuncionario.Text))
            {
                _mensagemErro.Mensagem("Rua inválida");
                return false;
            }
            else if (string.IsNullOrEmpty(bairroFuncionario.Text))
            {
                _mensagemErro.Mensagem("Bairro inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(cepFuncionario.Text))
            {
                _mensagemErro.Mensagem("CEP inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(numeroFuncionario.Text))
            {
                _mensagemErro.Mensagem("Número inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(celularFuncionario.Text))
            {
                _mensagemErro.Mensagem("Celular inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(cidadeFuncionario.Text))
            {
                _mensagemErro.Mensagem("Cidade inválida");
                return false;
            }
            else if (string.IsNullOrEmpty(estadoFuncionario.Text))
            {
                _mensagemErro.Mensagem("Estado inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(salarioFuncionario.Text))
            {
                _mensagemErro.Mensagem("Salário inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(comissaoFuncionario.Text))
            {
                _mensagemErro.Mensagem("Comissão inválida");
                return false;
            }
            else if (string.IsNullOrEmpty(agenciaFuncionario.Text))
            {
                _mensagemErro.Mensagem("Agência inválida");
                return false;
            }
            else if (string.IsNullOrEmpty(numContaFuncionario.Text))
            {
                _mensagemErro.Mensagem("Número da Conta inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(codContaFuncionario.Text))
            {
                _mensagemErro.Mensagem("Código da Conta inválido");
                return false;
            }
            return true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}