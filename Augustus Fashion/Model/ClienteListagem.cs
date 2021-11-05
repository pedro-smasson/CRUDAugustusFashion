using System;

namespace Augustus_Fashion.Model
{
    public class ClienteListagem
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string Celular { get; set; }
        public DateTime Nascimento { get; set; }
        public EnderecoModel Endereco { get; set; }

        //public string EnderecoCompleto
        //{
        //    get
        //    {
        //        return cidade + cep + estado + rua + bairro;
        //    }
        //}
        //public Endereco Endereco { get; set; }

    }
}
