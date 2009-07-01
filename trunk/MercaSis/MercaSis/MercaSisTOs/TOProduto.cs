using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MercaSisTOs
{
    public class TOProduto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double PrecoUnit { get; set; }
        public string Descricao { get; set; }
        public int QuantidadeEstoque { get; set; }
        public double Peso { get; set; }
        public int Categoria { get; set; }
        public string Imagem { get; set; }        
    }
}
