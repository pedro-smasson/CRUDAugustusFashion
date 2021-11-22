using Augustus_Fashion.Controller;
using Augustus_Fashion.Model;
using Augustus_Fashion.Model.Produto;
using Augustus_Fashion.View.Produto;
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
    public partial class CadastroProduto : Form
    {
        ProdutoModel _produtoModel = new ProdutoModel();
        ProdutoControl _produtoControl = new ProdutoControl();

        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void FecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            telaInicial ti = new telaInicial();
            ti.ShowDialog();
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            codProduto.Text = "";
            codBarrasProduto.Text = "";
            nomeProduto.Text = "";
            fabricanteProduto.Text = "";
            precoVendaProduto.Text = "";
            precoCustoProduto.Text = "";
            estoqueProduto.Text = "";
            chkAtivo.Checked = false;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private bool Validar() 
        {
            if (!Testes.ValidarNumeric(codBarrasProduto.Text))
            {
                MessageBox.Show("Informe um Código de Barras válido!");
                return false;
            }
            else if (!Testes.ValidarNumeric(precoVendaProduto.Text))
            {
                MessageBox.Show("Informe um Preço de Venda válido!");
                return false;
            }
            else if (!Testes.ValidarNumeric(precoCustoProduto.Text))
            {
                MessageBox.Show("Informe um Preço de Custo válido!");
                return false;
            }
            else if (!Testes.ValidarString(nomeProduto.Text))
            {
                MessageBox.Show("Informe um Nome válido!");
                return false;
            }
            else if (!Testes.ValidarString(fabricanteProduto.Text))
            {
                MessageBox.Show("Informe um Fabricante válido!");
                return false;
            }
            else if (!Testes.ValidarNumeric(estoqueProduto.Text))
            {
                MessageBox.Show("Informe uma quantidade de Estoque válida!");
                return false;
            }
            else 
            {
                return true;
            } 
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (Validar()) 
            {
                _produtoModel.CodBarra = codBarrasProduto.Text;
                _produtoModel.PrecoVenda = Convert.ToDecimal(precoVendaProduto.Text).ToString();
                _produtoModel.PrecoCusto = precoCustoProduto.Text;
                _produtoModel.Nome = nomeProduto.Text;
                _produtoModel.Fabricante = fabricanteProduto.Text;
                _produtoModel.Estoque = Convert.ToInt32(estoqueProduto.Text);
                
                _produtoModel.StatusProduto = chkAtivo.Checked;

                try
                {
                    _produtoControl.CadastrarProduto(_produtoModel);
                    MessageBox.Show("Produto Cadastrado com Sucesso!");

                    codProduto.Text = "";
                    codBarrasProduto.Text = "";
                    nomeProduto.Text = "";
                    fabricanteProduto.Text = "";
                    precoVendaProduto.Text = "";
                    precoCustoProduto.Text = "";
                    estoqueProduto.Text = "";
                    chkAtivo.Checked = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Falha no Cadastro!" + ex.Message);
                }
            }
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

        private void eSTOQUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            ListarProduto lp = new ListarProduto();
            lp.ShowDialog();
            Close();
        }

        private void cAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
