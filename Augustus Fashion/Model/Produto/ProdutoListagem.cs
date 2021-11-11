using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Augustus_Fashion.Model.Funcionário
{
    class ProdutoListagem
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public int PrecoVenda { get; set; }
        public int Estoque { get; set; }
        public string Fabricante { get; set; }
        public string StatusProduto { get; set; }
    }
}
