using Augustus_Fashion.ValueObjects;

namespace Augustus_Fashion.Model.Relatorios
{
    public class RelatorioClienteModel
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public int NumeroDePedidos { get; set; }
        public Dinheiro TotalBruto { get; set; }
        public decimal TotalDesconto { get; set; }
        public Dinheiro TotalGasto { get; set; }
    }
}
