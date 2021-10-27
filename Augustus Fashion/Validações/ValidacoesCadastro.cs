using System.Text.RegularExpressions;


namespace Augustus_Fashion.Validações
{
    public static class ValidacoesCadastro
    {
        public static bool ValidarString(this string valor) => new Regex(@"^[a-zA-Z]+$").Match(valor).Success;
        public static bool ValidarNumeric(this string valor) => new Regex(@"^[0-9]+").Match(valor).Success;
    }
}
