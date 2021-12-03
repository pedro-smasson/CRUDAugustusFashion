using Augustus_Fashion.FluentValidation;
using System;

namespace Augustus_Fashion.Model
{
   public class ClienteModel : Pessoa
    {
        public string Limite { get; set; }
        public string LimiteGasto { get; set; }

        public bool CalcularSeClienteTemLimiteDisponivel() 
        {
            if(Convert.ToDecimal(LimiteGasto) >= Convert.ToDecimal(Limite)) 
            {
                return false;
            }
            return true;
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