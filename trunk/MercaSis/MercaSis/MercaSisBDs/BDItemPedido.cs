using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MercaSisBDs;
using MercaSisTOs;

namespace MercaSisBDs
{
    public class BDItemPedido : ConnectionString
    {
        public void InserirItemPedido(TOItemPedido iPed)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into ItemPedido values (@CodPedido,@CodProduto,@Preco)";
                    SqlParameter pCodigo = new SqlParameter("@CodPedido", iPed.CodigoPedido.Valor);
                    pCodigo.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(pCodigo);

                    SqlParameter pCodigoPro = new SqlParameter("@CodProduto", iPed.CodigoProduto.Valor);
                    pCodigoPro.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(pCodigoPro);

                    SqlParameter pPreco = new SqlParameter("@Preco", iPed.Preco.Valor);
                    pPreco.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(pPreco);
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

        public void AlterarItemPedido(TOItemPedido iPed)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = "update ItemPedido set ipe_codigo_produto = @CodProduto, ipe_preco = @Preco";
                    cmd = Parameters(cmd, iPed);
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

        public void ExcluirItemPedido(TOItemPedido iPed)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = "delete ItemPedido where ipe_codigo_pedido = @codigo";
                    SqlParameter pCodigo = new SqlParameter("@codigo", iPed.CodigoPedido.Valor);
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

        public TOItemPedido BuscarItemPedido_PorCodigoPedido(int codigo)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                TOItemPedido ItemPedidoBuscado = new TOItemPedido();
                try
                {
                    string where = "";

                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from ItemPedido";
                    where += " where ipe_codigo_pedido = @CodPedido";
                    SqlParameter pCodPedido = new SqlParameter("@CodPedido", codigo);
                    pCodPedido.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(pCodPedido);
                    cmd.CommandText += where;
                    cmd.Prepare();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            PopularDTO(ItemPedidoBuscado, reader);
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
                return ItemPedidoBuscado;
            }
        }

        public TOItemPedido BuscarItemPedido_PorCodigoProduto(int codigo)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                TOItemPedido ItemPedidoBuscado = new TOItemPedido();
                try
                {
                    string where = "";

                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from ItemPedido";
                    where += " where ipe_codigo_pedido = @CodPedido";
                    SqlParameter pCodPedido = new SqlParameter("@CodPedido", codigo);
                    pCodPedido.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(pCodPedido);
                    cmd.CommandText += where;
                    cmd.Prepare();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            PopularDTO(ItemPedidoBuscado, reader);
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
                return ItemPedidoBuscado;
            }
        }

        private SqlCommand Parameters(SqlCommand cmd, TOItemPedido iPed)
        {
            SqlParameter pCodProduto = new SqlParameter("@CodProduto", iPed.CodigoProduto.Valor);
            pCodProduto.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(pCodProduto);

            SqlParameter pPreco = new SqlParameter("@Preco",iPed.Preco.Valor);
            pPreco.SqlDbType = SqlDbType.Float;
            cmd.Parameters.Add(pPreco);


            return cmd;
        }

        private TOItemPedido PopularDTO(TOItemPedido pedidoBuscado, SqlDataReader reader)
        {
            pedidoBuscado.CodigoPedido.Valor = (Int32)reader["ipe_codigo_pedido"];
            pedidoBuscado.CodigoProduto.Valor = (Int32)reader["ipe_codigo_produto"];
            pedidoBuscado.Preco.Valor = (Int32)reader["ipe_preco"];
            
            return pedidoBuscado;
        }
    }
}
