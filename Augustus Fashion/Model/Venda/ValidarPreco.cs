using System;
using System.Linq;

namespace Augustus_Fashion.Model.Venda
{
    public static class ValidarPreco
    {

        public static string RemoverFormatacaoDoPreco(string valor)
        {
            string precoSemFormatacao = valor;

            precoSemFormatacao = new string
            ((from caractere in precoSemFormatacao where char.IsDigit(caractere) select caractere).ToArray());

            var precoCorreto = (Convert.ToDecimal(precoSemFormatacao) / 100);
            return precoCorreto.ToString();
        }
    }
}