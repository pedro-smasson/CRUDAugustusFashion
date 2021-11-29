using System;
using System.Linq;

namespace Augustus_Fashion.Model.Venda
{
    public static class ValidarPreco
    {
        public static decimal DecimalOuZero(this string valor)
        {
            decimal.TryParse(valor.Replace(".", ","), out decimal resultado);
            return resultado;
        }
    }
}