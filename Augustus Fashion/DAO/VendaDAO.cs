using Augustus_Fashion.Model.Venda;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Augustus_Fashion.DAO
{
    class VendaDAO
    {
        public static void CadastrarVenda(PedidoModel pedido, List<PedidoProdutoModel> produtoPedido)
        {
            var queryPedido = @"insert into Pedido (IdFuncionario, IdCliente, TotalBruto, TotalLiquido, Desconto, 
            PrecoFinal, FormaDePagamento, QuantidadeProduto, Lucro) output inserted.IdPedido values (@IdFuncionario, 
            @IdCliente, @PrecoBruto, @PrecoLiquido, @TotalDesconto, @PrecoTotal, @FormaDePagamento, @QuantidadeProduto,
            @Lucro)";

            var queryVenda = @"insert into Venda (IdPedido, IdProduto, PrecoVenda, QuantidadeProduto, Desconto, Total)
            values (@IdPedido, @IdProduto, @PrecoLiquido, @QuantidadeProduto, @Desconto, @PrecoFinal)";

            var queryAlterarEstoque = @"update Produto set Estoque -= @QuantidadeProduto where IdProduto = @IdProduto";

            try
            {
                var conexao = new conexao().Connection();
                {
                    conexao.Open();
                    using (var transacao = conexao.BeginTransaction())
                    {
                        var idPedido = Convert.ToInt32(conexao.ExecuteScalar(queryPedido, pedido, transacao).ToString());
                        foreach (var carrinho in produtoPedido)
                        {
                            carrinho.IdPedido = idPedido;
                            conexao.Execute(queryVenda, carrinho, transacao);
                            conexao.Execute(queryAlterarEstoque, carrinho, transacao);
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
            var query = @"select p.Nome as NomeProduto, ped.TotalBruto as PrecoBruto, ped.TotalLiquido as
            PrecoLiquido, v.Total as PrecoFinal, v.QuantidadeProduto, v.Desconto from Venda v
            inner join Produto as p on v.IdProduto = p.IdProduto
            inner join Pedido as ped on ped.IdPedido = v.IdPedido
            where v.IdPedido = @IdPedido";

            try
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();
                    var a = conexao.Query<PedidoProdutoModel>(query, new { IdPedido = id }).ToList();

                    return a;
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

        public static void AlterarVenda(PedidoModel pedido, List<PedidoProdutoModel> produtoPedido)
        {
            var queryPedido = @"update Pedido set IdFuncionario = @IdFuncionario, IdCliente = @IdCliente,
            TotalBruto = @PrecoBruto, TotalLiquido = @PrecoLiquido, Desconto = @TotalDesconto, PrecoFinal = @PrecoTotal,
            FormaDePagamento = @FormaDePagamento, QuantidadeProduto = @QuantidadeProduto, Lucro = @Lucro
            where IdPedido = @IdPedido";

            var queryVendaJaExistente = @"update Venda set IdPedido = @IdPedido, IdProduto = @IdProduto, 
            PrecoVenda = @PrecoLiquido, QuantidadeProduto = @QuantidadeProduto, Desconto = @Desconto, Total = @PrecoFinal
            where IdVenda = @IdVenda";

            var queryVenda = @"insert into Venda (IdPedido, IdProduto, PrecoVenda, QuantidadeProduto, Desconto, Total)
            values (@IdPedido, @IdProduto, @PrecoLiquido, @QuantidadeProduto, @Desconto, @PrecoFinal)";

            var queryAlterarEstoque = @"update Produto set Estoque -= @QuantidadeProduto where IdProduto = @IdProduto";

            try
            {
                var conexao = new conexao().Connection();
                {
                    conexao.Open();
                    using (var transacao = conexao.BeginTransaction())
                    {
                        conexao.Execute(queryPedido, pedido, transacao);
                        foreach (var carrinho in produtoPedido)
                        {
                            if (carrinho.IdPedido == 0)
                            {
                                carrinho.IdPedido = pedido.IdPedido;
                                conexao.Execute(queryVenda, carrinho, transacao);
                                conexao.Execute(queryAlterarEstoque, carrinho, transacao);
                            }
                            else
                            {
                                conexao.Execute(queryVendaJaExistente, carrinho, transacao);
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
    }
}
