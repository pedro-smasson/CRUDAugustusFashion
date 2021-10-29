using Augustus_Fashion.Model;
using Augustus_Fashion.Controller;
using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Augustus_Fashion.View
{
    public partial class CadastroFuncionario : Form
    {
        FuncionarioModel funcmodel = new FuncionarioModel();
        FuncionarioControl funccontrol = new FuncionarioControl();

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
                funcmodel.nome = nomeFuncionario.Text;
                funcmodel.email = emailFuncionario.Text;
                funcmodel.nascimento = Convert.ToDateTime(datanascFuncionario.Text);
                funcmodel.cpf = cpfFuncionario.Text;
                funcmodel.rua = ruaFuncionario.Text;
                funcmodel.bairro = bairroFuncionario.Text;
                funcmodel.cep = cepFuncionario.Text;
                funcmodel.numero = numeroFuncionario.Text;
                funcmodel.cidade = cidadeFuncionario.Text;
                funcmodel.estado = estadoFuncionario.Text;
                funcmodel.complemento = complementoFuncionario.Text;
                funcmodel.celular = celularFuncionario.Text;
                funcmodel.salario = salarioFuncionario.Text;
                funcmodel.agencia = agenciaFuncionario.Text;
                funcmodel.comissao = comissaoFuncionario.Text;
                funcmodel.numConta = numContaFuncionario.Text;
                funcmodel.codConta = codContaFuncionario.Text;

                if (sexoMascFuncionario.Checked == true)
                    funcmodel.sexo = "M";
                else if (sexoFemFuncionario.Checked == true)
                    funcmodel.sexo = "F";
                else
                    funcmodel.sexo = "O";


                funccontrol.CadastrarFuncionario(funcmodel);

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

        private void cLIENTESToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Hide();
            ExcluirCliente ec = new ExcluirCliente();
            ec.ShowDialog();
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

        private void fUNCIONÁRIOSToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Hide();
            ExcluirFuncionario ef = new ExcluirFuncionario();
            ef.ShowDialog();
            Close();
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

            else if (!Testes.validarEmail(emailFuncionario.Text))
            {
                MessageBox.Show("Email inválido");
                return false;
            }

            else if (!Testes.validarDataNasc(datanascFuncionario.Text))
            {
                MessageBox.Show("Data de Nascimento inválida");
                return false;
            }

            else if (!Testes.validarCpf(cpfFuncionario.Text))
            {
                MessageBox.Show("CPF inválido");
                return false;
            }

            else if (!ValidarSexo())
            {
                MessageBox.Show("Sexo inválido");
                return false;
            }

            else if (!Testes.validarStringENumeric(ruaFuncionario.Text))
            {
                MessageBox.Show("Rua inválida");
                return false;
            }

            else if (!Testes.ValidarString(bairroFuncionario.Text))
            {
                MessageBox.Show("Bairro inválido");
                return false;
            }

            else if (!Testes.validarCep(cepFuncionario.Text))
            {
                MessageBox.Show("CEP inválido");
                return false;
            }

            else if (!Testes.ValidarNumeric(numeroFuncionario.Text))
            {
                MessageBox.Show("Número inválido");
                return false;
            }

            else if (!Testes.validarCelular(celularFuncionario.Text))
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

            else if (!Testes.validarComissao(comissaoFuncionario.Text))
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
