using Augustus_Fashion.ValueObjects;
using System.Collections.Generic;

namespace Augustus_Fashion.Model
{
    public class EnderecoModel
    {

        List<string> _mensagens;
        public EnderecoModel()
        {
            _mensagens = new List<string>();
        }

        public int IdPessoa { get; set; }
        public int IdEndereco { get; set; }
        public CEP Cep { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Complemento { get; set; }


        public override string ToString()
        {
            return $" Rua: {Rua}, Cep: {Cep}, Número: {Numero}, Bairro: {Bairro}, Cidade: {Cidade}, " +
                $"Estado: {Estado}, Complemento: {Complemento}";
        }
    }
}
