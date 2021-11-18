using Augustus_Fashion.View.Pedido;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Augustus_Fashion.View.Telas_Centrais
{
    public partial class TelaPedido : Form
    {
        public TelaPedido()
        {
            InitializeComponent();
        }

        private void pctCadastro_Click(object sender, EventArgs e)
        {
            Hide();
            VendaPedido efetuarVenda = new VendaPedido();
            efetuarVenda.ShowDialog();
            Close();
        }

        private void pctLista_Click(object sender, EventArgs e)
        {
            Hide();
            ListagemPedido listarPedido = new ListagemPedido();
            listarPedido.ShowDialog();
            Close();
        }
    }
}
