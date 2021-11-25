namespace Augustus_Fashion.Model.Venda
{
    public class ListagemVendaModel
    {
        public int IdPedido { get; set; }
        public string NomeFuncionario { get; set; }
        public string NomeCliente { get; set; }
        public int QuantidadeProduto { get; set; }
        public decimal PrecoFinal { get; set; }
        public decimal Lucro { get; set; }
        public string FormaDePagamento { get; set; }
    }
}
