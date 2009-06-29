using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MercaSisTOs;
using MercaSisBDs;

namespace MercaSisRNs
{
    public class RNProduto
    {
        public List<TOProduto> BuscarProdutos(string pro, string categoria)
        {
            List<TOProduto> listaProduto = new List<TOProduto>();
            BDProduto bdPro = new BDProduto();
            listaProduto = bdPro.BuscarProdutoPorNomeECategoria(pro, categoria);
            return listaProduto;
        }

        public List<string> ListarCategoria(List<string> Categorias)
        {
            BDProduto bdPro = new BDProduto();
            bdPro.BuscaCategoria(Categorias);

            return Categorias;
        }

        public int BuscarCodCategoria(string categNome)
        {
            BDProduto bdPro = new BDProduto();
            int codCategoria = bdPro.BuscaCodigoCategoria(categNome);
            return codCategoria;
        }

        public void CadastrarNovaCategoria(string categoria)
        {
            BDProduto bdPro = new BDProduto();
            bdPro.InserirCategoria(categoria);
        }

        public void InserirProduto(TOProduto pro)
        {
            BDProduto bdPPro = new BDProduto();
            bdPPro.InserirProduto(pro);
        }

        public void AlterarProduto(TOProduto pro)
        {
            BDProduto bdPro = new BDProduto();
            bdPro.AlterarProduto(pro);
        }

        public void ExcluirProduto(TOProduto pro)
        {
            BDProduto bdPro = new BDProduto();
            bdPro.ExcluirProduto(pro);
        }

        public List<string> Convert_Pro(List<TOProduto> produto)
        {
            List<string> lista = new List<string>();
            foreach (TOProduto item in produto)
            {


            }
            return lista;
        }
    }
}
