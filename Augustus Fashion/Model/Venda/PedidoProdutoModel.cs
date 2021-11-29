using Augustus_Fashion.ValueObjects;

namespace Augustus_Fashion.Model.Venda
{
    public class PedidoProdutoModel
    {
        public int IdPedido { get; set; }
        public int IdVenda { get; set; }
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public int QuantidadeProduto { get; set; }
        public Dinheiro PrecoCusto { get; set; }
        public Dinheiro PrecoBruto { get; set; }
        public Dinheiro Desconto { get; set; }

        public Dinheiro PrecoLiquido 
        { 
            get => PrecoBruto.ToDecimal() - Desconto.ToDecimal();
        }

        public Dinheiro PrecoFinal
        {
            get => (PrecoLiquido.ToDecimal() * QuantidadeProduto);
        }

    }
}