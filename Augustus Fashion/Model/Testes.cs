using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Augustus_Fashion.Model
{
    public static class Testes
    {
        public static bool ValidarString(this string valor) => 
            new Regex(@"^[a-zA-Z]+$").Match(valor).Success;

        public static bool ValidarNumeric(this string valor) => 
            new Regex(@"^[0-9]+$").Match(valor).Success;

        public static bool validarCpf(this string valor) => 
            new Regex(@"^[0-9]{3}[.][0-9]{3}[.][0-9]{3}[-][0-9]{2}$").Match(valor).Success;

        public static bool validarEmail(this string valor) => 
            new Regex(@"^[a-zA-Z0-9._-]+[@][a-z]+[.]([a-zA-Z]{2,3})+$").Match(valor).Success;

        public static bool validarDataNasc(this string valor) =>
            new Regex(@"^[0-3][0-9][\/][0-1][0-9][\/][0-9]{4}$").Match(valor).Success;

        public static bool validarStringENumeric(this string valor) =>
            new Regex(@"^[0-9a-zA-Z\s]+$").Match(valor).Success;

        public static bool validarCep(this string valor) =>
            new Regex(@"^[0-9]{2}[.][0-9]{3}[-][0-9]{3}$").Match(valor).Success;

        public static bool validarComissao(this string valor) =>
            new Regex(@"^[0-9]+[%]$").Match(valor).Success;

        public static bool validarCelular(this string valor) =>
            new Regex(@"^[0-9]{11}$").Match(valor).Success;
    }
}
