using System.ComponentModel;

namespace Augustus_Fashion.Enum
{
    public enum FiltrosSimples
    {
        [Description("order by ")]
        ProdutoMaisVendido,
        [Description("order by ")]
        ProdutoMenosVendido,
        [Description("order by Estoque asc")]
        MaiorEstoque,
        [Description("")]
        MenorEstoque,
        [Description("")]
        VendaMaisRentavel,
        [Description("")]
        VendaMenosRentavel
    }
}
