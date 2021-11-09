﻿using Augustus_Fashion.Model;
using Augustus_Fashion.DAO;
using System;
using System.Collections.Generic;
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

        public /*???*/string CadastrarCliente(ClienteModel clienteModel)
        {
            try
            {
                var retornar = clienteModel.ValidarCliente();

                if(retornar == string.Empty) 
                {
                    ClienteDao.CadastrarCliente(clienteModel);
                }
                return retornar;   
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
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


