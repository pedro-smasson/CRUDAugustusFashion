using System.ComponentModel;

namespace Augustus_Fashion.Enums
{
    public enum EnumFiltrarPor
    {
        [Description(" Count(p.IdPedido) ")]
        Quantidade,
        [Description(" Sum(p.Desconto) ")]
        Desconto,
        [Description(" Sum(p.TotalLiquido) ")]
        PrecoLiquido
    }
}
