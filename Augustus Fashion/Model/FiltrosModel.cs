using Augustus_Fashion.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Augustus_Fashion.Model
{
    class FiltrosModel
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public Dinheiro TotalGasto { get; set; }
        public int NumeroDePedidos { get; set; }
        public decimal Desconto { get; set; }
        public DateTime DataPedido { get; set; }
    }
}
