using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MercaSisBDs;
using MercaSisTOs;

namespace MercaSisRNs
{
    public class RNPedido :ConnectionString
    {
        public void CadastrarPedido(TOPedido ped)
        {
            BDPedido bdPed = new BDPedido();
            bdPed.InserirPedido(ped);
        }

        public void AlterarPedido(TOPedido ped)
        {
            BDPedido bdPed = new BDPedido();
            bdPed.AlterarPedido(ped);
        }

        public void ExcluirPedido(TOPedido ped)
        {
            BDPedido bdPed = new BDPedido();
            bdPed.ExcluirPedido(ped);
        }

        public List<TOPedido> BuscarPedidos()
        {
            BDPedido bdPed = new BDPedido();
            return bdPed.BuscarPedido();
        }
    }
}
