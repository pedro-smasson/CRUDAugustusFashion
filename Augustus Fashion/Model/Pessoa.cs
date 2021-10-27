using System;

namespace Augustus_Fashion.Model
{
    public abstract class Pessoa
    {
        public string cep { get; set; }
        public string rua { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string complemento { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public string cpf { get; set; }
        public int id { get; set; }
        public string nome { get; set; }
        public string sexo { get; set; }
        public DateTime nascimento { get; set; }

    }
}
