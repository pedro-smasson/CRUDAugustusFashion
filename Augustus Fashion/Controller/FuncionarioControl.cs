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
    }
}
