using Augustus_Fashion.ValueObjects;
using System;

namespace Augustus_Fashion.Model
{
    public class FiltrosProdutoModel
    {
        public int IdCliente { get; set; }
        public string NomeProduto { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }

        public string Where()
        {
            var queryWhere = " where p.DataPedido between @DataInicial and @DataFinal + ' 23:59' ";

            if (IdCliente != 0)
            {
                queryWhere += " and p.IdCliente = @IdCliente ";
            }
            return queryWhere;
        }

        public string Having()
        {
            var queryHaving = " having pec.Nome like @NomeProduto + '%' ";

            if (String.IsNullOrEmpty(NomeProduto))
            {
                queryHaving = "";
            }
            return queryHaving;
        }
    }
}
