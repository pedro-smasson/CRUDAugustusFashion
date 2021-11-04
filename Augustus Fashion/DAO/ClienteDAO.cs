using Augustus_Fashion.Model;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System;

namespace Augustus_Fashion.DAO
{
    public class ClienteDao
    {
        public static void CadastrarCliente(ClienteModel cliente)
        {
            

            var queryPessoa = @"insert into Pessoa output inserted.IdPessoa values(@Nome, @Sexo, @Nascimento, @Celular,
            @Email, @Cpf)";
            var queryCliente = @"insert into Cliente (IdPessoa, Limite) values(@IdPessoa, @Limite)";
            var queryEndereco = @"insert into Endereco (IdPessoa, Cep, Rua, Numero, Bairro, Cidade, Estado, Complemento)
            values(@IdPessoa, @Cep, @Rua, @Numero, @Bairro, @Cidade, @Estado, @Complemento)";

            try
            {
                using (var conexao = new conexao().Connection())
                {
                conexao.Open();
                using (var transacao = conexao.BeginTransaction())
                
                {
                    int id = conexao.ExecuteScalar<int>(queryPessoa, cliente, transacao);
                    cliente.IdPessoa = id;
                    cliente.Endereco.IdPessoa = id;

                    conexao.Execute(queryCliente, cliente, transacao);
                    conexao.Execute(queryEndereco, cliente.Endereco, transacao);

                    transacao.Commit();
                }
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
                //conexao.Query<ClienteModel>(queryPessoa, queryCliente, QueryEndereco, cliente);
        }

        public static void AlterarCliente(ClienteModel cliente) 
        {
            var conexao = new conexao().Connection();
            var query = @"update cliente set Nome = @Nome, Sexo = @Sexo, Nascimento = @Nascimento,
            Limite = @Limite, Cep = @Cep, Rua = @Rua, Numero = @Numero, Bairro = @Bairro,
            Cidade = @Cidade, Estado = @Estado, Complemento = @Complemento, Celular = @Celular,
            Email = @Email, Cpf = @Cpf where Id = @Id";
            conexao.Query<ClienteModel>(query, cliente);
        }

        public static void ExcluirCliente(ClienteModel cliente) 
        {
            var conexao = new conexao().Connection();
            var query = @"delete from cliente where Id = @Id";
            conexao.Query<ClienteModel>(query, cliente);
        }

        public static List<ClienteListagem> ListarCliente() 
        {
            var conexao = new conexao().Connection();
            var query = @"select Id, Nome, Cidade, Celular, Nascimento from cliente";
            var resultado = conexao.Query<ClienteListagem>(query);
            return resultado.ToList(); 
        }

        public static ClienteModel Buscar(int id)
        {
            var conexao = new conexao().Connection();
            var query = @"select * from cliente where Id=@Id";
            var parametros = new DynamicParameters();
            parametros.Add("@Id", id, System.Data.DbType.Int32);

            var resultado = conexao.QueryFirstOrDefault<ClienteModel>(query, parametros/*new { id }*/);
            return resultado;
        }

        public static List<ClienteListagem> BuscarLista(string nome)
        {
            var conexao = new conexao().Connection();
            var query = @"select Id, Nome, Cidade, Celular, Nascimento from cliente where Nome like @Nome + '%'";
            var parametros = new DynamicParameters();
            parametros.Add("@nome", nome, System.Data.DbType.String);

            var resultado = conexao.Query<ClienteListagem>(query, parametros).ToList();
            return resultado;
        }
    }
}