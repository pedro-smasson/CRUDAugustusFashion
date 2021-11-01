using System;

namespace Augustus_Fashion.Model
{
    public class FuncionarioModel : Pessoa
    {

        public string salario { get; set; }
        public string comissao { get; set; }
        public string agencia { get; set; }
        public string numConta { get; set; }
        public string codConta { get; set; }
    }
}
