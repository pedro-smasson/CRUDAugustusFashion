using Augustus_Fashion.DAO;
using Augustus_Fashion.Model.Funcionário;
using Augustus_Fashion.Model.Produto;
using System;
using System.Collections.Generic;

namespace Augustus_Fashion.Controller
{
    class ProdutoControl
    {
        public void CadastrarProduto(ProdutoModel produto) 
        {
            try
            {
                ProdutoDAO.CadastrarProduto(produto);
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public ProdutoModel Buscar(int id)
        {

            return ProdutoDAO.Buscar(id);
        }

        public List<ProdutoListagem> BuscarLista(string nome)
        {
            try
            {
                var lista = ProdutoDAO.BuscarLista(nome);
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }

        public List<ProdutoListagem> ListarProduto()
        {

            return ProdutoDAO.ListarProduto();
        }
    }
}
