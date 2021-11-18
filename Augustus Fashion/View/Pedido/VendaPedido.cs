using Augustus_Fashion.Controller;
using Augustus_Fashion.Model.Venda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Augustus_Fashion.View.Pedido
{    
    public partial class VendaPedido : Form
    {
        FuncionarioControl _funcionariocontrol = new FuncionarioControl();

        PedidoModel _pedido = new PedidoModel();

        public VendaPedido()
        {
            InitializeComponent();
        }

        public int SelecionarFuncionarioModel()
        {
            int id = Convert.ToInt32(dgvFuncionario.SelectedRows[0].Cells[1].Value);
            return id;
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            dgvFuncionario.DataSource = _funcionariocontrol.BuscarLista(txtFuncionario.Text);

            if (txtFuncionario.Text == "%")
            {
                dgvFuncionario.DataSource = _funcionariocontrol.ListarFuncionarios();
                txtFuncionario.Text = "";
            }
        }

        private void VendaPedido_Load(object sender, EventArgs e)
        {
            dgvFuncionario.DataSource = _funcionariocontrol.ListarFuncionarios();
        }

        private void txtSelecionado_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvFuncionario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var nome = dgvFuncionario.SelectedRows[0].Cells[1].Value;
            txtSelecionado.Text = nome.ToString();

            _pedido.IdFuncionario = (int)dgvFuncionario.SelectedRows[0].Cells[0].Value;
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            if (txtSelecionado.Text == "") 
            {
                MessageBox.Show("Selecione o Funcionário");
            }
            else 
            {
                this.Hide();
                VendaPedido2 telaVenda2 = new VendaPedido2(_pedido.IdFuncionario);
                telaVenda2.ShowDialog();
                this.Show();
                //Close();
            }

        }
    }
}
