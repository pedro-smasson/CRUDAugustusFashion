using Augustus_Fashion.Controller;
using Augustus_Fashion.MensagemGlobal;
using Augustus_Fashion.Model;
using Augustus_Fashion.View;
using System;
using System.Windows.Forms;

namespace Augustus_Fashion
{

    public partial class cadastroCliente : Form
    {
        ClienteModel _clientemodel = new ClienteModel();
        ClienteControl _clientecontrol = new ClienteControl();
        MensagemInfo _mensagemInfo = new MensagemInfo();
        MensagemErro _mensagemErro = new MensagemErro();

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
                        _mensagemInfo.Mensagem("Cliente Cadastrado com Sucesso!");

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
                    else 
                    {
                        MessageBox.Show(retornar);
                    }
                }
                catch 
                {
                    _mensagemErro.Mensagem("Falha no Cadastro!");
                }
            }
            
        }

        private bool Validar()
        {
            
            if (!Validacoes.ValidarString(nomeCliente.Text))
            {
                _mensagemErro.Mensagem("Nome inválido");
                return false;
            }

            else if (!Validacoes.ValidarEmail(emailCliente.Text))
            {
                _mensagemErro.Mensagem("Email inválido");
                return false;
            }

            else if (!Validacoes.ValidarDatas(datanascCliente.Text))
            {
                _mensagemErro.Mensagem("Data de Nascimento inválida");
                return false;
            }
            
            else if (!Validacoes.ValidarCpf(cpfCliente.Text))
            {
                _mensagemErro.Mensagem("CPF inválido");
                return false;
            }

            else if (!ValidarSexo())
            {
                _mensagemErro.Mensagem("Sexo inválido");
                return false;
            }

            else if (!Validacoes.ValidarStringENumeric(ruaCliente.Text))
            {
                _mensagemErro.Mensagem("Rua inválida");
                return false;
            }

            else if (!Validacoes.ValidarString(bairroCliente.Text))
            {
                _mensagemErro.Mensagem("Bairro inválido");
                return false;
            }

            else if (!Validacoes.ValidarCep(cepCliente.Text))
            {
                _mensagemErro.Mensagem("CEP inválido");
                return false;
            }

            else if (!Validacoes.ValidarNumeric(numeroCliente.Text))
            {
                _mensagemErro.Mensagem("Número inválido");
                return false;
            }

            else if (!Validacoes.ValidarCelular(celularCliente.Text))
            {
                _mensagemErro.Mensagem("Celular inválido");
                return false;
            }

            else if (!Validacoes.ValidarString(cidadeCliente.Text))
            {
                _mensagemErro.Mensagem("Cidade inválida");
                return false;
            }

            else if (string.IsNullOrEmpty(estadoCliente.Text))
            {
                _mensagemErro.Mensagem("Estado inválido");
                return false;
            }

            else if (!Validacoes.ValidarNumeric(valorLimiteCliente.Text))
            {
                _mensagemErro.Mensagem("Valor limite inválido");
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
