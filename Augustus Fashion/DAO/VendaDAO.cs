using Augustus_Fashion.Model.Venda;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Augustus_Fashion.DAO
{
    class VendaDAO
    {
        public static void CadastrarVenda(PedidoModel pedido)
        {
            var queryPedido = @"insert into Pedido (IdFuncionario, IdCliente, TotalBruto, TotalLiquido, Desconto, 
            PrecoFinal, FormaDePagamento, QuantidadeProduto, Lucro, DataPedido) output inserted.IdPedido values (@IdFuncionario, 
            @IdCliente, @PrecoBrutoTotalDoPedido, @PrecoLiquidoTotalDoPedido, @DescontoTotalDoPedido,
            @PrecoTotal, @FormaDePagamento, @QuantidadeProdutoTotalDoPedido, @Lucro, @DataPedido)";

            var queryVenda = @"insert into Venda (IdPedido, IdProduto, PrecoVenda, QuantidadeProduto, Desconto, Total)
            values (@IdPedido, @IdProduto, @PrecoLiquidoUnitario, @QuantidadeProduto, @DescontoUnitario, @PrecoLiquidoTotal)";

            var queryLimite = @"update Cliente set LimiteGasto += @PrecoTotal where IdCliente = @IdCliente";

            var queryAlterarEstoque = @"update Produto set Estoque -= @QuantidadeProdutoTotalDoPedido where IdProduto = @IdProduto";

            try
            {
                var conexao = new conexao().Connection();
                {
                    conexao.Open();
                    using (var transacao = conexao.BeginTransaction())
                    {
                        var idPedido = Convert.ToInt32(conexao.ExecuteScalar(queryPedido, new
                        {
                            pedido.IdFuncionario,
                            pedido.IdCliente,
                            pedido.FormaDePagamento,
                            pedido.QuantidadeProdutoTotalDoPedido,
                            PrecoBrutoTotalDoPedido = pedido.PrecoBrutoTotalDoPedido.RetornarValorEmDecimal(),
                            PrecoLiquidoTotalDoPedido = pedido.PrecoLiquidoTotalDoPedido.RetornarValorEmDecimal(),
                            DescontoTotalDoPedido = pedido.DescontoTotalDoPedido.RetornarValorEmDecimal(),
                            PrecoTotal = pedido.PrecoTotal.RetornarValorEmDecimal(),
                            Lucro = pedido.Lucro.RetornarValorEmDecimal(),
                            DataPedido = pedido.DataPedido.Date
                        }, transacao).ToString());

                        foreach (var pedidoProduto in pedido.Produtos)
                        {
                            pedidoProduto.IdPedido = idPedido;
                            conexao.Execute(queryVenda, new
                            {
                                pedidoProduto.IdPedido,
                                pedidoProduto.IdProduto,
                                pedidoProduto.QuantidadeProduto,
                                PrecoLiquidoUnitario = pedidoProduto.PrecoLiquidoUnitario.RetornarValorEmDecimal(),
                                DescontoUnitario = pedidoProduto.DescontoUnitario.RetornarValorEmDecimal(),
                                PrecoLiquidoTotal = pedidoProduto.PrecoLiquidoTotal.RetornarValorEmDecimal(),

                            }, transacao);
                            conexao.Execute(queryAlterarEstoque, new { pedidoProduto.IdProduto, pedido.QuantidadeProdutoTotalDoPedido }, transacao);
                        }
                        if (pedido.FormaDePagamento == "Á Prazo") 
                        {
                            conexao.Execute(queryLimite, new 
                            { 
                                pedido.IdCliente, 
                                PrecoTotal = pedido.PrecoTotal.RetornarValorEmDecimal()
                            }, transacao);
                        }
                        transacao.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void AlterarVenda(PedidoModel pedido)
        {
            var queryPedido = @"update Pedido set IdFuncionario = @IdFuncionario, IdCliente = @IdCliente,
            TotalBruto = @PrecoBrutoTotalDoPedido, TotalLiquido = @PrecoLiquidoTotalDoPedido, Desconto = @DescontoTotalDoPedido,
            PrecoFinal = @PrecoTotal, FormaDePagamento = @FormaDePagamento, QuantidadeProduto = @QuantidadeProdutoTotalDoPedido,
            Lucro = @Lucro
            where IdPedido = @IdPedido";

            var queryVendaJaExistente = @"update Venda set IdPedido = @IdPedido, IdProduto = @IdProduto, 
            PrecoVenda = @PrecoLiquidoUnitario, QuantidadeProduto = @QuantidadeProduto, Desconto = @DescontoUnitario,
            Total = @PrecoLiquidoTotal
            where IdVenda = @IdVenda";

            var queryVenda = @"insert into Venda (IdPedido, IdProduto, PrecoVenda, QuantidadeProduto, Desconto, Total)
            values (@IdPedido, @IdProduto, @PrecoLiquidoTotal, @QuantidadeProduto, @Desconto, @PrecoFinal)";

            var queryAlterarEstoque = @"update Produto set Estoque -= @QuantidadeProduto where IdProduto = @IdProduto";

            try
            {
                var conexao = new conexao().Connection();
                {
                    conexao.Open();
                    using (var transacao = conexao.BeginTransaction())
                    {
                        conexao.Execute(queryPedido, new
                        {
                            pedido.IdPedido,
                            pedido.IdFuncionario,
                            pedido.IdCliente,
                            pedido.FormaDePagamento,
                            pedido.QuantidadeProdutoTotalDoPedido,
                            PrecoBrutoTotalDoPedido = pedido.PrecoBrutoTotalDoPedido.RetornarValorEmDecimal(),
                            PrecoLiquidoTotalDoPedido = pedido.PrecoLiquidoTotalDoPedido.RetornarValorEmDecimal(),
                            DescontoTotalDoPedido = pedido.DescontoTotalDoPedido.RetornarValorEmDecimal(),
                            PrecoTotal = pedido.PrecoTotal.RetornarValorEmDecimal(),
                            Lucro = pedido.Lucro.RetornarValorEmDecimal(),
                        }, transacao);

                        foreach (var carrinho in pedido.Produtos)
                        {
                            if (carrinho.IdPedido == 0)
                            {
                                carrinho.IdPedido = pedido.IdPedido;
                                conexao.Execute(queryVenda, new
                                {
                                    carrinho.IdPedido,
                                    carrinho.IdProduto,
                                    carrinho.QuantidadeProduto,
                                    PrecoLiquidoTotal = carrinho.PrecoLiquidoUnitario.RetornarValorEmDecimal(),
                                    Desconto = carrinho.DescontoUnitario.RetornarValorEmDecimal(),
                                    PrecoFinal = carrinho.PrecoLiquidoTotal.RetornarValorEmDecimal()
                                }, transacao);
                                conexao.Execute(queryAlterarEstoque, carrinho, transacao);
                            }
                            else
                            {
                                conexao.Execute(queryVendaJaExistente, new
                                {
                                    carrinho.IdPedido,
                                    carrinho.IdProduto,
                                    carrinho.IdVenda,
                                    carrinho.QuantidadeProduto,
                                    PrecoLiquido = carrinho.PrecoLiquidoUnitario.RetornarValorEmDecimal(),
                                    Desconto = carrinho.DescontoUnitario.RetornarValorEmDecimal(),
                                    PrecoFinal = carrinho.PrecoLiquidoTotal.RetornarValorEmDecimal(),
                                    QuantidadeProdutoTotalDoPedido = carrinho.QuantidadeProduto
                                }, transacao);
                                conexao.Execute(queryAlterarEstoque, carrinho, transacao);
                            }
                        }
                        transacao.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<PedidoProdutoModel> BuscarProdutos(int id)
        {
            var query = @"select p.IdProduto, p.Nome as NomeProduto, p.PrecoCusto as PrecoCustoUnitario, v.Total as PrecoLiquidoUnitario,
            v.QuantidadeProduto, v.Desconto as DescontoUnitario, v.PrecoVenda as PrecoBrutoUnitario
            from Venda v
            inner join Produto as p on v.IdProduto = p.IdProduto
            where v.IdPedido = @IdPedido";

            try
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();
                    return conexao.Query<PedidoProdutoModel>(query, new { IdPedido = id }).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DesativarVenda(PedidoModel pedido)
        {
            var selectVenda = @"select IdProduto, QuantidadeProduto from Venda where IdPedido = @IdPedido";
            var queryPedido = @"delete from Pedido where IdPedido = @IdPedido";
            var queryVenda = @"delete from Venda where IdPedido = @IdPedido";
            var queryAlterarEstoque = @"update Produto set Estoque += @QuantidadeProduto where IdProduto = @IdProduto";
            try
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();
                    using (var transacao = conexao.BeginTransaction())
                    {
                        List<PedidoProdutoModel> produtoPedido = conexao.Query<PedidoProdutoModel>(selectVenda, new { pedido.IdPedido }, transacao).ToList();
                        foreach (var update in produtoPedido)
                        {
                            conexao.Execute(queryAlterarEstoque, update, transacao);
                        }
                        conexao.Execute(queryVenda, pedido, transacao);
                        conexao.Execute(queryPedido, pedido, transacao);
                        transacao.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<ListagemVendaModel> ListarPedidos()
        {
            var query = @"select p.IdPedido, p.QuantidadeProduto, p.PrecoFinal, p.Lucro, p.FormaDePagamento, 
            pec.Nome as NomeCliente, pef.Nome as NomeFuncionario from Pedido p
            inner join Cliente c on c.IdCliente = p.IdCliente 
            inner join Pessoa pec on pec.IdPessoa = c.IdPessoa 
            inner join Funcionario f on f.IdFuncionario = p.IdFuncionario
            inner join Pessoa pef on pef.IdPessoa = f.IdPessoa";

            try
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();

                    var listar = conexao.Query<ListagemVendaModel>(query);
                    return listar.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<ListagemVendaModel> BuscarLista(string nomeFuncionario, string nomeCliente)
        {
            var queryCliente = @"select p.IdPedido, p.QuantidadeProduto, p.PrecoFinal, p.Lucro, p.FormaDePagamento, 
            pec.Nome as NomeCliente, pef.Nome as NomeFuncionario from Pedido p
            inner join Cliente c on c.IdCliente = p.IdCliente 
            inner join Pessoa pec on pec.IdPessoa = c.IdPessoa 
            inner join Funcionario f on f.IdFuncionario = p.IdFuncionario
            inner join Pessoa pef on pef.IdPessoa = f.IdPessoa
            where (pec.Nome like @NomeCliente + '%') and (pef.Nome like @NomeFuncionario + '%')";

            try
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();

                    var listar = conexao.Query<ListagemVendaModel>(queryCliente, new
                    {
                        NomeFuncionario = nomeFuncionario,
                        NomeCliente = nomeCliente
                    });
                    return listar.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static PedidoModel Buscar(int id)
        {
            var query = @"select p.IdPedido, p.QuantidadeProduto, p.PrecoFinal, p.Lucro, p.FormaDePagamento, 
            pec.Nome as NomeCliente, c.IdCliente, f.IdFuncionario, pef.Nome as NomeFuncionario
            from Pedido p
            inner join Cliente c on c.IdCliente = p.IdCliente 
            inner join Pessoa pec on pec.IdPessoa = c.IdPessoa 
            inner join Funcionario f on f.IdFuncionario = p.IdFuncionario
            inner join Pessoa pef on pef.IdPessoa = f.IdPessoa where p.IdPedido = @IdPedido";

            try
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();

                    return conexao.Query<PedidoModel>(query, new { IdPedido = id }).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}