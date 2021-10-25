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
        public static void CadastrarFuncionario(FuncionarioModel funcionario)
        {
            var conexao = new conexao().Connection();
            var query = @"insert into funcionario values(@nome, @sexo, @nascimento, @salario, @comissao,
            @cep, @rua, @numero, @bairro, @cidade, @estado, @complemento, @celular,
            @email, @cpf, @agencia, @numConta, @codConta)";
            conexao.Query<FuncionarioModel>(query, funcionario);
        }

        public static FuncionarioModel Buscar(int id) 
        {
            var conexao = new conexao().Connection();
            var query = @"select * from funcionario where id=@id";
            var parametros = new DynamicParameters();
            parametros.Add("@id", id, System.Data.DbType.Int32);

            var resultado = conexao.QueryFirstOrDefault<FuncionarioModel>(query, parametros);
            return resultado;
        }

        public static void AlterarFuncionario(FuncionarioModel funcionario)
        {
            var conexao = new conexao().Connection();
            var query = @"update funcionario set nome = @nome, sexo = @sexo, nascimento = @nascimento,
            salario = @salario, comissao = @comissao, cep = @cep, rua = @rua, numero = @numero, bairro = @bairro,
            cidade = @cidade, estado = @estado, complemento = @complemento, celular = @celular,
            email = @email, cpf = @cpf, agencia = @agencia, numConta = @numConta, codConta = @codConta where id = @id";
            conexao.Query<FuncionarioModel>(query, funcionario);
        }

        public static List<FuncionarioModel> BuscarLista(string nome)
        {
            var conexao = new conexao().Connection();
            var query = @"select * from funcionario where nome=@nome";
            var parametros = new DynamicParameters();
            parametros.Add("@nome", nome, System.Data.DbType.String);

            var resultado = conexao.Query<FuncionarioModel>(query, parametros).ToList();
            return resultado;
        }

        public static void ExcluirFuncionario(FuncionarioModel func)
        {
            var conexao = new conexao().Connection();
            var query = @"delete from funcionario where id=@id";
            conexao.Query<ClienteModel>(query, func);
        }
    }
}
