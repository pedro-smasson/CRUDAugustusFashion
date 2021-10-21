using Augustus_Fashion.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Augustus_Fashion.DAO
{
    class FuncionarioDAO
    {
        public static void CadastrarFuncionario(IDbConnection conexao, FuncionarioModel funcionario)
        {
            var query = @"insert into funcionario values(@nome, @sexo, @nascimento, @salario, @comissao,
            @cep, @rua, @numero, @bairro, @cidade, @estado, @complemento, @celular,
            @email, @cpf, @agencia, @numConta, @codConta)";
            conexao.Query<FuncionarioModel>(query, funcionario);
        }
    }
}
