using Augustus_Fashion.FluentValidation;
using Augustus_Fashion.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using Augustus_Fashion.MensagemGlobal;

namespace Augustus_Fashion.Model.Venda
{
    public class PedidoModel
    {
        MensagemErro _mensagemErro = new MensagemErro();

        public PedidoModel()
        {
            Produtos = new List<PedidoProdutoModel>();
        }

        public bool CalcularSeClienteTemLimiteDisponivel(decimal input)
        {
            if (Limite > LimiteGasto + input)
            {
                return true;
            }
            _mensagemErro.Mensagem("Erro! Tentativa de compra excede o Limite do Cliente!");
            return false;
        }

        public int IdPedido { get; set; }
        public int IdFuncionario { get; set; }
        public int IdCliente { get; set; }
        public decimal Limite { get; set; }
        public decimal LimiteGasto { get; set; }
        public DateTime DataPedido { get; set; }
        public string FormaDePagamento { get; set; }
        public bool StatusPedido { get; set; }
        public string Status { get { return StatusPedido ? "1" : "0"; } set { } }


        public Dinheiro PrecoBrutoTotalDoPedido
        {
            get => Produtos.Sum(produto => produto.PrecoBrutoTotal.RetornarValorEmDecimal());
        }

        public Dinheiro DescontoTotalDoPedido
        {
            get => Produtos.Sum(produto => produto.DescontoUnitario.RetornarValorEmDecimal());
        }

        public int QuantidadeProdutoTotalDoPedido
        {
            get => Produtos.Sum(produto => produto.QuantidadeProduto);
        }

        public Dinheiro PrecoLiquidoTotalDoPedido
        {
            get => Produtos.Sum(produto => produto.PrecoLiquidoUnitario.RetornarValorEmDecimal());
        }

        public Dinheiro PrecoTotal
        {
            get => Produtos.Sum(produto => produto.PrecoLiquidoTotal.RetornarValorEmDecimal()); set { }
        }

        public Dinheiro Lucro
        {
            get => Produtos.Sum(produto => (produto.PrecoLiquidoTotal.RetornarValorEmDecimal()
            - produto.PrecoCustoUnitario.RetornarValorEmDecimal()));
        }

        public Dinheiro PrecoASerExibidoNoFinal()
        {
            return Produtos.Sum(produto => produto.PrecoLiquidoTotal.RetornarValorEmDecimal());
        }

        public List<PedidoProdutoModel> Produtos { get; set; }

        public void AdicionarProduto(PedidoProdutoModel produto) => Produtos.Add(produto);

        public string ValidarDinheiro()
        {
            var resultado = new TodoODinheiroValidation().Validate(this);
            if (resultado.IsValid)
            {
                return string.Empty;
            }
            return resultado.ToString();
        }
    }
}