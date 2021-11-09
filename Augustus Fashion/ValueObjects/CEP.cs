using System;
using System.Linq;

namespace Augustus_Fashion.ValueObjects
{
    public class CEP
    {
        private string _cep;

        public CEP(string input) 
        {
            _cep = input;
        }

        public string CepFormatado
        {
            get => Convert.ToInt32(_cep).ToString(@"00000-000");
        }

        public string LimparCepFormatado() 
        {
            string cepSemFormatacao = _cep;

            cepSemFormatacao = new string((from c in cepSemFormatacao where char.IsDigit(c) select c).ToArray());
            return cepSemFormatacao;
        }

        public string RetornarCep { get => _cep; }
        public static implicit operator CEP(string input) => new CEP(input);

        public override string ToString()
        {
            return _cep;
        }
    }
}
