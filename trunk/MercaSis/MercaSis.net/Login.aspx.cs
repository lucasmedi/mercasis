﻿using System;
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

namespace MercaSisFE
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lkbProsNovo_Click(object sender, EventArgs e)
        {
            ///Caso ja tenha sido setado o CPF, ele redireciona para o CadastroCliente.aspx
            ///Passando o CPF via Session
            if (txtCEPNovo.Text != "")
            {
                Session["txtCEPNovo"] = txtCEPNovo.Text;
                Response.Redirect("CadastrarCliente.aspx");
            }
        }
    }
}
