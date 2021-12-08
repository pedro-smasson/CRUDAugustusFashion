using Augustus_Fashion.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Augustus_Fashion.DAO
{
    class FiltrosDAO
    {

        public static List<FiltrosClienteModel> QuantidadeDePedidosCrescente()
        {
            var query = @"select pec.Nome, Sum(p.PrecoFinal) as TotalGasto, Count(p.IdPedido) as NumeroDePedidos, c.IdCliente
            from Pedido p
			inner join Cliente c on c.IdCliente = p.IdCliente
            inner join Pessoa pec on pec.IdPessoa = c.IdPessoa       
            where c.IdPessoa = pec.IdPessoa
			group by pec.Nome, c.IdCliente order by NumeroDePedidos asc";

            try
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();
                    var listar = conexao.Query<FiltrosClienteModel>(query);
                    return listar.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<FiltrosClienteModel> QuantidadeDePedidosDecrescente()
        {
            var query = @"select pec.Nome, Sum(p.PrecoFinal) as TotalGasto, Count(p.IdPedido) as NumeroDePedidos, c.IdCliente
            from Pedido p
			inner join Cliente c on c.IdCliente = p.IdCliente
            inner join Pessoa pec on pec.IdPessoa = c.IdPessoa       
            where c.IdPessoa = pec.IdPessoa
			group by pec.Nome, c.IdCliente order by NumeroDePedidos desc";

            try
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();
                    var listar = conexao.Query<FiltrosClienteModel>(query);
                    return listar.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<FiltrosClienteModel> TotalLiquidoCrescente()
        {
            var query = @"select pec.Nome, Sum(p.PrecoFinal) as TotalGasto, c.IdCliente
            from Pedido p
			inner join Cliente c on c.IdCliente = p.IdCliente
            inner join Pessoa pec on pec.IdPessoa = c.IdPessoa       
            where c.IdPessoa = pec.IdPessoa
			group by pec.Nome, c.IdCliente order by TotalGasto asc";

            try
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();
                    var listar = conexao.Query<FiltrosClienteModel>(query);
                    return listar.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<FiltrosClienteModel> TotalLiquidoDecrescente()
        {
            var query = @"select pec.Nome, Sum(p.PrecoFinal) as TotalGasto, c.IdCliente
            from Pedido p
			inner join Cliente c on c.IdCliente = p.IdCliente
            inner join Pessoa pec on pec.IdPessoa = c.IdPessoa       
            where c.IdPessoa = pec.IdPessoa
			group by pec.Nome, c.IdCliente order by TotalGasto desc";

            try
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();
                    var listar = conexao.Query<FiltrosClienteModel>(query);
                    return listar.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<FiltrosClienteModel> DescontoCrescente()
        {
            var query = @"select pec.Nome, Sum(p.PrecoFinal) as TotalGasto, Count(p.IdPedido) as NumeroDePedidos,
            Sum(p.Desconto) as Desconto, c.IdCliente
            from Pedido p
			inner join Cliente c on c.IdCliente = p.IdCliente
            inner join Pessoa pec on pec.IdPessoa = c.IdPessoa       
            where c.IdPessoa = pec.IdPessoa
			group by pec.Nome, c.IdCliente order by Desconto asc";

            try
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();
                    var listar = conexao.Query<FiltrosClienteModel>(query);
                    return listar.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<FiltrosClienteModel> DescontoDecrescente()
        {
            var query = @"select pec.Nome, Sum(p.PrecoFinal) as TotalGasto, Count(p.IdPedido) as NumeroDePedidos,
            Sum(p.Desconto) as Desconto, c.IdCliente
            from Pedido p
			inner join Cliente c on c.IdCliente = p.IdCliente
            inner join Pessoa pec on pec.IdPessoa = c.IdPessoa       
            where c.IdPessoa = pec.IdPessoa
			group by pec.Nome, c.IdCliente order by Desconto desc";

            try
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();
                    var listar = conexao.Query<FiltrosClienteModel>(query);
                    return listar.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<FiltrosClienteModel> Top5ClientesQueMaisGastaram()
        {
            var query = @"select top 5 pec.Nome, Sum(p.PrecoFinal) as TotalGasto, c.IdCliente
			from Pedido p
			inner join Cliente c on c.IdCliente = p.IdCliente
			inner join Pessoa pec on pec.IdPessoa = c.IdPessoa
			where c.IdPessoa = pec.IdPessoa
			group by pec.Nome, c.IdCliente order by TotalGasto desc";

            try
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();
                    var listar = conexao.Query<FiltrosClienteModel>(query);
                    return listar.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<FiltrosClienteModel> Top5ClientesQueMenosGastaram()
        {
            var query = @"select top 5 pec.Nome, Sum(p.PrecoFinal) as TotalGasto, c.IdCliente
			from Pedido p
			inner join Cliente c on c.IdCliente = p.IdCliente
			inner join Pessoa pec on pec.IdPessoa = c.IdPessoa
			where c.IdPessoa = pec.IdPessoa
			group by pec.Nome, c.IdCliente order by TotalGasto asc";

            try
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();
                    var listar = conexao.Query<FiltrosClienteModel>(query);
                    return listar.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<FiltrosClienteModel> Top5ClientesQueMaisCompraram()
        {
            var query = @"select top 5 pec.Nome, Sum(p.PrecoFinal) as TotalGasto, Count(p.IdPedido) as NumeroDePedidos, c.IdCliente
            from Pedido p
			inner join Cliente c on c.IdCliente = p.IdCliente
            inner join Pessoa pec on pec.IdPessoa = c.IdPessoa       
            where c.IdPessoa = pec.IdPessoa
			group by pec.Nome, c.IdCliente order by NumeroDePedidos desc";

            try
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();
                    var listar = conexao.Query<FiltrosClienteModel>(query);
                    return listar.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<FiltrosClienteModel> Top5ClientesQueMenosCompraram()
        {
            var query = @"select top 5 pec.Nome, Sum(p.PrecoFinal) as TotalGasto, Count(p.IdPedido) as NumeroDePedidos, c.IdCliente
            from Pedido p
			inner join Cliente c on c.IdCliente = p.IdCliente
            inner join Pessoa pec on pec.IdPessoa = c.IdPessoa       
            where c.IdPessoa = pec.IdPessoa
			group by pec.Nome, c.IdCliente order by NumeroDePedidos asc";

            try
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();
                    var listar = conexao.Query<FiltrosClienteModel>(query);
                    return listar.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<FiltrosClienteModel> EspecificarData(DateTime dataInicial, DateTime dataFinal)
        {
            var query = @"select pec.Nome, Sum(p.PrecoFinal) as TotalGasto, Count(p.IdPedido) as NumeroDePedidos,
            p.DataPedido
            from Pedido p
			inner join Cliente c on c.IdCliente = p.IdCliente
            inner join Pessoa pec on pec.IdPessoa = c.IdPessoa       
            where p.DataPedido between @dataInicial and @dataFinal 
			group by pec.Nome, p.DataPedido";

            try
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();
                    var listar = conexao.Query<FiltrosClienteModel>(query, new {dataInicial = dataInicial.ToString("dd/MM/yyyy"),
                        dataFinal = dataFinal.ToString("dd/MM/yyyy")});
                    return listar.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<FiltrosClienteModel> EspecificarValor(decimal valor1, decimal valor2) 
        {
            var query = @"select pec.Nome, p.PrecoFinal as TotalGasto, p.IdPedido as NumeroDePedidos, p.DataPedido
            from Pedido p
            inner join Cliente c on c.IdCliente = p.IdCliente
            inner join Pessoa pec on pec.IdPessoa = c.IdPessoa
            where p.PrecoFinal between @valor1 and @valor2
            group by pec.Nome, p.PrecoFinal, p.IdPedido, p.DataPedido order by TotalGasto desc";

            try 
            {
                using (var conexao = new conexao().Connection()) 
                {
                    conexao.Open();
                    var listar = conexao.Query<FiltrosClienteModel>(query, new { valor1 = valor1, valor2 = valor2});
                    return listar.ToList();
                }
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<FiltrosVendaProdutoModel> ProdutoComMaiorEstoque()
        {
            var query = @"select IdProduto, Nome, Estoque, Fabricante from Produto where IdProduto = IdProduto
            group by IdProduto, Nome, Estoque, Fabricante order by Estoque desc";

            try
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();
                    var listagem = conexao.Query<FiltrosVendaProdutoModel>(query).ToList();
                    return listagem;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<FiltrosVendaProdutoModel> ProdutoComMenorEstoque()
        {
            var query = @"select IdProduto, Nome, Estoque, Fabricante from Produto where IdProduto = IdProduto
            group by IdProduto, Nome, Estoque, Fabricante order by Estoque asc";

            try
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();
                    var listagem = conexao.Query<FiltrosVendaProdutoModel>(query).ToList();
                    return listagem;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
