using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using MercaSisTOs;

namespace MercaSisBDs
{
    public class BDPedido : ConnectionString
    {
        #region Métodos Públicos

        public void InserirPedido(TOPedido ped)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into Pedido values (@codigoCliente, @codigoItens," +
                        " @enderecoEntrega, @numeroEntrega, @bairroEntrega, @compEntrega, @cidadeEntrega," +
                        " @estadoEntrega, @cepEntrega, @precoLiq, @precoFrete, @precoTotal, @formaPagto," +
                        " @situacao, @dataPedido, @dataEntrega)";
                    cmd = Parameters(cmd, ped);
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

        public void AlterarPedido(TOPedido ped)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                try
                {
                    long codigo = ped.CodigoPedido.Valor;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = "update Pedido set ped_codigo_cliente = @codigoCliente," +
                        " ped_codigo_items = @codigoItens, ped_endereco_entrega = @enderecoEntrega," +
                        " ped_numero_entrega = @numeroEntrega, ped_bairro_entrega = @bairroEntrega," +
                        " ped_comp_entrega = @compEntrega, ped_cidade_entrega = @cidadeEntrega," +
                        " ped_estado_entrega = @estadoEntrega, ped_cep_entrega = @cepEntrega, " +
                        "ped_preco_liq = @precoLiq, ped_preco_frete = @precoFrete," +
                        " ped_preco_total = @precoTotal,  ped_forma_pagto = @formaPagto," +
                        " ped_situacao = @situacao, ped_data_pedido = @dataPedido," +
                        " ped_data_entrega = @dataEntrega where ped_codigo = @codigo";

                    SqlParameter pCodigo = new SqlParameter("@codigo", ped.CodigoPedido.Valor);
                    pCodigo.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(pCodigo);

                    cmd = Parameters(cmd, ped);
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

        public void ExcluirPedido(TOPedido ped)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = "delete Pedido where ped_codigo = @codigo";
                    SqlParameter pCodigo = new SqlParameter("@codigo", ped.CodigoPedido.Valor);
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

        public List<TOPedido> BuscarPedido()
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                TOPedido ped = new TOPedido();
                List<TOPedido> listaTO = new List<TOPedido>();
                try
                {
                    //TOCliente clienteBuscado = new TOCliente();
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from Pedido";
                    cmd.Prepare();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            ped = PopularDTO(ped, reader);
                            listaTO.Add(ped);
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
                return listaTO;
            }
        }

        #endregion

        #region Métodos Privados

        private SqlCommand Parameters(SqlCommand cmd, TOPedido ped)
        {
            SqlParameter pCodigoCliente = new SqlParameter("@codigoCliente", ped.CodigoCliente.Valor);
            pCodigoCliente.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(pCodigoCliente);

            SqlParameter pCodigoItens = new SqlParameter("@codigoItens", ped.CodigoItemProd.Valor);
            pCodigoItens.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(pCodigoItens);

            SqlParameter pEnderecoEntrega = new SqlParameter("@enderecoEntrega", ped.EnderecoEntrega.Valor);
            pEnderecoEntrega.SqlDbType = SqlDbType.VarChar;
            pEnderecoEntrega.Size = 255;
            cmd.Parameters.Add(pEnderecoEntrega);

            SqlParameter pNumeroEntrega = new SqlParameter("@numeroEntrega", ped.NumeroEntrega.Valor);
            pNumeroEntrega.SqlDbType = SqlDbType.VarChar;
            pNumeroEntrega.Size = 255;
            cmd.Parameters.Add(pNumeroEntrega);

            SqlParameter pBairroEntrega = new SqlParameter("@bairroEntrega", ped.BairroEntrega.Valor);
            pBairroEntrega.SqlDbType = SqlDbType.VarChar;
            pBairroEntrega.Size = 255;
            cmd.Parameters.Add(pBairroEntrega);

            SqlParameter pCompEntrega = new SqlParameter("@compEntrega", ped.ComplementoEntrega.Valor);
            pCompEntrega.SqlDbType = SqlDbType.VarChar;
            pCompEntrega.Size = 255;
            cmd.Parameters.Add(pCompEntrega);

            SqlParameter pCidadeEntrega = new SqlParameter("@cidadeEntrega", ped.CidadeEntrega.Valor);
            pCidadeEntrega.SqlDbType = SqlDbType.VarChar;
            pCidadeEntrega.Size = 255;
            cmd.Parameters.Add(pCidadeEntrega);

            SqlParameter pEstadoEntrega = new SqlParameter("@estadoEntrega", ped.EstadoEntrega.Valor);
            pEstadoEntrega.SqlDbType = SqlDbType.VarChar;
            pEstadoEntrega.Size = 255;
            cmd.Parameters.Add(pEstadoEntrega);

            SqlParameter pCepEntrega = new SqlParameter("@cepEntrega", ped.CEPEntrega.Valor);
            pCepEntrega.SqlDbType = SqlDbType.VarChar;

            pCepEntrega.Size = 255;
            cmd.Parameters.Add(pCepEntrega);

            SqlParameter pPrecoLiq = new SqlParameter("@precoLiq", ped.PrecoLiquido.Valor);
            pPrecoLiq.SqlDbType = SqlDbType.Float;
            cmd.Parameters.Add(pPrecoLiq);

            SqlParameter pPrecoFrete = new SqlParameter("@precoFrete", ped.PrecoFrete.Valor);
            pPrecoFrete.SqlDbType = SqlDbType.Float;
            cmd.Parameters.Add(pPrecoFrete);

            SqlParameter pPrecoTotal = new SqlParameter("@precoTotal", ped.PrecoTotal.Valor);
            pPrecoTotal.SqlDbType = SqlDbType.Float;
            cmd.Parameters.Add(pPrecoTotal);

            SqlParameter pFormaPagto = new SqlParameter("@formaPagto", ped.FormaPagto.Valor);
            pFormaPagto.SqlDbType = SqlDbType.VarChar;
            pFormaPagto.Size = 255;
            cmd.Parameters.Add(pFormaPagto);

            SqlParameter pSituacao = new SqlParameter("@situacao", ped.Situacao.Valor);
            pSituacao.SqlDbType = SqlDbType.VarChar;
            pSituacao.Size = 255;
            cmd.Parameters.Add(pSituacao);

            SqlParameter pDataPedido = new SqlParameter("@dataPedido", ped.DataPedido.Valor);
            pDataPedido.SqlDbType = SqlDbType.DateTime;
            cmd.Parameters.Add(pDataPedido);

            SqlParameter pDataEntrega = new SqlParameter("@dataEntrega", ped.DataEntrega.Valor);
            pDataEntrega.SqlDbType = SqlDbType.DateTime;
            cmd.Parameters.Add(pDataEntrega);

            return cmd;
        }

        private TOPedido PopularDTO(TOPedido pedidoBuscado, SqlDataReader reader)
        {
            pedidoBuscado.CodigoPedido.Valor = (Int32)reader["ped_codigo"];
            pedidoBuscado.CodigoCliente.Valor = (Int32)reader["ped_codigo_cliente"];
            pedidoBuscado.CodigoItemProd.Valor = (Int32)reader["ped_codigo_items"];
            pedidoBuscado.EnderecoEntrega.Valor = (string)reader["ped_endereco_entrega"];
            pedidoBuscado.NumeroEntrega.Valor = (Int32)reader["ped_numero_entrega"];
            pedidoBuscado.BairroEntrega.Valor = (string)reader["ped_bairro_entrega"];
            pedidoBuscado.ComplementoEntrega.Valor = (string)reader["ped_comp_entrega"];
            pedidoBuscado.CidadeEntrega.Valor = (string)reader["ped_cidade_entrega"];
            pedidoBuscado.EstadoEntrega.Valor = (string)reader["ped_estado_entrega"];
            pedidoBuscado.CEPEntrega.Valor = (string)reader["ped_cep_entrega"];
            pedidoBuscado.PrecoLiquido.Valor = (float)reader["ped_preco_liq"];
            pedidoBuscado.PrecoFrete.Valor = (float)reader["ped_preco_frete"];
            pedidoBuscado.PrecoTotal.Valor = (float)reader["ped_preco_total"];
            pedidoBuscado.FormaPagto.Valor = (string)reader["ped_forma_pagto"];
            pedidoBuscado.Situacao.Valor = (string)reader["ped_situacao"];
            pedidoBuscado.DataPedido.Valor = (DateTime)reader["ped_data_pedido"];
            pedidoBuscado.DataEntrega.Valor = (DateTime)reader["ped_data_entrega"];

            return pedidoBuscado;
        }

        #endregion
    }
}
