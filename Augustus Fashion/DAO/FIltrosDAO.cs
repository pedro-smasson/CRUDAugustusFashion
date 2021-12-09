using Augustus_Fashion.Model;
using Augustus_Fashion.Model.Relatorios;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Augustus_Fashion.DAO
{
    class FiltrosDAO
    {
        public static List<RelatorioProdutosModel> QueryFiltragemProduto(FiltrosProdutoModel filtrosProdutoModel)
        {
            var query = @" select pec.Nome, Sum(p.QuantidadeProduto) as Quantidade, Sum(p.TotalBruto) as TotalBruto, Sum(p.Desconto) as Desconto,
			Sum(p.TotalLiquido) as TotalLiquido, Sum(pro.PrecoCusto) as PrecoCusto, Sum(p.Lucro) as Lucro,
            c.IdCliente from Pedido p
			inner join Cliente c on c.IdCliente = p.IdCliente
            inner join Pessoa pec on pec.IdPessoa = c.IdPessoa 
			inner join Venda v on v.IdPedido = p.IdPedido
			inner join Produto pro on pro.IdProduto = v.IdProduto";

            query += filtrosProdutoModel.Where();
            query += @" group by pec.Nome, c.IdCliente ";
            query += filtrosProdutoModel.Having();

            try
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();
                    var listar = conexao.Query<RelatorioProdutosModel>(query);
                    return listar.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}