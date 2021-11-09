using Augustus_Fashion.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
