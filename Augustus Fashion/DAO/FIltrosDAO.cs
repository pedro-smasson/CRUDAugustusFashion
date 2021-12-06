﻿using Augustus_Fashion.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Augustus_Fashion.DAO
{
    class FiltrosDAO
    {

        public static List<FiltrosModel> QuantidadeDePedidosCrescente()
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
                    var listar = conexao.Query<FiltrosModel>(query);
                    return listar.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<FiltrosModel> QuantidadeDePedidosDecrescente()
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
                    var listar = conexao.Query<FiltrosModel>(query);
                    return listar.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<FiltrosModel> TotalLiquidoCrescente()
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
                    var listar = conexao.Query<FiltrosModel>(query);
                    return listar.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<FiltrosModel> TotalLiquidoDecrescente()
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
                    var listar = conexao.Query<FiltrosModel>(query);
                    return listar.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<FiltrosModel> DescontoCrescente()
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
                    var listar = conexao.Query<FiltrosModel>(query);
                    return listar.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<FiltrosModel> DescontoDecrescente()
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
                    var listar = conexao.Query<FiltrosModel>(query);
                    return listar.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<FiltrosModel> Top5ClientesQueMaisGastaram()
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
                    var listar = conexao.Query<FiltrosModel>(query);
                    return listar.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<FiltrosModel> Top5ClientesQueMenosGastaram()
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
                    var listar = conexao.Query<FiltrosModel>(query);
                    return listar.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<FiltrosModel> Top5ClientesQueMaisCompraram()
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
                    var listar = conexao.Query<FiltrosModel>(query);
                    return listar.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<FiltrosModel> Top5ClientesQueMenosCompraram()
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
                    var listar = conexao.Query<FiltrosModel>(query);
                    return listar.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<FiltrosModel> EspecificarData(DateTime dataInicial, DateTime dataFinal)
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
                    var listar = conexao.Query<FiltrosModel>(query, new {dataInicial = dataInicial.ToString("dd/MM/yyyy"),
                        dataFinal = dataFinal.ToString("dd/MM/yyyy")});
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
