using System;
using Augustus_Fashion.Controller;
using Augustus_Fashion.Model;
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
    public partial class AlterarFuncionario : Form
    {
        FuncionarioModel funcionariomodel = new FuncionarioModel();
        FuncionarioControl funcionariocontrol = new FuncionarioControl();

        public AlterarFuncionario()
        {
            InitializeComponent();
        }

        private void AlterarFuncionario_Load(object sender, EventArgs e)
        {
            btnAlterar.Enabled = false;
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

        private void cLIENTESToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Hide();
            ExcluirCliente ec = new ExcluirCliente();
            ec.ShowDialog();
            this.Close();
        }

        private void FecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buscarCliente_Click(object sender, EventArgs e)
        {
            funcionariomodel = funcionariocontrol.Buscar(Int32.Parse(idFuncionario.Text));

            if (funcionariomodel != null)
            {

                nomeFuncionario.Text = funcionariomodel.nome;
                emailFuncionario.Text = funcionariomodel.email;
                datanascFuncionario.Text = funcionariomodel.nascimento;
                cpfFuncionario.Text = funcionariomodel.cpf;
                ruaFuncionario.Text = funcionariomodel.rua;
                bairroFuncionario.Text = funcionariomodel.bairro;
                cepFuncionario.Text = funcionariomodel.cep;
                numeroFuncionario.Text = funcionariomodel.numero;
                cidadeFuncionario.Text = funcionariomodel.cidade;
                estadoFuncionario.Text = funcionariomodel.estado;
                complementoFuncionario.Text = funcionariomodel.complemento;
                celularFuncionario.Text = funcionariomodel.celular;
                salarioFuncionario.Text = funcionariomodel.salario;
                agenciaFuncionario.Text = funcionariomodel.agencia;
                comissaoFuncionario.Text = funcionariomodel.comissao;
                codContaFuncionario.Text = funcionariomodel.codConta;
                numContaFuncionario.Text = funcionariomodel.numConta;

                if (funcionariomodel.sexo == "M")
                    sexoMascFuncionario.Checked = true;

                else if (funcionariomodel.sexo == "F")
                    sexoFemFuncionario.Checked = true;

                else if (funcionariomodel.sexo == "O")
                    sexOtherFuncionario.Checked = true;

                btnAlterar.Enabled = true;
            }
            else
            {
                MessageBox.Show("ID não cadastrado!");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            funcionariomodel.nome = nomeFuncionario.Text;
            funcionariomodel.email = emailFuncionario.Text;
            funcionariomodel.nascimento = datanascFuncionario.Text;
            funcionariomodel.cpf = cpfFuncionario.Text;
            funcionariomodel.rua = ruaFuncionario.Text;
            funcionariomodel.bairro = bairroFuncionario.Text;
            funcionariomodel.cep = cepFuncionario.Text;
            funcionariomodel.numero = numeroFuncionario.Text;
            funcionariomodel.cidade = cidadeFuncionario.Text;
            funcionariomodel.estado = estadoFuncionario.Text;
            funcionariomodel.complemento = complementoFuncionario.Text;
            funcionariomodel.celular = celularFuncionario.Text;
            funcionariomodel.salario = salarioFuncionario.Text;
            funcionariomodel.agencia = agenciaFuncionario.Text;
            funcionariomodel.comissao = comissaoFuncionario.Text;
            funcionariomodel.codConta = codContaFuncionario.Text;
            funcionariomodel.numConta = numContaFuncionario.Text;

            if (sexoMascFuncionario.Checked == true)
                funcionariomodel.sexo = "M";
            else if (sexoFemFuncionario.Checked == true)
                funcionariomodel.sexo = "F";
            else if (sexOtherFuncionario.Checked == true)
                funcionariomodel.sexo = "O";

            funcionariocontrol.AlterarFuncionario(funcionariomodel);

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
            idFuncionario.Text = "";

        }

        private void fUNCIONÁRIOSToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Hide();
            ExcluirFuncionario ef = new ExcluirFuncionario();
            ef.ShowDialog();
            Close();
        }
    }
}
