using Augustus_Fashion.DAO;
using Augustus_Fashion.Model;
using Augustus_Fashion.Model.Venda;
using System;
using System.Collections.Generic;

namespace Augustus_Fashion.Controller
{
    class FiltrosControl
    {
        public List<FiltrosModel> QuantidadeDePedidosCrescente()
        {
            return FiltrosDAO.QuantidadeDePedidosCrescente();
        }

        public List<FiltrosModel> QuantidadeDePedidosDecrescente()
        {
            return FiltrosDAO.QuantidadeDePedidosDecrescente();
        }

        public List<FiltrosModel> TotalLiquidoCrescente() 
        {
            return FiltrosDAO.TotalLiquidoCrescente();
        }

        public List<FiltrosModel> TotalLiquidoDecrescente() 
        {
            return FiltrosDAO.TotalLiquidoDecrescente();
        }

        public List<FiltrosModel> DescontoCrescente()
        {
            return FiltrosDAO.DescontoCrescente();
        }

        public List<FiltrosModel> DescontoDecrescente()
        {
            return FiltrosDAO.DescontoDecrescente();
        }

        public List<FiltrosModel> Top5ClientesQueMaisGastaram() 
        {
            return FiltrosDAO.Top5ClientesQueMaisGastaram();
        }

        public List<FiltrosModel> Top5ClientesQueMenosGastaram()
        {
            return FiltrosDAO.Top5ClientesQueMenosGastaram();
        }

        public List<FiltrosModel> Top5ClientesQueMaisCompraram()
        {
            return FiltrosDAO.Top5ClientesQueMaisCompraram();
        }

        public List<FiltrosModel> Top5ClientesQueMenosCompraram()
        {
            return FiltrosDAO.Top5ClientesQueMenosCompraram();
        }

        public List<FiltrosModel> EspecificarData(DateTime dataInicial, DateTime dataFinal) 
        {
            return FiltrosDAO.EspecificarData(dataInicial, dataFinal);
        }
    }
}
