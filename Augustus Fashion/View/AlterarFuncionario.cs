﻿using System;
using Augustus_Fashion.Controller;
using Augustus_Fashion.Model;
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

        public void dadosDe(FuncionarioModel func)
        {
            idFuncionario.Text = func.id.ToString();
            nomeFuncionario.Text = func.nome;
            emailFuncionario.Text = func.email;
            datanascFuncionario.Text = func.nascimento.ToString();
            cpfFuncionario.Text = func.cpf;
            ruaFuncionario.Text = func.rua;
            bairroFuncionario.Text = func.bairro;
            cepFuncionario.Text = func.cep;
            numeroFuncionario.Text = func.numero;
            celularFuncionario.Text = func.celular;
            cidadeFuncionario.Text = func.cidade;
            estadoFuncionario.Text = func.estado;
            complementoFuncionario.Text = func.complemento;
            salarioFuncionario.Text = func.salario;
            comissaoFuncionario.Text = func.comissao;
            agenciaFuncionario.Text = func.agencia;
            numContaFuncionario.Text = func.numConta;
            codContaFuncionario.Text = func.codConta;

            if (func.sexo == "M")
                sexoMascFuncionario.Checked = true;
            else if (func.sexo == "F")
                sexoFemFuncionario.Checked = true;
            else if (func.sexo == "O")
                sexOtherFuncionario.Checked = true;

            funcionariomodel = func;

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
                funcionariocontrol.ExcluirFuncionario(funcionariomodel);

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
                funcionariomodel.nome = nomeFuncionario.Text;
                funcionariomodel.email = emailFuncionario.Text;
                funcionariomodel.nascimento = Convert.ToDateTime(datanascFuncionario.Text);
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
