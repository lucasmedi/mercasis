using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MercaSisBDs;
using MercaSisTOs;

namespace MercaSisRNs
{
    public class RNItemPedido
    {
        public void CadastrarItemPedido(TOItemPedido iPedido)
        {
            BDItemPedido bdIped = new BDItemPedido();
            bdIped.InserirItemPedido(iPedido);
        }

        public void AlterarItemPedido(TOItemPedido iPed)
        {
            BDItemPedido bdIped = new BDItemPedido();
            bdIped.AlterarItemPedido(iPed);
        }

        public void ExcluirItemPedido(TOItemPedido iPed)
        {
            BDItemPedido bdIped = new BDItemPedido();
            bdIped.ExcluirItemPedido(iPed);
        }

        public TOItemPedido BuscarItemPedido_PorCodigoPedido(int cod)
        {
            TOItemPedido toIped = new TOItemPedido();
            BDItemPedido bdIped = new BDItemPedido();
            toIped= bdIped.BuscarItemPedido_PorCodigoPedido(cod);
            return toIped;
        }

        public TOItemPedido BuscarItemPedido_PorCodigoProduto(int cod)
        {
            TOItemPedido toIped = new TOItemPedido();
            BDItemPedido bdIped = new BDItemPedido();
            toIped = bdIped.BuscarItemPedido_PorCodigoProduto(cod);
            return toIped;
        }
    }
}
