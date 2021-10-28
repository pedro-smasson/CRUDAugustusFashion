using Augustus_Fashion.Controller;
using Augustus_Fashion.Model;
using Augustus_Fashion.View;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Augustus_Fashion
{

    public partial class cadastroCliente : Form
    {
        ClienteModel clientemodel = new ClienteModel();
        ClienteControl clientecontrol = new ClienteControl();

        public cadastroCliente()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            nomeCliente.Text = "";
            emailCliente.Text = "";
            datanascCliente.Text = "";
            cpfCliente.Text = "";
            ruaCliente.Text = "";
            bairroCliente.Text = "";
            cepCliente.Text = "";
            numeroCliente.Text = "";
            celularCliente.Text = "";
            cidadeCliente.Text = "";
            estadoCliente.Text = "";
            complementoCliente.Text = "";
            valorLimiteCliente.Text = "";
            sexoMascCliente.Checked = false;
            sexoFemCliente.Checked = false;
            sexOtherCliente.Checked = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {

                clientemodel.nome = nomeCliente.Text;
                clientemodel.email = emailCliente.Text;
                clientemodel.nascimento = Convert.ToDateTime(datanascCliente.Text);
                clientemodel.cpf = cpfCliente.Text;
                clientemodel.rua = ruaCliente.Text;
                clientemodel.bairro = bairroCliente.Text;
                clientemodel.cep = cepCliente.Text;
                clientemodel.numero = numeroCliente.Text;
                clientemodel.cidade = cidadeCliente.Text;
                clientemodel.estado = estadoCliente.Text;
                clientemodel.complemento = complementoCliente.Text;
                clientemodel.celular = celularCliente.Text;
                clientemodel.limite = valorLimiteCliente.Text;

                if (sexoMascCliente.Checked == true)
                    clientemodel.sexo = "M";
                else if (sexoFemCliente.Checked == true)
                    clientemodel.sexo = "F";
                else if (sexOtherCliente.Checked == true)
                    clientemodel.sexo = "O";

                clientecontrol.CadastrarCliente(clientemodel);

                nomeCliente.Text = "";
                emailCliente.Text = "";
                datanascCliente.Text = "";
                cpfCliente.Text = "";
                ruaCliente.Text = "";
                bairroCliente.Text = "";
                cepCliente.Text = "";
                numeroCliente.Text = "";
                celularCliente.Text = "";
                cidadeCliente.Text = "";
                estadoCliente.Text = "";
                complementoCliente.Text = "";
                valorLimiteCliente.Text = "";
                sexoMascCliente.Checked = false;
                sexoFemCliente.Checked = false;
                sexOtherCliente.Checked = false;
            }
            
        }

        private bool Validar()
        {

            if (!Testes.ValidarString(nomeCliente.Text))
            {
                MessageBox.Show("Nome inválido");
                return false;
            }

            else if (!Testes.validarEmail(emailCliente.Text))
            {
                MessageBox.Show("Email inválido");
                return false;
            }

            else if (!Testes.validarDataNasc(datanascCliente.Text))
            {
                MessageBox.Show("Data de Nascimento inválida");
                return false;
            }

            else if (!Testes.validarCpf(cpfCliente.Text))
            {
                MessageBox.Show("CPF inválido");
                return false;
            }

            else if (!ValidarSexo())
            {
                MessageBox.Show("Sexo inválido");
                return false;
            }

            else if (!Testes.validarStringENumeric(ruaCliente.Text))
            {
                MessageBox.Show("Rua inválida");
                return false;
            }

            else if (!Testes.ValidarString(bairroCliente.Text))
            {
                MessageBox.Show("Bairro inválido");
                return false;
            }

            else if (!Testes.validarCep(cepCliente.Text))
            {
                MessageBox.Show("CEP inválido");
                return false;
            }

            else if (!Testes.ValidarNumeric(numeroCliente.Text))
            {
                MessageBox.Show("Número inválido");
                return false;
            }

            else if (!Testes.ValidarNumeric(celularCliente.Text))
            {
                MessageBox.Show("Celular inválido");
                return false;
            }

            else if (!Testes.ValidarString(cidadeCliente.Text))
            {
                MessageBox.Show("Cidade inválida");
                return false;
            }

            else if (string.IsNullOrEmpty(estadoCliente.Text))
            {
                MessageBox.Show("Estado inválido");
                return false;
            }

            else if (!Testes.ValidarNumeric(valorLimiteCliente.Text))
            {
                MessageBox.Show("Valor limite inválido");
                return false;
            }

            else
            {
                return true;
            }
        }

        private bool ValidarSexo() 
        {
            if (sexoMascCliente.Checked == true)
               return true;
            else if (sexoFemCliente.Checked == true)
                return true;
            else if (sexOtherCliente.Checked == true)
                return true;
            else 
            {
                return false;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Hide();
            AlterarCliente alc = new AlterarCliente();
            alc.ShowDialog();
            this.Close();
        }

        private void FecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastroCliente_Load(object sender, EventArgs e)
        {
             
        }

        private void fUNCIONÁRIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            CadastroFuncionario cf = new CadastroFuncionario();
            cf.ShowDialog();
            this.Close();
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
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

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            AlterarCliente ac = new AlterarCliente();
            ac.ShowDialog();
            this.Close();
        }

        private void excluirCliente_Click(object sender, EventArgs e)
        {
            Hide();
            ExcluirCliente ec = new ExcluirCliente();
            ec.ShowDialog();
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
    }
}
