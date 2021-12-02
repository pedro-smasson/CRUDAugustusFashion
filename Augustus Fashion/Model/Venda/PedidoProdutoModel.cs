using Augustus_Fashion.ValueObjects;

namespace Augustus_Fashion.Model.Venda
{
    public class PedidoProdutoModel
    {
        public PedidoProdutoModel()
        {
            PrecoCustoUnitario = new Dinheiro();
            PrecoBrutoUnitario = new Dinheiro();
            DescontoUnitario = new Dinheiro();
        }

        public int IdPedido { get; set; }
        public int IdVenda { get; set; }
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public int QuantidadeProduto { get; set; }

        public Dinheiro PrecoCustoUnitario { get; set; }

        public Dinheiro DescontoUnitario { get; set; }

        public Dinheiro PrecoBrutoUnitario { get; set; }
        public Dinheiro PrecoBrutoTotal { get => PrecoBrutoUnitario.RetornarValorEmDecimal() * QuantidadeProduto; }
        

        public Dinheiro PrecoLiquidoUnitario
        { 
            get => PrecoBrutoUnitario.RetornarValorEmDecimal() - DescontoUnitario.RetornarValorEmDecimal();
        }
        public Dinheiro PrecoLiquidoTotal
        {
            get => (PrecoLiquidoUnitario.RetornarValorEmDecimal() * QuantidadeProduto);
        }

    }
}