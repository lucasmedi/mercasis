using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MercaSisTOs
{
    public class TOItemPedido
    {
        public Campo<int> CodigoPedido = new Campo<int>();
        public Campo<int> CodigoProduto = new Campo<int>();
        public Campo<float> Preco = new Campo<float>();
    }
}
