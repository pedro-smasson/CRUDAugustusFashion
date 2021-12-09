using Augustus_Fashion.DAO;
using Augustus_Fashion.Model;
using Augustus_Fashion.Model.Funcionário;
using Augustus_Fashion.Model.Relatorios;
using Augustus_Fashion.Model.Venda;
using System;
using System.Collections.Generic;

namespace Augustus_Fashion.Controller
{
    class FiltrosControl
    {
        public List<RelatorioProdutosModel> QueryFiltragemProduto(FiltrosProdutoModel filtrosProdutoModel)
        {
            return FiltrosDAO.QueryFiltragemProduto(filtrosProdutoModel);
        }
    }
}
