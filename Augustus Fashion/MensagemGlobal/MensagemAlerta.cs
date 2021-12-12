using System.Windows.Forms;

namespace Augustus_Fashion.MensagemGlobal
{
    public class MensagemAlerta : MensagemMae
    {
        public override void Mensagem(string msg) => MessageBox.Show(msg, "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
