using Augustus_Fashion.ValueObjects;
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
        public bool StatusPedido { get; set; }
        public string Status { get { return StatusPedido ? "1" : "0"; } set { } }


        public Dinheiro PrecoBruto
        {
            get => Produtos.Sum(produto => produto.PrecoBruto.ToDecimal());
        }

        public Dinheiro TotalDesconto
        {
            get => Produtos.Sum(produto => produto.Desconto.ToDecimal());
        }

        public int QuantidadeProduto
        {
            get => Produtos.Sum(produto => produto.QuantidadeProduto);
        }

        public Dinheiro PrecoLiquido
        {
            get => PrecoBruto.ToDecimal() - TotalDesconto.ToDecimal();
        }

        public Dinheiro PrecoTotal
        {
            get => PrecoLiquido.ToDecimal() * QuantidadeProduto;
        }

        public Dinheiro Lucro 
        {
            get => Produtos.Sum(produto => (produto.PrecoLiquido.ToDecimal() - produto.PrecoCusto.ToDecimal()) * produto.QuantidadeProduto);
        }

        public Dinheiro PrecoASerExibidoNoFinal() 
        {
            return Produtos.Sum(produto => produto.PrecoFinal.ToDecimal());
        }

        public List<PedidoProdutoModel> Produtos { get; set; }

        public void AdicionarProduto(PedidoProdutoModel produto)
        {
            Produtos.Add(produto);
        }
    }
}