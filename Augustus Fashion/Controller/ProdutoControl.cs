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
            //return null;
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
