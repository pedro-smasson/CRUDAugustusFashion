using System;
using Augustus_Fashion.Model;
using Augustus_Fashion.Controller;
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
    public partial class ExcluirFuncionario : Form
    {
        FuncionarioControl funcionariocontrol = new FuncionarioControl();
        FuncionarioModel funcionariomodel = new FuncionarioModel();

        public ExcluirFuncionario()
        {
            InitializeComponent();
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

                btnExcluir.Enabled = true;
            }
            else
            {
                MessageBox.Show("ID não cadastrado!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            funcionariocontrol.ExcluirFuncionario(funcionariomodel);

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
            Hide();
            AlterarFuncionario af = new AlterarFuncionario();
            af.ShowDialog();
            this.Close();
        }

        private void cLIENTESToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Hide();
            ExcluirCliente ec = new ExcluirCliente();
            ec.ShowDialog();
            this.Close();
        }

        private void fUNCIONÁRIOSToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void FecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExcluirFuncionario_Load(object sender, EventArgs e)
        {
            btnExcluir.Enabled = false;
        }
    }
}
