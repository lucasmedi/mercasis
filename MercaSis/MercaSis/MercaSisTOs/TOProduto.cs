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
        public Campo<double> PrecoUnit = new Campo<double>();
        public Campo<string> Descricao = new Campo<string>();
        public Campo<int> QuantidadeEstoque = new Campo<int>();
        public Campo<double> Peso = new Campo<double>();
        public Campo<int> Categoria = new Campo<int>();
        public Campo<string> Imagem = new Campo<string>();
    }
}
