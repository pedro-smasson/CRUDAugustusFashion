using Augustus_Fashion.DAO;
using Augustus_Fashion.Model;
using Augustus_Fashion.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Augustus_Fashion.Controller
{
    class FuncionarioControl
    {
        public void CadastrarFuncionario(FuncionarioModel funcModel)
        {
            try
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();
                    FuncionarioDAO.CadastrarFuncionario(conexao, funcModel);
                    MessageBox.Show("Funcionário Cadastrado com Sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public FuncionarioModel Buscar(int id) 
        {
            using (var conexao = new conexao().Connection()) 
            {
                conexao.Open();
                return FuncionarioDAO.Buscar(conexao, id);
            }

        }

        public void AlterarFuncionario(FuncionarioModel funcionarioModel)
        {
            try
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();
                    FuncionarioDAO.AlterarFuncionario(conexao, funcionarioModel);
                    MessageBox.Show("Funcionário Alterado com Sucesso!");
                }
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
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();
                    var lista = FuncionarioDAO.BuscarLista(conexao, nome);
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
