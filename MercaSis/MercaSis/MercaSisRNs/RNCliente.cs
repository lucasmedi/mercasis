using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MercaSisTOs;
using MercaSisBDs;

namespace MercaSisRNs
{
    public class RNCliente
    {
        public void CadastraCliente(TOCliente cli)
        {
            BDCliente bdCli = new BDCliente();
            bdCli.InserirCliente(cli);
        }

        public void AlterarCliente(TOCliente cli)
        {
            BDCliente bdCli = new BDCliente();
            bdCli.AlterarCliente(cli);
        }

        public void ExcluirCliente(TOCliente cli)
        {
            BDCliente bdCli = new BDCliente();
            bdCli.ExcluirCliente(cli);
        }

        public TOCliente BuscarPorLogin(string user, string password)
        {
            BDCliente bdCli = new BDCliente();
            TOCliente cliente = bdCli.BuscarClientePorLogin(user, password);
            return cliente;
        }

        public TOCliente BuscarClientePorCPF(string cpf_Cnpf)
        {
            BDCliente bdCli = new BDCliente();
            TOCliente cliente = bdCli.BuscarClientePorCPF(cpf_Cnpf);
            return cliente;
        }


    }
}
