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
        public int Desconto { get; set; }

        public double PrecoLiquido 
        { 
            get => PrecoBruto - Desconto;
        }

 /* total abaixo */
        public double PrecoFinal
        {
            get => PrecoLiquido * QuantidadeProduto;
        }

    }
}
