using Augustus_Fashion.DAO;
using Augustus_Fashion.Model.Funcionário;
using Augustus_Fashion.Model.Produto;
using Augustus_Fashion.ValueObjects;
using System;
using System.Collections.Generic;

namespace Augustus_Fashion.Controller
{
    class ProdutoControl
    {
        public void CadastrarProduto(ProdutoModel produtoModel) => ProdutoDAO.CadastrarProduto(produtoModel);

        public ProdutoModel Buscar(int idProduto) => ProdutoDAO.Buscar(idProduto);

        public List<ProdutoListagem> BuscarLista(string nomeProduto) => ProdutoDAO.BuscarLista(nomeProduto);

        public List<ProdutoListagem> ListarProduto() => ProdutoDAO.ListarProduto();

        public List<ProdutoListagem> ListarTodosOsProdutos() => ProdutoDAO.ListarTodosOsProdutos();

        public void ExcluirProduto(ProdutoModel produtoModel) => ProdutoDAO.ExcluirProduto(produtoModel);

        public void AlterarProduto(ProdutoModel produtoModel) => ProdutoDAO.AlterarProduto(produtoModel);

        public decimal ObterLucro(int idPedido) => ProdutoDAO.ObterLucro(idPedido);
    }
}