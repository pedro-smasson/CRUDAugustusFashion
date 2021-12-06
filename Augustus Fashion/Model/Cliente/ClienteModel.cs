using Augustus_Fashion.FluentValidation;
using Augustus_Fashion.ValueObjects;
using System;

namespace Augustus_Fashion.Model
{
   public class ClienteModel : Pessoa
    {
        public string Limite { get; set; }
        public Dinheiro LimiteGasto { get; set; }

        public bool CalcularSeClienteTemLimiteDisponivel() 
        {
            if(Convert.ToDecimal(this.LimiteGasto) < Convert.ToDecimal(this.Limite)) 
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