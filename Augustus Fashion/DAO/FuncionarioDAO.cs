using Augustus_Fashion.Model;
using System.Collections.Generic;
using System.Linq;
using Dapper;

namespace Augustus_Fashion.DAO
{
    class FuncionarioDAO
    {
        public static void CadastrarFuncionario(FuncionarioModel funcionario)
        {
            var conexao = new conexao().Connection();
            var query = @"insert into funcionario values(@Nome, @Sexo, @Nascimento, @Salario, @Comissao,
            @Cep, @Rua, @Numero, @Bairro, @Cidade, @Estado, @Complemento, @Celular,
            @Email, @Cpf, @Agencia, @NumConta, @CodConta)";
            conexao.Query<FuncionarioModel>(query, funcionario);
        }

        public static FuncionarioModel Buscar(int id) 
        {
            var conexao = new conexao().Connection();
            var query = @"select * from funcionario where Id = @Id";
            var parametros = new DynamicParameters();
            parametros.Add("@Id", id, System.Data.DbType.Int32);

            var resultado = conexao.QueryFirstOrDefault<FuncionarioModel>(query, parametros);
            return resultado;
        }

        public static void AlterarFuncionario(FuncionarioModel funcionario)
        {
            var conexao = new conexao().Connection();
            var query = @"update funcionario set Nome = @Nome, Sexo = @Sexo, Nascimento = @Nascimento,
            Salario = @Salario, Comissao = @Comissao, Cep = @Cep, Rua = @Rua, Numero = @Numero, Bairro = @Bairro,
            Cidade = @Cidade, Estado = @Estado, Complemento = @Complemento, Celular = @Celular,
            Email = @Email, Cpf = @Cpf, Agencia = @Agencia, NumConta = @NumConta, CodConta = @CodConta where Id = @Id";
            conexao.Query<FuncionarioModel>(query, funcionario);
        }

        public static List<FuncionarioModel> BuscarLista(string nome)
        {
            var conexao = new conexao().Connection();
            var query = @"select * from funcionario where Nome like @Nome + '%'";
            var parametros = new DynamicParameters();
            parametros.Add("@nome", nome, System.Data.DbType.String);

            var resultado = conexao.Query<FuncionarioModel>(query, parametros).ToList();
            return resultado;
        }

        public static void ExcluirFuncionario(FuncionarioModel func)
        {
            var conexao = new conexao().Connection();
            var query = @"delete from funcionario where Id = @Id";
            conexao.Query<ClienteModel>(query, func);
        }

        public static List<FuncionarioListagem> ListarFuncionario()
        {
            var conexao = new conexao().Connection();
            var query = @"select Id, Nome, Cidade, Celular, Nascimento from funcionario";
            var resultado = conexao.Query<FuncionarioListagem>(query);
            return resultado.ToList();
        }
    }
}
