using System;

namespace Augustus_Fashion.Model
{
    public abstract class Pessoa
    {
        public Pessoa()
        {
            Endereco = new EnderecoModel();
        }

        public string Celular { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public DateTime Nascimento { get; set; }

        public EnderecoModel Endereco { get; set; }
    }
}
