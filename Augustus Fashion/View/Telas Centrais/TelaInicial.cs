using Augustus_Fashion.View.Produto;
using Augustus_Fashion.View.Telas_Centrais;
using System;
using System.Windows.Forms;

namespace Augustus_Fashion.View
{

    public partial class telaInicial : Form
    {

        public telaInicial()
        {
            InitializeComponent();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            cadastroCliente cc = new cadastroCliente();
            cc.ShowDialog();
            this.Close();
        }

        private void fUNCIONÁRIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            CadastroFuncionario cf = new CadastroFuncionario();
            cf.ShowDialog();
            this.Close();
        }

        private void FecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cLIENTESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            ListarCliente lc = new ListarCliente();
            lc.ShowDialog();
            this.Close();
        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            AlterarCliente ac = new AlterarCliente();
            ac.ShowDialog();
            this.Close();
        }

        private void eXCLUIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fUNCIONÁRIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            AlterarFuncionario af = new AlterarFuncionario();
            af.ShowDialog();
            this.Close();
        }

        private void fUNCIONÁRIOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            ListarFuncionario lf = new ListarFuncionario();
            lf.ShowDialog();
            this.Close();
        }

        //private void pictureBox1_Click(object sender, EventArgs e)
        //{
        //    Hide();
        //    cadastroCliente cc = new cadastroCliente();
        //    cc.ShowDialog();
        //    this.Close();
        //}

        //private void pictureBox5_Click(object sender, EventArgs e)
        //{
        //    Hide();
        //    CadastroFuncionario cf = new CadastroFuncionario();
        //    cf.ShowDialog();
        //    this.Close();
        //}

        //private void pictureBox2_Click(object sender, EventArgs e)
        //{
        //    Hide();
        //    ListarCliente lc = new ListarCliente();
        //    lc.ShowDialog();
        //    this.Close();
        //}

        //private void pictureBox6_Click(object sender, EventArgs e)
        //{
        //    Hide();
        //    ListarFuncionario lf = new ListarFuncionario();
        //    lf.ShowDialog();
        //    this.Close();
        //}

        //private void pictureBox3_Click(object sender, EventArgs e)
        //{
        //    Hide();
        //    AlterarCliente ac = new AlterarCliente();
        //    ac.ShowDialog();
        //    this.Close();
        //}

        //private void pictureBox7_Click(object sender, EventArgs e)
        //{
        //    Hide();
        //    AlterarFuncionario af = new AlterarFuncionario();
        //    af.ShowDialog();
        //    this.Close();
        //}

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            CadastroProduto cp = new CadastroProduto();
            cp.ShowDialog();
            Close();

        }

        private void eSTOQUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            ListarProduto lp = new ListarProduto();
            lp.ShowDialog();
            Close();
        }

        private void pbCliente_Click(object sender, EventArgs e)
        {
            Hide();
            TelaCliente tc = new TelaCliente();
            tc.ShowDialog();
            Close();
        }

        private void pbProduto_Click(object sender, EventArgs e)
        {
            Hide();
            TelaProduto tp = new TelaProduto();
            tp.ShowDialog();
            Close();
        }

        private void pbFuncionario_Click(object sender, EventArgs e)
        {
            Hide();
            TelaFuncionario tf = new TelaFuncionario();
            tf.ShowDialog();
            Close();
        }
    }
}
