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

        public static List<PedidoModel> QuantidadeCrescente() 
        {
            var query = @"select pec.Nome, v.QuantidadeProduto, v.Total, p.PrecoFinal, p.FormaDePagamento
            from Pedido p
			inner join Cliente c on c.IdCliente = p.IdCliente
            inner join Pessoa pec on pec.IdPessoa = c.IdPessoa           
            inner join Venda v on v.IdPedido = p.IdPedido where c.IdPessoa = pec.IdPessoa
            order by v.QuantidadeProduto asc";

            try 
            {
                using (var conexao = new conexao().Connection()) 
                {
                    conexao.Open();
                    var listar = conexao.Query<PedidoModel>(query);

                    return listar.ToList();
                }
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
            
        }

        public static void FiltrarValorCrescente() 
        {

        }

        public static void FiltrarValorDescrescente() 
        {

        }

        public static void Filtrar() 
        {
        }
    }
}
