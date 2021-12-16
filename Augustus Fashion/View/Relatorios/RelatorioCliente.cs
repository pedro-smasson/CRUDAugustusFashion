using Augustus_Fashion.Controller;
using Augustus_Fashion.InstanciarTela;
using Augustus_Fashion.MensagemGlobal;
using Augustus_Fashion.Model;
using Augustus_Fashion.Model.Relatorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Augustus_Fashion.View.Relatorios
{
    public partial class RelatorioCliente : Form
    {
        FiltrosControl _filtrosController = new FiltrosControl();
        FiltrosClienteModel _filtrosModel = new FiltrosClienteModel();
        MensagemErro _mensagemErro = new MensagemErro();

        public RelatorioCliente()
        {
            InitializeComponent();
            cbOrdenarPor.DropDownWidth = DropDownWidth(cbOrdenarPor);
            cbFiltrarPor.DropDownWidth = DropDownWidth(cbFiltrarPor);
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

        private void FiltrosPreenchidos()
        {
            _filtrosModel.OrdenarPor = (Enums.EnumOrdenarPor)cbOrdenarPor.SelectedIndex;
            _filtrosModel.FiltrarPor = (Enums.EnumFiltrarPor)cbFiltrarPor.SelectedIndex;

            _filtrosModel.DataInicial = dtpDataInicial.Value;
            _filtrosModel.DataFinal = dtpDataFinal.Value;

            _filtrosModel.Ordem = cbCrescenteOuDecrescente.Text;
            _filtrosModel.QuantidadeClientes = (int)nudCliente.Value;
            _filtrosModel.APartir = nudValorInicial.Value;
        }

        private void Totalizadores(List<RelatorioClienteModel> total)
        {
            lblNumeroDePedidos.Text = total.Sum(x => (x.NumeroDePedidos)).ToString();
            lblTotalBruto.Text = total.Sum(x => (x.TotalBruto.RetornarValorEmDecimal())).ToString("c");
            lblTotalGasto.Text = total.Sum(x => (x.TotalGasto.RetornarValorEmDecimal())).ToString("c");
            lblTotalDesconto.Text = total.Sum(x => (x.TotalDesconto)).ToString();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacoes.VerificarSeDataInicialEhMaiorQueDataFinal(dtpDataInicial.Value, dtpDataFinal.Value))
                {
                    FiltrosPreenchidos();
                    var filtrarCliente = _filtrosController.QueryFiltragemCliente(_filtrosModel);
                    dgvCliente.DataSource = filtrarCliente;
                    Totalizadores(filtrarCliente);
                    dgvCliente.Columns["IdCliente"].Visible = false;

                    dgvCliente.Columns[1].HeaderText = "Nome";
                    dgvCliente.Columns[2].HeaderText = "Número de Pedidos";
                    dgvCliente.Columns[3].HeaderText = "Total Bruto";
                    dgvCliente.Columns[4].HeaderText = "Total Desconto";
                    dgvCliente.Columns[5].HeaderText = "Total Gasto";
                }
                else
                {
                    _mensagemErro.Mensagem("A Data Inicial é maior que a Data Final!");
                    dtpDataInicial.Value = DateTime.Today;
                }
            }
            catch
            {
                _mensagemErro.Mensagem("Erro na filtragem!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e) => Limpar();

        private void Limpar()
        {
            dtpDataInicial.Value = DateTime.Today;
            dtpDataFinal.Value = DateTime.Today;
            cbCrescenteOuDecrescente.Text = "";
            cbFiltrarPor.Text = "";
            cbOrdenarPor.Text = "";
            nudCliente.Value = 0;
            nudValorInicial.Value = 0;
        }

        private void fECHARToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Instanciar.TelaInicial();
            Close();
        }
    }
}