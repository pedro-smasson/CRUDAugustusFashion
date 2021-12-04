using Augustus_Fashion.Model;
using Augustus_Fashion.Model.Produto;
using Augustus_Fashion.Model.Venda;
using System.Collections.Generic;
using Dapper;
using System;
using System.Linq;

namespace Augustus_Fashion.DAO
{
    class FiltrosDAO
    {

        public static List<FiltrosModel> QuantidadeCrescente()
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

        public static List<FiltrosModel> QuantidadeDecrescente()
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

        public static void Filtrar()
        {
        }
    }
}
