using System.Windows.Forms;

namespace Augustus_Fashion.MensagemGlobal
{
    public class MensagemErro : MensagemMae
    {
        public override void Mensagem(string msg) => MessageBox.Show(msg, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
