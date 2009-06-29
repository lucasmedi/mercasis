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
            if (IsPostBack == true)
            {
                #region Implementar, pios não está buscando os Produtos
                string busca = (string)Session["txtBusca"];
                string categoria = (string)Session["ddlCategoria"];
                RNProduto rnPro = new RNProduto();
                List<TOProduto> Lista = new List<TOProduto>();
                if (busca != null)
                {
                    Lista = rnPro.BuscarProdutos(busca, categoria);
                }
                #endregion
                if (busca == "")
                {
                    SdsProdutos.SelectCommand = "select * from Produto where pro_categoria_codigo=" +
                        "'" + rnPro.BuscarCodCategoria(categoria) + "'";
                }
                if(busca!=""&&categoria!="")
                {
                    SdsProdutos.SelectCommand = "select * from Produto where pro_categoria_codigo=" +
                        "'" + rnPro.BuscarCodCategoria(categoria) + "' and pro_nome='"+busca+"'";
                }
                if (busca == "" && categoria == "")
                {
                    SdsProdutos.SelectCommand = "select * from Produto where pro_categoria_codigo=" +
                        "'" + rnPro.BuscarCodCategoria(categoria) + "' and pro_nome='" + busca + "'";
                }
            }
            else
            {

            }
            //RNProduto rnPro = new RNProduto();
            //rnPro.ListarCategoria();
        }
    }
}
