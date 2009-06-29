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
            cliente.NomeCompleto.Valor = txtNome.Text;
            if (txtCPF.Enabled == true)
            {
                cliente.Cpf_Cnpj.Valor = txtCPF.Text;
                cliente.Entidade.Valor = "";
            }
            else
            {
                cliente.Cpf_Cnpj.Valor = txtCNPJ.Text;
                cliente.Entidade.Valor = txtEntidade.Text;
            }
            cliente.Sexo.Valor = rblSexo.SelectedValue;
            cliente.DataNascimento.Valor = Convert_Data(txtDataNasc.Text);
            cliente.DataCadastro.Valor = DateTime.Now;
            cliente.Telefone.Valor = Convert_Telefone(txtDDDRes.Text, txtTelRes.Text);
            cliente.TelefoneSec.Valor = Convert_Telefone(txtDDDCel.Text, txtTelCel.Text);
            cliente.Email.Valor = txtEmail.Text;
            if (txtSenha.Text == txtConfSenha.Text)
            {
                cliente.Senha.Valor = txtSenha.Text;
            }
            cliente.Apelido.Valor = txtComoChamar.Text;
            cliente.Endereco.Valor = txtEndereco.Text;
            cliente.Numero.Valor = Convert.ToInt32(txtNumero.Text);
            cliente.Complemento.Valor = txtComplemento.Text;
            cliente.Cep.Valor = Converte_CEP(txtCEPIni.Text, txtCEPFim.Text);
            cliente.Bairro.Valor = txtBairro.Text;
            cliente.Cidade.Valor = txtCidade.Text;
            cliente.Uf.Valor = ddlEstado.SelectedValue;
            RNCliente rnCli = new RNCliente();
            rnCli.CadastraCliente(cliente);

            #endregion
        }

        public DateTime Convert_Data(string data)
        {
            #region Convertendo texto para data
            string dataFinal="";
            //data.Replace('/', '-');
            string []dataConv=data.Split('/');/*
            StringBuilder texto = new StringBuilder();
            texto.Append(dataConv[2]);
            texto.Append('-');
            texto.Append(dataConv[1]);
            texto.Append('-');
            texto.Append(dataConv[0]);
            dataFinal = texto.ToString();*/
            int dia = Convert.ToInt32(dataConv[0]);
            int mes = Convert.ToInt32(dataConv[1]);
            int ano = Convert.ToInt32(dataConv[2]);
            DateTime Time = new DateTime(ano,mes,dia);
            return Time; //Convert.ToDateTime(dataFinal);
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
