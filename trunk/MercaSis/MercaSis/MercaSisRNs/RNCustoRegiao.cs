using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MercaSisBDs;
using MercaSisTOs;

namespace MercaSisRNs
{
    public class RNCustoRegiao:ConnectionString
    {
        public void CadastrarCustoRegiao(TOCustoRegiao cre)
        {
            BDCustoRegiao bdCre = new BDCustoRegiao();
            bdCre.InserirCustoRegiao(cre);
        }

        public void AlterarCustoRegiao(TOCustoRegiao cre)
        {
            BDCustoRegiao bdCre = new BDCustoRegiao();
            bdCre.AlterarCustoRegiao(cre);
        }

        public void ExcluirCustoRegiao(TOCustoRegiao cre)
        {
            BDCustoRegiao bdCre = new BDCustoRegiao();
            bdCre.ExcluirCustoRegiao(cre);
        }

        public TOCustoRegiao BuscarCustoRegiao_PorCodigo(int codigo)
        {
            TOCustoRegiao toCre = new TOCustoRegiao();
            BDCustoRegiao bdCre = new BDCustoRegiao();
            toCre= bdCre.BuscarCustoRegiaoPorCodigo(codigo);
            return toCre;
        }

        public TOCustoRegiao BuscarCustoRegiao_PorRegiao(string regiao)
        {
            TOCustoRegiao toCre = new TOCustoRegiao();
            BDCustoRegiao bdCre = new BDCustoRegiao();
            toCre = bdCre.BuscarCustoRegiaoPorRegiao(regiao);
            return toCre;
        }
    }
}
