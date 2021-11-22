using Augustus_Fashion.Model.Venda;
using Dapper;
using System;
using System.Collections.Generic;

namespace Augustus_Fashion.DAO
{
    class VendaDAO
    {
        public static void CadastrarVenda(PedidoModel pedido, List<PedidoProdutoModel> produtoPedido) 
        {
            var queryPedido = @"insert into Pedido (IdFuncionario, IdCliente, TotalBruto, TotalLiquido, Desconto, 
            PrecoFinal, FormaDePagamento, QuantidadeProduto) output inserted.IdPedido values (@IdFuncionario, 
            @IdCliente, @PrecoBruto, @PrecoLiquido, @TotalDesconto, @PrecoTotal, @FormaDePagamento, @QuantidadeProduto)";

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

        public static void ExcluirVenda(PedidoModel pedido, List<PedidoProdutoModel> produtoPedido) 
        {

        }
    }
}
