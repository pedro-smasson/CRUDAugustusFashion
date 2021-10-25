using Augustus_Fashion.DAO;
using Augustus_Fashion.Model;
using Augustus_Fashion.View;
using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace Augustus_Fashion.Controller
{
    class FuncionarioControl
    {
        public void CadastrarFuncionario(FuncionarioModel funcModel)
        {
            try
            {
                FuncionarioDAO.CadastrarFuncionario(funcModel);
                MessageBox.Show("Funcionário Cadastrado com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public FuncionarioModel Buscar(int id)
        {

            return FuncionarioDAO.Buscar(id);
        }

    

    public void AlterarFuncionario(FuncionarioModel funcModel)
    {
        try
        {
            FuncionarioDAO.AlterarFuncionario(funcModel);
            MessageBox.Show("Cliente Alterado com Sucesso!");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    public List<FuncionarioModel> BuscarLista(string nome)
    {
        try
        {
            var lista = FuncionarioDAO.BuscarLista(nome);
            return lista;
        }
        catch (Exception excecao)
        {
            MessageBox.Show(excecao.Message);
        }
        return null;
    }

    public void ExcluirFuncionario(FuncionarioModel funcModel)
    {
        try
        {
            FuncionarioDAO.ExcluirFuncionario(funcModel);
            MessageBox.Show("Funcionário deletado com sucesso!");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

    }
  }
}