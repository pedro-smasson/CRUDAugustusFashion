using System;

namespace Augustus_Fashion.Model
{
    public class FiltrosProdutoModel
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }

        public string Where()
        {
            var queryWhere = " where p.DataPedido between @DataInicial and @DataFinal + ' 23:59' ";

            if (IdProduto != 0)
            {
                queryWhere += " and pro.IdProduto = @IdProduto ";
            }
            return queryWhere;
        }

        public string Having()
        {
            var queryHaving = " having pro.Nome like @NomeProduto + '%' ";

            if (String.IsNullOrEmpty(NomeProduto))
            {
                queryHaving = "";
            }
            return queryHaving;
        }
    }
}
