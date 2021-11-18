using System;

namespace Augustus_Fashion.Model.Venda
{
    public class PedidoModel
    {
        public int IdPedido { get; set; }
        public int IdFuncionario { get; set; }
        public int IdCliente { get; set; }
        public string FormaDePagamento { get; set; }
        public decimal PrecoBruto { get; set; }
        public decimal Desconto { get; set; }
        public int QuantidadeProduto { get; set; }
        public decimal PrecoLiquido 
        {
            get => PrecoBruto - Desconto;
        }
        public decimal PrecoFinal 
        { 
            get => PrecoLiquido * QuantidadeProduto;
        }
    }
}