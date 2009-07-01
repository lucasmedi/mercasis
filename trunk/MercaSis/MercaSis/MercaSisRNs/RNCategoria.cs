using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MercaSisTOs;
using MercaSisBDs;

namespace MercaSisRNs
{
    class RNCategoria
    {
        public void CadastrarCategoria(TOCategoria cat)
        {
            BDCategoria bdCat = new BDCategoria();
            bdCat.InserirCategoria(cat);
        }

        public void AlterarCategoria(TOCategoria cat)
        {
            BDCategoria bdCat = new BDCategoria();
            bdCat.AlterarCategoria(cat);
        }

        public void ExcluirCategoria(TOCategoria cat)
        {
            BDCategoria bdCat = new BDCategoria();
            bdCat.ExcluirCategoria(cat);
        }
    }
}
