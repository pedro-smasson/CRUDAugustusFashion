using Augustus_Fashion.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Augustus_Fashion.DAO
{
    class FuncionarioDAO
    {
        public static void CadastrarFuncionario(FuncionarioModel funcionario)
        {
            var queryPessoa = @"insert into Pessoa output inserted.IdPessoa values(@Nome, @Sexo, @Nascimento, @Celular,
            @Email, @Cpf)";
            var queryfuncionario = @"insert into Funcionario (IdPessoa, Salario, Comissao, Agencia, NumConta, CodConta)
            values(@IdPessoa, @Salario, @Comissao, @Agencia, @NumConta, @CodConta)";
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
                            Nome = funcionario.Nome,
                            Sexo = funcionario.Sexo,
                            Nascimento = funcionario.Nascimento,
                            Celular = funcionario.Celular,
                            Email = funcionario.Email,
                            Cpf = funcionario.Cpf.LimparCpfFormatado(),
                        }, transacao);

                        funcionario.IdPessoa = id;
                        funcionario.Endereco.IdPessoa = id;

                        conexao.Execute(queryfuncionario, funcionario, transacao);
                        conexao.Execute(queryEndereco, new
                        {
                            IdPessoa = funcionario.IdPessoa,
                            IdEndereco = funcionario.Endereco.IdEndereco,
                            Cep = funcionario.Endereco.Cep.LimparCepFormatado(),
                            Rua = funcionario.Endereco.Rua,
                            Numero = funcionario.Endereco.Numero,
                            Bairro = funcionario.Endereco.Bairro,
                            Cidade = funcionario.Endereco.Cidade,
                            Estado = funcionario.Endereco.Estado,
                            Complemento = funcionario.Endereco.Complemento,
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

        private static FuncionarioModel MapearBusca(FuncionarioModel funcionarioModel, EnderecoModel enderecoModel)
        {
            funcionarioModel.Endereco = enderecoModel;
            return funcionarioModel;
        }

        public static FuncionarioModel Buscar(int id)
        {
            var query = @"select f.IdFuncionario, f.Salario, f.Comissao, f.Agencia, f.NumConta, f.CodConta,
            f.IdPessoa, p.IdPessoa, p.Nome, p.Sexo, p.Nascimento, p.Celular, p.Email, p.Cpf,
            f.IdPessoa, e.IdEndereco, e.Cep, e.Rua, e.Cidade, e.Numero, e.Bairro, e.Estado, e.Complemento from
            Pessoa p inner join Funcionario f on p.IdPessoa = f.IdPessoa
            inner join Endereco e on f.IdPessoa = e.IdPessoa where f.IdFuncionario = @IdFuncionario";

            try
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();

                    var parametros = new DynamicParameters();
                    parametros.Add("IdFuncionario", id);

                    return conexao.Query(query, (FuncionarioModel funcionarioModel, EnderecoModel enderecoModel)
                    => MapearBusca(funcionarioModel, enderecoModel), splitOn: "IdPessoa", param: parametros).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void AlterarFuncionario(FuncionarioModel funcionario)
        {
            var queryPessoa = @"update Pessoa set Nome = @Nome, Sexo = @Sexo, Nascimento = @Nascimento,
            Celular = @Celular, Email = @Email, Cpf = @Cpf where IdPessoa = @IdPessoa";
            var queryFuncionario = @"update Funcionario set Salario = @Salario, Comissao = @Comissao, Agencia = @Agencia,
            NumConta = @NumConta, CodConta = @CodConta where IdPessoa = @IdPessoa";
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
                            Nome = funcionario.Nome,
                            Sexo = funcionario.Sexo,
                            Nascimento = funcionario.Nascimento,
                            Celular = funcionario.Celular,
                            Email = funcionario.Email,
                            Cpf = funcionario.Cpf.LimparCpfFormatado(),
                            IdPessoa = funcionario.IdPessoa,
                        }, transacao);

                        conexao.Execute(queryFuncionario, funcionario, transacao);
                        conexao.Execute(queryEndereco, new 
                        {
                            IdPessoa = funcionario.IdPessoa,
                            IdEndereco = funcionario.Endereco.IdEndereco,
                            Cep = funcionario.Endereco.Cep.LimparCepFormatado(),
                            Rua = funcionario.Endereco.Rua,
                            Numero = funcionario.Endereco.Numero,
                            Bairro = funcionario.Endereco.Bairro,
                            Cidade = funcionario.Endereco.Cidade,
                            Estado = funcionario.Endereco.Estado,
                            Complemento = funcionario.Endereco.Complemento,
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

        public static List<FuncionarioListagem> BuscarLista(string nome)
        {
            var query = @"select f.IdFuncionario, f.Comissao, f.Agencia, f.NumConta, f.CodConta,
            f.IdPessoa, p.IdPessoa, p.Nome, p.Sexo, p.Nascimento, p.Celular, p.Email, p.Cpf,
            f.IdPessoa, e.IdEndereco, e.Cep, e.Rua, e.Cidade, e.Numero, e.Bairro, e.Estado, e.Complemento from
            Pessoa p inner join Funcionario f on p.IdPessoa = f.IdPessoa
            inner join Endereco e on f.IdPessoa = e.IdPessoa where p.Nome like @Nome + '%'";

            try
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();

                    return conexao.Query(query, (FuncionarioListagem funcionarioListagem, EnderecoModel funcionarioModel)
                    => Mapear(funcionarioListagem, funcionarioModel), new { Nome = nome}, splitOn: "IdPessoa").ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void ExcluirFuncionario(FuncionarioModel funcionario)
        {

            var queryEndereco = @"delete from Endereco where IdPessoa = @IdPessoa";
            var queryFuncionario = @"delete from Funcionario where IdPessoa = @IdPessoa";
            var queryPessoa = @"delete from Pessoa where IdPessoa = @IdPessoa";

            try
            {
                var conexao = new conexao().Connection();
                {
                    conexao.Open();
                    using (var transacao = conexao.BeginTransaction())
                    {
                        conexao.Execute(queryEndereco, new { IdPessoa = funcionario.IdPessoa }, transacao);
                        conexao.Execute(queryFuncionario, new { IdPessoa = funcionario.IdPessoa }, transacao);
                        conexao.Execute(queryPessoa, new { IdPessoa = funcionario.IdPessoa }, transacao);

                        transacao.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private static FuncionarioListagem Mapear(FuncionarioListagem funcionarioListagem, EnderecoModel enderecoModel)
        {
            funcionarioListagem.Endereco = enderecoModel;
            return funcionarioListagem;
        }

        public static List<FuncionarioListagem> ListarFuncionario()
        {

            var query = @"select f.IdFuncionario, f.Comissao, f.Agencia, f.NumConta, f.CodConta,
            f.IdPessoa, p.IdPessoa, p.Nome, p.Sexo, p.Nascimento, p.Celular, p.Email, p.Cpf,
            f.IdPessoa, e.IdEndereco, e.Cep, e.Rua, e.Cidade, e.Numero, e.Bairro, e.Estado, e.Complemento from
            Pessoa p inner join Funcionario f on f.IdPessoa = p.IdPessoa
            inner join Endereco e on f.IdPessoa = e.IdPessoa";

            try
            {
                using (var conexao = new conexao().Connection())
                {
                    conexao.Open();
                    return conexao.Query(query, (FuncionarioListagem funcionarioListagem, EnderecoModel enderecoModel)
                    => Mapear(funcionarioListagem, enderecoModel), splitOn: "IdPessoa").ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
