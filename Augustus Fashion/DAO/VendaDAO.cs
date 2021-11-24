using Augustus_Fashion.Model.Venda;
using Augustus_Fashion.View.Pedido;
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
            @IdCliente, @PrecoBruto, @PrecoLiquido, @TotalDesconto, @PrecoTotal, @FormaDePagamento, @QuantidadeProduto, @Lucro)";

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
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DesativarVenda(PedidoModel pedido, List<PedidoProdutoModel> produtoPedido) 
        {

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
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<ListagemVendaModel> BuscarLista(string nome) 
        {
            var query = @"select p.IdPedido, p.QuantidadeProduto, p.PrecoFinal, p.Lucro, p.FormaDePagamento, 
            pec.Nome as NomeCliente, pef.Nome as NomeFuncionario from Pedido p
            inner join Cliente c on c.IdCliente = p.IdCliente 
            inner join Pessoa pec on pec.IdPessoa = c.IdPessoa 
            inner join Funcionario f on f.IdFuncionario = p.IdFuncionario
            inner join Pessoa pef on pef.IdPessoa = f.IdPessoa where (pec.Nome like @Nome + '%') or 
            (pef.Nome like @Nome + '%')";

            try 
            {
                using (var conexao = new conexao().Connection()) 
                {
                    conexao.Open();

                    var listar = conexao.Query<ListagemVendaModel>(query, new { Nome = nome });
                    return listar.ToList();
                }
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public static PedidoModel Buscar(int id) 
        {
            var query = @"select p.IdPedido, p.QuantidadeProduto, p.PrecoFinal, p.Lucro, p.FormaDePagamento, 
            pec.Nome as NomeCliente, pef.Nome as NomeFuncionario from Pedido p
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
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
