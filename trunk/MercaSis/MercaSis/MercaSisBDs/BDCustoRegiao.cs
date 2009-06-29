using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using MercaSisTOs;

namespace MercaSisBDs
{
    public class BDCustoRegiao : ConnectionString
    {
        #region Métodos Públicos

        public void InserirCustoRegiao(TOCustoRegiao cre)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into CustoRegiao values (@regiao, @preco)";
                    cmd = Parameters(cmd, cre);
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

        public void AlterarCustoRegiao(TOCustoRegiao cre)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = "update CustoRegiao set cre_regiao = @regiao, cre_preco = @preco where cre_codigo = @codigo";
                    SqlParameter pCodigo = new SqlParameter("@codigo", cre.Codigo.Valor);
                    pCodigo.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(pCodigo);
                    cmd = Parameters(cmd, cre);
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

        public void ExcluirCustoRegiao(TOCustoRegiao cre)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = "delete CustoRegiao where cre_codigo = @codigo";
                    SqlParameter pCodigo = new SqlParameter("@codigo", cre.Codigo.Valor);
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

        public TOCustoRegiao BuscarCustoRegiaoPorCodigo(int codigo)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                TOCustoRegiao CustoRegiaoBuscado = new TOCustoRegiao();
                try
                {
                    string where = "";

                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from CustoRegiao";
                    where += " where cre_codigo = @CodReg";
                    SqlParameter pCodReg = new SqlParameter("@CodReg", codigo);
                    pCodReg.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(pCodReg);
                    cmd.CommandText += where;
                    cmd.Prepare();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            PopularDTO(CustoRegiaoBuscado, reader);
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
                return CustoRegiaoBuscado;
            }
        }

        public TOCustoRegiao BuscarCustoRegiaoPorRegiao(string regiao)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                TOCustoRegiao CustoRegiaoBuscado = new TOCustoRegiao();
                try
                {
                    string where = "";

                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from CustoRegiao";
                    where += " where cre_regiao = @CodReg";
                    SqlParameter pReg = new SqlParameter("@CodReg", regiao);
                    pReg.SqlDbType = SqlDbType.VarChar;
                    pReg.Size = 255;
                    cmd.Parameters.Add(pReg);
                    cmd.CommandText += where;
                    cmd.Prepare();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            PopularDTO(CustoRegiaoBuscado, reader);
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
                return CustoRegiaoBuscado;
            }
        }

        #endregion

        #region Métodos Privados

        private SqlCommand Parameters(SqlCommand cmd, TOCustoRegiao cre)
        {
            SqlParameter pRegiao = new SqlParameter("@regiao", cre.Regiao.Valor);
            pRegiao.SqlDbType = SqlDbType.VarChar;
            pRegiao.Size = 255;
            cmd.Parameters.Add(pRegiao);

            SqlParameter pPreco = new SqlParameter("@preco", cre.Custo.Valor);
            pPreco.SqlDbType = SqlDbType.Float;
            cmd.Parameters.Add(pPreco);

            return cmd;
        }

        private TOCustoRegiao PopularDTO(TOCustoRegiao custoRegBuscado, SqlDataReader reader)
        {
            custoRegBuscado.Codigo.Valor= (Int32)reader["cre_codigo"];
            custoRegBuscado.Regiao.Valor = (string)reader["cre_regioao"];
            custoRegBuscado.Custo.Valor = (Int32)reader["cre_preco"];

            return custoRegBuscado;
        }
        #endregion
    }
}
