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
using MercaSisRNs;
using System.Collections.Generic;
using MercaSisTOs;

namespace MercaSisFE
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RNProduto rnPro = new RNProduto();
            List<string> lista = new List<string>();
            lista.Add(ddlCategoria.Text);
            rnPro.ListarCategoria(lista);
            lista.IndexOf(ddlCategoria.Text);
            lista.Add("Nova Categoria");
            ddlCategoria.DataSource = lista;
            ddlCategoria.DataBind();
        }

        protected void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            //Funciona, só está comentado para testes como AlertCadastrado();

            
            RNProduto rnPro = new RNProduto();
            TOProduto toPro = new TOProduto();
            string NomeImg="";
            if (fulImage.FileName != "")
            {
                string caminhoFi = @"C:\TCC\MercaSis\MercaSis\MercaSis.net\bd\ImagensBD";
                fulImage.PostedFile.SaveAs(caminhoFi + @"\" + fulImage.FileName); //TODO - Verificar o acesso na pasta 
                NomeImg = fulImage.FileName;
            }
            else
            {
               toPro.Imagem.Valor = "Default.jpg";
            }
            toPro.Nome.Valor = txtNome.Text;
            toPro.PrecoUnit.Valor = Convert.ToDouble(txtPrecoUnit.Text);
            toPro.Descricao.Valor = txtDescricao.Text;
            toPro.QuantidadeEstoque.Valor = Convert.ToInt32(txtQtdEstoque.Text);
            toPro.Peso.Valor = Convert.ToDouble(txtPeso.Text);
            if (txtNovaCategoria.Visible == true)
            {
                rnPro.CadastrarNovaCategoria(txtNovaCategoria.Text);
                toPro.Categoria.Valor= rnPro.BuscarCodCategoria(txtNovaCategoria.Text);
            }
            else
            {
                toPro.Categoria.Valor = rnPro.BuscarCodCategoria(ddlCategoria.SelectedValue);
            }
            toPro.Imagem.Valor =NomeImg;
            rnPro.InserirProduto(toPro);
            
            string myScript = @"function AlertCadastrado() { alert('Cadastrado com Sucesso!'); } AlertCadastrado();";
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "MyScript", myScript.ToString(), true);
            //Response.Redirect("Index.aspx");
        }

        protected void ddlCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCategoria.SelectedValue == "Nova Categoria" || ddlCategoria.SelectedItem.Value == "Nova Categoria")
            {
                lblCategoria.Text = "Nova Categoria:";
                ddlCategoria.Visible = false;
                txtNovaCategoria.Visible = true;
                txtNovaCategoria.Focus();
            }
        }
    }
}
