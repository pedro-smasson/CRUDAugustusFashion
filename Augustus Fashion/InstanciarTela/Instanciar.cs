using Augustus_Fashion.View;
using System.Windows.Forms;

namespace Augustus_Fashion.InstanciarTela
{
    public class Instanciar
    {
        public static void TelaInicial() 
        {
            telaInicial telaInicial = new telaInicial();
            telaInicial.ShowDialog();
        }

        public static void LimparCampos(Control componentes) 
        {
            foreach(var item in componentes.Controls) 
            {
                Limpar((Control)item);
            }
        }

        private static void Limpar(Control item)
        {
            if(item is TextBox || item is MaskedTextBox)
            {
                item.Text = string.Empty;
            }
            else if(item is DateTimePicker picker) 
            {
                picker.Value = System.DateTime.Today;
            }
            else if(item is NumericUpDown valor) 
            {
                valor.Value = 0;
            }
            else if(item is ComboBox campo) 
            {
                campo.SelectedIndex = -1;
            }
            else if(item is RadioButton radioButton) 
            {
                radioButton.Checked = false;
            }
            else if (item is CheckBox checkBox) 
            {
                checkBox.Checked = false;
            }
            else if (item is GroupBox)
            {
                LimparCampos(item);
            }
        }
    }
}