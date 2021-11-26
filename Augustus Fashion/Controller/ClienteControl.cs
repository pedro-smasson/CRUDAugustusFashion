using Augustus_Fashion.DAO;
using Augustus_Fashion.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Augustus_Fashion.Controller
{
    class ClienteControl
    {

        public string CadastrarCliente(ClienteModel clienteModel)
        {
            try
            {
                var retornarCadastrarCliente = clienteModel.ValidarCliente();

                if (retornarCadastrarCliente == string.Empty)
                {
                    ClienteDao.CadastrarCliente(clienteModel);
                }
                return retornarCadastrarCliente;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
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
            try
            {
                ClienteDao.ExcluirCliente(clienteModel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
                MessageBox.Show(ex.Message);
            }
            return null;
        }

    }
}


