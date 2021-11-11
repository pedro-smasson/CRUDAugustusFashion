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
    public partial class TelaCliente : Form
    {
        public TelaCliente()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            cadastroCliente cc = new cadastroCliente();
            cc.ShowDialog();
            Close();   
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Hide();
            ListarCliente lc = new ListarCliente();
            lc.ShowDialog();
            Close();
        }
    }
}
