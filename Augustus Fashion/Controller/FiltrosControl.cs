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
    }
}
