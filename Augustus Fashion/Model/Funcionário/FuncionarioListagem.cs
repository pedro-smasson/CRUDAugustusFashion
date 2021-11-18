using System;

namespace Augustus_Fashion.Model
{
    class FuncionarioListagem
    {
        //public int IdPessoa { get; set; }
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string Celular { get; set; }
        public DateTime Nascimento { get; set; }
        public EnderecoModel Endereco { get; set; }
    }
}
