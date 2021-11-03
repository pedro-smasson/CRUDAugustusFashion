using System;
using Augustus_Fashion.Controller;
using Augustus_Fashion.Model;
using System.Windows.Forms;

namespace Augustus_Fashion.View
{
    public partial class AlterarFuncionario : Form
    {
        FuncionarioModel _funcionariomodel = new FuncionarioModel();
        FuncionarioControl _funcionariocontrol = new FuncionarioControl();

        public AlterarFuncionario()
        {
            InitializeComponent();
        }

        public void dadosDe(FuncionarioModel func)
        {
            idFuncionario.Text = func.Id.ToString();
            nomeFuncionario.Text = func.Nome;
            emailFuncionario.Text = func.Email;
            datanascFuncionario.Text = func.Nascimento.ToString();
            cpfFuncionario.Text = func.Cpf;
            ruaFuncionario.Text = func.Rua;
            bairroFuncionario.Text = func.Bairro;
            cepFuncionario.Text = func.Cep;
            numeroFuncionario.Text = func.Numero;
            celularFuncionario.Text = func.Celular;
            cidadeFuncionario.Text = func.Cidade;
            estadoFuncionario.Text = func.Estado;
            complementoFuncionario.Text = func.Complemento;
            salarioFuncionario.Text = func.Salario;
            comissaoFuncionario.Text = func.Comissao;
            agenciaFuncionario.Text = func.Agencia;
            numContaFuncionario.Text = func.NumConta;
            codContaFuncionario.Text = func.CodConta;

            if (func.Sexo == "M")
                sexoMascFuncionario.Checked = true;
            else if (func.Sexo == "F")
                sexoFemFuncionario.Checked = true;
            else if (func.Sexo == "O")
                sexOtherFuncionario.Checked = true;

            _funcionariomodel = func;

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

        private void fUNCIONÁRIOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            ListarFuncionario lf = new ListarFuncionario();
            lf.ShowDialog();
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
            this.Refresh();
        }

        private void FecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                _funcionariocontrol.ExcluirFuncionario(_funcionariomodel);

                Hide();
                ListarFuncionario lc = new ListarFuncionario();
                lc.ShowDialog();
                this.Close();
            }

            else
            {
                MessageBox.Show("Falha na Exclusão");
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
                _funcionariomodel.Rua = ruaFuncionario.Text;
                _funcionariomodel.Bairro = bairroFuncionario.Text;
                _funcionariomodel.Cep = cepFuncionario.Text;
                _funcionariomodel.Numero = numeroFuncionario.Text;
                _funcionariomodel.Cidade = cidadeFuncionario.Text;
                _funcionariomodel.Estado = estadoFuncionario.Text;
                _funcionariomodel.Complemento = complementoFuncionario.Text;
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

                _funcionariocontrol.AlterarFuncionario(_funcionariomodel);

                Hide();
                ListarFuncionario lc = new ListarFuncionario();
                lc.ShowDialog();
                this.Close();
            }

            else 
            {
                MessageBox.Show("Corrija os Campos Incorretos!");
            }

        }
        private bool Validar()
        {

            if (string.IsNullOrEmpty(nomeFuncionario.Text))
            {
                MessageBox.Show("Nome inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(emailFuncionario.Text))
            {
                MessageBox.Show("Email inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(datanascFuncionario.Text))
            {
                MessageBox.Show("Data de Nascimento inválida");
                return false;
            }
            else if (string.IsNullOrEmpty(cpfFuncionario.Text))
            {
                MessageBox.Show("CPF inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(sexoFuncionario.Text))
            {
                MessageBox.Show("Sexo inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(ruaFuncionario.Text))
            {
                MessageBox.Show("Rua inválida");
                return false;
            }
            else if (string.IsNullOrEmpty(bairroFuncionario.Text))
            {
                MessageBox.Show("Bairro inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(cepFuncionario.Text))
            {
                MessageBox.Show("CEP inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(numeroFuncionario.Text))
            {
                MessageBox.Show("Número inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(celularFuncionario.Text))
            {
                MessageBox.Show("Celular inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(cidadeFuncionario.Text))
            {
                MessageBox.Show("Cidade inválida");
                return false;
            }
            else if (string.IsNullOrEmpty(estadoFuncionario.Text))
            {
                MessageBox.Show("Estado inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(salarioFuncionario.Text))
            {
                MessageBox.Show("Salário inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(comissaoFuncionario.Text))
            {
                MessageBox.Show("Comissão inválida");
                return false;
            }
            else if (string.IsNullOrEmpty(agenciaFuncionario.Text))
            {
                MessageBox.Show("Agência inválida");
                return false;
            }
            else if (string.IsNullOrEmpty(numContaFuncionario.Text))
            {
                MessageBox.Show("Número da Conta inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(codContaFuncionario.Text))
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
