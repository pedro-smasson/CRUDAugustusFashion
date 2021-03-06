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
            var query = @" select pro.Nome, Sum(v.QuantidadeProduto) as Quantidade, Sum(p.TotalBruto) as TotalBruto,
            Sum(v.Desconto * v.QuantidadeProduto) as Desconto,
            pro.PrecoCusto as PrecoCusto, Sum(p.Lucro) as Lucro, pro.IdProduto from Pedido p
			inner join Cliente c on c.IdCliente = p.IdCliente
            inner join Pessoa pec on pec.IdPessoa = c.IdPessoa 
			inner join Venda v on v.IdPedido = p.IdPedido
			inner join Produto pro on pro.IdProduto = v.IdProduto";

            query += filtrosProdutoModel.Where();
            query += @" group by pro.Nome, pro.IdProduto, pro.PrecoCusto ";
            query += filtrosProdutoModel.Having();

            try
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();
                    var listar = conexao.Query<RelatorioProdutosModel>(query, new
                    {
                        filtrosProdutoModel.IdProduto,
                        DataInicial = filtrosProdutoModel.DataInicial.Date,
                        DataFinal = filtrosProdutoModel.DataFinal.Date,
                        filtrosProdutoModel.NomeProduto
                    });
                    return listar.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<RelatorioClienteModel> QueryFiltragemClientes(FiltrosClienteModel filtrosClienteModel)
        {
            var query = @"select ";

            query += filtrosClienteModel.Top();

            query += @"c.IdPessoa, pec.Nome, Count(p.IdPedido) as NumeroDePedidos, Sum(p.TotalBruto) as TotalBruto,
            Sum(p.Desconto) as TotalDesconto, Sum(p.PrecoFinal) as TotalGasto
            from Pedido p
            inner join Cliente c on c.IdCliente = p.IdCliente
            inner join Pessoa pec on pec.IdPessoa = c.IdPessoa
            where c.IdCliente = p.IdCliente and p.DataPedido between @DataInicial and @DataFinal + ' 23:59' 
            group by c.IdPessoa, pec.Nome";

            query += filtrosClienteModel.Having();
            query += filtrosClienteModel.OrderBy();
            query += filtrosClienteModel.OrdemCrescenteOuDecrescente();

            try
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();
                    var listar = conexao.Query<RelatorioClienteModel>(query, filtrosClienteModel);
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