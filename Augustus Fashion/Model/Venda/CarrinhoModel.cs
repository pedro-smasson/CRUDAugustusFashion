using System;

namespace Augustus_Fashion.Model.Venda
{
    public class CarrinhoModel
    {
        public int IdPedido { get; set;  }
        public int IdProduto { get; set;  }
        public int IdCarrinho { get; set; }
        public string NomeProduto { get; set; }
        public int QuantidadeProduto { get; set; }
        public float PrecoBruto { get; set; }
        public decimal Desconto { get; set; }

        public double PrecoLiquido 
        { 
            get => PrecoBruto - Convert.ToInt32(Desconto);
        }

        public decimal PrecoFinal
        {
            get => (decimal)(PrecoLiquido * QuantidadeProduto);
        }

    }
}
