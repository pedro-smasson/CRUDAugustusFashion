using Augustus_Fashion.Model.Venda;
using FluentValidation;

namespace Augustus_Fashion.FluentValidation
{
    public class TodoODinheiroValidation : AbstractValidator<PedidoModel>
    {
        public TodoODinheiroValidation() 
        {
            RuleFor(x => x.PrecoBruto).SetValidator(new DinheiroValidation());
            RuleFor(x => x.PrecoLiquido).SetValidator(new DinheiroValidation());
            RuleFor(x => x.TotalDesconto).SetValidator(new DinheiroValidation());
            RuleFor(x => x.PrecoTotal).SetValidator(new DinheiroValidation());
            RuleFor(x => x.Lucro).SetValidator(new DinheiroValidation());
            RuleFor(x => x.PrecoASerExibidoNoFinal()).SetValidator(new DinheiroValidation());
        }
    }
}
