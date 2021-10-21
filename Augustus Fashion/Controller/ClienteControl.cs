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
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();
                    ClienteDao.CadastrarCliente(conexao, clienteModel);
                    MessageBox.Show("Cliente Cadastrado com Sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AlterarCliente(ClienteModel clienteModel)
        {
            try
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();
                    ClienteDao.AlterarCliente(conexao, clienteModel);
                    MessageBox.Show("Cliente Alterado com Sucesso!");
                }
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
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();
                    var lista = ClienteDao.ListarCliente(conexao);
                    return lista;
                }
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }

            return new List<ClienteModel>();
        }

        public void ExcluirCliente(ClienteModel clienteModel)
        {

        }

        public ClienteModel Buscar(int id)
        {
            using (var conexao = new conexao().Connection())
            {
                conexao.Open();
                return ClienteDao.Buscar(conexao, id);
            }
        }

        public List<ClienteModel> BuscarLista(string nome)
        {
            try
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();
                    var lista = ClienteDao.BuscarLista(conexao, nome);
                    return lista;
                }
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message);
            }
            return null;
        }
    }
}


