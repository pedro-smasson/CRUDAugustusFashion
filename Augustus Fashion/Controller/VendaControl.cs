using Augustus_Fashion.DAO;
using Augustus_Fashion.Model.Venda;
using System.Collections.Generic;

namespace Augustus_Fashion.Controller
{
    public class VendaControl
    {
        public void CadastrarVenda(PedidoModel pedidoModel) => VendaDAO.CadastrarVenda(pedidoModel);

        public List<ListagemVendaModel> ListarPedidos() => VendaDAO.ListarPedidos();

        public List<ListagemVendaModel> BuscarLista(string nomeFuncionario, string nomeCliente) =>
            VendaDAO.BuscarLista(nomeFuncionario, nomeCliente);

        public PedidoModel Buscar(int id) => VendaDAO.Buscar(id);

        public List<PedidoProdutoModel> BuscarProdutosDaVenda(int id) => VendaDAO.BuscarProdutos(id);

        public void AlterarVenda(PedidoModel pedido) => VendaDAO.AlterarVenda(pedido);

        public void DesativarVenda(PedidoModel pedido) => VendaDAO.DesativarVenda(pedido);
    }
}