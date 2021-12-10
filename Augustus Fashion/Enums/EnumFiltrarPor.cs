using System.ComponentModel;

namespace Augustus_Fashion.Enums
{
    public enum EnumFiltrarPor
    {
        [Description("  ")]
        Nome = -1,
        [Description(" Count(p.IdPedido) ")]
        Quantidade,
        [Description(" Sum(p.Desconto) ")]
        Desconto,
        [Description(" Sum(p.TotalLiquido) ")]
        PrecoLiquido
    }
}
