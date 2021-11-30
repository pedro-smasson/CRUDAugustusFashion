using Augustus_Fashion.ValueObjects;
using FluentValidation;

namespace Augustus_Fashion.FluentValidation
{
    public class DinheiroValidation : AbstractValidator<Dinheiro>
    {
        public DinheiroValidation() 
        {
            RuleFor(x => x.ToString()).Matches(@"^[R][$] [0-9]+[,][0-9]{2}$").WithMessage("Informe um valor válido!");
        }
    }
}
