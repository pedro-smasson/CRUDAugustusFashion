using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Augustus_Fashion.Model
{
    public class ClienteListagem
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cidade { get; set; }
        public string celular { get; set; }
        public DateTime nascimento { get; set; }
    }
}
