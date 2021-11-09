using System;
using Augustus_Fashion.ValueObjects;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Augustus_Fashion.Model
{
    public class EnderecoModel
    {
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
            return $" Rua: {Rua}, Cep: {Cep.ToString()}, Número: {Numero}, Bairro: {Bairro}, Cidade: {Cidade}, Estado: {Estado}, Complemento: {Complemento}";
        }
    }
}
