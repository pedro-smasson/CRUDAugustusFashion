using System;
using System.Linq;

namespace Augustus_Fashion.ValueObjects
{
    public class CPF
    {
        private string _cpf;

        public CPF(string input) 
        {
            _cpf = input;
        }

        public string CpfFormatado
        {
            get => Convert.ToInt32(_cpf).ToString(@"000.000.000-00");
        }

        public string LimparCpfFormatado()
        {
            string cpfSemFormatacao = _cpf;

            cpfSemFormatacao = new string((from c in cpfSemFormatacao where char.IsDigit(c) select c).ToArray());
            return cpfSemFormatacao;
        }

        public string RetornarCpf { get => _cpf; }
        public static implicit operator CPF(string input) => new CPF(input);

        public override string ToString()
        {
            return _cpf;
        }
    }
}
//jkdsa
