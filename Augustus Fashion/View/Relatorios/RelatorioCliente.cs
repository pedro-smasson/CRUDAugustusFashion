using Augustus_Fashion.Controller;
using System;
using System.Windows.Forms;

namespace Augustus_Fashion.View.Relatorios
{
    public partial class RelatorioCliente : Form
    {
        ClienteControl _clienteController = new ClienteControl();
        FiltrosControl _filtrosController = new FiltrosControl();

        public RelatorioCliente()
        {
            InitializeComponent();
            cbFiltrosSimples.DropDownWidth = DropDownWidth(cbFiltrosSimples);
            cbFiltrosAvancados.DropDownWidth = DropDownWidth(cbFiltrosAvancados);
        }

        int DropDownWidth(ComboBox comboBox)
        {
            int maiorTamanho = 0, temp = 0;
            foreach (var itens in comboBox.Items)
            {
                temp = TextRenderer.MeasureText(itens.ToString(), comboBox.Font).Width;
                if (temp > maiorTamanho)
                {
                    maiorTamanho = temp;
                }
            }
            return maiorTamanho;
        }

        private void RelatorioCliente_Load(object sender, EventArgs e)
        {
            dgvCliente.DataSource = _clienteController.ListarClientes();
        }

        private void QualFiltroEstaSelecionado() 
        {
            if(cbFiltrosSimples.Text == "Qtde Pedidos Crescente") 
            {
                dgvCliente.DataSource = _filtrosController.QuantidadeDePedidosCrescente();
                this.dgvCliente.Columns["IdCliente"].Visible = true;
                this.dgvCliente.Columns["NumeroDePedidos"].Visible = true;
                this.dgvCliente.Columns["Nome"].Visible = true;
                this.dgvCliente.Columns["TotalGasto"].Visible = false;
                this.dgvCliente.Columns["Desconto"].Visible = false;
            }
            else if (cbFiltrosSimples.Text == "Qtde Pedidos Descrescente") 
            {
                dgvCliente.DataSource = _filtrosController.QuantidadeDePedidosDecrescente();
                this.dgvCliente.Columns["IdCliente"].Visible = true;
                this.dgvCliente.Columns["NumeroDePedidos"].Visible = true;
                this.dgvCliente.Columns["Nome"].Visible = true;
                this.dgvCliente.Columns["TotalGasto"].Visible = false;
                this.dgvCliente.Columns["Desconto"].Visible = false;
            }
            else if (cbFiltrosSimples.Text == "Total Liquido Crescente")
            {
                dgvCliente.DataSource = _filtrosController.TotalLiquidoCrescente();
                this.dgvCliente.Columns["IdCliente"].Visible = true;
                this.dgvCliente.Columns["NumeroDePedidos"].Visible = false;
                this.dgvCliente.Columns["Nome"].Visible = true;
                this.dgvCliente.Columns["TotalGasto"].Visible = true;
                this.dgvCliente.Columns["Desconto"].Visible = false;
            }
            else if (cbFiltrosSimples.Text == "Total Liquido Decrescente")
            {
                dgvCliente.DataSource = _filtrosController.TotalLiquidoDecrescente();
                this.dgvCliente.Columns["IdCliente"].Visible = true;
                this.dgvCliente.Columns["NumeroDePedidos"].Visible = false;
                this.dgvCliente.Columns["Nome"].Visible = true;
                this.dgvCliente.Columns["TotalGasto"].Visible = true;
                this.dgvCliente.Columns["Desconto"].Visible = false;
            }
            else if (cbFiltrosSimples.Text == "Desconto Crescente")
            {
                dgvCliente.DataSource = _filtrosController.DescontoCrescente();
                this.dgvCliente.Columns["IdCliente"].Visible = true;
                this.dgvCliente.Columns["NumeroDePedidos"].Visible = false;
                this.dgvCliente.Columns["Nome"].Visible = true;
                this.dgvCliente.Columns["TotalGasto"].Visible = false;
                this.dgvCliente.Columns["Desconto"].Visible = true;
            }
            else if (cbFiltrosSimples.Text == "Desconto Decrescente")
            {
                dgvCliente.DataSource = _filtrosController.DescontoDecrescente();
                this.dgvCliente.Columns["IdCliente"].Visible = true;
                this.dgvCliente.Columns["NumeroDePedidos"].Visible = false;
                this.dgvCliente.Columns["Nome"].Visible = true;
                this.dgvCliente.Columns["TotalGasto"].Visible = false;
                this.dgvCliente.Columns["Desconto"].Visible = true;
            }

            else if (cbFiltrosAvancados.Text == "Clientes que Mais Compraram")
            {
                dgvCliente.DataSource = _filtrosController.QuantidadeDePedidosCrescente();
                this.dgvCliente.Columns["IdCliente"].Visible = true;
                this.dgvCliente.Columns["NumeroDePedidos"].Visible = true;
                this.dgvCliente.Columns["Nome"].Visible = true;
                this.dgvCliente.Columns["TotalGasto"].Visible = false;
                this.dgvCliente.Columns["Desconto"].Visible = false;
            }
            else if (cbFiltrosAvancados.Text == "Clientes que Menos Compraram")
            {
                dgvCliente.DataSource = _filtrosController.QuantidadeDePedidosDecrescente();
                this.dgvCliente.Columns["IdCliente"].Visible = true;
                this.dgvCliente.Columns["NumeroDePedidos"].Visible = true;
                this.dgvCliente.Columns["Nome"].Visible = true;
                this.dgvCliente.Columns["TotalGasto"].Visible = false;
                this.dgvCliente.Columns["Desconto"].Visible = false;
            }
            else if (cbFiltrosAvancados.Text == "5 Clientes que Mais Gastaram")
            {
                dgvCliente.DataSource = _filtrosController.Top5ClientesQueMaisGastaram();
                this.dgvCliente.Columns["IdCliente"].Visible = true;
                this.dgvCliente.Columns["NumeroDePedidos"].Visible = false;
                this.dgvCliente.Columns["Nome"].Visible = true;
                this.dgvCliente.Columns["TotalGasto"].Visible = true;
                this.dgvCliente.Columns["Desconto"].Visible = false;
            }
            else if (cbFiltrosAvancados.Text == "5 Clientes que Menos Gastaram")
            {
                dgvCliente.DataSource = _filtrosController.Top5ClientesQueMenosGastaram();
                this.dgvCliente.Columns["IdCliente"].Visible = true;
                this.dgvCliente.Columns["NumeroDePedidos"].Visible = false;
                this.dgvCliente.Columns["Nome"].Visible = true;
                this.dgvCliente.Columns["TotalGasto"].Visible = true;
                this.dgvCliente.Columns["Desconto"].Visible = false;
            }
            else if (cbFiltrosAvancados.Text == "5 Clientes que Mais Compraram")
            {
                dgvCliente.DataSource = _filtrosController.Top5ClientesQueMaisCompraram();
                this.dgvCliente.Columns["IdCliente"].Visible = true;
                this.dgvCliente.Columns["NumeroDePedidos"].Visible = true;
                this.dgvCliente.Columns["Nome"].Visible = true;
                this.dgvCliente.Columns["TotalGasto"].Visible = false;
                this.dgvCliente.Columns["Desconto"].Visible = false;
            }
            else if (cbFiltrosAvancados.Text == "5 Clientes que Menos Compraram")
            {
                dgvCliente.DataSource = _filtrosController.Top5ClientesQueMenosCompraram();
                this.dgvCliente.Columns["IdCliente"].Visible = true;
                this.dgvCliente.Columns["NumeroDePedidos"].Visible = true;
                this.dgvCliente.Columns["Nome"].Visible = true;
                this.dgvCliente.Columns["TotalGasto"].Visible = false;
                this.dgvCliente.Columns["Desconto"].Visible = false;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            QualFiltroEstaSelecionado();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cbFiltrosAvancados.SelectedItem = null;
            cbFiltrosSimples.SelectedItem = null;
        }

        private void fECHARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaInicial telaInicial = new telaInicial();
            telaInicial.ShowDialog();
            this.Close();
        }
    }
}