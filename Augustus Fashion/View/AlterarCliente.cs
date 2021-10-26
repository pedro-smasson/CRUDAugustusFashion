using Augustus_Fashion.Controller;
using Augustus_Fashion.Model;
using System;
using System.Windows.Forms;

namespace Augustus_Fashion.View
{
    public partial class AlterarCliente : Form
    {
        ClienteModel clientemodel = new ClienteModel();
        ClienteControl clientecontrol = new ClienteControl();

        public AlterarCliente()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
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

                clientecontrol.AlterarCliente(clientemodel);

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
                idCliente.Text = "";
            }

            else 
            {
                MessageBox.Show("Corrija os Campos Incorretos!");
            }
            
        }

        private void BuscarCliente_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(idCliente.Text))
            {
                clientemodel = clientecontrol.Buscar(Int32.Parse(idCliente.Text));

                if (clientemodel != null)
                {

                    nomeCliente.Text = clientemodel.nome;
                    emailCliente.Text = clientemodel.email;
                    datanascCliente.Text = clientemodel.nascimento.ToString("dd/MM/yyyy");
                    cpfCliente.Text = clientemodel.cpf;
                    ruaCliente.Text = clientemodel.rua;
                    bairroCliente.Text = clientemodel.bairro;
                    cepCliente.Text = clientemodel.cep;
                    numeroCliente.Text = clientemodel.numero;
                    cidadeCliente.Text = clientemodel.cidade;
                    estadoCliente.Text = clientemodel.estado;
                    complementoCliente.Text = clientemodel.complemento;
                    celularCliente.Text = clientemodel.celular;
                    valorLimiteCliente.Text = clientemodel.limite;

                    if (clientemodel.sexo == "M")
                        sexoMascCliente.Checked = true;

                    else if (clientemodel.sexo == "F")
                        sexoFemCliente.Checked = true;

                    else if (clientemodel.sexo == "O")
                        sexOtherCliente.Checked = true;

                    btnAlterar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("ID não cadastrado!");
                }
            } 

            
        }

            private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            telaInicial ti = new telaInicial();
            ti.ShowDialog();
            this.Close();
        }

        private void FecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void AlterarCliente_Load(object sender, EventArgs e)
        {
            btnAlterar.Enabled = false;
        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
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

            if (string.IsNullOrEmpty(nomeCliente.Text))
            {
                MessageBox.Show("Nome inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(emailCliente.Text))
            {
                MessageBox.Show("Email inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(datanascCliente.Text))
            {
                MessageBox.Show("Data de Nascimento inválida");
                return false;
            }
            else if (string.IsNullOrEmpty(cpfCliente.Text))
            {
                MessageBox.Show("CPF inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(sexoCliente.Text))
            {
                MessageBox.Show("Sexo inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(ruaCliente.Text))
            {
                MessageBox.Show("Rua inválida");
                return false;
            }
            else if (string.IsNullOrEmpty(bairroCliente.Text))
            {
                MessageBox.Show("Bairro inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(cepCliente.Text))
            {
                MessageBox.Show("CEP inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(numeroCliente.Text))
            {
                MessageBox.Show("Número inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(celularCliente.Text))
            {
                MessageBox.Show("Celular inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(cidadeCliente.Text))
            {
                MessageBox.Show("Cidade inválida");
                return false;
            }
            else if (string.IsNullOrEmpty(estadoCliente.Text))
            {
                MessageBox.Show("Estado inválido");
                return false;
            }
            else if (string.IsNullOrEmpty(valorLimiteCliente.Text))
            {
                MessageBox.Show("Valor limite inválido");
                return false;
            }

            else
            {
                return true;
            }
        }
    }
}
