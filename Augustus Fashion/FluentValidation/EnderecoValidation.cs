using Augustus_Fashion.Model;
using FluentValidation;

namespace Augustus_Fashion.FluentValidation
{
    public class EnderecoValidation : AbstractValidator<EnderecoModel>
    {
        public EnderecoValidation()
        {
            RuleFor(x => x.Cep).SetValidator(new CEPValidation());
        }
    }
}