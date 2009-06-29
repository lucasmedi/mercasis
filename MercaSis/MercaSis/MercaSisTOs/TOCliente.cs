using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MercaSisTOs
{
    /// <summary>
    /// Classe TOCliente com as instâncias dos objetos com os dados do Cliente
    /// </summary>
    public class TOCliente
    {
        public Campo<Int32> Codigo = new Campo<Int32>();
        public Campo<string> NomeCompleto = new Campo<string>();
        public Campo<string> Cpf_Cnpj = new Campo<string>();
        public Campo<string> Entidade = new Campo<string>();
        public Campo<string> Sexo = new Campo<string>();
        public Campo<DateTime> DataNascimento = new Campo<DateTime>();
        public Campo<DateTime> DataCadastro = new Campo<DateTime>();
        public Campo<string> Telefone = new Campo<string>();
        public Campo<string> TelefoneSec = new Campo<string>();
        public Campo<string> Email = new Campo<string>();
        public Campo<string> Senha = new Campo<string>();
        public Campo<string> Endereco = new Campo<string>();
        public Campo<int> Numero = new Campo<int>();
        public Campo<string> Complemento = new Campo<string>();
        public Campo<string> Cep = new Campo<string>();
        public Campo<string> Bairro = new Campo<string>();
        public Campo<string> Cidade = new Campo<string>();
        public Campo<string> Uf = new Campo<string>();
        public Campo<string> Pais = new Campo<string>();
        public Campo<string> Apelido = new Campo<string>();
    }
}
