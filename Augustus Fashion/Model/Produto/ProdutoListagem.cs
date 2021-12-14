using Augustus_Fashion.ValueObjects;

namespace Augustus_Fashion.Model.Funcionário
{
    public class ProdutoListagem
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public Dinheiro PrecoVenda { get; set; }
        public Dinheiro PrecoCusto { get; set; }
        public int Estoque { get; set; }
        public string Fabricante { get; set; }
        private bool StatusProduto { get; set; }

        public string Status { get { return StatusProduto ? "Ativo" : "Inativo"; } set { } }
    }
}