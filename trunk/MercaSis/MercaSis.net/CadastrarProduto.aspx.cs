using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
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
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            string caminhoFi = @"C:\MercaSis\MercaSis\MercaSisFE\bd\ImagensBD";
            fulImage.PostedFile.SaveAs(caminhoFi + @"\" + fulImage.FileName); //TODO - Verificar o acesso na pasta 
            string caminho = fulImage.FileName;
        }

        protected void ddlCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCategoria.SelectedValue == "New"||ddlCategoria.SelectedItem.Value=="New")
            {
                lblCategoria.Text = "Nova Categoria:";
                ddlCategoria.Visible = false;
                txtNovaCategoria.Visible = true;
            }
        }
    }
}
