using System.Collections.Generic;
using System.Linq;

namespace Augustus_Fashion.Model.Venda
{
    public class PedidoModel
    {
        public PedidoModel()
        {
            Produtos = new List<PedidoProdutoModel>();
        }

        public int IdPedido { get; set; }
        public int IdFuncionario { get; set; }
        public int IdCliente { get; set; }
        public string FormaDePagamento { get; set; }

        public decimal PrecoBruto
        {
            get => Produtos.Sum(produto => produto.PrecoBruto);
        }

        public decimal TotalDesconto
        {
            get => Produtos.Sum(produto => produto.Desconto);
        }

        public int QuantidadeProduto
        {
            get => Produtos.Sum(produto => produto.QuantidadeProduto);
        }

        public decimal PrecoLiquido
        {
            get => PrecoBruto - TotalDesconto;
        }

        public decimal PrecoTotal
        {
            get => PrecoLiquido * QuantidadeProduto;
        }

        public decimal Lucro 
        {
            get => Produtos.Sum(produto => (produto.PrecoLiquido - produto.PrecoCusto) * produto.QuantidadeProduto);
        }

        public decimal PrecoASerExibidoNoFinal() 
        {
            return Produtos.Sum(produto => produto.PrecoFinal);
        }

        public List<PedidoProdutoModel> Produtos { get; set; }

        public void AdicionarProduto(PedidoProdutoModel produto)
        {
            Produtos.Add(produto);
        }
    }
}