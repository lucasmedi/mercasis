using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using MercaSisTOs;

namespace MercaSisBDs
{
    public class BDCliente : ConnectionString
    {
        #region Métodos Públicos

        public void InserirCliente(TOCliente cli)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into Cliente values (@nome, @cpfCnpj, @sexo, @data_nascimento, @data_cadastro, @telefone, @telefoneSec, @email, @senha, @endereco, @numero, @complemento, @cep, @bairro, @cidade, @uf, @apelido)";
                    cmd = Parameters(cmd, cli);
                    cmd.Prepare();
                    cmd.ExecuteReader();
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public void AlterarCliente(TOCliente cli)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                try
                {                    
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = "update Cliente set cli_nome = @nome, cli_cpfCnpj = @cpfCnpj, cli_sexo = @sexo, cli_dataNascimento = @data_nascimento, cli_dataCadastro = @data_cadastro, cli_telefone = @telefone, cli_telefoneSec = @telefoneSec, cli_email = @email, cli_senha = @senha, cli_endereco = @endereco, cli_numero = @numero, cli_complemento = @complemento, cli_cep = @cep, cli_bairro = @bairro, cli_cidade = @cidade, cli_estado @uf where cli_codigo = @codigo";
                    SqlParameter pCodigo = new SqlParameter("@codigo", cli.Codigo);
                    pCodigo.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(pCodigo);
                    cmd = Parameters(cmd, cli);
                    cmd.Prepare();
                    cmd.ExecuteReader();
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public void ExcluirCliente(TOCliente cli)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = "delete Clientes where cli_codigo = @codigo";
                    SqlParameter pCodigo = new SqlParameter("@codigo", cli.Codigo);
                    pCodigo.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(pCodigo);
                    cmd.Prepare();
                    cmd.ExecuteReader();
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }        

