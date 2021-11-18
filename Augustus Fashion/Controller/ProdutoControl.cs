using Augustus_Fashion.DAO;
using Augustus_Fashion.Model.Funcionário;
using Augustus_Fashion.Model.Produto;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Augustus_Fashion.Controller
{
    class ProdutoControl
    {
        public void CadastrarProduto(ProdutoModel produtoModel) 
        {
            try
            {
                ProdutoDAO.CadastrarProduto(produtoModel);
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public ProdutoModel Buscar(int idProduto)
        {

            return ProdutoDAO.Buscar(idProduto);
        }

        public List<ProdutoListagem> BuscarLista(string nomeProduto)
        {
            try
            {
                var lista = ProdutoDAO.BuscarLista(nomeProduto);
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ProdutoListagem> ListarProduto()
        {

            return ProdutoDAO.ListarProduto();
        }

        public void ExcluirProduto(ProdutoModel produtoModel)
        {
            try
            {
                ProdutoDAO.ExcluirProduto(produtoModel);
                MessageBox.Show("Produto deletado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void AlterarProduto(ProdutoModel produtoModel) 
        {
            try 
            {
                ProdutoDAO.AlterarProduto(produtoModel);
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
