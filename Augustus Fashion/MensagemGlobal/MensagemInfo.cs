using System.Windows.Forms;

namespace Augustus_Fashion.MensagemGlobal
{
    public class MensagemInfo : MensagemMae
    {
        public override void Mensagem(string msg) => MessageBox.Show(msg, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
