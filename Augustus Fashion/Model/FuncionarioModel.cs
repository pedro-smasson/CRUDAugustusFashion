using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Augustus_Fashion.Model
{
    class FuncionarioModel : Pessoa
    {

        public string salario { get; set; }
        public string comissao { get; set; }
        public string agencia { get; set; }
        public string numConta { get; set; }
        public string codConta { get; set; }
    }
}
