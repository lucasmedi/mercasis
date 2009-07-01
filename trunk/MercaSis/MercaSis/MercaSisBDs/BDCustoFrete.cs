using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using MercaSisTOs;

namespace MercaSisBDs
{
    public class BDCustoFrete : ConnectionString
    {
        #region Métodos Públicos

        public void InserirCustoFrete(TOCustoFrete cfr)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into CustoFrete values (@preco)";
                    cmd = Parameters(cmd, cfr);
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

        public void AlterarCustoFrete(TOCustoFrete cfr)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = "update CustoFrete set cfr_preco = @preco where cfr_codigo = @codigo";

                    SqlParameter pCodigo = new SqlParameter("@codigo", cfr.Codigo);
                    pCodigo.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(pCodigo);

                    cmd = Parameters(cmd, cfr);
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

        public void ExcluirCustoFrete(TOCustoFrete cfr)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = "delete CustoFrete where cfr_codigo = @codigo";

                    SqlParameter pCodigo = new SqlParameter("@codigo", cfr.Codigo);
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

        public TOCustoFrete BuscarCustoFrete_PorCodio(int codigo)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                TOCustoFrete CustoFreteBuscado = new TOCustoFrete();
                try
                {
                    string where = "";

                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from CustoFrete";
                    where += " where cfr_codigo = @CodFre";
                    SqlParameter pCodReg = new SqlParameter("@CodFre", codigo);
                    pCodReg.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(pCodReg);
                    cmd.CommandText += where;
                    cmd.Prepare();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            PopularDTO(CustoFreteBuscado, reader);
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
                return CustoFreteBuscado;
            }
        }

        public TOCustoFrete BuscarCustoFrete()
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                TOCustoFrete CustoFreteBuscado = new TOCustoFrete();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from CustoFrete";
                    cmd.Prepare();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            PopularDTO(CustoFreteBuscado, reader);
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
                return CustoFreteBuscado;
            }
        }

        #endregion

        #region Métodos Privados

        private SqlCommand Parameters(SqlCommand cmd, TOCustoFrete cfr)
        {
            SqlParameter pPreco = new SqlParameter("@preco", cfr.Custo);
            pPreco.SqlDbType = SqlDbType.Float;
            cmd.Parameters.Add(pPreco);

            return cmd;
        }

        private TOCustoFrete PopularDTO(TOCustoFrete custoFreBuscado, SqlDataReader reader)
        {
            custoFreBuscado.Codigo = (Int32)reader["cfr_codigo"];
            custoFreBuscado.Custo = (Int32)reader["cfr_preco"];

            return custoFreBuscado;
        }

        #endregion
    }
}
