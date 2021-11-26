using Augustus_Fashion.DAO;
using Augustus_Fashion.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Augustus_Fashion.Controller
{
    class FuncionarioControl
    {
        public void CadastrarFuncionario(FuncionarioModel funcionarioModel)
        {
            try
            {
                FuncionarioDAO.CadastrarFuncionario(funcionarioModel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public FuncionarioModel Buscar(int idFuncionario)
        {

            return FuncionarioDAO.Buscar(idFuncionario);
        }

        public void AlterarFuncionario(FuncionarioModel funcionarioModel)
        {
            try
            {
                FuncionarioDAO.AlterarFuncionario(funcionarioModel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<FuncionarioListagem> BuscarLista(string nomeFuncionario)
        {
            try
            {
                var listaFuncionario = FuncionarioDAO.BuscarLista(nomeFuncionario);
                return listaFuncionario;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void ExcluirFuncionario(FuncionarioModel funcionarioModel)
        {
            try
            {
                FuncionarioDAO.ExcluirFuncionario(funcionarioModel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public List<FuncionarioListagem> ListarFuncionarios()
        {
            return FuncionarioDAO.ListarFuncionario();
        }
    }
}