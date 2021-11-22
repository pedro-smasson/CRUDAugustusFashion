using System;
using System.Linq;

namespace Augustus_Fashion.Model.Venda
{
    public static class ValidarPreco
    {
        public static double DoubleOuZero(this string valor)
        {
            double.TryParse(valor.Replace(".", ","), out double resultado);
            return resultado;
        }

        public static decimal DecimalOuZero(this string valor)
        {
            decimal.TryParse(valor.Replace(".", ","), out decimal resultado);
            return resultado;
        }

        public static string RemoverFormatacaoDoPreco(this string valor)
        {
            string precoSemFormatacao = valor;

            precoSemFormatacao = new string
            ((from caractere in precoSemFormatacao where char.IsDigit(caractere) select caractere).ToArray());

            var precoCorreto = (Convert.ToDecimal(precoSemFormatacao));
            return precoCorreto.ToString();
        }
    }
}