using Augustus_Fashion.DAO;
using Augustus_Fashion.Model;
using Augustus_Fashion.Model.Funcionário;
using Augustus_Fashion.Model.Venda;
using System;
using System.Collections.Generic;

namespace Augustus_Fashion.Controller
{
    class FiltrosControl
    {
        public List<FiltrosClienteModel> QuantidadeDePedidosCrescente()
        {
            return FiltrosDAO.QuantidadeDePedidosCrescente();
        }

        public List<FiltrosClienteModel> QuantidadeDePedidosDecrescente()
        {
            return FiltrosDAO.QuantidadeDePedidosDecrescente();
        }

        public List<FiltrosClienteModel> TotalLiquidoCrescente() 
        {
            return FiltrosDAO.TotalLiquidoCrescente();
        }

        public List<FiltrosClienteModel> TotalLiquidoDecrescente() 
        {
            return FiltrosDAO.TotalLiquidoDecrescente();
        }

        public List<FiltrosClienteModel> DescontoCrescente()
        {
            return FiltrosDAO.DescontoCrescente();
        }

        public List<FiltrosClienteModel> DescontoDecrescente()
        {
            return FiltrosDAO.DescontoDecrescente();
        }

        public List<FiltrosClienteModel> Top5ClientesQueMaisGastaram() 
        {
            return FiltrosDAO.Top5ClientesQueMaisGastaram();
        }

        public List<FiltrosClienteModel> Top5ClientesQueMenosGastaram()
        {
            return FiltrosDAO.Top5ClientesQueMenosGastaram();
        }

        public List<FiltrosClienteModel> Top5ClientesQueMaisCompraram()
        {
            return FiltrosDAO.Top5ClientesQueMaisCompraram();
        }

        public List<FiltrosClienteModel> Top5ClientesQueMenosCompraram()
        {
            return FiltrosDAO.Top5ClientesQueMenosCompraram();
        }

        public List<FiltrosClienteModel> EspecificarData(DateTime dataInicial, DateTime dataFinal) 
        {
            return FiltrosDAO.EspecificarData(dataInicial, dataFinal);
        }

        public List<FiltrosClienteModel> EspecificarValor(decimal valor1, decimal valor2) 
        {
            return FiltrosDAO.EspecificarValor(valor1, valor2);
        }

        public List<FiltrosVendaProdutoModel> ProdutoComMaiorEstoque()
        {
            return FiltrosDAO.ProdutoComMaiorEstoque();
        }

        public List<FiltrosVendaProdutoModel> ProdutoComMenorEstoque()
        {
            return FiltrosDAO.ProdutoComMenorEstoque();
        }
    }
}
