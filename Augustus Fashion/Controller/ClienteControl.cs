using Augustus_Fashion.DAO;
using Augustus_Fashion.Model;
using Augustus_Fashion.MensagemGlobal;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Augustus_Fashion.Controller
{
    public class ClienteControl
    {

        public string CadastrarCliente(ClienteModel clienteModel)
        {
            var retornarCadastrarCliente = clienteModel.ValidarCliente();

            if (retornarCadastrarCliente == string.Empty)
            {
                ClienteDao.CadastrarCliente(clienteModel);
            }
            return retornarCadastrarCliente;
        }

        public string AlterarCliente(ClienteModel clienteModel)
        {
            try
            {
                var retornarAlterarCliente = clienteModel.ValidarCliente();

                if (retornarAlterarCliente == string.Empty)
                {
                    ClienteDao.AlterarCliente(clienteModel);
                }
                return retornarAlterarCliente;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ClienteListagem> ListarClientes()
        {
            return ClienteDao.ListarCliente();
        }

        public void ExcluirCliente(ClienteModel clienteModel)
        {
                ClienteDao.ExcluirCliente(clienteModel);
        }

        public ClienteModel Buscar(int idCliente)
        {
            return ClienteDao.Buscar(idCliente);
        }

        public List<ClienteListagem> BuscarLista(string nomeCliente)
        {
            try
            {
                var listaCliente = ClienteDao.BuscarLista(nomeCliente);
                return listaCliente;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }          
        }

        public static ClienteModel BuscarCliente(int idCliente)
        {
            return ClienteDao.Buscar(idCliente);
        }

    }
}


