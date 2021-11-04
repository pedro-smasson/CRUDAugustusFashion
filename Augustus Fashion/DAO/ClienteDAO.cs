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
            //var conexao = new conexao().Connection();
            var queryPessoa = @"update Pessoa set Nome = @Nome, Sexo = @Sexo, Nascimento = @Nascimento,
            Celular = @Celular, Email = @Email, Cpf = @Cpf where IdPessoa = @IdPessoa";
            var queryCliente = @"update Cliente set Limite = @Limite where IdPessoa = @IdPessoa";
            var queryEndereco = @"update Endereco set Cep = @Cep, Rua = @Rua, Numero = @Numero, Bairro = @Bairro,
            Cidade = @Cidade, Estado = @Estado, Complemento = @Complemento where IdPessoa = @IdPessoa";

            try 
            {
                using (var conexao = new conexao().Connection()) 
                {
                    conexao.Open();
                    using (var transacao = conexao.BeginTransaction()) 
                    {
                        conexao.Execute(queryPessoa, cliente, transacao);
                        conexao.Execute(queryCliente, cliente, transacao);
                        conexao.Execute(queryEndereco, cliente, transacao);

                        transacao.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            //conexao.Query<ClienteModel>(queryPessoa, cliente);
        }

        public static void ExcluirCliente(ClienteModel cliente) 
        {
            var conexao = new conexao().Connection();
            var query = @"delete from cliente where Id = @Id";
            conexao.Query<ClienteModel>(query, cliente);
        }

        public static List<ClienteListagem> ListarCliente() 
        {
            
            var query = @"select c.IdCliente, c.Limite,
            c.IdPessoa, p.IdPessoa, p.Nome, p.Sexo, p.Nascimento, p.Celular, p.Email, p.Cpf,
            c.IdPessoa, e.IdEndereco, e.Cep, e.Rua, e.Cidade, e.Numero, e.Bairro, e.Estado, e.Complemento from
            Pessoa p inner join Cliente c on p.IdPessoa = c.IdCliente
            inner join Endereco e on c.IdPessoa = e.IdPessoa";

            try 
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();
                    return conexao.Query<ClienteListagem>(query).ToList();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            //var resultado = conexao.Query<ClienteListagem>(query);
            //return resultado.ToList(); 
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