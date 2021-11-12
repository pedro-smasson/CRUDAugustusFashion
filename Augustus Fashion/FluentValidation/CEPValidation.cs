using Augustus_Fashion.ValueObjects;
using FluentValidation;

namespace Augustus_Fashion.FluentValidation
{
    public class CEPValidation : AbstractValidator<CEP>
    {
        public CEPValidation()
        {
            RuleFor(x => x.ToString()).Matches(@"^[0-9]{2}[.][0-9]{3}[-][0-9]{3}$").WithMessage("Informe um CEP válido!");
        }

        //public static implicit operator CEPValidation(string input) => new CEPValidation();
    }
}
