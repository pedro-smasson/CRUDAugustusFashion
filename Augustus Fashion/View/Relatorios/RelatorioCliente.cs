using Augustus_Fashion.Controller;
using Augustus_Fashion.Model;
using System;
using System.Windows.Forms;

namespace Augustus_Fashion.View.Relatorios
{
    public partial class RelatorioCliente : Form
    {
        ClienteControl _clienteController = new ClienteControl();
        FiltrosControl _filtrosController = new FiltrosControl();
        FiltrosClienteModel _filtrosModel = new FiltrosClienteModel();

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

        private void RelatorioCliente_Load(object sender, EventArgs e)
        {
            dgvCliente.DataSource = _clienteController.ListarClientes();
        }

        private void FiltrosPreenchidos() 
        {


            _filtrosModel.OrdenarPor = (Enums.EnumOrdenarPor)cbOrdenarPor.SelectedIndex;
            _filtrosModel.FiltrarPor = (Enums.EnumFiltrarPor)cbFiltrarPor.SelectedIndex;

            _filtrosModel.DataInicial = dtpDataInicial.Value;
            _filtrosModel.DataFinal = dtpDataFinal.Value;

            _filtrosModel.Ordem = cbCrescenteOuDecrescente.Text;
            _filtrosModel.QuantidadeClientes = dudCliente.SelectedIndex;
            _filtrosModel.APartir = dudValorInicial.SelectedIndex;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if(!Validacoes.VerificarSeDataInicialEhMaiorQueDataFinal(dtpDataInicial.Value, dtpDataFinal.Value)) 
            {
                FiltrosPreenchidos();
                dgvCliente.DataSource = _filtrosController.QueryFiltragemCliente(_filtrosModel);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            
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

        private void btnData_Click(object sender, EventArgs e)
        {
            //btnData.Visible = false;
            //btnValor.Visible = false;
            //btnBuscar.Visible = true;
            //label4.Visible = true;
            //mtDataFinal.Visible = true;
            //mtDataInicial.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //if (mtDataInicial.MaskFull && mtDataFinal.MaskFull)
            //{
            //    //dgvCliente.DataSource = _filtrosController.EspecificarData(Convert.ToDateTime(mtDataInicial.Text),
            //    //Convert.ToDateTime(mtDataFinal.Text));

            //    this.dgvCliente.Columns["IdCliente"].Visible = false;
            //    this.dgvCliente.Columns["Desconto"].Visible = false;
            //    this.dgvCliente.Columns["NumeroDePedidos"].Visible = false;
            //}
        }

        //private void btnValor_Click(object sender, EventArgs e)
        //{
        //    btnData.Visible = false;
        //    btnValor.Visible = false;
        //    txtValor1.Visible = true;
        //    txtValor2.Visible = true;
        //    label4.Visible = true;
        //    btnBuscar2.Visible = true;
        //}

        //private void btnBuscar2_Click(object sender, EventArgs e)
        //{
        //    if (Validacoes.ValidarNumeric(txtValor1.Text) && Validacoes.ValidarNumeric(txtValor2.Text))
        //    {
        //        //dgvCliente.DataSource = _filtrosController.EspecificarValor(Convert.ToDecimal(txtValor1.Text),
        //        //Convert.ToDecimal(txtValor2.Text));
        //    }
        //    else
        //    {
        //        MessageBox.Show("Informe apenas Números!");
        //    }
        //}
    }
}