using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MercaSisTOs
{
    public class TOPedido
    {
        public Campo<int> CodigoPedido = new Campo<int>();
        public Campo<int> CodigoCliente = new Campo<int>();
        public Campo<int> CodigoItemProd = new Campo<int>();
        public Campo<string> EnderecoEntrega = new Campo<string>();
        public Campo<int> NumeroEntrega = new Campo<int>();
        public Campo<string> BairroEntrega = new Campo<string>();
        public Campo<string> ComplementoEntrega = new Campo<string>();
        public Campo<string> CEPEntrega = new Campo<string>();
        public Campo<string> CidadeEntrega = new Campo<string>();
        public Campo<string> EstadoEntrega = new Campo<string>();
        public Campo<float> PrecoLiquido = new Campo<float>();
        public Campo<float> PrecoFrete = new Campo<float>();
        public Campo<double> PrecoTotal = new Campo<double>();
        public Campo<string> FormaPagto = new Campo<string>();
        public Campo<string> Situacao = new Campo<string>();
        public Campo<DateTime> DataPedido = new Campo<DateTime>();
        public Campo<DateTime> DataEntrega = new Campo<DateTime>();
    }   
}