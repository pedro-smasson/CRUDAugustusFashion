using System;

namespace Augustus_Fashion.Model
{
    public class FuncionarioModel : Pessoa
    {
        public string Salario { get; set; }
        public string Comissao { get; set; }
        public string Agencia { get; set; }
        public string NumConta { get; set; }
        public string CodConta { get; set; }
    }
}