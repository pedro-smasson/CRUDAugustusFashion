using Augustus_Fashion.Model;
using FluentValidation;

namespace Augustus_Fashion.FluentValidation
{
    public class PessoaValidation : AbstractValidator<Pessoa>
    {
        public PessoaValidation() 
        {
            RuleFor(x=> x.Endereco).SetValidator(new EnderecoValidation());
            RuleFor(x=> x.Cpf).SetValidator(new CPFValidation());
        }
    }
}
