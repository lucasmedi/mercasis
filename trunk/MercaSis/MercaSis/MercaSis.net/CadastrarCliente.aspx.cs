using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using MercaSisTOs;
using System.Text;
using MercaSisRNs;

namespace MercaSisFE
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["txtCEPNovo"] != null)
            {
                txtCEPIni.Text = Session["txtCEPNovo"].ToString();
            }
        }

        protected void btnProsseguir_Click(object sender, EventArgs e)
        {
            #region Preparando o Cadastramento de um Novo Cliente
            TOCliente cliente = new TOCliente();
            cliente.NomeCompleto = txtNome.Text;
            if (txtCPF.Enabled == true)
            {
                cliente.Cpf_Cnpj = txtCPF.Text;
                cliente.Entidade = "";
            }
            else
            {
                cliente.Cpf_Cnpj = txtCNPJ.Text;
                cliente.Entidade = txtEntidade.Text;
            }
            cliente.Sexo = rblSexo.SelectedValue;
            cliente.DataNascimento = Convert_Data(txtDataNasc.Text);
            cliente.DataCadastro = DateTime.Now;
            cliente.Telefone = Convert_Telefone(txtDDDRes.Text, txtTelRes.Text);
            cliente.TelefoneSec = Convert_Telefone(txtDDDCel.Text, txtTelCel.Text);
            cliente.Email = txtEmail.Text;
            if (txtSenha.Text == txtConfSenha.Text)
            {
                cliente.Senha = txtSenha.Text;
            }
            cliente.Apelido = txtComoChamar.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Numero = Convert.ToInt32(txtNumero.Text);
            cliente.Complemento = txtComplemento.Text;
            cliente.Cep = Converte_CEP(txtCEPIni.Text, txtCEPFim.Text);
            cliente.Bairro = txtBairro.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Uf = ddlEstado.SelectedValue;
            RNCliente rnCli = new RNCliente();
            rnCli.CadastraCliente(cliente);

            #endregion
        }

        public DateTime Convert_Data(string data)
        {
            #region Convertendo texto para data
            string []dataConv=data.Split('/');
            int dia = Convert.ToInt32(dataConv[0]);
            int mes = Convert.ToInt32(dataConv[1]);
            int ano = Convert.ToInt32(dataConv[2]);
            DateTime Time = new DateTime(ano,mes,dia);
            return Time;
            #endregion
        }
        public string Convert_Telefone(string ddd, string tel)
        {
            string telefone="";
            telefone = ddd + tel;
            return telefone;
        }
        public string Converte_CEP(string cepIni, string cepFim)
        {
            string cep = "";
            cep = cepIni + cepFim;
            return cep;
        }
        protected void lkbAlterarEntCad_Click(object sender, EventArgs e)
        {
            #region Altera entre pessoa fisica e juridica
            //Ativa os campos de Pessoa Fisica
            if (txtCPF.Enabled == true)
            {
                lblCPF_CNPJ.Text = "CNPJ:";
                lkbAlterarEntCad.Text = "Alterar para Pessoa Fisica";
                lblHead.Text = "Cadastro de Pessoa Juridica";
                txtCNPJ.Enabled = true;
                txtCNPJ.Visible = true;
                txtCPF.Visible = false;
                txtCPF.Enabled = false;
                txtEntidade.Visible = true;
                txtEntidade.Enabled = true;
                lblEntidade.Visible = true;
                lblEntidade.Enabled = true;
            }
            else //Ativa os campos de Pessoa Juridica
            {
                lblCPF_CNPJ.Text = "CPF:";
                lkbAlterarEntCad.Text = "Alterar para Pessoa Juridica";
                lblHead.Text = "Cadastro de Pessoa Fisica";
                txtCNPJ.Enabled = false;
                txtCNPJ.Visible = false;
                txtCPF.Visible = true;
                txtCPF.Enabled = true;
                txtEntidade.Visible = false;
                txtEntidade.Enabled = false;
                lblEntidade.Visible = false;
                lblEntidade.Enabled = false;
            }
            #endregion
        }
    }
}
