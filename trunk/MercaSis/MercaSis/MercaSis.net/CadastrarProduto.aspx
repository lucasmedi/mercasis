<%@ Page Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="CadastrarProduto.aspx.cs"
    Inherits="MercaSisFE.WebForm5" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style4
        {
            width: 190px;
        }
        .style5
        {
            width: 156px;
        }
        .style6
        {
            width: 269px;
        }
        .style7
        {
            width: 156px;
            height: 30px;
        }
        .style8
        {
            width: 269px;
            height: 30px;
        }
        .style9
        {
            height: 30px;
        }
        .style10
        {
            width: 156px;
            height: 26px;
        }
        .style11
        {
            width: 269px;
            height: 26px;
        }
        .style12
        {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphConteudo" runat="server">
    <table style="width: 100%;">
        <tr>
            <td class="style4">
                <h5>
                    Cadastrar novo Produto:</h5>
            </td>
            <td>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
    </table>
    <table style="width: 100%;">
        <tr>
            <td class="style10" align="right">
                Nome:
            </td>
            <td class="style11">
                <asp:TextBox ID="txtNome" runat="server" Width="220px"></asp:TextBox>
            </td>
            <td class="style12">
            </td>
        </tr>
        <tr>
            <td class="style5" align="right">
                Preco Unitario:
            </td>
            <td class="style6">
                <asp:TextBox ID="txtPrecoUnit" runat="server" Width="220px"></asp:TextBox>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td class="style5" align="right">
                Descricao:
            </td>
            <td class="style6">
                <asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine" Width="220px"
                    MaxLength="254"></asp:TextBox>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td class="style5" align="right">
                Quantidade em Estoque:
            </td>
            <td class="style6">
                <asp:TextBox ID="txtQtdEstoque" runat="server" Width="220px"></asp:TextBox>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style10" align="right">
                Peso:
            </td>
            <td class="style11">
                <asp:TextBox ID="txtPeso" runat="server" Width="220px"></asp:TextBox>
            </td>
            <td class="style12">
            </td>
        </tr>
        <tr>
            <td class="style5" align="right">
                <asp:Label ID="lblCategoria" runat="server" Text="Categoria:"></asp:Label>
            </td>
            <td class="style6">
                <asp:DropDownList ID="ddlCategoria" runat="server" OnTextChanged="ddlCategoria_SelectedIndexChanged"
                    Width="220px" AutoPostBack="True">
                    <asp:ListItem Selected="True">Selecione</asp:ListItem>
                    <asp:ListItem Value="New">Nova Categoria...</asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="txtNovaCategoria" runat="server" Visible="False" Width="220px"></asp:TextBox>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td class="style5" align="right">
                Imagem:
            </td>
            <td class="style6">
                <asp:FileUpload ID="fulImage" runat="server" Width="220px" />
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td class="style7" align="right">
            </td>
            <td align="left" class="style8">
                <asp:Button ID="btnCancelar" runat="server" Style="margin-left: 0px" Text="Cancelar"
                    Width="90px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCadastrarProduto" runat="server" Text="Cadastrar" OnClick="btnCadastrarProduto_Click"
                    Width="90px" />
            </td>
            <td class="style9">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style5" align="right">
                &nbsp;
            </td>
            <td align="center" class="style6">
                <br />
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
