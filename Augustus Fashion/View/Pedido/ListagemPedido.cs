using Augustus_Fashion.Controller;
using Augustus_Fashion.Model.Venda;
using System;
using System.Windows.Forms;

namespace Augustus_Fashion.View.Pedido
{
    public partial class ListagemPedido : Form
    {
        VendaControl _vendaControl = new VendaControl();
        ListagemVendaModel _listagemVendaModel = new ListagemVendaModel();

        public ListagemPedido()
        {
            InitializeComponent();
        }

        private void ListagemPedido_Load(object sender, EventArgs e)
        {
            dgvPedido.DataSource = _vendaControl.ListarPedidos();
        }

        private void buscarId_Click(object sender, EventArgs e)
        {
            //dgvPedido.DataSource = _vendaControl.BuscarLista(Convert.ToInt32(txtBuscarID.Text));

            if(txtBuscarID.Text == "%") 
            {
                dgvPedido.DataSource = _vendaControl.ListarPedidos();
                txtBuscarID.Text = "";
            }
        }
    }
}
