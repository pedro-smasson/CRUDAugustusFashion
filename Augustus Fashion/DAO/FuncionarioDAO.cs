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

        public static FuncionarioModel Buscar(IDbConnection conexao, int id) 
        {
            var query = @"select * from funcionario where id=@id";
            var parametros = new DynamicParameters();
            parametros.Add("@id", id, System.Data.DbType.Int32);

            var resultado = conexao.QueryFirstOrDefault<FuncionarioModel>(query, parametros);
            return resultado;
        }

        public static void AlterarFuncionario(IDbConnection conexao, FuncionarioModel funcionario)
        {
            var query = @"update funcionario set nome = @nome, sexo = @sexo, nascimento = @nascimento,
            salario = @salario, comissao = @comissao, cep = @cep, rua = @rua, numero = @numero, bairro = @bairro,
            cidade = @cidade, estado = @estado, complemento = @complemento, celular = @celular,
            email = @email, cpf = @cpf, agencia = @agencia, numConta = @numConta, codConta = @codConta where id = @id";
            conexao.Query<FuncionarioModel>(query, funcionario);
        }

        public static List<FuncionarioModel> BuscarLista(IDbConnection conexao, string nome)
        {
            var query = @"select * from funcionario where nome=@nome";
            var parametros = new DynamicParameters();
            parametros.Add("@nome", nome, System.Data.DbType.String);

            var resultado = conexao.Query<FuncionarioModel>(query, parametros).ToList();
            return resultado;
        }
    }
}
