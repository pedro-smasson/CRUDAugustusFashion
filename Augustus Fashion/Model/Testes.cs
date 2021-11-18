using System;
using System.Text.RegularExpressions;

namespace Augustus_Fashion.Model
{
    public static class Testes
    {
        public static bool ValidarString(this string valor) => 
            new Regex(@"^[a-zA-ZÀ-úÀ-ÿ\s]+$").Match(valor).Success;

        public static bool ValidarNumeric(this string valor) => 
            new Regex(@"^[0-9,.]+$").Match(valor).Success;

        public static bool ValidarCpf(this string valor) => 
            new Regex(@"^[0-9]{3}[.][0-9]{3}[.][0-9]{3}[-][0-9]{2}$").Match(valor).Success;

        public static bool ValidarEmail(this string valor) => 
            new Regex(@"^[a-zA-Z0-9._-]+[@][a-z]+[.]([a-zA-Z]{2,3})+$").Match(valor).Success;

        public static bool ValidarDataNasc(this string valor) =>
            new Regex(@"^[0-3][0-9][\/][0-1][0-9][\/][0-9]{4}$").Match(valor).Success;

        public static bool ValidarStringENumeric(this string valor) =>
            new Regex(@"^[0-9a-zA-ZÀ-úÀ-ÿ\s]+$").Match(valor).Success;

        public static bool ValidarCep(this string valor) =>
            new Regex(@"^[0-9]{2}[.][0-9]{3}[-][0-9]{3}$").Match(valor).Success;

        public static bool ValidarComissao(this string valor) =>
            new Regex(@"^[0-9]+[%]$").Match(valor).Success;

        public static bool ValidarCelular(this string valor) =>
            new Regex(@"^[0-9]{11}$").Match(valor).Success;

        public static bool ValidarDesconto(this float valor) =>
            new Regex(@"^[0-9]+[%]$").Match(Convert.ToString(valor)).Success;
    }
}