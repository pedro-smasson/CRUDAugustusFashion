using Augustus_Fashion.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Augustus_Fashion.FluentValidation
{
    public class LimiteValidation : AbstractValidator<ClienteModel>
    {
        public LimiteValidation() 
        {
            RuleFor(x => Convert.ToInt32(x.Limite)).LessThanOrEqualTo(50000).WithMessage("Insira um valor menor que 50000!");
            RuleFor(x => Convert.ToInt32(x.Limite)).GreaterThan(0).WithMessage("Insira um valor maior que 0!");
        }
    }
}
