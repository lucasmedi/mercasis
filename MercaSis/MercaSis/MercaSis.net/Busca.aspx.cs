using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MercaSisTOs;
using MercaSisRNs;
using System.Collections;
using System.Data.Common;
using System.Data.SqlClient;

namespace MercaSisFE
{
    public partial class Busca : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack != true)
            {
                #region Implementar, pios não está buscando os Produtos

                string busca = (string)Session["txtBusca"];
                string categoria = (string)Session["ddlCategoria"];
                Session.Clear();
                RNProduto rnPro = new RNProduto();
                List<TOProduto> Lista = new List<TOProduto>();
                Lista = rnPro.BuscarProdutos(busca, categoria);
                GridView1.DataSource = Lista;
                GridView1.DataBind();
                //ListView1.DataSource = Lista;
                //ListView1.DataBind();
                DataGrid1.DataSource = Lista;
                DataGrid1.DataBind();
                #endregion
            }
            else
            {
                
                string busca = (string)Session["txtBusca"];
                string categoria = (string)Session["ddlCategoria"];
                Session.Clear();
                RNProduto rnPro = new RNProduto();
                List<TOProduto> Lista = new List<TOProduto>();
                Lista = rnPro.BuscarProdutos(busca, categoria);
                GridView1.DataSource = Lista;
                GridView1.DataBind();
                //ListView1.DataSource = Lista;
                //ListView1.DataBind();
                DataGrid1.DataSource = Lista;
                DataGrid1.DataBind();
            }
            //RNProduto rnPro = new RNProduto();
            //rnPro.ListarCategoria();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string id = GridView1.SelectedRow.Cells[1].Text;
            //Server.Transfer("produtoDescricao.aspx?id="+id);
        }
    }
}
