using Augustus_Fashion.DAO;
using Augustus_Fashion.Model.Venda;
using System;
using System.Collections.Generic;

namespace Augustus_Fashion.Controller
{
    public class VendaControl
    {
        public string CadastrarVenda(PedidoModel pedidoModel, List<PedidoProdutoModel> carrinhos) 
        {
            try 
            {
                VendaDAO.CadastrarVenda(pedidoModel, carrinhos);
                return string.Empty;
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
