using Augustus_Fashion.ValueObjects;
using System;

namespace Augustus_Fashion.Model
{
    class FiltrosClienteModel
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public Dinheiro TotalGasto { get; set; }
        public int NumeroDePedidos { get; set; }
        public decimal Desconto { get; set; }
        public DateTime DataPedido { get; set; }
    }
}
