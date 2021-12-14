﻿using Augustus_Fashion.Model.Funcionário;
using Augustus_Fashion.Model.Produto;
using Augustus_Fashion.ValueObjects;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Augustus_Fashion.DAO
{
    class ProdutoDAO
    {
        public static void CadastrarProduto(ProdutoModel produto)
        {
            var queryProduto = @"insert into Produto (CodBarra, Nome, PrecoVenda, PrecoCusto, Estoque,
            StatusProduto, Fabricante) values(@CodBarra, @Nome, @PrecoVenda, @PrecoCusto, @Estoque,
            @StatusProduto, @Fabricante)";

            try
            {
                var conexao = new conexao().Connection();
                {
                    conexao.Open();
                    using (var transacao = conexao.BeginTransaction())
                    {
                        conexao.Execute(queryProduto, new
                        {
                            CodBarra = produto.CodBarra,
                            Nome = produto.Nome,
                            PrecoVenda = produto.PrecoVenda.RetornarValorEmDecimal(),
                            PrecoCusto = produto.PrecoCusto.RetornarValorEmDecimal(),
                            Estoque = produto.Estoque,
                            StatusProduto = produto.StatusProduto,
                            Fabricante = produto.Fabricante,
                        }, transacao);
                        transacao.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<ProdutoListagem> ListarProduto()
        {
            var query = @"select IdProduto, Nome, PrecoVenda, Estoque, Fabricante,
            StatusProduto, PrecoCusto from Produto
            where StatusProduto = '1'";

            try
            {
                var conexao = new conexao().Connection();
                {
                    conexao.Open();
                    return conexao.Query<ProdutoListagem>(query).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<ProdutoListagem> ListarTodosOsProdutos()
        {

            var query = @"select IdProduto, Nome, PrecoVenda, Estoque, Fabricante, StatusProduto from Produto";

            try
            {
                var conexao = new conexao().Connection();
                {
                    conexao.Open();
                    return conexao.Query<ProdutoListagem>(query).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static ProdutoModel Buscar(int id)
        {
            var query = @"select IdProduto, CodBarra, Nome, PrecoVenda, PrecoCusto, Estoque, StatusProduto, Fabricante
            from Produto where IdProduto = @IdProduto";

            try
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();

                    return conexao.QueryFirstOrDefault<ProdutoModel>(query, new { IdProduto = id });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<ProdutoListagem> BuscarLista(string nome)
        {
            var query = @"select IdProduto, CodBarra, Nome, PrecoVenda, PrecoCusto, Estoque, StatusProduto, Fabricante from
            Produto where Nome like @Nome + '%'";

            try
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();

                    var parametros = new DynamicParameters();
                    parametros.Add("Nome", nome, System.Data.DbType.String);

                    var resultado = conexao.Query<ProdutoListagem>(query, parametros).ToList();
                    return resultado;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void ExcluirProduto(ProdutoModel produtoModel)
        {
            var query = @"delete from Produto where IdProduto = @IdProduto";

            try
            {
                var conexao = new conexao().Connection();
                {
                    conexao.Open();
                    conexao.Query<ProdutoModel>(query, new { IdProduto = produtoModel.IdProduto });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void AlterarProduto(ProdutoModel produto)
        {
            var query = @"update Produto set Nome = @Nome, CodBarra = @CodBarra, PrecoVenda = @PrecoVenda,
            PrecoCusto = @PrecoCusto, Estoque = @Estoque, StatusProduto = @StatusProduto, Fabricante = @Fabricante
            where IdProduto = @IdProduto";

            try
            {
                var conexao = new conexao().Connection();
                {
                    conexao.Open();
                    conexao.Query<ProdutoModel>(query, new
                    {
                        IdProduto = produto.IdProduto,
                        CodBarra = produto.CodBarra,
                        Nome = produto.Nome,
                        PrecoVenda = produto.PrecoVenda.RetornarValorEmDecimal(),
                        PrecoCusto = produto.PrecoCusto.RetornarValorEmDecimal(),
                        Estoque = produto.Estoque,
                        StatusProduto = produto.StatusProduto,
                        Fabricante = produto.Fabricante,
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static decimal ObterLucro(int idPedido)
        {
            string query = @"SELECT Lucro from Pedido where IdPedido = @idPedido";

            try
            {
                using (var conexao = new conexao().Connection()) 
                {
                    conexao.Open();
                    var a = conexao.Query<decimal>(query, new { idPedido }).FirstOrDefault();
                    return a;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message) ;
            }
        }
    }
}