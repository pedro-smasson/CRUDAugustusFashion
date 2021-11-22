namespace Augustus_Fashion.Model.Venda
{
    public class PedidoProdutoModel
    {
        public int IdPedido { get; set; }
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public int QuantidadeProduto { get; set; }
        public decimal PrecoCusto { get; set; }
        public decimal PrecoBruto { get; set; }
        public decimal Desconto { get; set; }

        public decimal PrecoLiquido 
        { 
            get => PrecoBruto - Desconto;
        }

        public decimal PrecoFinal
        {
            get => (PrecoLiquido * QuantidadeProduto);
        }

    }
}