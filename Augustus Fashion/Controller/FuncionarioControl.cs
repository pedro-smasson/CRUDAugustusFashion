using Augustus_Fashion.DAO;
using Augustus_Fashion.Model;
using System.Collections.Generic;

namespace Augustus_Fashion.Controller
{
    class FuncionarioControl
    {
        public List<FuncionarioListagem> BuscarLista(string nomeFuncionario) => FuncionarioDAO.BuscarLista(nomeFuncionario);

        public void CadastrarFuncionario(FuncionarioModel funcionarioModel) => FuncionarioDAO.CadastrarFuncionario(funcionarioModel);

        public FuncionarioModel Buscar(int idFuncionario) => FuncionarioDAO.Buscar(idFuncionario);

        public void AlterarFuncionario(FuncionarioModel funcionarioModel) => FuncionarioDAO.AlterarFuncionario(funcionarioModel);

        public void ExcluirFuncionario(FuncionarioModel funcionarioModel) => FuncionarioDAO.ExcluirFuncionario(funcionarioModel);

        public List<FuncionarioListagem> ListarFuncionarios() => FuncionarioDAO.ListarFuncionario();
    }
}