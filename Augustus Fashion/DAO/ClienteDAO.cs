using Augustus_Fashion.Model;
using System.Collections.Generic;
using System.Linq;
using Dapper;

namespace Augustus_Fashion.DAO
{
    public class ClienteDao
    {
        public static void CadastrarCliente(ClienteModel cliente)
        {
            var conexao = new conexao().Connection();
            var query = @"insert into cliente values(@nome, @sexo, @nascimento, @limite,
            @cep, @rua, @numero, @bairro, @cidade, @estado, @complemento, @celular,
            @email, @cpf)";
            conexao.Query<ClienteModel>(query, cliente);
        }

        public static void AlterarCliente(ClienteModel cliente) 
        {
            var conexao = new conexao().Connection();
            var query = @"update cliente set nome = @nome, sexo = @sexo, nascimento = @nascimento,
            limite = @limite, cep = @cep, rua = @rua, numero = @numero, bairro = @bairro,
            cidade = @cidade, estado = @estado, complemento = @complemento, celular = @celular,
            email = @email, cpf = @cpf where id = @id";
            conexao.Query<ClienteModel>(query, cliente);
        }

        public static void ExcluirCliente(ClienteModel cliente) 
        {
            var conexao = new conexao().Connection();
            var query = @"delete from cliente where id=@id";
            conexao.Query<ClienteModel>(query, cliente);
        }

        public static List<ClienteModel> ListarCliente() 
        {
            var conexao = new conexao().Connection();
            var query = @"select * from cliente";
            var resultado = conexao.Query<ClienteModel>(query);
            return resultado.ToList(); 
        }

        public static ClienteModel Buscar(int id)
        {
            var conexao = new conexao().Connection();
            var query = @"select * from cliente where id=@id";
            var parametros = new DynamicParameters();
            parametros.Add("@id", id, System.Data.DbType.Int32);

            var resultado = conexao.QueryFirstOrDefault<ClienteModel>(query, parametros/*new { id }*/);
            return resultado;
        }

        public static List<ClienteModel> BuscarLista(string nome)
        {
            var conexao = new conexao().Connection();
            var query = @"select * from cliente where nome=@nome";
            var parametros = new DynamicParameters();
            parametros.Add("@nome", nome, System.Data.DbType.String);

            var resultado = conexao.Query<ClienteModel>(query, parametros).ToList();
            return resultado;
        }
    }
}