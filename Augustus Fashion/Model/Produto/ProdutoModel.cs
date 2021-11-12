namespace Augustus_Fashion.Model.Produto
{
    public class ProdutoModel
    {
        public int IdProduto { get; set; }
        public string CodBarra { get; set; }
        public string Nome { get; set; }
        public string PrecoVenda { get; set; }
        public string PrecoCusto { get; set; }
        public int Estoque { get; set; }
        public bool StatusProduto { get; set; }
        public string Fabricante { get; set; }
        //public bool Ativo { get; set; }
    }
}
