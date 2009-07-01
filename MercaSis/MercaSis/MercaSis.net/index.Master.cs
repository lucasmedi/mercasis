using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using MercaSisTOs;
using MercaSisFE;
using MercaSisRNs;
using System.Collections.Generic;

namespace scie
{
    public partial class index : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Obs: O Código Abaixo estava dentro do IF
            #region Busca as Categorias
            RNProduto rnPro = new RNProduto();
            List<string> lista = new List<string>();
            lista.Add(ddlCategoriaBusca.Text);
            rnPro.ListarCategoria(lista);
            lista.IndexOf(ddlCategoriaBusca.Text);
            //lista.Insert(0, ddlCategoriaBusca.Text);
            ddlCategoriaBusca.DataSource = lista;
            ddlCategoriaBusca.DataBind();
            #endregion
            if (IsPostBack != true)
            {
            }
            else
            {

            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Session.Add("txtBusca", txtBuscar.Text);
            Session.Add("ddlCategoria", ddlCategoriaBusca.SelectedValue);
            Response.Redirect("Busca.aspx");
        }

        protected void lkbLogin_Click(object sender, EventArgs e)
        {
            RNCliente rnCli = new RNCliente();
            TOCliente toCli = new TOCliente();
            toCli = rnCli.BuscarPorLogin(txtUserName.Text, txtPassword.Text);
            if (toCli.NomeCompleto == null)
            {
                lblUserSenhEr.Visible = true;
                //Response.Redirect("Login.aspx");
            }
            else
            {
                lblUserSenhEr.Visible = false;
                lblApelido.Text = "Olá " + toCli.Apelido + ".";
                lblApelido.Visible = true;
                Session["TOCliente"] = toCli;
            }
            //cli.BuscarClientePorLogin(txtUserName.Text, txtPassword.Text);
        }
    }
}
