using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Augustus_Fashion.Model.Venda
{
    public class PedidoModel
    {
        public int IdPedido { get; set; }
        public int IdFuncionario { get; set; }
        public int IdCliente { get; set; }
        public string FormaDePagamento { get; set; }
        public float PrecoBruto { get; set; }
        public decimal Desconto { get; set; }
        public int QuantidadeProduto { get; set; }
        public double PrecoLiquido 
        {
            get => PrecoBruto - Convert.ToInt32(Desconto);
        }
        public double PrecoFinal 
        { 
            get => PrecoLiquido * QuantidadeProduto;
        }
    }
}
