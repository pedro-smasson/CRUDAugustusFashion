using Augustus_Fashion.Controller;
using Augustus_Fashion.Model.Produto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Augustus_Fashion.View.Produto
{
    public partial class ListarProduto : Form
    {
        ProdutoControl _produtoControl = new ProdutoControl();
        ProdutoModel _produtoModel = new ProdutoModel();

        public ListarProduto()
        {
            InitializeComponent();
        }

        private void ListarProduto_Load(object sender, EventArgs e)
        {
            dgvProduto.DataSource = _produtoControl.ListarProduto();
        }

        private void buscarNome_Click(object sender, EventArgs e)
        {
            dgvProduto.DataSource = _produtoControl.BuscarLista(txtNome.Text);

            if (txtNome.Text == "%")
            {
                dgvProduto.DataSource = _produtoControl.ListarProduto();
                txtNome.Text = "";
            }
        }
    }
}
