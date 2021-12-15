using Augustus_Fashion.FluentValidation;
using Augustus_Fashion.ValueObjects;

namespace Augustus_Fashion.Model
{
    public class ClienteModel : Pessoa
    {
        public decimal Limite { get; set; }
        public decimal LimiteGasto { get; set; }

        public bool CalcularSeClienteTemLimiteDisponivel()
        {
            if (Limite > LimiteGasto)
            {
                return true;
            }
            return false;
        }

        public string ValidarCliente()
        {
            var resultado = new ClienteValidation().Validate(this);
            if (resultado.IsValid)
            {
                return string.Empty;
            }
            return resultado.ToString();
        }

    }
}