        public TOCliente BuscarClientePorCPF(string cli)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                TOCliente clienteBuscado = new TOCliente();
                try
                {
                    string where = "";

                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from Cliente";
                    where += " where cpfCnpj = @cpfCnpj";
                    SqlParameter pCpfCnpj = new SqlParameter("@cpfCnpj",cli);
                    pCpfCnpj.SqlDbType = SqlDbType.VarChar;
                    pCpfCnpj.Size = 255;
                    cmd.Parameters.Add(pCpfCnpj);
                    cmd.CommandText += where;
                    cmd.Prepare();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            PopularDTO(clienteBuscado, reader);                            
                        }
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                return clienteBuscado;
            }
        }

        public TOCliente BuscarClientePorLogin(string usuario,string senha)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                TOCliente cliente = new TOCliente();
                try
                {
                    //TOCliente clienteBuscado = new TOCliente();
                    string where = "";

                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from Cliente";
                    where += " where  cli_apelido= @apelido and cli_senha=@senha";
                    SqlParameter pApelido = new SqlParameter("@apelido",usuario);
                    SqlParameter pSenha = new SqlParameter("@senha",senha);
                    pApelido.SqlDbType = SqlDbType.VarChar;
                    pApelido.Size = 255;
                    pSenha.SqlDbType = SqlDbType.VarChar;
                    pSenha.Size = 255;
                    cmd.Parameters.Add(pApelido);
                    cmd.Parameters.Add(pSenha);
                    cmd.CommandText += where;
                    cmd.Prepare();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            PopularDTO(cliente, reader);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                return cliente;
            }
        }

        #endregion

        #region Métodos Privados

        private SqlCommand Parameters(SqlCommand cmd, TOCliente cli)
        {
            SqlParameter pNome = new SqlParameter("@nome", cli.NomeCompleto);
            pNome.SqlDbType = SqlDbType.VarChar;
            pNome.Size = 255;
            cmd.Parameters.Add(pNome);

            SqlParameter pCpfCnpj = new SqlParameter("@cpfCnpj", cli.Cpf_Cnpj);
            pCpfCnpj.SqlDbType = SqlDbType.VarChar;
            pCpfCnpj.Size = 255;
            cmd.Parameters.Add(pCpfCnpj);

            SqlParameter pEntidade = new SqlParameter("@entidade", cli.Entidade);
            pEntidade.SqlDbType = SqlDbType.VarChar;
            pEntidade.Size = 255;
            cmd.Parameters.Add(pEntidade);

            SqlParameter pSexo = new SqlParameter("@sexo", cli.Sexo);
            pSexo.SqlDbType = SqlDbType.VarChar;
            pSexo.Size = 1;
            cmd.Parameters.Add(pSexo);

            SqlParameter pDataNascimento = new SqlParameter("@data_nascimento", cli.DataNascimento);
            pDataNascimento.SqlDbType = SqlDbType.DateTime;
            cmd.Parameters.Add(pDataNascimento);

            SqlParameter pDataCadastro = new SqlParameter("@data_cadastro", cli.DataCadastro);
            pDataCadastro.SqlDbType = SqlDbType.DateTime;
            cmd.Parameters.Add(pDataCadastro);

            SqlParameter pTelefone = new SqlParameter("@telefone", cli.Telefone);
            pTelefone.SqlDbType = SqlDbType.VarChar;
            pTelefone.Size = 255;
            cmd.Parameters.Add(pTelefone);

            SqlParameter pTelefoneSec = new SqlParameter("@telefoneSec", cli.TelefoneSec);
            pTelefoneSec.SqlDbType = SqlDbType.VarChar;
            pTelefoneSec.Size = 255;
            cmd.Parameters.Add(pTelefoneSec);

            SqlParameter pEmail = new SqlParameter("@email", cli.Email);
            pEmail.SqlDbType = SqlDbType.VarChar;
            pEmail.Size = 255;
            cmd.Parameters.Add(pEmail);

            SqlParameter pSenha = new SqlParameter("@senha", cli.Senha);
            pSenha.SqlDbType = SqlDbType.VarChar;
            pSenha.Size = 255;
            cmd.Parameters.Add(pSenha);

            SqlParameter pEndereco = new SqlParameter("@endereco", cli.Endereco);
            pEndereco.SqlDbType = SqlDbType.VarChar;
            pEndereco.Size = 255;
            cmd.Parameters.Add(pEndereco);

            SqlParameter pNumero = new SqlParameter("@numero", cli.Numero);
            pNumero.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(pNumero);

            SqlParameter pComplemento = new SqlParameter("@complemento", cli.Complemento);
            pComplemento.SqlDbType = SqlDbType.VarChar;
            pComplemento.Size = 255;
            cmd.Parameters.Add(pComplemento);

            SqlParameter pCep = new SqlParameter("@cep", cli.Cep);
            pCep.SqlDbType = SqlDbType.VarChar;
            pCep.Size = 255;
            cmd.Parameters.Add(pCep);

            SqlParameter pBairro = new SqlParameter("@bairro", cli.Bairro);
            pBairro.SqlDbType = SqlDbType.VarChar;
            pBairro.Size = 255;
            cmd.Parameters.Add(pBairro);

            SqlParameter pCidade = new SqlParameter("@cidade", cli.Cidade);
            pCidade.SqlDbType = SqlDbType.VarChar;
            pCidade.Size = 255;
            cmd.Parameters.Add(pCidade);

            SqlParameter pUf = new SqlParameter("@uf", cli.Uf);
            pUf.SqlDbType = SqlDbType.VarChar;
            pUf.Size = 2;
            cmd.Parameters.Add(pUf);

            SqlParameter pApelido = new SqlParameter("@apelido", cli.Apelido);
            pApelido.SqlDbType = SqlDbType.VarChar;
            pApelido.Size = 255;
            cmd.Parameters.Add(pApelido);

            return cmd;
        }

        private TOCliente PopularDTO(TOCliente clienteBuscado, SqlDataReader reader)
        {
            clienteBuscado.Codigo = (Int32)reader["cli_codigo"];
            clienteBuscado.NomeCompleto = (string)reader["cli_nome"];
            clienteBuscado.Cpf_Cnpj = (string)reader["cli_cpfCnpj"];
            if (clienteBuscado.Cpf_Cnpj.Length > 12)
            {
                clienteBuscado.Entidade = (string)reader["cli_entidade"];
            }
            clienteBuscado.Sexo = (string)reader["cli_senha"];
            clienteBuscado.DataNascimento = (DateTime)reader["cli_dataNascimento"];
            clienteBuscado.Telefone = (string)reader["cli_telefone"];
            clienteBuscado.TelefoneSec = (string)reader["cli_telefoneSec"];
            clienteBuscado.Email = (string)reader["cli_email"];
            clienteBuscado.Senha = (string)reader["cli_senha"];
            clienteBuscado.Endereco = (string)reader["cli_endereco"];
            clienteBuscado.Complemento = (string)reader["cli_complemento"];
            clienteBuscado.Cep = (string)reader["cli_cep"];
            clienteBuscado.Bairro = (string)reader["cli_bairro"];
            clienteBuscado.Uf = (string)reader["cli_estado"];
            clienteBuscado.Apelido =(string)reader["cli_apelido"];
            return clienteBuscado;
        }

        #endregion
    }
}