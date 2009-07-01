using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using MercaSisTOs;

namespace MercaSisBDs
{
    public class BDProduto : ConnectionString
    {
        #region Métodos Públicos

        public void InserirProduto(TOProduto prod)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into Produto values (@nome, @preco, @qtdEstoque, @peso, @categoria, @descricao, @imagem)";
                    cmd = Parameters(cmd, prod);
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

        public void AlterarProduto(TOProduto prod)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                try
                {
                    long codigo = prod.Codigo;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = "update Produto set pro_nome = @nome, pro_preco = @preco," +
                        "pro_qtd_estoque = @qtdEstoque, pro_peso = @peso, pro_categoria = @categoria," +
                        "pro_descricao = @descricao, pro_imagem = @imagem where pro_codigo = @codigo";

                    SqlParameter pCodigo = new SqlParameter("@codigo", prod.Codigo);
                    pCodigo.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(pCodigo);

                    cmd = Parameters(cmd, prod);
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

        public void ExcluirProduto(TOProduto prod)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = "delete Produto where prod_codigo = @codigo";

                    SqlParameter pCodigo = new SqlParameter("@codigo", prod.Codigo);
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

        public List<TOProduto> BuscarProdutoPorNomeECategoria(string produto, string categoria)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                TOProduto pro = new TOProduto();
                List<TOProduto> listaTO = new List<TOProduto>();
                try
                {
                    //TOCliente clienteBuscado = new TOCliente();
                    string where = "";

                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    SqlParameter pProduto;
                    SqlParameter pCategoria;
                    if (categoria != null)
                    {
                        cmd.CommandText = "select * from Produto";
                        where += " where  pro_nome= @nome";
                        pProduto = new SqlParameter("@nome", produto);
                        pProduto.SqlDbType = SqlDbType.VarChar;
                        pProduto.Size = 255;
                        cmd.Parameters.Add(pProduto);
                    }
                    else
                    {
                        cmd.CommandText = "select * from Produto p,Categoria c";
                        where += " where  p.pro_nome= @produto and c.cat_nome=@categoria";
                        pProduto = new SqlParameter("@produto", produto);
                        pCategoria = new SqlParameter("@categoria", categoria);
                        pProduto.SqlDbType = SqlDbType.VarChar;
                        pProduto.Size = 255;
                        pCategoria.SqlDbType = SqlDbType.VarChar;
                        pCategoria.Size = 255;
                        cmd.Parameters.Add(pProduto);
                        cmd.Parameters.Add(pCategoria);
                    }
                    cmd.CommandText += where;
                    cmd.Prepare();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            pro = PopularDTO(pro, reader);
                            listaTO.Add(pro);
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

        public List<string> BuscaCategoria(List<string> listaTO)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                string categ = "";
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from Categoria";
                    cmd.Prepare();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            categ = PopularCategoria(reader);
                            listaTO.Add(categ);
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

        public int BuscaCodigoCategoria(string categNome)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                int codCat = 0;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    SqlParameter pCategoriaNome;
                    cmd.CommandText = "select cat_codigo from Categoria where cat_nome = @nome";
                    pCategoriaNome = new SqlParameter("@nome", categNome);
                    pCategoriaNome.SqlDbType = SqlDbType.VarChar;
                    pCategoriaNome.Size = 255;
                    cmd.Parameters.Add(pCategoriaNome);
                    cmd.Prepare();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            codCat = PopularCodCategoria(reader);
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
                return codCat;
            }
        }

        #endregion

        #region Métodos Privados

        private SqlCommand Parameters(SqlCommand cmd, TOProduto prod)
        {
            SqlParameter pNome = new SqlParameter("@nome", prod.Nome);
            pNome.SqlDbType = SqlDbType.VarChar;
            pNome.Size = 255;
            cmd.Parameters.Add(pNome);

            SqlParameter pPreco = new SqlParameter("@preco", prod.PrecoUnit);
            pPreco.SqlDbType = SqlDbType.Float;
            cmd.Parameters.Add(pPreco);

            SqlParameter pEstoque = new SqlParameter("@qtdEstoque", prod.QuantidadeEstoque);
            pEstoque.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(pEstoque);

            SqlParameter pPeso = new SqlParameter("@peso", prod.Peso);
            pPeso.SqlDbType = SqlDbType.Float;
            cmd.Parameters.Add(pPeso);

            SqlParameter pCategoria = new SqlParameter("@categoria", prod.Categoria);
            pCategoria.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(pCategoria);

            SqlParameter pDescricao = new SqlParameter("@descricao", prod.Descricao);
            pDescricao.SqlDbType = SqlDbType.VarChar;
            pDescricao.Size = 255;
            cmd.Parameters.Add(pDescricao);

            SqlParameter pImagem = new SqlParameter("@imagem", prod.Imagem);
            pImagem.SqlDbType = SqlDbType.VarChar;
            pImagem.Size = 255;
            cmd.Parameters.Add(pImagem);

            return cmd;
        }

        private TOProduto PopularDTO(TOProduto produtoBuscado, SqlDataReader reader)
        {
            produtoBuscado.Codigo = (Int32)reader["pro_codigo"];
            produtoBuscado.Nome = (string)reader["pro_nome"];
            produtoBuscado.PrecoUnit = (double)reader["pro_preco"];
            produtoBuscado.QuantidadeEstoque = (Int32)reader["pro_qtd_estoque"];
            produtoBuscado.Peso = (double)reader["pro_peso"];
            produtoBuscado.Categoria = (Int32)reader["pro_categoria_codigo"];
            produtoBuscado.Descricao = (string)reader["pro_descricao"];
            //produtoBuscado.Imagem = (string)reader["pro_imagem"];

            return produtoBuscado;
        }

        public void InserirCategoria(string categoria)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    SqlParameter pNome;
                    cmd.CommandText = "insert into Categoria values (@nome)";
                    pNome = new SqlParameter("@nome", categoria);
                    pNome.SqlDbType = SqlDbType.VarChar;
                    pNome.Size = 255;
                    cmd.Parameters.Add(pNome);
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

        private string PopularCategoria(SqlDataReader reader)
        {
            string CategoriaBuscada;
            CategoriaBuscada = (string)reader["cat_nome"];

            return CategoriaBuscada;
        }

        private int PopularCodCategoria(SqlDataReader reader)
        {
            int codCategoria;
            codCategoria = (int)reader["cat_codigo"];

            return codCategoria;
        }

        #endregion
    }
}
