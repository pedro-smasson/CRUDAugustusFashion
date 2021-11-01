using Augustus_Fashion.Model;
using Augustus_Fashion.DAO;
using Augustus_Fashion.View;
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

        //public void AbrirFormulario() => new AlterarCliente(this).Show();

        //public void AbrirFormulario(ClienteModel clienteModelSelecionado)
        //{
        //    ClienteControl clienteControl = new ClienteControl();
        //    new AlterarCliente(this, clienteModelSelecionado, clienteControl).Show();
        //}

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

        public List<ClienteListagem> ListarClientes()
        {

            return ClienteDao.ListarCliente();
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

        public List<ClienteListagem> BuscarLista(string nome)
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


