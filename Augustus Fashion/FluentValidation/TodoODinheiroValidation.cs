using Augustus_Fashion.Model.Venda;
using FluentValidation;

namespace Augustus_Fashion.FluentValidation
{
    public class TodoODinheiroValidation : AbstractValidator<PedidoModel>
    {
        public TodoODinheiroValidation() 
        {
            RuleFor(x => x.PrecoBrutoTotalDoPedido).SetValidator(new DinheiroValidation());
            RuleFor(x => x.PrecoLiquidoTotalDoPedido).SetValidator(new DinheiroValidation());
            RuleFor(x => x.DescontoTotalDoPedido).SetValidator(new DinheiroValidation());
            RuleFor(x => x.PrecoTotal).SetValidator(new DinheiroValidation());
            RuleFor(x => x.Lucro).SetValidator(new DinheiroValidation());
            RuleFor(x => x.PrecoASerExibidoNoFinal()).SetValidator(new DinheiroValidation());
        }
    }
}
