namespace Augustus_Fashion.Model.Funcionário
{
    class ProdutoListagem
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public decimal PrecoVenda { get; set; }
        public int Estoque { get; set; }
        public string Fabricante { get; set; }
        private bool StatusProduto { get; set; }

        public string Status { get { return StatusProduto ? "Ativo" : "Inativo"; } set { } }
    }
}