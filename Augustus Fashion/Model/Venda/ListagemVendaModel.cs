using Augustus_Fashion.ValueObjects;

namespace Augustus_Fashion.Model.Venda
{
    public class ListagemVendaModel
    {
        public int IdPedido { get; set; }
        public string NomeFuncionario { get; set; }
        public string NomeCliente { get; set; }
        public int QuantidadeProduto { get; set; }
        public Dinheiro PrecoFinal { get; set; }
        public Dinheiro Lucro { get; set; }
        public string FormaDePagamento { get; set; }
    }
}
