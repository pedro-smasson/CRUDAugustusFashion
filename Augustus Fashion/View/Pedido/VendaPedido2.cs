﻿using Augustus_Fashion.Controller;
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
    public partial class VendaPedido2 : Form
    {
        ClienteControl _clientecontrol = new ClienteControl();

        public VendaPedido2()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            dgvCliente.DataSource = _clientecontrol.BuscarLista(txtCliente.Text);

            if(txtCliente.Text == "%") 
            {
                dgvCliente.DataSource = _clientecontrol.ListarClientes();
                txtCliente.Text = "";
            }
        }

        private void VendaPedido2_Load(object sender, EventArgs e)
        {
            dgvCliente.DataSource = _clientecontrol.ListarClientes();
        }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var nome = dgvCliente.SelectedRows[0].Cells[1].Value;
            txtSelecionado.Text = nome.ToString();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            if(txtSelecionado.Text == "") 
            {
                MessageBox.Show("Selecione o Cliente!");
            }
            else 
            {
                this.Hide();
                VendaPedido3 telaVenda3 = new VendaPedido3();
                telaVenda3.ShowDialog();
                this.Show();
            }
            
        }
    }
}