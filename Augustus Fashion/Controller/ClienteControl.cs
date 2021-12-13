using Augustus_Fashion.DAO;
using Augustus_Fashion.Model;
using System.Collections.Generic;

namespace Augustus_Fashion.Controller
{
    public class ClienteControl
    {
        public void CadastrarCliente(ClienteModel clienteModel) => ClienteDao.CadastrarCliente(clienteModel);

        public void AlterarCliente(ClienteModel clienteModel) => ClienteDao.AlterarCliente(clienteModel);

        public List<ClienteListagem> ListarClientes() => ClienteDao.ListarCliente();

        public void ExcluirCliente(ClienteModel clienteModel) => ClienteDao.ExcluirCliente(clienteModel);
  
        public ClienteModel Buscar(int idCliente) => ClienteDao.Buscar(idCliente);

        public List<ClienteListagem> BuscarLista(string nomeCliente) => ClienteDao.BuscarLista(nomeCliente);

        public static ClienteModel BuscarCliente(int idCliente) => ClienteDao.Buscar(idCliente);
    }
}