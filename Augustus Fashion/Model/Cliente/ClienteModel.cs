using Augustus_Fashion.FluentValidation;

namespace Augustus_Fashion.Model
{
   public class ClienteModel : Pessoa
    {
        public string Limite { get; set; }

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
