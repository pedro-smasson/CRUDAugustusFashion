using Augustus_Fashion.Model;
using Augustus_Fashion.Controller;
using Augustus_Fashion.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using System.Data;

namespace Augustus_Fashion.DAO
{
    public class ClienteDao
    {
        public static void CadastrarCliente(IDbConnection conexao, ClienteModel cliente)
        {
            var query = @"insert into cliente values(@nome, @sexo, @nascimento, @limite,
            @cep, @rua, @numero, @bairro, @cidade, @estado, @complemento, @celular,
            @email, @cpf)";
            conexao.Query<ClienteModel>(query, cliente);
        }

        public static void AlterarCliente(IDbConnection conexao, ClienteModel cliente) 
        {
            var query = @"update cliente set nome = @nome, sexo = @sexo, nascimento = @nascimento,
            limite = @limite, cep = @cep, rua = @rua, numero = @numero, bairro = @bairro,
            cidade = @cidade, estado = @estado, complemento = @complemento, celular = @celular,
            email = @email, cpf = @cpf where id = @id";
            conexao.Query<ClienteModel>(query, cliente);
        }

        public static void ExcluirCliente(IDbConnection conexao, ClienteModel cliente) 
        {
            var query = @"delete from cliente where id=@id";
            conexao.Query<ClienteModel>(query, cliente);
        }

        public static List<ClienteModel> ListarCliente(IDbConnection conexao) 
        {
            var query = @"select * from cliente";
            var resultado = conexao.Query<ClienteModel>(query);
            return resultado.ToList(); 
        }

        public static ClienteModel Buscar(IDbConnection conexao, int id)
        {
            var query = @"select * from cliente where id=@id";
            var parametros = new DynamicParameters();
            parametros.Add("@id", id, System.Data.DbType.Int32);

            var resultado = conexao.QueryFirstOrDefault<ClienteModel>(query, parametros);
            return resultado;
        }
    }
}