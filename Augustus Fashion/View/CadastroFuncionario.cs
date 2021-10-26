using Augustus_Fashion.Model;
using Augustus_Fashion.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            else 
            {
                MessageBox.Show("Corrija os Campos Incorretos!");
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
