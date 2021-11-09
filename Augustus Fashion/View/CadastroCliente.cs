using Augustus_Fashion.Controller;
using Augustus_Fashion.FluentValidation;
using Augustus_Fashion.Model;
using Augustus_Fashion.View;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Augustus_Fashion
{

    public partial class cadastroCliente : Form
    {
        ClienteModel _clientemodel = new ClienteModel();
        ClienteControl _clientecontrol = new ClienteControl();

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

                _clientemodel.Nome = nomeCliente.Text;
                _clientemodel.Email = emailCliente.Text;
                _clientemodel.Nascimento = Convert.ToDateTime(datanascCliente.Text);
                _clientemodel.Cpf = cpfCliente.Text;
                _clientemodel.Endereco.Rua = ruaCliente.Text;
                _clientemodel.Endereco.Bairro = bairroCliente.Text;
                _clientemodel.Endereco.Cep = cepCliente.Text;
                _clientemodel.Endereco.Numero = numeroCliente.Text;
                _clientemodel.Endereco.Cidade = cidadeCliente.Text;
                _clientemodel.Endereco.Estado = estadoCliente.Text;
                _clientemodel.Endereco.Complemento = complementoCliente.Text;
                _clientemodel.Celular = celularCliente.Text;
                _clientemodel.Limite = valorLimiteCliente.Text;

                if (sexoMascCliente.Checked == true)
                    _clientemodel.Sexo = "M";
                else if (sexoFemCliente.Checked == true)
                    _clientemodel.Sexo = "F";
                else if (sexOtherCliente.Checked == true)
                    _clientemodel.Sexo = "O";

               

                try 
                {
                    var retornar = new ClienteControl().CadastrarCliente(_clientemodel);
                    if(retornar == string.Empty) 
                    {
                        _clientecontrol.CadastrarCliente(_clientemodel);
                        MessageBox.Show("Cliente Cadastrado com Sucesso!");
                    }
                    else 
                    {
                        MessageBox.Show(retornar);
                    }
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("Falha no Cadastro!" + ex.Message);
                }

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
            CPFValidation cpfV = new CPFValidation();
            var validarCpf = cpfV.Validate(cpfCliente.Text);

            CEPValidation cepV = new CEPValidation();
            var validarCep = cepV.Validate(cepCliente.Text);

            if (!Testes.ValidarString(nomeCliente.Text))
            {
                MessageBox.Show("Nome inválido");
                return false;
            }

            else if (!Testes.ValidarEmail(emailCliente.Text))
            {
                MessageBox.Show("Email inválido");
                return false;
            }

            else if (!Testes.ValidarDataNasc(datanascCliente.Text))
            {
                MessageBox.Show("Data de Nascimento inválida");
                return false;
            }
            
            else if (!validarCpf.IsValid)
            {
                MessageBox.Show(validarCpf.Errors.FirstOrDefault().ToString());
                return false;
            }

            else if (!ValidarSexo())
            {
                MessageBox.Show("Sexo inválido");
                return false;
            }

            else if (!Testes.ValidarStringENumeric(ruaCliente.Text))
            {
                MessageBox.Show("Rua inválida");
                return false;
            }

            else if (!Testes.ValidarString(bairroCliente.Text))
            {
                MessageBox.Show("Bairro inválido");
                return false;
            }

            else if (!validarCep.IsValid)
            {
                MessageBox.Show(validarCep.Errors.FirstOrDefault().ToString());
                return false;
            }

            else if (!Testes.ValidarNumeric(numeroCliente.Text))
            {
                MessageBox.Show("Número inválido");
                return false;
            }

            else if (!Testes.ValidarCelular(celularCliente.Text))
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

    }
}
