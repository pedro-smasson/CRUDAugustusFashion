﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Augustus_Fashion.Model.Venda
{
    public class CarrinhoModel
    {
        public int IdCarrinho { get; set; }
        public string NomeProduto { get; set; }
        public int QuantidadeProduto { get; set; }
        public float PrecoVenda { get; set; }
        public int Desconto { get; set; }

        public double PrecoFinal
        {
            get => (PrecoVenda * QuantidadeProduto) * Desconto / 100;
        }

    }
}