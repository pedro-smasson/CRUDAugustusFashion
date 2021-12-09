using System.ComponentModel;

namespace Augustus_Fashion.Enum
{
    public enum FiltrosSimples
    {
        [Description("order by ")]
        ProdutoMaisVendido,
        [Description("")]
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
