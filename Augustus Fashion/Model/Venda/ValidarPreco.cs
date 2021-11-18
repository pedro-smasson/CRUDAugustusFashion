using System;
using System.Linq;

namespace Augustus_Fashion.Model.Venda
{
    public static class ValidarPreco
    {

        public static string RemoverFormatacaoDoPreco(string valor)
        {
            string precoSemFormatacao = valor;

            precoSemFormatacao = new string((from c in precoSemFormatacao
                                             where char.IsDigit(c)
                                             select c).ToArray());

            var precoCorreto = (Convert.ToInt32(precoSemFormatacao) / 100);
            return precoCorreto.ToString();
        }
    }
}
