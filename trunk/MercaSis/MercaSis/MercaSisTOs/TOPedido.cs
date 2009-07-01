using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MercaSisTOs
{
    public class TOPedido
    {
        public int CodigoPedido { get; set; }
        public int CodigoCliente { get; set; }
        public int CodigoItemProd { get; set; }
        public string EnderecoEntrega { get; set; }
        public int NumeroEntrega { get; set; }
        public string BairroEntrega { get; set; }
        public string ComplementoEntrega { get; set; }
        public string CEPEntrega { get; set; }
        public string CidadeEntrega { get; set; }
        public string EstadoEntrega { get; set; }
        public float PrecoLiquido { get; set; }
        public float PrecoFrete { get; set; }
        public float PrecoTotal { get; set; }
        public string FormaPagto { get; set; }
        public string Situacao { get; set; }
        public DateTime DataPedido { get; set; }
        public DateTime DataEntrega { get; set; }
    }   
}