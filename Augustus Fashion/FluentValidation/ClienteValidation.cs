using Augustus_Fashion.Model;
using FluentValidation;

namespace Augustus_Fashion.FluentValidation
{
    public class ClienteValidation : AbstractValidator<ClienteModel>
    {
        public ClienteValidation() 
        {
            RuleFor(x => x).SetValidator(new PessoaValidation());
            RuleFor(x => x).SetValidator(new LimiteValidation());
        }
    }
}
