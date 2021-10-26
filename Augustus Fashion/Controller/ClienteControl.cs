using Augustus_Fashion.Model;
using Augustus_Fashion.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Augustus_Fashion.Controller
{
    class ClienteControl
    {
        public void CadastrarCliente(ClienteModel clienteModel)
        {
            try
            {
                    ClienteDao.CadastrarCliente(clienteModel);
                    MessageBox.Show("Cliente Cadastrado com Sucesso!");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AlterarCliente(ClienteModel clienteModel)
        {
            try
            {
                    ClienteDao.AlterarCliente(clienteModel);
                    MessageBox.Show("Cliente Alterado com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<ClienteModel> ListarClientes(ClienteModel clienteModel)
        {
            try
            {
                    var lista = ClienteDao.ListarCliente();
                    return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return new List<ClienteModel>();
        }

        public void ExcluirCliente(ClienteModel clienteModel)
        {
            try 
            {
                ClienteDao.ExcluirCliente(clienteModel);
                MessageBox.Show("Cliente deletado com sucesso!");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public ClienteModel Buscar(int id)
        {
            {
                return ClienteDao.Buscar(id);
            }
        }

        public List<ClienteModel> BuscarLista(string nome)
        {
            try
            {
                    var lista = ClienteDao.BuscarLista(nome);
                    return lista;
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
            return null;
        }
    }
}


