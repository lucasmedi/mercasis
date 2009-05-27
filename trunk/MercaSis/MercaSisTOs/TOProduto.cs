using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MercaSisTOs
{
    public class TOProduto
    {
        public Campo<int> Codigo = new Campo<int>();
        public Campo<string> Nome = new Campo<string>();
        public Campo<string> Descricao = new Campo<string>();
        public Campo<double> PrecoUnit = new Campo<double>();
        public Campo<double> Peso = new Campo<double>();
        public Campo<string> Categoria = new Campo<string>();
        public Campo<int> Quantidade = new Campo<int>();
    }
}
