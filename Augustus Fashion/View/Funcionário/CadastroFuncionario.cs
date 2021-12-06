using Augustus_Fashion.Model;
using Augustus_Fashion.Controller;
using System;
using System.Windows.Forms;

namespace Augustus_Fashion.View
{
    public partial class CadastroFuncionario : Form
    {
        FuncionarioModel _funcmodel = new FuncionarioModel();
        FuncionarioControl _funccontrol = new FuncionarioControl();

        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void FecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fUNCIONÁRIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            cadastroCliente cc = new cadastroCliente();
            cc.ShowDialog();
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (Validar()) 
            {
                _funcmodel.Nome = nomeFuncionario.Text;
                _funcmodel.Email = emailFuncionario.Text;
                _funcmodel.Nascimento = Convert.ToDateTime(datanascFuncionario.Text);
                _funcmodel.Cpf = cpfFuncionario.Text;
                _funcmodel.Endereco.Rua = ruaFuncionario.Text;
                _funcmodel.Endereco.Bairro = bairroFuncionario.Text;
                _funcmodel.Endereco.Cep = cepFuncionario.Text;
                _funcmodel.Endereco.Numero = numeroFuncionario.Text;
                _funcmodel.Endereco.Cidade = cidadeFuncionario.Text;
                _funcmodel.Endereco.Estado = estadoFuncionario.Text;
                _funcmodel.Endereco.Complemento = complementoFuncionario.Text;
                _funcmodel.Celular = celularFuncionario.Text;
                _funcmodel.Salario = salarioFuncionario.Text;
                _funcmodel.Agencia = agenciaFuncionario.Text;
                _funcmodel.Comissao = comissaoFuncionario.Text;
                _funcmodel.NumConta = numContaFuncionario.Text;
                _funcmodel.CodConta = codContaFuncionario.Text;

                if (sexoMascFuncionario.Checked == true)
                    _funcmodel.Sexo = "M";
                else if (sexoFemFuncionario.Checked == true)
                    _funcmodel.Sexo = "F";
                else
                    _funcmodel.Sexo = "O";


                _funccontrol.CadastrarFuncionario(_funcmodel);
                MessageBox.Show("Funcionário Cadastrado com Sucesso!");

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
            
        }

        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            telaInicial ti = new telaInicial();
            ti.ShowDialog();
            this.Close();
        }

        private void cLIENTESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            ListarCliente lc = new ListarCliente();
            lc.ShowDialog();
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Hide();
            AlterarFuncionario af = new AlterarFuncionario();
            af.ShowDialog();
            this.Close();
        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            AlterarCliente ac = new AlterarCliente();
            ac.ShowDialog();
            this.Close();
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
            if (sexoMascFuncionario.Checked == true)
                return true;
            else if (sexoFemFuncionario.Checked == true)
                return true;
            else if (sexOtherFuncionario.Checked == true)
                return true;
            else
            {
                return false;
            }
        }

        private bool Validar()
        {

            if (!Testes.ValidarString(nomeFuncionario.Text))
            {
                MessageBox.Show("Nome inválido");
                return false;
            }

            else if (!Testes.ValidarEmail(emailFuncionario.Text))
            {
                MessageBox.Show("Email inválido");
                return false;
            }

            else if (!Testes.ValidarDatas(datanascFuncionario.Text))
            {
                MessageBox.Show("Data de Nascimento inválida");
                return false;
            }

            else if (!Testes.ValidarCpf(cpfFuncionario.Text))
            {
                MessageBox.Show("CPF inválido");
                return false;
            }

            else if (!ValidarSexo())
            {
                MessageBox.Show("Sexo inválido");
                return false;
            }

            else if (!Testes.ValidarStringENumeric(ruaFuncionario.Text))
            {
                MessageBox.Show("Rua inválida");
                return false;
            }

            else if (!Testes.ValidarString(bairroFuncionario.Text))
            {
                MessageBox.Show("Bairro inválido");
                return false;
            }

            else if (!Testes.ValidarCep(cepFuncionario.Text))
            {
                MessageBox.Show("CEP inválido");
                return false;
            }

            else if (!Testes.ValidarNumeric(numeroFuncionario.Text))
            {
                MessageBox.Show("Número inválido");
                return false;
            }

            else if (!Testes.ValidarCelular(celularFuncionario.Text))
            {
                MessageBox.Show("Celular inválido");
                return false;
            }

            else if (!Testes.ValidarString(cidadeFuncionario.Text))
            {
                MessageBox.Show("Cidade inválida");
                return false;
            }

            else if (string.IsNullOrEmpty(estadoFuncionario.Text))
            {
                MessageBox.Show("Estado inválido");
                return false;
            }

            else if (!Testes.ValidarNumeric(salarioFuncionario.Text))
            {
                MessageBox.Show("Salário inválido");
                return false;
            }

            else if (!Testes.ValidarComissao(comissaoFuncionario.Text))
            {
                MessageBox.Show("Comissão inválida");
                return false;
            }

            else if (!Testes.ValidarNumeric(agenciaFuncionario.Text))
            {
                MessageBox.Show("Agência inválida");
                return false;
            }

            else if (!Testes.ValidarNumeric(numContaFuncionario.Text))
            {
                MessageBox.Show("Número da Conta inválido");
                return false;
            }

            else if (!Testes.ValidarNumeric(codContaFuncionario.Text))
            {
                MessageBox.Show("Código da Conta inválido");
                return false;
            }

            else
            {
                return true;
            }
        }
    }
}
