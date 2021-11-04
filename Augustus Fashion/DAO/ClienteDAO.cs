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
                      
            var queryEndereco = @"delete from Endereco where IdPessoa = @IdPessoa";
            var queryCliente = @"delete from Cliente where IdPessoa = @IdPessoa";
            var queryPessoa = @"delete from Pessoa where IdPessoa = @IdPessoa";

            try 
            {
                var conexao = new conexao().Connection();
                {
                    conexao.Open();
                    using (var transacao = conexao.BeginTransaction()) 
                    {
                        conexao.Execute(queryEndereco, new {IdPessoa = cliente.IdPessoa}, transacao);
                        conexao.Execute(queryCliente, new {IdPessoa = cliente.IdPessoa}, transacao);
                        conexao.Execute(queryPessoa, new {IdPessoa = cliente.IdPessoa}, transacao);

                        transacao.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            //conexao.Query<ClienteModel>(queryEndereco, cliente);
        }

        public static List<ClienteListagem> ListarCliente() 
        {
            
            var query = @"select c.IdCliente, c.Limite,
            c.IdPessoa, p.IdPessoa, p.Nome, p.Sexo, p.Nascimento, p.Celular, p.Email, p.Cpf,
            c.IdPessoa, e.IdEndereco, e.Cep, e.Rua, e.Cidade, e.Numero, e.Bairro, e.Estado, e.Complemento from
            Pessoa p inner join Cliente c on c.IdPessoa = p.IdPessoa
            inner join Endereco e on c.IdPessoa = e.IdPessoa"; /*where p.IdPessoa = @IdPessoa*/

            try 
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();
                    return conexao.Query(query, (ClienteListagem clienteListagem, EnderecoModel enderecoModel)
                    => Mapear(clienteListagem, enderecoModel), splitOn: "IdPessoa").ToList();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            //var resultado = conexao.Query<ClienteListagem>(query);
            //return resultado.ToList(); 
        }

        private static ClienteListagem Mapear(ClienteListagem clienteListagem, EnderecoModel enderecoModel) 
        {
            clienteListagem.Endereco = enderecoModel;
            return clienteListagem;
        }

        private static ClienteModel MapearBusca(ClienteModel clienteModel, EnderecoModel enderecoModel)
        {
            clienteModel.Endereco = enderecoModel;
            return clienteModel;
        }

        public static ClienteModel Buscar(int id)
        {           
            var query = @"select c.IdCliente, c.Limite,
            c.IdPessoa, p.IdPessoa, p.Nome, p.Sexo, p.Nascimento, p.Celular, p.Email, p.Cpf,
            c.IdPessoa, e.IdEndereco, e.Cep, e.Rua, e.Cidade, e.Numero, e.Bairro, e.Estado, e.Complemento from
            Pessoa p inner join Cliente c on p.IdPessoa = c.IdPessoa
            inner join Endereco e on c.IdPessoa = e.IdPessoa where c.IdPessoa = @IdPessoa";

            try 
            {
                using (var conexao = new conexao().Connection()) 
                {
                    conexao.Open();
                    return conexao.Query(query, (ClienteModel clienteModel, EnderecoModel enderecoModel)
                    => MapearBusca(clienteModel, enderecoModel), splitOn: "IdPessoa").FirstOrDefault();
                }
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }


            //var parametros = new DynamicParameters();
            //parametros.Add("@Id", id, System.Data.DbType.Int32);

            //var resultado = conexao.QueryFirstOrDefault<ClienteModel>(query, parametros/*new { id }*/);
            //return resultado;
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