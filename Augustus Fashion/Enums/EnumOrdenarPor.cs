using System.ComponentModel;

namespace Augustus_Fashion.Enums
{
    public enum EnumOrdenarPor
    {
        [Description("  ")]
        Nome = -1,
        [Description(" order by Sum(p.QuantidadeProduto) ")]
        Quantidade,
        [Description(" order by Sum(p.Desconto) ")]
        Desconto,
        [Description(" order by Sum(p.PrecoFinal) ")]
        PrecoLiquido
    }
}
