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
//using MercaSisTOs;
using System.Text;
//using MercaSisRNs;

namespace MercaSisFE
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.Count > 0)
            {
                txtCEPIni.Text = Session["txtCEPNovo"].ToString();
            }
        }

        protected void btnProsseguir_Click(object sender, EventArgs e)
        {
            #region Manter Comentado até a implementação
            ///Parte Referente ao "Cadastro de Pessoa Fisica"
            ///Manter os Blócos de Código comentados até a implementação
            /*
            TOCliente cli = new TOCliente();
            cli.NomeCompleto.Valor = txtNome.Text;
            cli.Cpf_Cnpj.Valor = txtCPF.Text;
            cli.Sexo.Valor = rblSexo.SelectedValue;
            cli.DataNascimento.Valor = Convert_Data(txtDataNasc.Text);
            cli.Telefone.Valor = txtTelCom.Text; //TODO - Verificar como ficará esta função junto ao DDD
            cli.TelefoneSec.Valor = txtTelCel.Text; ///TODO - Verificar como ficará esta função junto as DDD
                                                    ///Pois devemos verificar a corma de 
                                                    ///como ele ficará no banco de dados
            ///Parte Referente a "Identificação"
             */
            #endregion
        }


        //Método Responsável por converter o texto do campo Data de Nascimento digitado em DateTime
        //válidando para o recebimento no SqlServer
        public DateTime Convert_Data(string data)
        {
            #region Convertendo texto para data
            string dataFinal="";
            data.Replace('/', '-');
            string []dataConv=data.Split('-');
            StringBuilder texto = new StringBuilder();
            texto.Append(dataConv[2]);
            texto.Append('-');
            texto.Append(dataConv[1]);
            texto.Append('-');
            texto.Append(dataConv[0]);
            dataFinal = texto.ToString();
            return Convert.ToDateTime(dataFinal);
            #endregion
        }

        //Link Button Responsável pela alteração entre Pessoa Fisica e Juridica
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
