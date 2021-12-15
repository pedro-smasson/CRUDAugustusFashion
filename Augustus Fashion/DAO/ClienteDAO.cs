using Augustus_Fashion.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

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
                        int id = conexao.ExecuteScalar<int>(queryPessoa, new
                        {
                            cliente.Nome,
                            cliente.Sexo,
                            cliente.Nascimento,
                            cliente.Celular,
                            cliente.Email,
                            Cpf = cliente.Cpf.LimparCpfFormatado(),
                        }, transacao);

                        cliente.IdPessoa = id;
                        cliente.Endereco.IdPessoa = id;

                        conexao.Execute(queryCliente, new
                        {
                            cliente.IdPessoa,
                            cliente.Limite,
                        }, transacao);
                        conexao.Execute(queryEndereco, new
                        {
                            cliente.IdPessoa,
                            cliente.Endereco.IdEndereco,
                            cliente.Endereco.Rua,
                            cliente.Endereco.Numero,
                            cliente.Endereco.Bairro,
                            cliente.Endereco.Cidade,
                            cliente.Endereco.Estado,
                            cliente.Endereco.Complemento,
                            Cep = cliente.Endereco.Cep.LimparCepFormatado(),
                        }, transacao);

                        transacao.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void AlterarCliente(ClienteModel cliente)
        {
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
                        conexao.Execute(queryPessoa, new
                        {
                            cliente.Nome,
                            cliente.Sexo,
                            cliente.Nascimento,
                            cliente.Celular,
                            cliente.Email,
                            cliente.IdPessoa,
                            Cpf = cliente.Cpf.LimparCpfFormatado()
                        }, transacao);
                        conexao.Execute(queryCliente, new
                        {
                            cliente.IdPessoa,
                            cliente.Limite
                        }, transacao);
                        conexao.Execute(queryEndereco, new
                        {
                            cliente.IdPessoa,
                            cliente.Endereco.IdEndereco,
                            cliente.Endereco.Rua,
                            cliente.Endereco.Numero,
                            cliente.Endereco.Bairro,
                            cliente.Endereco.Cidade,
                            cliente.Endereco.Estado,
                            cliente.Endereco.Complemento,
                            Cep = cliente.Endereco.Cep.LimparCepFormatado(),
                        }, transacao);

                        transacao.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
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
                        conexao.Execute(queryEndereco, new { cliente.IdPessoa }, transacao);
                        conexao.Execute(queryCliente, new { cliente.IdPessoa }, transacao);
                        conexao.Execute(queryPessoa, new { cliente.IdPessoa }, transacao);

                        transacao.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<ClienteListagem> ListarCliente()
        {
            var query = @"select c.IdCliente, c.Limite,
            c.IdPessoa, p.IdPessoa, p.Nome, p.Sexo, p.Nascimento, p.Celular, p.Email, p.Cpf,
            c.IdPessoa, e.IdEndereco, e.Cep, e.Rua, e.Cidade, e.Numero, e.Bairro, e.Estado, e.Complemento from
            Pessoa p inner join Cliente c on c.IdPessoa = p.IdPessoa
            inner join Endereco e on c.IdPessoa = e.IdPessoa";

            try
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();
                    return conexao.Query(query, (ClienteListagem clienteListagem, EnderecoModel enderecoModel)
                    => Mapear(clienteListagem, enderecoModel), splitOn: "IdPessoa").ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static ClienteModel Buscar(int idCliente)
        {
            var query = @"select c.IdCliente, c.Limite,
            c.IdPessoa, p.IdPessoa, p.Nome, p.Sexo, p.Nascimento, p.Celular, p.Email, p.Cpf,
            c.IdPessoa, e.IdEndereco, e.Cep, e.Rua, e.Cidade, e.Numero, e.Bairro, e.Estado, e.Complemento from
            Pessoa p inner join Cliente c on p.IdPessoa = c.IdPessoa
            inner join Endereco e on c.IdPessoa = e.IdPessoa where c.IdCliente = @IdCliente";

            try
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();

                    return conexao.Query(query, (ClienteModel clienteModel, EnderecoModel enderecoModel)
                    => MapearBusca(clienteModel, enderecoModel), splitOn: "IdPessoa", param: new { IdCliente = idCliente }).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<ClienteListagem> BuscarLista(string nomeCliente)
        {
            var query = @"select c.IdCliente, c.Limite,
            c.IdPessoa, p.IdPessoa, p.Nome, p.Sexo, p.Nascimento, p.Celular, p.Email, p.Cpf,
            c.IdPessoa, e.IdEndereco, e.Cep, e.Rua, e.Cidade, e.Numero, e.Bairro, e.Estado, e.Complemento 
            from Pessoa p inner join Cliente c on c.IdPessoa = p.IdPessoa
            inner join Endereco e on c.IdPessoa = e.IdPessoa where p.Nome like @Nome + '%'";

            try
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();

                    return conexao.Query(query, (ClienteListagem clienteListagem, EnderecoModel enderecoModel)
                     => Mapear(clienteListagem, enderecoModel), new { Nome = nomeCliente }, splitOn: "IdPessoa").ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
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
    }
}