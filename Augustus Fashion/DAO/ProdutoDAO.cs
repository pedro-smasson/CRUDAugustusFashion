using Augustus_Fashion.Model.Funcionário;
using Augustus_Fashion.Model.Produto;
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
                            produto.CodBarra,
                            produto.Nome,
                            produto.Estoque,
                            produto.StatusProduto,
                            produto.Fabricante,
                            PrecoVenda = produto.PrecoVenda.RetornarValorEmDecimal(),
                            PrecoCusto = produto.PrecoCusto.RetornarValorEmDecimal(),
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

            var query = @"select IdProduto, Nome, PrecoVenda, Estoque, Fabricante, StatusProduto, PrecoCusto from Produto";

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
                    conexao.Query<ProdutoModel>(query, new { produtoModel.IdProduto });
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
                        produto.IdProduto,
                        produto.CodBarra,
                        produto.Nome,
                        produto.Estoque,
                        produto.StatusProduto,
                        produto.Fabricante,
                        PrecoVenda = produto.PrecoVenda.RetornarValorEmDecimal(),
                        PrecoCusto = produto.PrecoCusto.RetornarValorEmDecimal(),
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}