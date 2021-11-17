using Augustus_Fashion.DAO;
using Augustus_Fashion.Model.Venda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Augustus_Fashion.Controller
{
    public class VendaControl
    {
        public string CadastrarVenda(PedidoModel pedido, List<CarrinhoModel> carrinhos) 
        {
            try 
            {
                VendaDAO.CadastrarVenda(pedido, carrinhos);
                return string.Empty;
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
