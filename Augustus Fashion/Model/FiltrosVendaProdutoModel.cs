using Augustus_Fashion.ValueObjects;
using System;

namespace Augustus_Fashion.Model
{
    public class FiltrosVendaProdutoModel
    {
        public class Produto 
        {
            public int IdProduto { get; set; }
            public int Estoque { get; set; }
            public string Nome { get; set; }
            public string Fabricante { get; set; }
            public Dinheiro Total { get; set; }
        }

        public class Venda 
        {
            public int IdPedido { get; set; }
            public Dinheiro PrecoFinal { get; set; }
            public Dinheiro Lucro { get; set; }
            public DateTime DataPedido { get; set; }
        }

        public class Especifico 
        {
            public int IdProduto { get; set; }
            public int Quantidade { get; set; }
            public string Nome { get; set; }
        }
    }
}
