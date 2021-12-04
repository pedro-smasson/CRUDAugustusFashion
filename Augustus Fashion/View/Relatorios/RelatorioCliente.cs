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
                dgvCliente.DataSource = _filtrosController.QuantidadeCrescente();
                this.dgvCliente.Columns["NumeroDePedidos"].Visible = true;
                this.dgvCliente.Columns["TotalGasto"].Visible = false;
            }
            else if (cbFiltrosSimples.Text == "Qtde Pedidos Descrescente") 
            {
                dgvCliente.DataSource = _filtrosController.QuantidadeDecrescente();
                this.dgvCliente.Columns["NumeroDePedidos"].Visible = true;
                this.dgvCliente.Columns["TotalGasto"].Visible = false;
            }
            else if (cbFiltrosSimples.Text == "Total Liquido Crescente")
            {
                dgvCliente.DataSource = _filtrosController.TotalLiquidoCrescente();
                this.dgvCliente.Columns["NumeroDePedidos"].Visible = false;
                this.dgvCliente.Columns["TotalGasto"].Visible = true;
            }
            else if (cbFiltrosSimples.Text == "Total Liquido Decrescente")
            {
                dgvCliente.DataSource = _filtrosController.TotalLiquidoDecrescente();
                this.dgvCliente.Columns["NumeroDePedidos"].Visible = false;
                this.dgvCliente.Columns["TotalGasto"].Visible = true;
            }
            else if (cbFiltrosSimples.Text == "Desconto Crescente")
            {

            }
            else if (cbFiltrosSimples.Text == "Desconto Decrescente")
            {

            }
            else if (cbFiltrosAvancados.Text == "Clientes que Mais Compraram")
            {

            }
            else if (cbFiltrosAvancados.Text == "Clientes que Menos Compraram")
            {

            }
            else if (cbFiltrosAvancados.Text == "5 Clientes que Mais Compraram")
            {

            }
            else if (cbFiltrosAvancados.Text == "5 Clientes que Menos Compraram")
            {

            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            QualFiltroEstaSelecionado();
        }
    }
}
