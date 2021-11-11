namespace Augustus_Fashion.Model.Produto
{
    class ProdutoModel
    {
        public int IdProduto { get; set; }
        public int CodBarra { get; set; }
        public string Nome { get; set; }
        public string PrecoVenda { get; set; }
        public string PrecoCusto { get; set; }
        public int Estoque { get; set; }
        public string StatusProduto { get; set; }
        public string Fabricante { get; set; }
    }
}
