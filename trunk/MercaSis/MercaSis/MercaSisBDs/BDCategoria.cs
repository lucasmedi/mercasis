using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MercaSisTOs;
using System.Data;
using System.Data.SqlClient;

namespace MercaSisBDs
{
    public class BDCategoria : ConnectionString
    {
        #region Métodos Públicos

        public void InserirCategoria(TOCategoria cat) 
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into Categoria values (@nome)";
                    cmd = Parameters(cmd, cat);
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

        public void AlterarCategoria(TOCategoria cat)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = "update Categoria set cat_nome = @nome where cat_codigo = @codigo";

                    SqlParameter pCodigo = new SqlParameter("@codigo", cat.Codigo);
                    pCodigo.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(pCodigo);

                    cmd = Parameters(cmd, cat);
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

        public void ExcluirCategoria(TOCategoria cat) 
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = "delete Categoria where cat_codigo = @codigo";

                    SqlParameter pCodigo = new SqlParameter("@codigo", cat.Codigo);
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

        #endregion

        #region Métodos Privados

        private SqlCommand Parameters(SqlCommand cmd, TOCategoria cat)
        {
            SqlParameter pNome = new SqlParameter("@nome", cat.Nome);
            pNome.SqlDbType = SqlDbType.VarChar;
            cmd.Parameters.Add(pNome);

            return cmd;
        }

        private TOCategoria PopularDTO(TOCategoria categoriaBuscada, SqlDataReader reader)
        {
            categoriaBuscada.Codigo = (Int32)reader["cat_codigo"];
            categoriaBuscada.Nome = (string)reader["cat_nome"];

            return categoriaBuscada;
        }

        #endregion
    }
}
