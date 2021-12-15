using System;

namespace Augustus_Fashion.Model
{
    public class ClienteListagem
    {
        //public int IdPessoa { get; set; }
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Celular { get; set; }
        public DateTime Nascimento { get; set; }
        public EnderecoModel Endereco { get; set; }
        public decimal Limite { get; set; }
        public decimal LimiteGasto { get; set; }
    }
}