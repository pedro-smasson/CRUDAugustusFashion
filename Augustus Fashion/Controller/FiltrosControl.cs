using Augustus_Fashion.DAO;
using Augustus_Fashion.Model;
using Augustus_Fashion.Model.Venda;
using System;
using System.Collections.Generic;

namespace Augustus_Fashion.Controller
{
    class FiltrosControl
    {
        public List<FiltrosModel> QuantidadeCrescente()
        {
            return FiltrosDAO.QuantidadeCrescente();
        }

        public List<FiltrosModel> QuantidadeDecrescente()
        {
            return FiltrosDAO.QuantidadeDecrescente();
        }

        public List<FiltrosModel> TotalLiquidoCrescente() 
        {
            return FiltrosDAO.TotalLiquidoCrescente();
        }

        public List<FiltrosModel> TotalLiquidoDecrescente() 
        {
            return FiltrosDAO.TotalLiquidoDecrescente();
        }
    }
}
