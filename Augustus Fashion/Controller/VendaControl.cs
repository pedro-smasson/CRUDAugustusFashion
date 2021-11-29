using Augustus_Fashion.DAO;
using Augustus_Fashion.Model.Venda;
using System;
using System.Collections.Generic;

namespace Augustus_Fashion.Controller
{
    public class VendaControl
    {
        public string CadastrarVenda(PedidoModel pedidoModel)
        {
            try
            {
                VendaDAO.CadastrarVenda(pedidoModel);
                return string.Empty;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ListagemVendaModel> ListarPedidos()
        {
            return VendaDAO.ListarPedidos();
        }

        public List<ListagemVendaModel> BuscarLista(string nomeFuncionario, string nomeCliente)
        {
            try
            {
                var listaPedido = VendaDAO.BuscarLista(nomeFuncionario, nomeCliente);
                return listaPedido;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public PedidoModel Buscar(int id)
        {
            return VendaDAO.Buscar(id);
        }

        public List<PedidoProdutoModel> BuscarProdutosDaVenda(int id)
        {
            try
            {
                return VendaDAO.BuscarProdutos(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string AlterarVenda(PedidoModel pedido, List<PedidoProdutoModel> produtos)
        {
            try
            {
                VendaDAO.AlterarVenda(pedido, produtos);
                return string.Empty;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string DesativarVenda(PedidoModel pedido)
        {
            try
            {
                VendaDAO.DesativarVenda(pedido);
                return string.Empty;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
