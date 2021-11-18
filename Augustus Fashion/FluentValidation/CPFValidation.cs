using Augustus_Fashion.ValueObjects;
using FluentValidation;

namespace Augustus_Fashion.FluentValidation
{
    public class CPFValidation : AbstractValidator<CPF>
    {
        public CPFValidation() 
        {
            RuleFor(x => x.ToString()).Matches(@"^[0-9]{3}[.][0-9]{3}[.][0-9]{3}[-][0-9]{2}$")
                .WithMessage("Informe um CPF válido!");
        }
    }
}