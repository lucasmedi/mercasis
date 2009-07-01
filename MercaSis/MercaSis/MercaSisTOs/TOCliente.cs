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
        public int Codigo { get; set; }
        public string NomeCompleto { get; set; }
        public string Cpf_Cnpj { get; set; }
        public string Entidade { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Telefone { get; set; }
        public string TelefoneSec { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Pais { get; set; }
        public string Apelido { get; set; }
    }
}
