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
            funcmodel.nome = nomeFuncionario.Text;
            funcmodel.email = emailFuncionario.Text;
            funcmodel.nascimento = datanascFuncionario.Text;
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

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }
    }
}
