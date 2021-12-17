using Augustus_Fashion.ValueObjects;

namespace Augustus_Fashion.Model.Relatorios
{
    class RelatorioProdutosModel
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        //public Dinheiro TotalBruto { get; set; }
        public decimal Desconto { get; set; }
        public Dinheiro TotalLiquido { get; set; }
        public Dinheiro PrecoCusto { get; set; }
        public Dinheiro Lucro { get; set; }
    }
}