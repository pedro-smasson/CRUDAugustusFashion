using Augustus_Fashion.ValueObjects;

namespace Augustus_Fashion.Model.Produto
{
    public class ProdutoModel
    {
        public int IdProduto { get; set; }
        public string CodBarra { get; set; }
        public string Nome { get; set; }
        public Dinheiro PrecoVenda { get; set; }
        public Dinheiro PrecoCusto { get; set; }
        public int Estoque { get; set; }
        public bool StatusProduto { get; set; }
        public string Fabricante { get; set; }
    }
}