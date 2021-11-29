using System;
using System.Linq;

namespace Augustus_Fashion.ValueObjects
{
    public class Dinheiro
    {
        private decimal _dinheiro;

        public Dinheiro()
        {

        }

        public Dinheiro(decimal input)
        {
            _dinheiro = input;
        }

        public Dinheiro(string input)
        {
            _dinheiro = Convert.ToDecimal(RemoverFormatacaoPrivate(input));
        }

        private string RemoverFormatacaoPrivate(string param)
        {
            string dinheiroFormatado = param;

            dinheiroFormatado = new string((from c in dinheiroFormatado where char.IsDigit(c) || c == ',' || c == '.' select c).ToArray());
            return dinheiroFormatado;
        }

        public override string ToString()
        {
            return _dinheiro.ToString("c");
        }

        public static decimal RemoverFormatacao(string input) 
        {
            input = new string((from c in input where char.IsDigit(c) || c == ',' select c).ToArray());
            return Convert.ToDecimal(input == "" ? "0" : input);
        } 

        public decimal RetornarValorEmDecimal() 
        {
            return _dinheiro;
        }

        public static implicit operator Dinheiro(decimal input) => new Dinheiro(input);
        public static implicit operator Dinheiro(string input) => new Dinheiro(input);
    }
}
