using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MercaSisTOs;
using MercaSisBDs;

namespace MercaSisRNs
{
    public class RNCustoFrete :ConnectionString
    {
        public void CadastrarCustoFrete(TOCustoFrete cfr)
        {
            BDCustoFrete bdCfe = new BDCustoFrete();
            bdCfe.InserirCustoFrete(cfr);
        }

        public void AlterarCustoFrete(TOCustoFrete crf)
        {
            BDCustoFrete bdCfe = new BDCustoFrete();
            bdCfe.AlterarCustoFrete(crf);
        }

        public void ExcluirCustoFrete(TOCustoFrete crf)
        {
            BDCustoFrete bdCfe = new BDCustoFrete();
            bdCfe.ExcluirCustoFrete(crf);
        }

        public TOCustoFrete BuscarCustoFrete_PorCodigo(int codigo)
        {
            TOCustoFrete toCfe = new TOCustoFrete();
            BDCustoFrete bdCfe = new BDCustoFrete();
            toCfe = bdCfe.BuscarCustoFrete_PorCodio(codigo);
            return toCfe;
        }

        public TOCustoFrete BuscarCustoFrete()
        {
            TOCustoFrete toCfe = new TOCustoFrete();
            BDCustoFrete bdCfe = new BDCustoFrete();
            toCfe = bdCfe.BuscarCustoFrete();
            return toCfe;
        }
    }
}
